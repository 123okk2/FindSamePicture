using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindSamePicture
{
    public partial class Form1 : Form
    {
        /*
        public struct Grade
        {
            public int grade;
            public double time;
        }*/

        public double[] gradeTime = new double[6];

        private Boolean isGame;
        private Boolean isStop = false;

        Game gameProcess;

        Boolean fstClick = true;
        int fstClickX;
        int fstClickY;
        Button fstButton;
        Button sndButton;

        const int A = 0;
        const int B = 1;
        const int C = 2;
        const int D = 3;
        const int E = 4;
        const int F = 5;
        const int G = 6;
        const int H = 7;

        public Form1()
        {
            InitializeComponent();
            try
            {
                StreamReader sr = new StreamReader("gradeInfo.txt");
                //Grade[] grades = new Grade[5];
                for (int i = 0; i < 5; i++) gradeTime[i] = Convert.ToDouble(sr.ReadLine());
                sr.Close();
                setGrade();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        public void setGrade()
        {
            score1.Text = gradeTime[0].ToString();
            score2.Text = gradeTime[1].ToString();
            score3.Text = gradeTime[2].ToString();
            score4.Text = gradeTime[3].ToString();
            score5.Text = gradeTime[4].ToString();
        }
        public void refreshGrade(double score)
        {
            Boolean isChanged = false;

            if(score < gradeTime[4])
            {
                gradeTime[5] = score;
                isChanged = !isChanged;
                for(int i=0; i<5; i++)
                {
                    for (int j = i + 1; j < 6; j++)
                    {
                        if (gradeTime[i] > gradeTime[j])
                        {
                            double tmp = gradeTime[i];
                            gradeTime[i] = gradeTime[j];
                            gradeTime[j] = tmp;
                        }
                    }
                }
            }

            if (isChanged)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("gradeInfo.txt");
                    for (int i = 0; i < 5; i++) sw.WriteLine(gradeTime[i]);
                    sw.Close();
                }
                catch(FileNotFoundException e)
                {
                    MessageBox.Show(e.StackTrace);
                }
                setGrade();
            }
        }

        private void DrawBtn(int draw, Button btn)
        {
            switch (draw)
            {
                case A:
                    btn.Text = "A";
                    btn.Enabled = false;
                    break;
                case B:
                    btn.Text = "B";
                    btn.Enabled = false;
                    break;
                case C:
                    btn.Text = "C";
                    btn.Enabled = false;
                    break;
                case D:
                    btn.Text = "D";
                    btn.Enabled = false;
                    break;
                case E:
                    btn.Text = "E";
                    btn.Enabled = false;
                    break;
                case F:
                    btn.Text = "F";
                    btn.Enabled = false;
                    break;
                case G:
                    btn.Text = "G";
                    btn.Enabled = false;
                    break;
                case H:
                    btn.Text = "H";
                    btn.Enabled = false;
                    break;
            }
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (isGame && !isStop)
            {
                Button btn = sender as Button;
                int x = (int)Char.GetNumericValue(btn.Name.ToCharArray()[3]);
                int y = (int)Char.GetNumericValue(btn.Name.ToCharArray()[4]);

                if (fstClick)
                {
                    fstClickX = x;
                    fstClickY = y;
                    int result = gameProcess.doClick(x, y);
                    if(result != 999)
                    {
                        DrawBtn(result, btn);
                    }
                    fstButton = btn;
                    fstClick = false;
                }
                else
                {
                    int result = gameProcess.isCorrect(fstClickX, fstClickY, x, y);
                    if (result < 999)
                    {
                        DrawBtn(result, btn);
                        if(gameProcess.isEnd())
                        {
                            timer1.Enabled = false;
                            MessageBox.Show("끝났습니다!");
                            refreshGrade(timerTime);
                            새게임ToolStripMenuItem.Enabled = true;
                            중지ToolStripMenuItem.Enabled = false;
                        }
                    }
                    if (result >= 999)
                    {
                        isStop = !isStop;
                        DrawBtn(result - 999, btn);
                        sndButton = btn;
                        stopTimer.Enabled = true;
                    }
                    fstClick = true;
                }
            }
        }

        double timerTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTime += 0.1;
            time.Text = string.Format("{0:0.0}", timerTime) + " sec";
        }

        private void stopTimer_Tick(object sender, EventArgs e)
        {
            fstButton.Text = "";
            fstButton.Enabled = true;
            sndButton.Text = "";
            sndButton.Enabled = true;
            stopTimer.Enabled = false;
            isStop = !isStop;
        }

        private void 새게임ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerTime = 0;
            isGame = true;
            Button[] btns = { btn00, btn01, btn02, btn03, btn10, btn11, btn12, btn13, btn20, btn21, btn22, btn23, btn30, btn31, btn32, btn33 };
            foreach (Button bt in btns) {
                bt.Text = "";
                bt.Enabled = true;
            }
            timer1.Enabled = true;
            gameProcess = new Game(false);
            새게임ToolStripMenuItem.Enabled = false;
            중지ToolStripMenuItem.Enabled = true;
        }

        private void 중지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            isGame = false;
            새게임ToolStripMenuItem.Enabled = true;
            중지ToolStripMenuItem.Enabled = false;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 기록보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking(gradeTime);
            r.Show();
        }

        private void 기록초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradeTime = new Double[6] { 99.99, 99.99, 99.99, 99.99, 99.99, 99.99 };
            StreamWriter sw = new StreamWriter("gradeInfo.txt");
            for (int i = 0; i < 5; i++) sw.WriteLine(gradeTime[i]);
            sw.Close();
            setGrade();
        }
    }
}