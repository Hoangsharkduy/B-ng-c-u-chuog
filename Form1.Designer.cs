namespace Bảng_cửu_chuog
{
    partial class Form1
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
            this.btnt = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbskq = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnt
            // 
            this.btnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnt.Location = new System.Drawing.Point(556, 185);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(153, 49);
            this.btnt.TabIndex = 0;
            this.btnt.Text = "XEM";
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(144, 187);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(271, 47);
            this.txt1.TabIndex = 1;
            // 
            // lbskq
            // 
            this.lbskq.FormattingEnabled = true;
            this.lbskq.Location = new System.Drawing.Point(144, 262);
            this.lbskq.Name = "lbskq";
            this.lbskq.Size = new System.Drawing.Size(565, 277);
            this.lbskq.TabIndex = 3;
            this.lbskq.SelectedIndexChanged += new System.EventHandler(this.lbskq_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "BẢNG MUỐN BẢNG CỬU CHƯƠNG MẤY?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbskq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ListBox lbskq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

