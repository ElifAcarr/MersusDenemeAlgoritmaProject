namespace Mersus_Algoritma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTarih = new System.Windows.Forms.ComboBox();
            this.comboBoxaralik = new System.Windows.Forms.ComboBox();
            this.monthCalendarbitis = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarbas = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTarih
            // 
            this.comboBoxTarih.FormattingEnabled = true;
            this.comboBoxTarih.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık"});
            this.comboBoxTarih.Location = new System.Drawing.Point(12, 41);
            this.comboBoxTarih.Name = "comboBoxTarih";
            this.comboBoxTarih.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTarih.TabIndex = 0;
            this.comboBoxTarih.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarih_SelectedIndexChanged);
            // 
            // comboBoxaralik
            // 
            this.comboBoxaralik.FormattingEnabled = true;
            this.comboBoxaralik.Location = new System.Drawing.Point(12, 92);
            this.comboBoxaralik.Name = "comboBoxaralik";
            this.comboBoxaralik.Size = new System.Drawing.Size(121, 23);
            this.comboBoxaralik.TabIndex = 1;
            this.comboBoxaralik.SelectedIndexChanged += new System.EventHandler(this.comboBoxaralik_SelectedIndexChanged);
            // 
            // monthCalendarbitis
            // 
            this.monthCalendarbitis.Location = new System.Drawing.Point(191, 209);
            this.monthCalendarbitis.Name = "monthCalendarbitis";
            this.monthCalendarbitis.TabIndex = 4;
            this.monthCalendarbitis.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarbitis_DateChanged);
            // 
            // monthCalendarbas
            // 
            this.monthCalendarbas.Location = new System.Drawing.Point(191, 18);
            this.monthCalendarbas.Name = "monthCalendarbas";
            this.monthCalendarbas.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(488, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 274);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pazartesi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Salı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Çarşamba";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Perşembe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Cuma";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Cumartesi";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Pazar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendarbas);
            this.Controls.Add(this.monthCalendarbitis);
            this.Controls.Add(this.comboBoxaralik);
            this.Controls.Add(this.comboBoxTarih);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxTarih;
        private ComboBox comboBoxaralik;
        private MonthCalendar monthCalendarbitis;
        private MonthCalendar monthCalendarbas;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}