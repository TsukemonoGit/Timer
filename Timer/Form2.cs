using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTimer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public  Form1 form1;
        private void closeButton_Click(object sender, EventArgs e)
        {
          
            form1.Close_Form2();
        
        }
       
        
        int preSecond_one=0;
        int preMinute_one = 0;
        int preHour_one = 0;
        int nowPressTMP_s;
        int nowPressTMP_m;
        int nowPressTMP_h;


        //---------------------------------------

        private void Enter_Click(object sender, EventArgs e)
        {
            int fullTime = Int32.Parse(hour_textBox.Text) * 60 * 60 + Int32.Parse(minute_textBox.Text) * 60 + Int32.Parse(second_textBox.Text);
            form1.SetTime(fullTime);

           form1.Close_Form2();
        }
        private void hourUp_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(hour_textBox.Text) < 59)
            {
                hour_textBox.Text = (Int32.Parse(hour_textBox.Text) + 1).ToString("00");
            }
        }
        private void hourDown_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(hour_textBox.Text) > 0)
            {
                hour_textBox.Text = (Int32.Parse(hour_textBox.Text) - 1).ToString("00");
            }
        }
        private void minuteUp_Button_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(minute_textBox.Text) < 59)
            {
                minute_textBox.Text = (Int32.Parse(minute_textBox.Text) + 1).ToString("00");
            }
        }

        private void minuteDown_Button_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(minute_textBox.Text) > 0)
            {
                minute_textBox.Text = (Int32.Parse(minute_textBox.Text) - 1).ToString("00");
            }
        }

        private void secondUp_Button_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(second_textBox.Text) < 59)
            {
                second_textBox.Text = (Int32.Parse(second_textBox.Text) + 1).ToString("00");
            }
        }

        private void secondDown_Button_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(second_textBox.Text) > 0)
            {
                second_textBox.Text = (Int32.Parse(second_textBox.Text) - 1).ToString("00");
            }
        }


        //----------------------------------------
        //数字のみ受付
        private void second_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースのみ入力有効（数字でも入力は一旦保留するので）
            if (e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            //０～９のときだけ
            //if (e.KeyChar >= '0' && '9' <= e.KeyChar)
            //{
                if (char.IsDigit(e.KeyChar))
                {
                    nowPressTMP_s = Int32.Parse(e.KeyChar.ToString());
              //  e.Handled = true;
               // MessageBox.Show(nowPressTMP_s.ToString());
                if (preSecond_one < 6)
                {
                  //  MessageBox.Show(preSecond_one.ToString() + nowPressTMP);
                    second_textBox.Text = preSecond_one.ToString()  + nowPressTMP_s.ToString();


                }
                else
                {
                    second_textBox.Text = "0" + nowPressTMP_s.ToString();

                }
                preSecond_one = nowPressTMP_s;//Int32.Parse(second_textBox.Text.Substring(1));
            }
         

        }

        private void minute_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースのみ入力有効（数字でも入力は一旦保留するので）
            // if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            if (e.KeyChar != '\b')
            {
                e.Handled = true;
            }  //０～９のときだけ
               //if (e.KeyChar >= '0' || '9' < e.KeyChar)
            if (char.IsDigit(e.KeyChar))
            {
                nowPressTMP_m = Int32.Parse(e.KeyChar.ToString());
              //  e.Handled = true;
                //MessageBox.Show(nowPressTMP.ToString());
                if (preMinute_one < 6)
                {
                    //  MessageBox.Show(preSecond_one.ToString() + nowPressTMP);
                    minute_textBox.Text = preMinute_one.ToString() + nowPressTMP_m.ToString();


                }
                else
                {
                    minute_textBox.Text = "0" + nowPressTMP_m.ToString();

                }
                preMinute_one = nowPressTMP_m;//Int32.Parse(second_textBox.Text.Substring(1));
            }

        }

        private void hour_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //バックスペースのみ入力有効（数字でも入力は一旦保留するので）
            // if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            if (e.KeyChar != '\b')
            {
                e.Handled = true;
            }  //０～９のときだけ
               //if (e.KeyChar >= '0' || '9' < e.KeyChar)
            if (char.IsDigit(e.KeyChar))
            {
                nowPressTMP_h = Int32.Parse(e.KeyChar.ToString());
                //e.Handled = true;
                //MessageBox.Show(nowPressTMP.ToString());
                if (preHour_one < 6)
                {
                    //  MessageBox.Show(preSecond_one.ToString() + nowPressTMP);
                    hour_textBox.Text = preHour_one.ToString() + nowPressTMP_h.ToString();


                }
                else
                {
                    hour_textBox.Text = "0" + nowPressTMP_h.ToString();

                }
                preHour_one = nowPressTMP_h;//Int32.Parse(second_textBox.Text.Substring(1));
            }

        }



        //----------------------------
        private void second_TextChanged(object sender, EventArgs e)
        {
            if (second_textBox.Text.Length == 0)
            {
                preSecond_one = 0;
            }
            else
            {
                preSecond_one = Int32.Parse(second_textBox.Text.Substring(second_textBox.Text.Length-1));
            }
        }

        private void minute_TextChanged(object sender, EventArgs e)
        {
            if (minute_textBox.Text.Length == 0)
            {
                preMinute_one = 0;
            }
            else
            {
                preMinute_one = Int32.Parse(minute_textBox.Text.Substring(minute_textBox.Text.Length - 1));
            }
        }

        private void hour_TextChanged(object sender, EventArgs e)
        {
            if (hour_textBox.Text.Length == 0)
            {
                preHour_one = 0;
            }
            else
            {
                preHour_one = Int32.Parse(hour_textBox.Text.Substring(hour_textBox.Text.Length - 1));
            }
        }

        //----------------------------


        //--ウインドウの移動

        //マウスのクリック位置を記憶
        private Point mousePoint;
        private void setting_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);

                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            }
        }
        //マウスの移動に合わせて画面を動かす
        private void setting_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
                //または、つぎのようにする
                //this.Location = new Point(
                //    this.Location.X + e.X - mousePoint.X,
                //    this.Location.Y + e.Y - mousePoint.Y);
            }
        }

        private void setting_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
