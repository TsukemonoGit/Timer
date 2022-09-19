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
    public partial class SaveTimer : Form
    {
        public SaveTimer()
        {
            InitializeComponent();
            LoadXML();
            ViewListBox();
        }
        public Form1 form1; 
        List<Setting> settings = new List<Setting>();
        Setting nowSetting;
        private void newSave_Click(object sender, EventArgs e)
        {
            settings.Add(nowSetting);
            ViewListBox(settings.Count -1);
        }

        private void overwriteSave_Click(object sender, EventArgs e)
        {
            int selectIndex = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                settings[selectIndex] = nowSetting;
                ViewListBox(selectIndex);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectIndex = listBox1.SelectedIndex;
            if (selectIndex!= -1)
            {
                settings.RemoveAt(selectIndex);
               
                ViewListBox(selectIndex);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            form1.nowViewSaveForm = false;
            UpdateXML();
            this.Close();
        }


        public void SetNowSetting(Setting setting)
        {
            nowSetting = setting;
        }

        void ViewListBox(int selectIndex=0)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < settings.Count; i++) {
                Setting setting = settings[i];
                string viewText = TimeToString(setting.MaxTime) + " 「" + setting.MemoText + "」";
                listBox1.Items.Add(viewText);
                }
            if (selectIndex < listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectIndex;
            }
        }

            private string TimeToString(int time_i)
            {
                TimeSpan hms_time = new TimeSpan(0, 0, time_i);
                return hms_time.ToString();
            }

        void LoadXML()
        {
            //settings =~~~~~~;
            //ViewListBox();
            //保存した内容を復元する
            
            //保存先
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\template.xml";

            System.Xml.Serialization.XmlSerializer serializer2 =
                new System.Xml.Serialization.XmlSerializer(typeof(List<Setting>));
            System.IO.StreamReader sr = new System.IO.StreamReader(
                fileName, new System.Text.UTF8Encoding(false));
            //SampleClass[] loadAry;
            settings = (List<Setting>)serializer2.Deserialize(sr);
            sr.Close();


        }
        void UpdateXML() {
            //保存先
            string fileName = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\template.xml";

            System.Xml.Serialization.XmlSerializer serializer1 =
        new System.Xml.Serialization.XmlSerializer(typeof(List<Setting>));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                fileName, false, new System.Text.UTF8Encoding(false));
            serializer1.Serialize(sw, settings);
            sw.Close();

        }


        //--------------------------------------------------------ウインドウの移動

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
