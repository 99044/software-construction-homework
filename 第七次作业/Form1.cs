using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private int depth=10;
        private double leng=100;
        private Pen pen;


        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n > 0)
            {
                double x1 = x0 + leng * Math.Cos(th);
                double y1 = y0 + leng * Math.Sin(th);

                drawLine(x0, y0, x1, y1);
                
                drawCayleyTree(n - 1,x1,y1,per1 * leng,th + th1);
                drawCayleyTree(n - 1,x1,y1,per2 * leng,th - th2);

            }
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            if (pen == null)
            {
                pen = new Pen(Color.Blue);
            }
            else
            {
                graphics.DrawLine(pen,(int) x0,(int) y0,(int) x1,(int) y1);
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.TabIndex = 10;
            Controls.Add(comboBox1);
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            if (comboBox1.SelectedItem != null)
            {
                depth = int.Parse(comboBox1.SelectedItem.ToString());
                // 使用 depth 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                depth = 100;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.TabIndex = 5;
            Controls.Add(comboBox1);
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            if (comboBox2.SelectedItem != null)
            {
                leng = int.Parse(comboBox2.SelectedItem.ToString());
                // 使用 leng 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                leng=100;            
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.TabIndex = 3;
            Controls.Add(comboBox3);
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            if (comboBox3.SelectedItem != null)
            {
                per1 = double.Parse(comboBox3.SelectedItem.ToString());
                // 使用 per1 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                per1 = 0.6;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.TabIndex = 4;
            Controls.Add(comboBox4);
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            if (comboBox4.SelectedItem != null)
            {
                per2 = double.Parse(comboBox4.SelectedItem.ToString());
                // 使用 per2 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                per2 = 0.7;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.TabIndex = 1;
            Controls.Add(comboBox5);
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            if (comboBox5.SelectedItem != null)
            {
                th1 = int.Parse(comboBox5.SelectedItem.ToString())* Math.PI / 180;
                // 使用 th1 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                th1 = 20 * Math.PI / 180;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.FormattingEnabled = true;
            comboBox6.TabIndex = 2;
            Controls.Add(comboBox1);
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            if (comboBox6.SelectedItem != null)
            {
                th2 = int.Parse(comboBox6.SelectedItem.ToString())* Math.PI / 180;
                // 使用 th2 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                th2 = 30 * Math.PI / 180;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.FormattingEnabled = true;
            comboBox7.TabIndex = 2;
            Controls.Add(comboBox1);
            comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            if (comboBox7.SelectedItem != null)
            {
                switch (comboBox7.SelectedItem.ToString())
                {
                    case "Blue" :
                        pen = new Pen(Brushes.Blue);
                        break;
                    case "Black":
                        pen = new Pen(Color.Black);
                        break;
                    case "Red":
                        pen = new Pen(Color.Red);
                        break;
                    case "Yellow":
                        pen = new Pen(Color.Yellow);
                        break;
                    case "Green":
                        pen = new Pen(Color.Green);
                        break;
                    default:
                        pen = new Pen(Color.Blue);
                        break;
                }

                // 使用 pen 变量来绘制 Cayley 树或进行其他操作
            }
            else
            {
                pen = new Pen(Color.Blue);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            graphics.Clear(BackColor);
            drawCayleyTree(depth,500,500,leng,-Math.PI/2);
        }
    }
}