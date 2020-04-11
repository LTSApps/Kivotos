namespace Kivotos
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updtcheck_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // updtcheck_btn
            // 
            this.updtcheck_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updtcheck_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updtcheck_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.updtcheck_btn.ForeColor = System.Drawing.Color.Navy;
            this.updtcheck_btn.Image = ((System.Drawing.Image)(resources.GetObject("updtcheck_btn.Image")));
            this.updtcheck_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updtcheck_btn.Location = new System.Drawing.Point(424, 210);
            this.updtcheck_btn.Name = "updtcheck_btn";
            this.updtcheck_btn.Size = new System.Drawing.Size(126, 38);
            this.updtcheck_btn.TabIndex = 32;
            this.updtcheck_btn.Text = "Έλεγχος για ενημερώσεις";
            this.updtcheck_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updtcheck_btn.UseVisualStyleBackColor = false;
            this.updtcheck_btn.Click += new System.EventHandler(this.updtcheck_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.back_btn.ForeColor = System.Drawing.Color.Navy;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.Location = new System.Drawing.Point(424, 254);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(126, 38);
            this.back_btn.TabIndex = 33;
            this.back_btn.Text = "Επιστροφή";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(438, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Κιβωτός";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(388, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(388, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Copyright: © 2020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(388, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mail: lazostsob@gmail.com";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updtcheck_btn);
            this.Controls.Add(this.back_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUs";
            this.Text = "Κιβωτός - Σχετικά με την εφαρμογή";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updtcheck_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}