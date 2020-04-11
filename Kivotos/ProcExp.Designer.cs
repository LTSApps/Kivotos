namespace Kivotos
{
    partial class ProcExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcExp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(6, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 39);
            this.panel1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(318, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(234, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Περιγραφή";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(122, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Κωδ. Εισαγωγής";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.back_btn.ForeColor = System.Drawing.Color.Navy;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.Location = new System.Drawing.Point(315, 389);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(131, 45);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Επιστροφή";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_btn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Navy;
            this.Delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("Delete_btn.Image")));
            this.Delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_btn.Location = new System.Drawing.Point(143, 389);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(129, 45);
            this.Delete_btn.TabIndex = 9;
            this.Delete_btn.Text = "Αφαίρεση";
            this.Delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.save_btn.ForeColor = System.Drawing.Color.Navy;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(6, 389);
            this.save_btn.Name = "save_btn";
            this.save_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.save_btn.Size = new System.Drawing.Size(131, 45);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Καταχώρηση";
            this.save_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // ProcExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Κιβωτός - Φόρμα Επεξεργασίας Εξαγωγών";
            this.Load += new System.EventHandler(this.ProcExp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}