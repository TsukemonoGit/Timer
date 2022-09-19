
namespace MyTimer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hour_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minute_textBox = new System.Windows.Forms.TextBox();
            this.second_textBox = new System.Windows.Forms.TextBox();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.hourUp_Button = new System.Windows.Forms.Button();
            this.hourDown_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.minuteDown_Button = new System.Windows.Forms.Button();
            this.minuteUp_Button = new System.Windows.Forms.Button();
            this.secondDown_Button = new System.Windows.Forms.Button();
            this.secondUp_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(361, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // hour_textBox
            // 
            this.hour_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hour_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.hour_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hour_textBox.Location = new System.Drawing.Point(35, 84);
            this.hour_textBox.MaxLength = 2;
            this.hour_textBox.Name = "hour_textBox";
            this.hour_textBox.ShortcutsEnabled = false;
            this.hour_textBox.Size = new System.Drawing.Size(60, 48);
            this.hour_textBox.TabIndex = 5;
            this.hour_textBox.Text = "00";
            this.hour_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hour_textBox.TextChanged += new System.EventHandler(this.hour_TextChanged);
            this.hour_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // minute_textBox
            // 
            this.minute_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minute_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.minute_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.minute_textBox.Location = new System.Drawing.Point(153, 84);
            this.minute_textBox.MaxLength = 2;
            this.minute_textBox.Name = "minute_textBox";
            this.minute_textBox.ShortcutsEnabled = false;
            this.minute_textBox.Size = new System.Drawing.Size(60, 48);
            this.minute_textBox.TabIndex = 7;
            this.minute_textBox.Text = "00";
            this.minute_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minute_textBox.TextChanged += new System.EventHandler(this.minute_TextChanged);
            this.minute_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute_KeyPress);
            // 
            // second_textBox
            // 
            this.second_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.second_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.second_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.second_textBox.Location = new System.Drawing.Point(268, 84);
            this.second_textBox.MaxLength = 2;
            this.second_textBox.Name = "second_textBox";
            this.second_textBox.ShortcutsEnabled = false;
            this.second_textBox.Size = new System.Drawing.Size(60, 48);
            this.second_textBox.TabIndex = 8;
            this.second_textBox.Text = "00";
            this.second_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.second_textBox.TextChanged += new System.EventHandler(this.second_TextChanged);
            this.second_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_KeyPress);
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Enter_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_Button.Location = new System.Drawing.Point(283, 194);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(98, 44);
            this.Enter_Button.TabIndex = 9;
            this.Enter_Button.Text = "設定";
            this.Enter_Button.UseVisualStyleBackColor = false;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Click);
            // 
            // hourUp_Button
            // 
            this.hourUp_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hourUp_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hourUp_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.hourUp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourUp_Button.Location = new System.Drawing.Point(35, 37);
            this.hourUp_Button.Name = "hourUp_Button";
            this.hourUp_Button.Size = new System.Drawing.Size(60, 40);
            this.hourUp_Button.TabIndex = 11;
            this.hourUp_Button.Text = "∧";
            this.hourUp_Button.UseVisualStyleBackColor = false;
            this.hourUp_Button.Click += new System.EventHandler(this.hourUp_Click);
            // 
            // hourDown_Button
            // 
            this.hourDown_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hourDown_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hourDown_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.hourDown_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourDown_Button.Location = new System.Drawing.Point(35, 141);
            this.hourDown_Button.Name = "hourDown_Button";
            this.hourDown_Button.Size = new System.Drawing.Size(60, 40);
            this.hourDown_Button.TabIndex = 12;
            this.hourDown_Button.Text = "∨";
            this.hourDown_Button.UseVisualStyleBackColor = false;
            this.hourDown_Button.Click += new System.EventHandler(this.hourDown_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(0, -50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 350);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setting_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setting_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setting_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(399, -50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 350);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 1);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(0, 249);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(400, 1);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // minuteDown_Button
            // 
            this.minuteDown_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minuteDown_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minuteDown_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.minuteDown_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuteDown_Button.Location = new System.Drawing.Point(153, 141);
            this.minuteDown_Button.Name = "minuteDown_Button";
            this.minuteDown_Button.Size = new System.Drawing.Size(60, 40);
            this.minuteDown_Button.TabIndex = 18;
            this.minuteDown_Button.Text = "∨";
            this.minuteDown_Button.UseVisualStyleBackColor = false;
            this.minuteDown_Button.Click += new System.EventHandler(this.minuteDown_Button_Click);
            // 
            // minuteUp_Button
            // 
            this.minuteUp_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minuteUp_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.minuteUp_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.minuteUp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuteUp_Button.Location = new System.Drawing.Point(153, 37);
            this.minuteUp_Button.Name = "minuteUp_Button";
            this.minuteUp_Button.Size = new System.Drawing.Size(60, 40);
            this.minuteUp_Button.TabIndex = 17;
            this.minuteUp_Button.Text = "∧";
            this.minuteUp_Button.UseVisualStyleBackColor = false;
            this.minuteUp_Button.Click += new System.EventHandler(this.minuteUp_Button_Click);
            // 
            // secondDown_Button
            // 
            this.secondDown_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondDown_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.secondDown_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.secondDown_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondDown_Button.Location = new System.Drawing.Point(268, 141);
            this.secondDown_Button.Name = "secondDown_Button";
            this.secondDown_Button.Size = new System.Drawing.Size(60, 40);
            this.secondDown_Button.TabIndex = 20;
            this.secondDown_Button.Text = "∨";
            this.secondDown_Button.UseVisualStyleBackColor = false;
            this.secondDown_Button.Click += new System.EventHandler(this.secondDown_Button_Click);
            // 
            // secondUp_Button
            // 
            this.secondUp_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondUp_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.secondUp_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.secondUp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondUp_Button.Location = new System.Drawing.Point(268, 37);
            this.secondUp_Button.Name = "secondUp_Button";
            this.secondUp_Button.Size = new System.Drawing.Size(60, 40);
            this.secondUp_Button.TabIndex = 19;
            this.secondUp_Button.Text = "∧";
            this.secondUp_Button.UseVisualStyleBackColor = false;
            this.secondUp_Button.Click += new System.EventHandler(this.secondUp_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.secondDown_Button);
            this.Controls.Add(this.secondUp_Button);
            this.Controls.Add(this.minuteDown_Button);
            this.Controls.Add(this.minuteUp_Button);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.hourDown_Button);
            this.Controls.Add(this.hourUp_Button);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.second_textBox);
            this.Controls.Add(this.minute_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hour_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setting_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hour_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minute_textBox;
        private System.Windows.Forms.TextBox second_textBox;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button hourUp_Button;
        private System.Windows.Forms.Button hourDown_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button minuteDown_Button;
        private System.Windows.Forms.Button minuteUp_Button;
        private System.Windows.Forms.Button secondDown_Button;
        private System.Windows.Forms.Button secondUp_Button;
    }
}