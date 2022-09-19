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
            LoadFile();
            ViewTime(maxTime);

        }


        public bool nowCounting = false;

        //--時間設定画面表示
        Form2 form2;
        public bool nowViewForm2;
        private void label1_Click(object sender, EventArgs e)
        {

            if (!nowViewForm2 && !nowCounting)
            {
                nowViewForm2 = true;
                form2 = new Form2();
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = this.Location;
                form2.form1 = this;
                form2.Show();
            }
        }
        public void Close_Form2()
        {
            nowViewForm2 = false;
            form2.Close();
        }


        int nowTime;
       public  int maxTime;//設定画面に表示させる。　設定画面により更新される。


        public void SetTime(int _maxTime)
        {
            maxTime = _maxTime;
            nowTime = maxTime;
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
            SaveFile();
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
                soundFile_textBox.SelectionStart = soundFile_textBox.Text.Length;
            }
        }



        private void soundTest_Button_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = soundFile_textBox.Text;
            //axWindowsMediaPlayer1.playlist

            if (soundFile_textBox.Text.Length == 0)
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            nowTime--;
            ViewTime(nowTime);
            int nowValue = 100 * nowTime / maxTime;
            if (nowValue > 50)
            {
                ProgressColor(colors[0]);
            }
            else if (nowValue > 15)
            {
                ProgressColor(colors[1]);
            }
            else
            {
                ProgressColor(colors[2]);
            }
            progressBar1.Value = nowValue;


            if (nowTime <= 0)
            {
                SoundPlayer simpleSound = new SoundPlayer(soundFile_textBox.Text);
                simpleSound.Play();
                StartStop_Click();

            }
        }

        private void Reset_Click(object sender=default, EventArgs e=default)
        {
            progressBar1.Value = 100;
            nowTime = maxTime;
            ViewTime(nowTime);
            ProgressColor(colors[0]);
        }

        //--------------------------------------プログレスバー色
        Color[] colors = { Color.LimeGreen, Color.Orange, Color.Red };
        void ProgressColor(Color color)
        {
            progressBar1.ForeColor = color;
        }

        private void StartStop_Click(object sender = default, EventArgs e = default)
        {
            
            if (!nowCounting)
            {
                if (nowTime == 0) { return; }
                if (soundFile_textBox.Text.Length == 0)
                {
                    MessageBox.Show("サウンドファイルを指定してください");
                    return;
                }
                else
                {
                    try
                    {
                        SoundPlayer simpleSound = new SoundPlayer(soundFile_textBox.Text);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("指定したファイルが見つかりません。");
                        return;
                    }
                    finally
                    {
                        //例外の有無に関わらず、最後に必ず実行される処理
                    }
                }
                //カウントダウンスタート
                nowCounting = true;
                StartStop_Button.Text = "ストップ";

                //      if(soundFile_textBox.Text)
                soundFile_Button.Enabled = false;
                timer1.Start();
            }
            else
            {
                //カウントダウンストップ
                nowCounting = false;
                StartStop_Button.Text = "スタート";
                timer1.Stop();
                soundFile_Button.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFile();
            
           // Reset_Click();
        }

        void SaveFile()
        {
            Setting appSettings = new Setting();
            appSettings.SoundFileName = soundFile_textBox.Text;
            appSettings.MaxTime = maxTime;
            appSettings.MemoText = memoTextBox.Text;
            //保存先
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\setting.config";



            //＜XMLファイルに書き込む＞
            //XmlSerializerオブジェクトを作成
            //書き込むオブジェクトの型を指定する
            System.Xml.Serialization.XmlSerializer serializer1 =
                new System.Xml.Serialization.XmlSerializer(typeof(Setting));


            //ファイルを開く（UTF-8 BOM無し）


            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));

            //シリアル化し、XMLファイルに保存する
            serializer1.Serialize(sw, appSettings);
            //閉じる
            sw.Close();
        }


        void LoadFile()

        {
            //保存先
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\setting.config";

            //＜XMLファイルから読み込む＞
            //XmlSerializerオブジェクトの作成
            System.Xml.Serialization.XmlSerializer serializer2 =
                new System.Xml.Serialization.XmlSerializer(typeof(Setting));


            //ファイルを開く
            System.IO.StreamReader sr = new System.IO.StreamReader(
                fileName, new System.Text.UTF8Encoding(false));

            try
            {
                //XMLファイルから読み込み、逆シリアル化する
                Setting appSettings = (Setting)serializer2.Deserialize(sr);
                //閉じる
                


                soundFile_textBox.Text = appSettings.SoundFileName;
                maxTime = appSettings.MaxTime;
                memoTextBox.Text = appSettings.MemoText;
                nowTime = maxTime;
                soundFile_textBox.SelectionStart = soundFile_textBox.Text.Length;
            }
            catch (System.InvalidOperationException)
            {
                return;
            }
            finally
            {
              
                sr.Close();
              
            }

        }


        public bool nowViewSaveForm = false;
        SaveTimer saveTimer;
        private void openSaveFormButon_Click(object sender, EventArgs e)
        {
            if (!nowViewSaveForm && !nowCounting)
            {
                Setting nowSetting = SetSettingData();
                nowViewSaveForm = true;
                saveTimer = new SaveTimer();
                saveTimer.SetNowSetting(nowSetting);
                saveTimer.StartPosition = FormStartPosition.Manual;
                saveTimer.Location = new Point ( this.Location.X+50 , this.Location.Y+70);
                saveTimer.form1 = this;
                saveTimer.Show();
            }
        }

        Setting SetSettingData()
        {
            Setting setting = new Setting();
            setting.MaxTime = maxTime;
            setting.MemoText = memoTextBox.Text;
            setting.SoundFileName = soundFile_textBox.Text;
            return setting;
        }

       public void LoadSettingData(Setting setting)
        {
            maxTime = setting.MaxTime;
            memoTextBox.Text = setting.MemoText;
            soundFile_textBox.Text = setting.SoundFileName;
            soundFile_textBox.SelectionStart = soundFile_textBox.Text.Length;
            Reset_Click();
        }
      public  bool nowViewLoadForm = false;
        LoadTimer loadTimer;
        private void openLoadFormButton_Click(object sender, EventArgs e)
        {
            if (!nowViewLoadForm && !nowCounting)
            {
                nowViewLoadForm = true;
                loadTimer = new LoadTimer();
                  loadTimer.StartPosition = FormStartPosition.Manual;
                  loadTimer.Location = new Point(this.Location.X + 50, this.Location.Y + 70);
                loadTimer.form1 = this;
                loadTimer.Show();
            }
        }
    }
}


