
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
            this.Enter = new System.Windows.Forms.Button();
            this.hourUp_Button = new System.Windows.Forms.Button();
            this.hourDown_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(361, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // hour_textBox
            // 
            this.hour_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.hour_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hour_textBox.Location = new System.Drawing.Point(35, 163);
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
            this.label1.Location = new System.Drawing.Point(243, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // minute_textBox
            // 
            this.minute_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.minute_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.minute_textBox.Location = new System.Drawing.Point(170, 163);
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
            this.second_textBox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.second_textBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.second_textBox.Location = new System.Drawing.Point(283, 163);
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
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(262, 263);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(98, 44);
            this.Enter.TabIndex = 9;
            this.Enter.Text = "設定";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // hourUp_Button
            // 
            this.hourUp_Button.Location = new System.Drawing.Point(35, 127);
            this.hourUp_Button.Name = "hourUp_Button";
            this.hourUp_Button.Size = new System.Drawing.Size(60, 30);
            this.hourUp_Button.TabIndex = 11;
            this.hourUp_Button.Text = "∧";
            this.hourUp_Button.UseVisualStyleBackColor = false;
            this.hourUp_Button.Click += new System.EventHandler(this.hourUp_Click);
            // 
            // hourDown_Button
            // 
            this.hourDown_Button.Location = new System.Drawing.Point(35, 217);
            this.hourDown_Button.Name = "hourDown_Button";
            this.hourDown_Button.Size = new System.Drawing.Size(60, 30);
            this.hourDown_Button.TabIndex = 12;
            this.hourDown_Button.Text = "∨";
            this.hourDown_Button.UseVisualStyleBackColor = false;
            this.hourDown_Button.Click += new System.EventHandler(this.hourDown_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 349);
            this.Controls.Add(this.hourDown_Button);
            this.Controls.Add(this.hourUp_Button);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.second_textBox);
            this.Controls.Add(this.minute_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hour_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("Meiryo UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setting_MouseUp);
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
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button hourUp_Button;
        private System.Windows.Forms.Button hourDown_Button;
    }
}