using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyTimer
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
          //  timer_Text.Text = "00:00:00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //State使うかは要検討
            if (!nowCounting)
            {
                //カウントダウンスタート
                nowCounting = true;
                button1.Text = "ストップ";
           
          //      if(soundFile_textBox.Text)
                soundFile_Button.Enabled = false;

            }
            else 
            {
                //カウントダウンストップ
                nowCounting = false;
                button1.Text = "スタート";
              
            }

        }
        public bool nowCounting = false;

        //--時間設定画面表示
        Form2 form2;
        public bool nowViewForm2;
        private void label1_Click(object sender, EventArgs e)
        {
            // label1.Text = "おしたね";
            if (!nowViewForm2 && !nowCounting)
            {
                nowViewForm2 = true;
                form2 = new Form2();
                form2.form1 = this;
                form2.Show();
            }
        }
        public void Close_Form2()
        {
            nowViewForm2 = false;
            form2.Close();
        }

        //timer
        //enum State { IDLE, COUNT, PAUSE }
        //State state = State.IDLE;
        int nowTime;
        int maxTime;//設定画面に表示させる。　設定画面により更新される。
        Timer timer = new Timer();

        public void SetTime(int _maxTime)
        {
            maxTime = _maxTime;
            ViewTime(maxTime);
        }
        public int ReadTime()
        {
            return maxTime;
        }
        private void ViewTime(int time_i) 
        {
            TimeSpan hms_time = new TimeSpan(0, 0, time_i);
            timer_Text.Text = hms_time.ToString();
        }




        //----------タイトルバー
        //--閉じるボタン
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--ウインドウの移動

        //マウスのクリック位置を記憶
        private Point mousePoint;
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);

                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            }
        }
        //マウスの移動に合わせて画面を動かす
        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
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

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
        //----------タイトルバー---------おわり

        //------再生ファイル指定
   

        private void soundFile_Button_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "wav ファイル |*.wav|mp3 ファイル|*.mp3";
            openFileDialog1.Filter = "wav ファイル |*.wav";
            DialogResult dr = openFileDialog1.ShowDialog();
         
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                soundFile_textBox.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void soundTest_Button_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = soundFile_textBox.Text;
            //axWindowsMediaPlayer1.playlist

            if (soundFile_textBox.Text .Length==0)
            {
                MessageBox.Show("サウンドファイルを指定してください");

            }
            else
            {
                try
                {
                    
                    SoundPlayer simpleSound = new SoundPlayer(soundFile_textBox.Text);
                    
                    simpleSound.Play();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("指定したファイルが見つかりません。");
                }
                finally
                {
                    //例外の有無に関わらず、最後に必ず実行される処理
                }

            }
          
        }
    }
}
