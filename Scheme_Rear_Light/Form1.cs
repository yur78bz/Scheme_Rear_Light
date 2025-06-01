using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheme_Rear_Light
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            lb8.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shemeDataSet.Socket_RearLight_R". При необходимости она может быть перемещена или удалена.
            this.socket_RearLight_RTableAdapter.Fill(this.shemeDataSet.Socket_RearLight_R);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shemeDataSet.Socket_RearLight_L". При необходимости она может быть перемещена или удалена.
            this.socket_RearLight_LTableAdapter.Fill(this.shemeDataSet.Socket_RearLight_L);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shemeDataSet.Socket_7S". При необходимости она может быть перемещена или удалена.
            this.socket_7STableAdapter.Fill(this.shemeDataSet.Socket_7S);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shemeDataSet.Socket_7N". При необходимости она может быть перемещена или удалена.
            this.socket_7NTableAdapter.Fill(this.shemeDataSet.Socket_7N);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shemeDataSet.Socket_15". При необходимости она может быть перемещена или удалена.
            this.socket_15TableAdapter.Fill(this.shemeDataSet.Socket_15);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Linen);                           // Цвет фона

            int indCmd = cmb15PIN.SelectedIndex;

            Pen p_Y = new Pen (Color.Yellow, 5);                  // цвет линии и ширина
            Pen p_G = new Pen(Color.Green, 5);
            Pen p_C = new Pen(Color.Cyan, 5);
            Pen p_Wh = new Pen(Color.White, 5);
            Pen p_Blc= new Pen(Color.Black, 5);
            Pen p_Br = new Pen(Color.Brown, 5);
            Pen p_Red = new Pen(Color.Red, 5);
            Pen p_Pinc = new Pen(Color.Pink, 5);
            Pen p_Orng = new Pen(Color.Orange, 5);

            Point p1 = new Point(410,85);                        // задаём первую точку
            Point p2= new Point(693,85);                         // задаём вторую точку

            Point p3 = new Point(500, 85);
            Point p4 = new Point(500, 38);

            Point p5 = new Point(503, 38);                        
            Point p6 = new Point(410, 38);

            Point p7 = new Point(500, 132);
            Point p8 = new Point(503, 132);

            Point p9 = new Point(410, 132);

            Point p10 = new Point(688, 38);
            Point p11 = new Point(690, 38);
            Point p12 = new Point(780, 38);

            Point p13 = new Point(690, 132);
            Point p14 = new Point(780, 132);

            Point p15 = new Point(690, 85);
            Point p16 = new Point(688, 132);

            Point p17 = new Point(503, 85);

            Point p20 = new Point(428, 85);
            Point p21 = new Point(446, 85);
            Point p22 = new Point(465, 85);
            Point p23 = new Point(483, 85);
            Point p24 = new Point(503, 85);

            Point p30 = new Point(500, 85);
            Point p31 = new Point(500, 70);
            Point p32 = new Point(500, 54);
            Point p33 = new Point(500, 38);

            Point p40 = new Point(503, 38);
            Point p41 = new Point(483, 38);
            Point p42 = new Point(465, 38);
            Point p43 = new Point(446, 38);
            Point p44 = new Point(428, 38);

            Point p50 = new Point(500, 85);
            Point p51 = new Point(500, 101);
            Point p52 = new Point(500, 117);
            Point p53 = new Point(500, 132);

            Point p60 = new Point(503, 132);
            Point p61 = new Point(483, 132);
            Point p62 = new Point(465, 132);
            Point p63 = new Point(446, 132);
            Point p64 = new Point(428, 132);

            switch (indCmd)
            {
                case 0:
                    g.DrawLine(p_Y, p1, p2);                               
                    g.DrawLine (p_Y, p3, p4);
                    g.DrawLine(p_Y, p5, p6);

                    g.DrawLine(p_Y,p15, p13);
                    g.DrawLine(p_Y, p16, p14);
                    lb8.Text = "Жёлтый";
                    break;

                case 1:
                    g.DrawLine(p_G, p1, p2);
                    g.DrawLine(p_G, p3, p4);
                    g.DrawLine(p_G, p5, p6);

                    g.DrawLine(p_G, p15, p11);
                    g.DrawLine(p_G, p10, p12);
                    lb8.Text = "Зелёный";
                    break;

                case 2:
                    g.DrawLine(p_C, p1, p2);
                    g.DrawLine(p_C, p3, p7);
                    g.DrawLine(p_C, p8, p9);

                    g.DrawLine(p_C, p15, p13);
                    g.DrawLine(p_C, p16, p14);
                    g.DrawLine(p_C, p15, p11);
                    g.DrawLine(p_C, p10, p12);
                    lb8.Text = "Голубой";
                    break;

                case 3:
                    g.DrawLine(p_Wh, p1, p2);
                    g.DrawLine(p_Wh, p3, p4);
                    g.DrawLine(p_Wh, p5, p6);

                    g.DrawLine(p_Wh, p15, p13);
                    g.DrawLine(p_Wh, p16, p14);
                    g.DrawLine(p_Wh, p15, p11);
                    g.DrawLine(p_Wh, p10, p12);
                    lb8.Text = "Белый";
                    break;

                case 4:
                    g.DrawLine(p_Blc, p1, p2);
                    g.DrawLine(p_Blc, p3, p4);
                    g.DrawLine(p_Blc, p5, p6);

                    g.DrawLine(p_Blc, p15, p13);
                    g.DrawLine(p_Blc, p16, p14);
                    lb8.Text = "Чёрный";
                    break;

                case 5:
                    g.DrawLine(p_Br, p1, p2);
                    g.DrawLine(p_Br, p3, p4);
                    g.DrawLine(p_Br, p5, p6);

                    g.DrawLine(p_Br, p15, p11);
                    g.DrawLine(p_Br, p10, p12);
                    lb8.Text = "Коричневый";
                    break;

                case 6:
                    g.DrawLine(p_Red, p1, p2);
                    g.DrawLine(p_Red, p3, p4);
                    g.DrawLine(p_Red, p5, p6);

                    g.DrawLine(p_Red, p15, p13);
                    g.DrawLine(p_Red, p16, p14);
                    g.DrawLine(p_Red, p15, p11);
                    g.DrawLine(p_Red, p10, p12);
                    lb8.Text = "Красный";
                    break;

                case 7:
                    g.DrawLine(p_Pinc, p1, p2);
                    g.DrawLine(p_Pinc, p3, p7);
                    g.DrawLine(p_Pinc, p8, p9);

                    g.DrawLine(p_Pinc, p15, p13);
                    g.DrawLine(p_Pinc, p16, p14);
                    g.DrawLine(p_Pinc, p15, p11);
                    g.DrawLine(p_Pinc, p10, p12);
                    lb8.Text = "Розовый";
                    break;

                case 8:

                    g.DrawLine(p_Orng, p1, p17);                    
                    g.DrawLine(p_Orng, p3, p7);
                    g.DrawLine(p_Orng, p8, p9);

                    lb8.Text = "Оранжевый";
                    break;

                case 9:
                    g.DrawLine(p_G, p1, p20);
                    g.DrawLine(p_Y, p20, p21);
                    g.DrawLine(p_G, p21, p22);
                    g.DrawLine(p_Y, p22, p23);
                    g.DrawLine(p_G, p23, p24);
                    g.DrawLine(p_Y, p24, p17);

                    lb8.Text = "Жёлто-зелёный";
                    break;

                case 10:
                    g.DrawLine(p_Blc, p1, p20);
                    g.DrawLine(p_Wh, p20, p21);
                    g.DrawLine(p_Blc, p21, p22);
                    g.DrawLine(p_Wh, p22, p23);
                    g.DrawLine(p_Blc, p23, p24);
                    g.DrawLine(p_Wh, p24, p17);

                    g.DrawLine(p_Wh, p3, p30);
                    g.DrawLine(p_Blc, p30, p31);
                    g.DrawLine(p_Wh, p31, p32);
                    g.DrawLine(p_Blc, p32, p33);

                    g.DrawLine(p_Wh, p5, p40);
                    g.DrawLine(p_Blc, p40, p41);
                    g.DrawLine(p_Wh, p41, p42);
                    g.DrawLine(p_Blc, p42, p43);
                    g.DrawLine(p_Wh, p43, p44);
                    g.DrawLine(p_Blc, p44, p6);

                    lb8.Text = "Бело-Чёрный";
                    break;

                case 11:
                    g.DrawLine(p_C, p1, p20);
                    g.DrawLine(p_Wh, p20, p21);
                    g.DrawLine(p_C, p21, p22);
                    g.DrawLine(p_Wh, p22, p23);
                    g.DrawLine(p_C, p23, p24);
                    g.DrawLine(p_Wh, p24, p17);


                    g.DrawLine(p_Wh, p3, p50);
                    g.DrawLine(p_C, p50, p51);
                    g.DrawLine(p_Wh, p51, p52);
                    g.DrawLine(p_C, p52, p7);

                    g.DrawLine(p_C, p60, p61);
                    g.DrawLine(p_Wh, p61, p62);
                    g.DrawLine(p_C, p62, p63);
                    g.DrawLine(p_Wh, p63, p64);
                    g.DrawLine(p_C, p64, p9);

                    lb8.Text = "Бело-голубой";
                    break;

                case 12:
                    g.DrawLine(p_Red, p1, p20);
                    g.DrawLine(p_Wh, p20, p21);
                    g.DrawLine(p_Red, p21, p22);
                    g.DrawLine(p_Wh, p22, p23);
                    g.DrawLine(p_Red, p23, p24);
                    g.DrawLine(p_Wh, p24, p17);


                    g.DrawLine(p_Wh, p3, p50);
                    g.DrawLine(p_Red, p50, p51);
                    g.DrawLine(p_Wh, p51, p52);
                    g.DrawLine(p_Red, p52, p7);

                    g.DrawLine(p_Red, p60, p61);
                    g.DrawLine(p_Wh, p61, p62);
                    g.DrawLine(p_Red, p62, p63);
                    g.DrawLine(p_Wh, p63, p64);
                    g.DrawLine(p_Red, p64, p9);

                    lb8.Text = "Бело-Красный";
                    break;

                case 13:
                    g.DrawLine(p_G, p1, p20);
                    g.DrawLine(p_Wh, p20, p21);
                    g.DrawLine(p_G, p21, p22);
                    g.DrawLine(p_Wh, p22, p23);
                    g.DrawLine(p_G, p23, p24);
                    g.DrawLine(p_Wh, p24, p17);


                    g.DrawLine(p_Wh, p3, p50);
                    g.DrawLine(p_G, p50, p51);
                    g.DrawLine(p_Wh, p51, p52);
                    g.DrawLine(p_G, p52, p7);

                    g.DrawLine(p_G, p60, p61);
                    g.DrawLine(p_Wh, p61, p62);
                    g.DrawLine(p_G, p62, p63);
                    g.DrawLine(p_Wh, p63, p64);
                    g.DrawLine(p_G, p64, p9);

                    lb8.Text = "Бело-Зелёный";
                    break;

                case 14:
                    g.DrawLine(p_Br, p1, p20);
                    g.DrawLine(p_Wh, p20, p21);
                    g.DrawLine(p_Br, p21, p22);
                    g.DrawLine(p_Wh, p22, p23);
                    g.DrawLine(p_Br, p23, p24);
                    g.DrawLine(p_Wh, p24, p17);


                    g.DrawLine(p_Wh, p3, p50);
                    g.DrawLine(p_Br, p50, p51);
                    g.DrawLine(p_Wh, p51, p52);
                    g.DrawLine(p_Br, p52, p7);

                    g.DrawLine(p_Br, p60, p61);
                    g.DrawLine(p_Wh, p61, p62);
                    g.DrawLine(p_Br, p62, p63);
                    g.DrawLine(p_Wh, p63, p64);
                    g.DrawLine(p_Br, p64, p9);

                    lb8.Text = "Бело-Коричневый";
                    break;
            }
            
            g.Dispose();                                           // освобождаем все русурсы связанные с отрисовкой
        }
    }
}
