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
    public partial class LoadTimer : Form
    {
        public LoadTimer()
        {
            InitializeComponent();
            LoadXML();
            ViewListBox();
        }
        public Form1 form1;
        List<Setting> settings=new List<Setting>();
        private void openButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Setting setting = settings[listBox1.SelectedIndex];
                form1.LoadSettingData(setting);
                form1.nowViewLoadForm = false;
                this.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            form1.nowViewLoadForm = false;
            this.Close();
        }

        //せーぶFormとろーどFormにおんなじめそっどがあるのはそとにだしてまとめるとかするべきではでも２こしかないしいいか
        void ViewListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < settings.Count; i++)
            {
                Setting setting = settings[i];
                string viewText = TimeToString(setting.MaxTime) + " 「" + setting.MemoText + "」";
                listBox1.Items.Add(viewText);
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
        settings = (List<Setting>) serializer2.Deserialize(sr);
        sr.Close();


        }

    //--------------------------------------------ウインドウの移動

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

