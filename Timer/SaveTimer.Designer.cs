
namespace MyTimer
{
    partial class SaveTimer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.newSave = new System.Windows.Forms.Button();
            this.overwriteSave = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 244);
            this.listBox1.TabIndex = 0;
            // 
            // newSave
            // 
            this.newSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.newSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.newSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSave.Location = new System.Drawing.Point(272, 27);
            this.newSave.Name = "newSave";
            this.newSave.Size = new System.Drawing.Size(116, 45);
            this.newSave.TabIndex = 1;
            this.newSave.Text = "新規保存";
            this.newSave.UseVisualStyleBackColor = false;
            this.newSave.Click += new System.EventHandler(this.newSave_Click);
            // 
            // overwriteSave
            // 
            this.overwriteSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.overwriteSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.overwriteSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.overwriteSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overwriteSave.Location = new System.Drawing.Point(272, 78);
            this.overwriteSave.Name = "overwriteSave";
            this.overwriteSave.Size = new System.Drawing.Size(116, 45);
            this.overwriteSave.TabIndex = 2;
            this.overwriteSave.Text = "上書き保存";
            this.overwriteSave.UseVisualStyleBackColor = false;
            this.overwriteSave.Click += new System.EventHandler(this.overwriteSave_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Location = new System.Drawing.Point(272, 129);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 45);
            this.delete.TabIndex = 3;
            this.delete.Text = "削除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(272, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 45);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 300);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(399, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 300);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 1);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 299);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(400, 1);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // SaveTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.overwriteSave);
            this.Controls.Add(this.newSave);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SaveTimer";
            this.Text = "SaveTimer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setting_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button newSave;
        private System.Windows.Forms.Button overwriteSave;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}