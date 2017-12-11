using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreenSaver
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
            label.BackColor = Color.Transparent;
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void From1_MouseEnter(object sender, EventArgs e)
        {
            //Application.Exit();  
            //鼠标移动就退出
        }

        private void From1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
            //键盘按下就退出
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int i = DateTime.Now.Second;
            switch (i % 20)
            {
                case 0: BackgroundImage = Properties.Resources.阿里安特宫殿; break;
                case 1: BackgroundImage = Properties.Resources.埃欧雷; break;
                case 2: BackgroundImage = Properties.Resources.冰峰雪域; break;
                case 3: BackgroundImage = Properties.Resources.宠物公园; break;
                case 4: BackgroundImage = Properties.Resources.地球防御本部; break;
                case 5: BackgroundImage = Properties.Resources.东方神洲; break;
                case 6: BackgroundImage = Properties.Resources.废弃都市; break;
                case 7: BackgroundImage = Properties.Resources.鬼屋; break;
                case 8: BackgroundImage = Properties.Resources.黑森林; break;
                case 9: BackgroundImage = Properties.Resources.江户村; break;
                case 10: BackgroundImage = Properties.Resources.里恩; break;
                case 11: BackgroundImage = Properties.Resources.林中之城; break;
                case 12: BackgroundImage = Properties.Resources.蚂蚁洞; break;
                case 13: BackgroundImage = Properties.Resources.诺特勒斯码头1; break;
                case 14: BackgroundImage = Properties.Resources.射手村; break;     
                case 15: BackgroundImage = Properties.Resources.时间通道; break;
                case 16: BackgroundImage = Properties.Resources.时间通道2; break;
                case 17: BackgroundImage = Properties.Resources.水晶花园; break;
                case 18: BackgroundImage = Properties.Resources.新叶城铁塔; break;
                case 19: BackgroundImage = Properties.Resources.童话村; break;
                case 20: BackgroundImage = Properties.Resources.玩具城; break;

                default: break;
            }




        }

    }
}
