namespace QuizPanda_Venansius_0706022110001
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.tbdari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmenjadi = new System.Windows.Forms.TextBox();
            this.btnkonv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukan Kalimat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukan Huruf :";
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(219, 29);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(543, 26);
            this.tbinput.TabIndex = 2;
            this.tbinput.TextChanged += new System.EventHandler(this.tbinput_TextChanged);
            // 
            // tbdari
            // 
            this.tbdari.Location = new System.Drawing.Point(219, 107);
            this.tbdari.Name = "tbdari";
            this.tbdari.Size = new System.Drawing.Size(140, 26);
            this.tbdari.TabIndex = 3;
            this.tbdari.TextChanged += new System.EventHandler(this.tbdari_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi :";
            // 
            // tbmenjadi
            // 
            this.tbmenjadi.Location = new System.Drawing.Point(622, 107);
            this.tbmenjadi.Name = "tbmenjadi";
            this.tbmenjadi.Size = new System.Drawing.Size(140, 26);
            this.tbmenjadi.TabIndex = 5;
            this.tbmenjadi.TextChanged += new System.EventHandler(this.tbmenjadi_TextChanged);
            // 
            // btnkonv
            // 
            this.btnkonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkonv.Location = new System.Drawing.Point(219, 188);
            this.btnkonv.Name = "btnkonv";
            this.btnkonv.Size = new System.Drawing.Size(543, 64);
            this.btnkonv.TabIndex = 6;
            this.btnkonv.Text = "Konversi";
            this.btnkonv.UseVisualStyleBackColor = true;
            this.btnkonv.Click += new System.EventHandler(this.btnkonv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil :";
            // 
            // labelhasil
            // 
            this.labelhasil.AutoSize = true;
            this.labelhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhasil.Location = new System.Drawing.Point(214, 301);
            this.labelhasil.Name = "labelhasil";
            this.labelhasil.Size = new System.Drawing.Size(0, 25);
            this.labelhasil.TabIndex = 8;
            this.labelhasil.Click += new System.EventHandler(this.labelhasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 395);
            this.Controls.Add(this.labelhasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnkonv);
            this.Controls.Add(this.tbmenjadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbdari);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.TextBox tbdari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmenjadi;
        private System.Windows.Forms.Button btnkonv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelhasil;
    }
}

