
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer_Text = new System.Windows.Forms.Label();
            this.TitlerPanel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.titlreLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.soundFile_Button = new System.Windows.Forms.Button();
            this.soundFile_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soundTest_Button = new System.Windows.Forms.Button();
            this.TitlerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("源ノ角ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(30, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_Text
            // 
            this.timer_Text.AutoSize = true;
            this.timer_Text.Font = new System.Drawing.Font("源ノ角ゴシック", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timer_Text.Location = new System.Drawing.Point(135, 137);
            this.timer_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer_Text.Name = "timer_Text";
            this.timer_Text.Size = new System.Drawing.Size(195, 62);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("源ノ角ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(259, 216);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "リセット";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(81, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 32);
            this.textBox1.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // soundFile_Button
            // 
            this.soundFile_Button.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundFile_Button.Location = new System.Drawing.Point(327, 410);
            this.soundFile_Button.Name = "soundFile_Button";
            this.soundFile_Button.Size = new System.Drawing.Size(60, 30);
            this.soundFile_Button.TabIndex = 7;
            this.soundFile_Button.Text = "参照";
            this.soundFile_Button.UseVisualStyleBackColor = true;
            this.soundFile_Button.Click += new System.EventHandler(this.soundFile_Button_Click);
            // 
            // soundFile_textBox
            // 
            this.soundFile_textBox.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundFile_textBox.Location = new System.Drawing.Point(93, 413);
            this.soundFile_textBox.Name = "soundFile_textBox";
            this.soundFile_textBox.ReadOnly = true;
            this.soundFile_textBox.Size = new System.Drawing.Size(215, 23);
            this.soundFile_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "通知音:";
            // 
            // soundTest_Button
            // 
            this.soundTest_Button.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.soundTest_Button.Location = new System.Drawing.Point(406, 410);
            this.soundTest_Button.Name = "soundTest_Button";
            this.soundTest_Button.Size = new System.Drawing.Size(60, 30);
            this.soundTest_Button.TabIndex = 10;
            this.soundTest_Button.Text = "テスト";
            this.soundTest_Button.UseVisualStyleBackColor = true;
            this.soundTest_Button.Click += new System.EventHandler(this.soundTest_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(486, 452);
            this.Controls.Add(this.soundTest_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soundFile_textBox);
            this.Controls.Add(this.soundFile_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TitlerPanel1);
            this.Controls.Add(this.timer_Text);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TitlerPanel1.ResumeLayout(false);
            this.TitlerPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label timer_Text;
        private System.Windows.Forms.Panel TitlerPanel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titlreLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button soundFile_Button;
        private System.Windows.Forms.TextBox soundFile_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button soundTest_Button;
    }
}

