
namespace MyTimer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartStop_Button = new System.Windows.Forms.Button();
            this.timer_Text = new System.Windows.Forms.Label();
            this.TitlerPanel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.titlreLabel = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soundFile_Button = new System.Windows.Forms.Button();
            this.soundFile_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soundTest_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openSaveFormButon = new System.Windows.Forms.Button();
            this.openLoadFormButton = new System.Windows.Forms.Button();
            this.TitlerPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStop_Button
            // 
            this.StartStop_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartStop_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.StartStop_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StartStop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop_Button.Font = new System.Drawing.Font("源ノ角ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartStop_Button.Location = new System.Drawing.Point(40, 256);
            this.StartStop_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartStop_Button.Name = "StartStop_Button";
            this.StartStop_Button.Size = new System.Drawing.Size(187, 70);
            this.StartStop_Button.TabIndex = 0;
            this.StartStop_Button.Text = "スタート";
            this.StartStop_Button.UseVisualStyleBackColor = false;
            this.StartStop_Button.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // timer_Text
            // 
            this.timer_Text.AutoSize = true;
            this.timer_Text.Font = new System.Drawing.Font("源ノ角ゴシック", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timer_Text.Location = new System.Drawing.Point(107, 116);
            this.timer_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer_Text.Name = "timer_Text";
            this.timer_Text.Size = new System.Drawing.Size(253, 81);
            this.timer_Text.TabIndex = 1;
            this.timer_Text.Text = "00:00:00";
            this.timer_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // TitlerPanel1
            // 
            this.TitlerPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitlerPanel1.Controls.Add(this.closeButton);
            this.TitlerPanel1.Controls.Add(this.titlreLabel);
            this.TitlerPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlerPanel1.Font = new System.Drawing.Font("源ノ角ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitlerPanel1.Location = new System.Drawing.Point(0, 0);
            this.TitlerPanel1.Name = "TitlerPanel1";
            this.TitlerPanel1.Size = new System.Drawing.Size(486, 50);
            this.TitlerPanel1.TabIndex = 2;
            this.TitlerPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitlerPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitlerPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(447, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titlreLabel
            // 
            this.titlreLabel.AutoSize = true;
            this.titlreLabel.Font = new System.Drawing.Font("源ノ角ゴシック", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titlreLabel.ForeColor = System.Drawing.Color.White;
            this.titlreLabel.Location = new System.Drawing.Point(25, 10);
            this.titlreLabel.Name = "titlreLabel";
            this.titlreLabel.Size = new System.Drawing.Size(94, 28);
            this.titlreLabel.TabIndex = 0;
            this.titlreLabel.Text = "MyTimer";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Reset_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Reset_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_Button.Font = new System.Drawing.Font("源ノ角ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Reset_Button.Location = new System.Drawing.Point(249, 256);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(187, 70);
            this.Reset_Button.TabIndex = 3;
            this.Reset_Button.Text = "リセット";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(96, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // memoTextBox
            // 
            this.memoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memoTextBox.Location = new System.Drawing.Point(40, 72);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(353, 32);
            this.memoTextBox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // soundFile_Button
            // 
            this.soundFile_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundFile_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.soundFile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.soundFile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundFile_Button.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundFile_Button.Location = new System.Drawing.Point(327, 356);
            this.soundFile_Button.Name = "soundFile_Button";
            this.soundFile_Button.Size = new System.Drawing.Size(60, 30);
            this.soundFile_Button.TabIndex = 7;
            this.soundFile_Button.Text = "参照";
            this.soundFile_Button.UseVisualStyleBackColor = false;
            this.soundFile_Button.Click += new System.EventHandler(this.soundFile_Button_Click);
            // 
            // soundFile_textBox
            // 
            this.soundFile_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.soundFile_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soundFile_textBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundFile_textBox.Location = new System.Drawing.Point(93, 366);
            this.soundFile_textBox.Name = "soundFile_textBox";
            this.soundFile_textBox.ReadOnly = true;
            this.soundFile_textBox.Size = new System.Drawing.Size(215, 16);
            this.soundFile_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "通知音:";
            // 
            // soundTest_Button
            // 
            this.soundTest_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soundTest_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.soundTest_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.soundTest_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundTest_Button.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundTest_Button.Location = new System.Drawing.Point(406, 356);
            this.soundTest_Button.Name = "soundTest_Button";
            this.soundTest_Button.Size = new System.Drawing.Size(60, 30);
            this.soundTest_Button.TabIndex = 10;
            this.soundTest_Button.Text = "テスト";
            this.soundTest_Button.UseVisualStyleBackColor = false;
            this.soundTest_Button.Click += new System.EventHandler(this.soundTest_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(93, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 1);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openSaveFormButon
            // 
            this.openSaveFormButon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openSaveFormButon.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.openSaveFormButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.openSaveFormButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSaveFormButon.Location = new System.Drawing.Point(402, 70);
            this.openSaveFormButon.Name = "openSaveFormButon";
            this.openSaveFormButon.Size = new System.Drawing.Size(75, 32);
            this.openSaveFormButon.TabIndex = 12;
            this.openSaveFormButon.Text = "保存";
            this.openSaveFormButon.UseVisualStyleBackColor = false;
            this.openSaveFormButon.Click += new System.EventHandler(this.openSaveFormButon_Click);
            // 
            // openLoadFormButton
            // 
            this.openLoadFormButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openLoadFormButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.openLoadFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.openLoadFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLoadFormButton.Location = new System.Drawing.Point(402, 108);
            this.openLoadFormButton.Name = "openLoadFormButton";
            this.openLoadFormButton.Size = new System.Drawing.Size(75, 34);
            this.openLoadFormButton.TabIndex = 13;
            this.openLoadFormButton.Text = "読込";
            this.openLoadFormButton.UseVisualStyleBackColor = false;
            this.openLoadFormButton.Click += new System.EventHandler(this.openLoadFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(486, 401);
            this.Controls.Add(this.openLoadFormButton);
            this.Controls.Add(this.openSaveFormButon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soundTest_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soundFile_textBox);
            this.Controls.Add(this.soundFile_Button);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.TitlerPanel1);
            this.Controls.Add(this.timer_Text);
            this.Controls.Add(this.StartStop_Button);
            this.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TitlerPanel1.ResumeLayout(false);
            this.TitlerPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStop_Button;
        private System.Windows.Forms.Label timer_Text;
        private System.Windows.Forms.Panel TitlerPanel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titlreLabel;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button soundFile_Button;
        private System.Windows.Forms.TextBox soundFile_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button soundTest_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openSaveFormButon;
        private System.Windows.Forms.Button openLoadFormButton;
        private System.Windows.Forms.TextBox memoTextBox;
    }
}

