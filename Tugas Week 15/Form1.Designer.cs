namespace Tugas_Week_15
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
            this.labelnamaitem = new System.Windows.Forms.Label();
            this.labelkategori = new System.Windows.Forms.Label();
            this.textBoxnama = new System.Windows.Forms.TextBox();
            this.checkBoxmakanan = new System.Windows.Forms.CheckBox();
            this.checkBoxminuman = new System.Windows.Forms.CheckBox();
            this.radioButtonmakanan = new System.Windows.Forms.RadioButton();
            this.radioButtonminuman = new System.Windows.Forms.RadioButton();
            this.groupBoxradiobutton = new System.Windows.Forms.GroupBox();
            this.groupBoxfilter = new System.Windows.Forms.GroupBox();
            this.buttoninput = new System.Windows.Forms.Button();
            this.buttonpanah = new System.Windows.Forms.Button();
            this.buttonsilang = new System.Windows.Forms.Button();
            this.listBoxkiri = new System.Windows.Forms.ListBox();
            this.listBoxkanan = new System.Windows.Forms.ListBox();
            this.groupBoxradiobutton.SuspendLayout();
            this.groupBoxfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnamaitem
            // 
            this.labelnamaitem.AutoSize = true;
            this.labelnamaitem.Location = new System.Drawing.Point(55, 28);
            this.labelnamaitem.Name = "labelnamaitem";
            this.labelnamaitem.Size = new System.Drawing.Size(75, 17);
            this.labelnamaitem.TabIndex = 0;
            this.labelnamaitem.Text = "Nama Item";
            // 
            // labelkategori
            // 
            this.labelkategori.AutoSize = true;
            this.labelkategori.Location = new System.Drawing.Point(55, 85);
            this.labelkategori.Name = "labelkategori";
            this.labelkategori.Size = new System.Drawing.Size(61, 17);
            this.labelkategori.TabIndex = 1;
            this.labelkategori.Text = "Kategori";
            // 
            // textBoxnama
            // 
            this.textBoxnama.Location = new System.Drawing.Point(193, 28);
            this.textBoxnama.Name = "textBoxnama";
            this.textBoxnama.Size = new System.Drawing.Size(151, 22);
            this.textBoxnama.TabIndex = 3;
            // 
            // checkBoxmakanan
            // 
            this.checkBoxmakanan.AutoSize = true;
            this.checkBoxmakanan.Location = new System.Drawing.Point(6, 28);
            this.checkBoxmakanan.Name = "checkBoxmakanan";
            this.checkBoxmakanan.Size = new System.Drawing.Size(88, 21);
            this.checkBoxmakanan.TabIndex = 4;
            this.checkBoxmakanan.Text = "Makanan";
            this.checkBoxmakanan.UseVisualStyleBackColor = true;
            this.checkBoxmakanan.CheckedChanged += new System.EventHandler(this.checkBoxmakanan_CheckedChanged);
            // 
            // checkBoxminuman
            // 
            this.checkBoxminuman.AutoSize = true;
            this.checkBoxminuman.Location = new System.Drawing.Point(6, 55);
            this.checkBoxminuman.Name = "checkBoxminuman";
            this.checkBoxminuman.Size = new System.Drawing.Size(87, 21);
            this.checkBoxminuman.TabIndex = 5;
            this.checkBoxminuman.Text = "Minuman";
            this.checkBoxminuman.UseVisualStyleBackColor = true;
            this.checkBoxminuman.CheckedChanged += new System.EventHandler(this.checkBoxminuman_CheckedChanged);
            // 
            // radioButtonmakanan
            // 
            this.radioButtonmakanan.AutoSize = true;
            this.radioButtonmakanan.Location = new System.Drawing.Point(6, 21);
            this.radioButtonmakanan.Name = "radioButtonmakanan";
            this.radioButtonmakanan.Size = new System.Drawing.Size(87, 21);
            this.radioButtonmakanan.TabIndex = 6;
            this.radioButtonmakanan.TabStop = true;
            this.radioButtonmakanan.Text = "Makanan";
            this.radioButtonmakanan.UseVisualStyleBackColor = true;
            // 
            // radioButtonminuman
            // 
            this.radioButtonminuman.AutoSize = true;
            this.radioButtonminuman.Location = new System.Drawing.Point(105, 21);
            this.radioButtonminuman.Name = "radioButtonminuman";
            this.radioButtonminuman.Size = new System.Drawing.Size(86, 21);
            this.radioButtonminuman.TabIndex = 7;
            this.radioButtonminuman.TabStop = true;
            this.radioButtonminuman.Text = "Minuman";
            this.radioButtonminuman.UseVisualStyleBackColor = true;
            // 
            // groupBoxradiobutton
            // 
            this.groupBoxradiobutton.Controls.Add(this.radioButtonmakanan);
            this.groupBoxradiobutton.Controls.Add(this.radioButtonminuman);
            this.groupBoxradiobutton.Location = new System.Drawing.Point(193, 72);
            this.groupBoxradiobutton.Name = "groupBoxradiobutton";
            this.groupBoxradiobutton.Size = new System.Drawing.Size(203, 73);
            this.groupBoxradiobutton.TabIndex = 8;
            this.groupBoxradiobutton.TabStop = false;
            // 
            // groupBoxfilter
            // 
            this.groupBoxfilter.Controls.Add(this.checkBoxmakanan);
            this.groupBoxfilter.Controls.Add(this.checkBoxminuman);
            this.groupBoxfilter.Location = new System.Drawing.Point(292, 277);
            this.groupBoxfilter.Name = "groupBoxfilter";
            this.groupBoxfilter.Size = new System.Drawing.Size(113, 130);
            this.groupBoxfilter.TabIndex = 9;
            this.groupBoxfilter.TabStop = false;
            this.groupBoxfilter.Text = "Filter";
            // 
            // buttoninput
            // 
            this.buttoninput.Location = new System.Drawing.Point(193, 151);
            this.buttoninput.Name = "buttoninput";
            this.buttoninput.Size = new System.Drawing.Size(95, 28);
            this.buttoninput.TabIndex = 10;
            this.buttoninput.Text = "input";
            this.buttoninput.UseVisualStyleBackColor = true;
            this.buttoninput.Click += new System.EventHandler(this.buttoninput_Click);
            // 
            // buttonpanah
            // 
            this.buttonpanah.Location = new System.Drawing.Point(292, 218);
            this.buttonpanah.Name = "buttonpanah";
            this.buttonpanah.Size = new System.Drawing.Size(75, 23);
            this.buttonpanah.TabIndex = 11;
            this.buttonpanah.Text = ">";
            this.buttonpanah.UseVisualStyleBackColor = true;
            this.buttonpanah.Click += new System.EventHandler(this.buttonpanah_Click);
            // 
            // buttonsilang
            // 
            this.buttonsilang.Location = new System.Drawing.Point(292, 248);
            this.buttonsilang.Name = "buttonsilang";
            this.buttonsilang.Size = new System.Drawing.Size(75, 23);
            this.buttonsilang.TabIndex = 12;
            this.buttonsilang.Text = "X";
            this.buttonsilang.UseVisualStyleBackColor = true;
            this.buttonsilang.Click += new System.EventHandler(this.buttonsilang_Click);
            // 
            // listBoxkiri
            // 
            this.listBoxkiri.FormattingEnabled = true;
            this.listBoxkiri.ItemHeight = 16;
            this.listBoxkiri.Items.AddRange(new object[] {
            "Mie Instan",
            "Telor",
            "Susu Sapi",
            "Kopi",
            "Roti ",
            "Keju",
            "Daging Giling",
            "Teh",
            "Bir"});
            this.listBoxkiri.Location = new System.Drawing.Point(58, 218);
            this.listBoxkiri.Name = "listBoxkiri";
            this.listBoxkiri.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxkiri.Size = new System.Drawing.Size(158, 212);
            this.listBoxkiri.TabIndex = 13;
            // 
            // listBoxkanan
            // 
            this.listBoxkanan.FormattingEnabled = true;
            this.listBoxkanan.ItemHeight = 16;
            this.listBoxkanan.Location = new System.Drawing.Point(444, 218);
            this.listBoxkanan.Name = "listBoxkanan";
            this.listBoxkanan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxkanan.Size = new System.Drawing.Size(158, 212);
            this.listBoxkanan.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxkanan);
            this.Controls.Add(this.listBoxkiri);
            this.Controls.Add(this.buttonsilang);
            this.Controls.Add(this.buttonpanah);
            this.Controls.Add(this.buttoninput);
            this.Controls.Add(this.groupBoxfilter);
            this.Controls.Add(this.groupBoxradiobutton);
            this.Controls.Add(this.textBoxnama);
            this.Controls.Add(this.labelkategori);
            this.Controls.Add(this.labelnamaitem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxradiobutton.ResumeLayout(false);
            this.groupBoxradiobutton.PerformLayout();
            this.groupBoxfilter.ResumeLayout(false);
            this.groupBoxfilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnamaitem;
        private System.Windows.Forms.Label labelkategori;
        private System.Windows.Forms.TextBox textBoxnama;
        private System.Windows.Forms.CheckBox checkBoxmakanan;
        private System.Windows.Forms.CheckBox checkBoxminuman;
        private System.Windows.Forms.RadioButton radioButtonmakanan;
        private System.Windows.Forms.RadioButton radioButtonminuman;
        private System.Windows.Forms.GroupBox groupBoxradiobutton;
        private System.Windows.Forms.GroupBox groupBoxfilter;
        private System.Windows.Forms.Button buttoninput;
        private System.Windows.Forms.Button buttonpanah;
        private System.Windows.Forms.Button buttonsilang;
        private System.Windows.Forms.ListBox listBoxkiri;
        private System.Windows.Forms.ListBox listBoxkanan;
    }
}

