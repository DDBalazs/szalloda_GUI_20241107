namespace szalloda_GUI_20241107
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbfel = new System.Windows.Forms.RadioButton();
            this.rbteljes = new System.Windows.Forms.RadioButton();
            this.rtadatok = new System.Windows.Forms.RichTextBox();
            this.txvendegnev = new System.Windows.Forms.TextBox();
            this.txvendegszam = new System.Windows.Forms.TextBox();
            this.cbejszakak = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rttorzsvendek = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbvendegteljes = new System.Windows.Forms.Label();
            this.lbvendegejszakak = new System.Windows.Forms.Label();
            this.lbujszamok = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(342, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendék neve: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(342, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Éjszakák száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(342, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendégek száma: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbno);
            this.groupBox1.Controls.Add(this.rbfel);
            this.groupBox1.Controls.Add(this.rbteljes);
            this.groupBox1.Location = new System.Drawing.Point(345, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ellátás típusa";
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.ForeColor = System.Drawing.Color.Blue;
            this.rbno.Location = new System.Drawing.Point(7, 68);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(55, 17);
            this.rbno.TabIndex = 2;
            this.rbno.TabStop = true;
            this.rbno.Text = "nincs";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbfel
            // 
            this.rbfel.AutoSize = true;
            this.rbfel.ForeColor = System.Drawing.Color.Blue;
            this.rbfel.Location = new System.Drawing.Point(7, 44);
            this.rbfel.Name = "rbfel";
            this.rbfel.Size = new System.Drawing.Size(80, 17);
            this.rbfel.TabIndex = 1;
            this.rbfel.TabStop = true;
            this.rbfel.Text = "fél panzió";
            this.rbfel.UseVisualStyleBackColor = true;
            // 
            // rbteljes
            // 
            this.rbteljes.AutoSize = true;
            this.rbteljes.ForeColor = System.Drawing.Color.Blue;
            this.rbteljes.Location = new System.Drawing.Point(7, 20);
            this.rbteljes.Name = "rbteljes";
            this.rbteljes.Size = new System.Drawing.Size(55, 17);
            this.rbteljes.TabIndex = 0;
            this.rbteljes.TabStop = true;
            this.rbteljes.Text = "teljes";
            this.rbteljes.UseVisualStyleBackColor = true;
            // 
            // rtadatok
            // 
            this.rtadatok.Location = new System.Drawing.Point(12, 18);
            this.rtadatok.Name = "rtadatok";
            this.rtadatok.ReadOnly = true;
            this.rtadatok.Size = new System.Drawing.Size(307, 288);
            this.rtadatok.TabIndex = 4;
            this.rtadatok.Text = "";
            // 
            // txvendegnev
            // 
            this.txvendegnev.Location = new System.Drawing.Point(440, 30);
            this.txvendegnev.Name = "txvendegnev";
            this.txvendegnev.Size = new System.Drawing.Size(120, 20);
            this.txvendegnev.TabIndex = 5;
            this.txvendegnev.TextChanged += new System.EventHandler(this.txvendegnev_TextChanged);
            // 
            // txvendegszam
            // 
            this.txvendegszam.Location = new System.Drawing.Point(460, 106);
            this.txvendegszam.Name = "txvendegszam";
            this.txvendegszam.Size = new System.Drawing.Size(100, 20);
            this.txvendegszam.TabIndex = 6;
            this.txvendegszam.TextChanged += new System.EventHandler(this.txvendegszam_TextChanged);
            // 
            // cbejszakak
            // 
            this.cbejszakak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbejszakak.FormattingEnabled = true;
            this.cbejszakak.Location = new System.Drawing.Point(450, 69);
            this.cbejszakak.Name = "cbejszakak";
            this.cbejszakak.Size = new System.Drawing.Size(110, 21);
            this.cbejszakak.TabIndex = 7;
            this.cbejszakak.SelectedIndexChanged += new System.EventHandler(this.cbejszakak_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(619, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 73);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(619, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 73);
            this.button3.TabIndex = 10;
            this.button3.Text = "Mentés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.rttorzsvendek);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbvendegteljes);
            this.panel1.Controls.Add(this.lbvendegejszakak);
            this.panel1.Location = new System.Drawing.Point(12, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 113);
            this.panel1.TabIndex = 11;
            // 
            // rttorzsvendek
            // 
            this.rttorzsvendek.Location = new System.Drawing.Point(543, 26);
            this.rttorzsvendek.Name = "rttorzsvendek";
            this.rttorzsvendek.Size = new System.Drawing.Size(162, 73);
            this.rttorzsvendek.TabIndex = 3;
            this.rttorzsvendek.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Törzsvendégek";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbvendegteljes
            // 
            this.lbvendegteljes.AutoSize = true;
            this.lbvendegteljes.Location = new System.Drawing.Point(13, 59);
            this.lbvendegteljes.Name = "lbvendegteljes";
            this.lbvendegteljes.Size = new System.Drawing.Size(238, 13);
            this.lbvendegteljes.TabIndex = 1;
            this.lbvendegteljes.Text = "A teljes ellátást igénybevevők létszáma: ";
            // 
            // lbvendegejszakak
            // 
            this.lbvendegejszakak.AutoSize = true;
            this.lbvendegejszakak.Location = new System.Drawing.Point(13, 15);
            this.lbvendegejszakak.Name = "lbvendegejszakak";
            this.lbvendegejszakak.Size = new System.Drawing.Size(203, 13);
            this.lbvendegejszakak.TabIndex = 0;
            this.lbvendegejszakak.Text = "Vendégéjszakák száma összesen: ";
            // 
            // lbujszamok
            // 
            this.lbujszamok.AutoSize = true;
            this.lbujszamok.ForeColor = System.Drawing.Color.Blue;
            this.lbujszamok.Location = new System.Drawing.Point(345, 292);
            this.lbujszamok.Name = "lbujszamok";
            this.lbujszamok.Size = new System.Drawing.Size(151, 13);
            this.lbujszamok.TabIndex = 12;
            this.lbujszamok.Text = "Vendég éjszakák száma: ";
            this.lbujszamok.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lbujszamok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbejszakak);
            this.Controls.Add(this.txvendegszam);
            this.Controls.Add(this.txvendegnev);
            this.Controls.Add(this.rtadatok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szállás foglalások";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbfel;
        private System.Windows.Forms.RadioButton rbteljes;
        private System.Windows.Forms.RichTextBox rtadatok;
        private System.Windows.Forms.TextBox txvendegnev;
        private System.Windows.Forms.TextBox txvendegszam;
        private System.Windows.Forms.ComboBox cbejszakak;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbvendegteljes;
        private System.Windows.Forms.Label lbvendegejszakak;
        private System.Windows.Forms.RichTextBox rttorzsvendek;
        private System.Windows.Forms.Label lbujszamok;
    }
}

