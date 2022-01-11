using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 建造者模式
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // 不知道为什么写在加载里无法显示
            //Pen p = new Pen(Color.Yellow);

            //PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            //PersonDirector pdThin = new PersonDirector(ptb);
            //pdThin.CreatePerson();

            //PersonFatBuilder pfb = new PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            //PersonDirector pdFat = new PersonDirector(pfb);
            //pdFat.CreatePerson();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pen p = new Pen(Color.Yellow);

            PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            PersonDirector pdThin = new PersonDirector(ptb);
            pdThin.CreatePerson();

            PersonFatBuilder pfb = new PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            PersonDirector pdFat = new PersonDirector(pfb);
            pdFat.CreatePerson();


            Graphics g = pictureBox3.CreateGraphics();
            g.DrawString("测试测试", new Font("宋体", 30), Brushes.Black, new PointF(1, 1));
        }
    }
}
