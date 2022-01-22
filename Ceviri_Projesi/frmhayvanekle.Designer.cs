namespace Ceviri_Projesi
{
    partial class frmhayvanekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfransızca = new System.Windows.Forms.TextBox();
            this.txtalmanca = new System.Windows.Forms.TextBox();
            this.txtturkce = new System.Windows.Forms.TextBox();
            this.txtingilizce = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Almanca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "İngilizce";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Türkçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fransızca";
            // 
            // txtfransızca
            // 
            this.txtfransızca.Location = new System.Drawing.Point(480, 125);
            this.txtfransızca.Name = "txtfransızca";
            this.txtfransızca.Size = new System.Drawing.Size(126, 26);
            this.txtfransızca.TabIndex = 4;
            // 
            // txtalmanca
            // 
            this.txtalmanca.Location = new System.Drawing.Point(348, 125);
            this.txtalmanca.Name = "txtalmanca";
            this.txtalmanca.Size = new System.Drawing.Size(126, 26);
            this.txtalmanca.TabIndex = 3;
            // 
            // txtturkce
            // 
            this.txtturkce.Location = new System.Drawing.Point(84, 125);
            this.txtturkce.Name = "txtturkce";
            this.txtturkce.Size = new System.Drawing.Size(126, 26);
            this.txtturkce.TabIndex = 1;
            // 
            // txtingilizce
            // 
            this.txtingilizce.Location = new System.Drawing.Point(216, 125);
            this.txtingilizce.Name = "txtingilizce";
            this.txtingilizce.Size = new System.Drawing.Size(126, 26);
            this.txtingilizce.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(84, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(522, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ekleme Paneli";
            // 
            // frmhayvanekle
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(624, 225);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtingilizce);
            this.Controls.Add(this.txtturkce);
            this.Controls.Add(this.txtalmanca);
            this.Controls.Add(this.txtfransızca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmhayvanekle";
            this.Text = "Hayvan Adı Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfransızca;
        private System.Windows.Forms.TextBox txtalmanca;
        private System.Windows.Forms.TextBox txtturkce;
        private System.Windows.Forms.TextBox txtingilizce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}