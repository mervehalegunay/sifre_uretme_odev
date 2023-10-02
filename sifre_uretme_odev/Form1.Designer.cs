namespace sifre_uretme_odev
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
            chcBoxKucukHarf = new CheckBox();
            chcBoxBuyukHarf = new CheckBox();
            chcBoxRakam = new CheckBox();
            chcBoxOzelKarakter = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnUret = new Button();
            txtSifre = new TextBox();
            numSifreSayisi = new NumericUpDown();
            numSifreUzunlugu = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSifreSayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSifreUzunlugu).BeginInit();
            SuspendLayout();
            // 
            // chcBoxKucukHarf
            // 
            chcBoxKucukHarf.AutoSize = true;
            chcBoxKucukHarf.Location = new Point(39, 44);
            chcBoxKucukHarf.Name = "chcBoxKucukHarf";
            chcBoxKucukHarf.Size = new Size(103, 24);
            chcBoxKucukHarf.TabIndex = 0;
            chcBoxKucukHarf.Text = "Küçük Harf";
            chcBoxKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chcBoxBuyukHarf
            // 
            chcBoxBuyukHarf.AutoSize = true;
            chcBoxBuyukHarf.Location = new Point(39, 93);
            chcBoxBuyukHarf.Name = "chcBoxBuyukHarf";
            chcBoxBuyukHarf.Size = new Size(103, 24);
            chcBoxBuyukHarf.TabIndex = 1;
            chcBoxBuyukHarf.Text = "Büyük Harf";
            chcBoxBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chcBoxRakam
            // 
            chcBoxRakam.AutoSize = true;
            chcBoxRakam.Location = new Point(39, 143);
            chcBoxRakam.Name = "chcBoxRakam";
            chcBoxRakam.Size = new Size(76, 24);
            chcBoxRakam.TabIndex = 3;
            chcBoxRakam.Text = "Rakam";
            chcBoxRakam.UseVisualStyleBackColor = true;
            // 
            // chcBoxOzelKarakter
            // 
            chcBoxOzelKarakter.AutoSize = true;
            chcBoxOzelKarakter.Location = new Point(39, 193);
            chcBoxOzelKarakter.Name = "chcBoxOzelKarakter";
            chcBoxOzelKarakter.Size = new Size(120, 24);
            chcBoxOzelKarakter.TabIndex = 2;
            chcBoxOzelKarakter.Text = "Özel Karakter";
            chcBoxOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 4;
            label1.Text = "PARAMETRELER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 276);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Şifre Sayısı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 355);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 6;
            label3.Text = "Şifre Uzunluğu :";
            // 
            // btnUret
            // 
            btnUret.BackColor = SystemColors.ActiveBorder;
            btnUret.Location = new Point(298, 405);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(94, 29);
            btnUret.TabIndex = 10;
            btnUret.Text = "ÜRET";
            btnUret.UseVisualStyleBackColor = false;
            btnUret.Click += btnUret_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(411, 44);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(290, 267);
            txtSifre.TabIndex = 11;
            // 
            // numSifreSayisi
            // 
            numSifreSayisi.Location = new Point(170, 274);
            numSifreSayisi.Name = "numSifreSayisi";
            numSifreSayisi.Size = new Size(150, 27);
            numSifreSayisi.TabIndex = 12;
            // 
            // numSifreUzunlugu
            // 
            numSifreUzunlugu.Location = new Point(170, 353);
            numSifreUzunlugu.Name = "numSifreUzunlugu";
            numSifreUzunlugu.Size = new Size(150, 27);
            numSifreUzunlugu.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numSifreUzunlugu);
            Controls.Add(numSifreSayisi);
            Controls.Add(txtSifre);
            Controls.Add(btnUret);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chcBoxRakam);
            Controls.Add(chcBoxOzelKarakter);
            Controls.Add(chcBoxBuyukHarf);
            Controls.Add(chcBoxKucukHarf);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSifreSayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSifreUzunlugu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chcBoxKucukHarf;
        private CheckBox chcBoxBuyukHarf;
        private CheckBox chcBoxRakam;
        private CheckBox chcBoxOzelKarakter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUret;
        private TextBox txtSifre;
        private NumericUpDown numSifreSayisi;
        private NumericUpDown numSifreUzunlugu;
    }
}