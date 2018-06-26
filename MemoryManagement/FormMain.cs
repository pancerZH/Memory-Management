using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryManagement
{
    public partial class FormMain : Form
    {
        public const int insNum = 320;  // 指令数量：320条
        public int currentInsNum = 0;  // 已经执行的指令数
        public int missTimes = 0;  // 缺页次数
        public float missRate = 0;  // 缺页率
        public static List<Ins> insList = new List<Ins>();  // 记录所有的指令
        public static Dictionary<int, Page> Contents = new Dictionary<int, Page>();  // 页目录
        public static int nextInsPos = 0;  // 记录下一条指令的位置
        public struct Ins
        {
            public int pos;  // 指令序号
            public string content;  // 指令内容
            public int nextPos;  // 下一条指令地址
        }

        public FormMain()
        {
            InitializeComponent();
            generateIns();
            showIns();
            writeNewContent();
        }

        public class Page  // 页对象
        {
            public int inTime;  // 记录页调入的时间，越大表示距离当前越近
            public int lastUseTime;  // 记录最后一次使用的时间，越大表示距离当前越近
            public int startPos;
            private Dictionary<int, Ins> page = new Dictionary<int, Ins>();  // 页

            public Page(int startPos, int inTime)
            {
                this.inTime = inTime;
                lastUseTime = inTime;
                this.startPos = startPos/10*10;

                for (int i = 0; i < 10; ++i)
                {
                    Ins newIns = insList[this.startPos + i];
                    page.Add(i, newIns);
                }
            }

            public Ins findCertainIns(int offset)
            {
                return page[offset];
            }
        }

        /*随机生成320条指令*/
        public void generateIns()
        {
            Random rd = new Random();
            for (int i=0; i<insNum; ++i)
            {
                int flag = rd.Next(4);  // 0和1代表顺序执行，2代表向后跳转，3代表向前跳转
                Ins newIns;
                newIns.pos = i;
                newIns.content = "do something";
                if (flag < 2)
                    newIns.nextPos = i + 1;
                else if (flag == 2)
                    newIns.nextPos = rd.Next(i + 1, insNum);
                else
                    newIns.nextPos = rd.Next(i);
                if (newIns.pos == 0)  // 第0个元素向后跳转
                    newIns.nextPos = rd.Next(1, insNum);
                if (newIns.pos == insNum - 1)  // 最后一个元素向前跳转
                    newIns.nextPos = rd.Next(0, insNum-1);
                insList.Add(newIns);
            }
        }

        /*在列表框中展示指令*/
        public void showIns()
        {
            foreach(Ins ins in insList)
            {
                string instruction = ins.pos.ToString() + ": " + ins.content + ' ' + ins.nextPos.ToString();
                listBoxTotal.Items.Add(instruction);
            }
        }

        /*查找某一位置指令对应的页是否在Cache内*/
        public int findPage(int pos)
        {
            foreach (KeyValuePair<int, Page> kvp in Contents)
            {
                int currentPos = kvp.Value.startPos;
                int offset = pos - currentPos;
                if (offset >= 0 && offset < 10)
                {
                    return kvp.Key;
                }
            }

            missTimes++;
            return -1;
        }

        /*向Cache增加一个页*/
        public void addPage(Page page)
        {
            if (Contents.Count == 4)  // 需要进行页替换
            {
                int currentPos = 0;
                if (radioFIFO.Checked)
                    currentPos = FIFO();
                else if (radioRand.Checked)
                    currentPos = Rand();
                else
                    currentPos = LRU();

                Contents.Remove(currentPos);
                Contents.Add(currentPos, page);
                writeNewCache(currentPos, page);
            }
            else
            {
                int targetIndex = Contents.Count;
                Contents.Add(targetIndex, page);
                writeNewCache(targetIndex, page);
            }
        }

        /*FIFO替换算法*/
        public int FIFO()
        {
            int newestTime = 320;
            int currentPos = 0;
            foreach(KeyValuePair<int, Page> kvp in Contents)
            {
                if (kvp.Value.inTime < newestTime)  // 选出最早进入的页
                {
                    newestTime = kvp.Value.inTime;
                    currentPos = kvp.Key;
                }
            }

            return currentPos;
        }

        /*Rand替换算法*/
        public int Rand()
        {
            Random rd = new Random();
            return rd.Next(0, 4);
        }

        /*LRU替换算法*/
        public int LRU()
        {
            int newestTime = 320;
            int currentPos = 0;
            foreach (KeyValuePair<int, Page> kvp in Contents)
            {
                if (kvp.Value.lastUseTime < newestTime)  // 选出最远被访问的页
                {
                    newestTime = kvp.Value.lastUseTime;
                    currentPos = kvp.Key;
                }
            }

            return currentPos;
        }

        /*重写结果区域内容*/
        public void writeNewContent()
        {
            string algo;
            if (radioFIFO.Checked)
                algo = "FIFO";
            else if (radioRand.Checked)
                algo = "Rand";
            else
                algo = "LRU";
            labelAlgoName.Text = "替换算法：" + algo;

            string missTimesStr = "缺页次数 = " + missTimes.ToString();
            labelMissTimes.Text = missTimesStr;
            missRate = (float)missTimes / currentInsNum;
            if (Double.IsNaN(missRate))
                missRate = 0;
            string missRateStr = "缺页率 = " + (missRate*100).ToString() + '%';
            labelMissRate.Text = missRateStr;
        }

        /*重写Cache区域内容*/
        public void writeNewCache(int cacheNum, Page page)
        {
            string cacheName = "listBox" + cacheNum.ToString();
            ListBox refreashBox = (ListBox)this.Controls.Find(cacheName, true)[0];
            refreashBox.Items.Clear();
            for(int offset=0; offset<10; ++offset)
            {
                Ins ins = page.findCertainIns(offset);
                string instruction = ins.pos.ToString() + ":" + ins.content + ' ' + ins.nextPos.ToString();
                refreashBox.Items.Add(instruction);
            }
        }

        /*重新初始化*/
        public void clearAll()
        {
            listBoxTotal.Items.Clear();
            insList.Clear();
            Contents.Clear();
            listBox0.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            nextInsPos = 0;

            buttonSingle.Enabled = true;
            buttonConstant.Enabled = true;
            labelPageContent.Text = "页：";
            labelOffsetContent.Text = "偏移量：";
            currentInsNum = 0;
            missTimes = 0;
            missRate = 0;
        }

        /*以同样的指令序列重新初始化*/
        public void initAgain()
        {
            Contents.Clear();
            listBox0.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            nextInsPos = 0;

            buttonSingle.Enabled = true;
            buttonConstant.Enabled = true;
            labelPageContent.Text = "页：";
            labelOffsetContent.Text = "偏移量：";
            currentInsNum = 0;
            missTimes = 0;
            missRate = 0;

            writeNewContent();
        }

        /*清除Cache中的选中项*/
        public void clearListBoxSelected()
        {
            for(int cacheNum = 0; cacheNum < 4; ++cacheNum)
            {
                string cacheName = "listBox" + cacheNum.ToString();
                ListBox refreashBox = (ListBox)this.Controls.Find(cacheName, true)[0];
                refreashBox.ClearSelected();
            }
        }

        /*点击新建按钮后重新生成指令*/
        private void buttonInit_Click(object sender, EventArgs e)
        {
            clearAll();
            generateIns();
            showIns();
            writeNewContent();
        }

        /*点击单步按钮后单步执行指令*/
        private void buttonSingle_Click(object sender, EventArgs e)
        {
            if(findPage(nextInsPos) == -1)  // 未从现有Cache中的页中找到对应的指令
            {
                Page newPage = new Page(nextInsPos, currentInsNum);
                addPage(newPage);
            }

            int pageIndex = findPage(nextInsPos);
            labelPageContent.Text = "页：" + pageIndex.ToString();
            Contents[pageIndex].lastUseTime = currentInsNum;
            int offset = nextInsPos - Contents[pageIndex].startPos;
            labelOffsetContent.Text = "偏移量：" + offset.ToString();
            currentInsNum++;

            clearListBoxSelected();
            string cacheName = "listBox" + pageIndex.ToString();
            ListBox chosenBox = (ListBox)this.Controls.Find(cacheName, true)[0];
            chosenBox.SetSelected(offset, true);

            nextInsPos = Contents[pageIndex].findCertainIns(offset).nextPos;
            if(currentInsNum == insNum-1)  // 该结束了
            {
                buttonSingle.Enabled = false;
                buttonConstant.Enabled = false;
            }
            writeNewContent();
        }

        /*点击执行到底按钮后连续执行指令*/
        private void buttonConstant_Click(object sender, EventArgs e)
        {
            for(; currentInsNum<320; ++currentInsNum)
            {
                if (findPage(nextInsPos) == -1)  // 未从现有Cache中的页中找到对应的指令
                {
                    Page newPage = new Page(nextInsPos, currentInsNum);
                    addPage(newPage);
                }

                int pageIndex = findPage(nextInsPos);
                labelPageContent.Text = "页：" + pageIndex.ToString();
                Contents[pageIndex].lastUseTime = currentInsNum;
                int offset = nextInsPos - Contents[pageIndex].startPos;
                labelOffsetContent.Text = "偏移量：" + offset.ToString();

                clearListBoxSelected();
                string cacheName = "listBox" + pageIndex.ToString();
                ListBox chosenBox = (ListBox)this.Controls.Find(cacheName, true)[0];
                chosenBox.SetSelected(offset, true);

                nextInsPos = Contents[pageIndex].findCertainIns(offset).nextPos;
            }

            buttonSingle.Enabled = false;
            buttonConstant.Enabled = false;
            writeNewContent();
        }

        private void radioFIFO_CheckedChanged(object sender, EventArgs e)
        {
            labelAlgoName.Text = "替换算法：FIFO";
            initAgain();
        }

        private void radioRand_CheckedChanged(object sender, EventArgs e)
        {
            labelAlgoName.Text = "替换算法：Rand";
            initAgain();
        }

        private void radioLRU_CheckedChanged(object sender, EventArgs e)
        {
            labelAlgoName.Text = "替换算法：LRU";
            initAgain();
        }
    }
}
