using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int pchoice, cchoice = 0;
        Random random = new Random();
        int tmrstate = 0;
        int pres, cres = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void rockstd_Click(object sender, EventArgs e)
        {
            pchoice = 1;
            rockstd.Enabled = false;
            timer.Enabled = true;
        }

        private void scissorsstd_Click(object sender, EventArgs e)
        {
            pchoice = 2;
            scissorsstd.Enabled = false;
            timer.Enabled = true;
        }

        private void paperstd_Click(object sender, EventArgs e)
        {
            pchoice = 3;
            paperstd.Enabled = false;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (tmrstate)
            {
                case 0:
                    tmrstate = 1;
                    info.Text = "Камень!";
                    break;
                case 1:
                    tmrstate = 2;
                    info.Text = "Ножницы!";
                    break;
                case 2:
                    tmrstate = 3;
                    info.Text = "Бумага!";
                    break;
                case 3:
                    tmrstate = 4;
                    info.Text = "Раз!";
                    break;
                case 4:
                    tmrstate = 5;
                    info.Text = "Два!";
                    break;
                case 5:
                    tmrstate = 6;
                    info.Text = "Три!";
                    break;
                case 6:
                    cchoice = random.Next(1, 3);
                    //
                    //win
                    //
                        //rock=>scissors
                        if (pchoice == 1 && cchoice == 2)
                        {
                            label2.Text = "Ножницы!";
                            info.Text = "Вы победили!";
                            pres++;
                            countstd.Text = pres + " : " + cres;
                        }
                        //scissors=>paper
                        if (pchoice == 2 && cchoice == 3)
                        {
                            label2.Text = "Бумага!";
                            info.Text = "Вы победили!";
                            pres++;
                            countstd.Text = pres + " : " + cres;
                        }
                        //paper=>rock
                        if (pchoice == 3 && cchoice == 1)
                        {
                            label2.Text = "Камень!";
                            info.Text = "Вы победили!";
                            pres++;
                            countstd.Text = pres + " : " + cres;
                        }
                    //
                    //lose
                    //
                        //scissors<=rock
                        if (pchoice == 2 && cchoice == 1)
                        {
                            label2.Text = "Камень!";
                            info.Text = "Вы проиграли!";
                            cres++;
                            countstd.Text = pres + " : " + cres;
                        }
                        //paper<=scissors
                        if (pchoice == 3 && cchoice == 2)
                        {
                            label2.Text = "Ножницы!";
                            info.Text = "Вы проиграли!";
                            cres++;
                            countstd.Text = pres + " : " + cres;
                        }
                        //rock<=paper
                        if (pchoice == 1 && cchoice == 3)
                        {
                            label2.Text = "Бумага!";
                            info.Text = "Вы проиграли";
                            cres++;
                            countstd.Text = pres + " : " + cres;
                        }
                    //
                    //draw
                    //
                        if (pchoice==cchoice)
                        {
                            switch (cchoice)
                            {
                                case 1:
                                    label2.Text = "Камень";
                                    break;
                                case 2:
                                    label2.Text = "Ножницы";
                                    break;
                                case 3:
                                    label2.Text = "Бумага";
                                    break;
                            }
                            info.Text = "Ничья!";
                        }
                    tmrstate = 0;
                    rockstd.Enabled = true;
                    paperstd.Enabled = true;
                    scissorsstd.Enabled = true;
                    timer.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pres = 0;
            cres = 0;
            countstd.Text = pres + " : " + cres;
        }
    }
}
