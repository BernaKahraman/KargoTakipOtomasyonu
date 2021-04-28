
namespace kargo_takip_otomasyonu
{
    partial class FrmKargoEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKargoEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RchGAdres = new System.Windows.Forms.RichTextBox();
            this.MskGTarih = new System.Windows.Forms.MaskedTextBox();
            this.CmbGSehir = new System.Windows.Forms.ComboBox();
            this.MskGTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtGSoyadı = new System.Windows.Forms.TextBox();
            this.TxtGAdı = new System.Windows.Forms.TextBox();
            this.MskGTC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RchAAdres = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RchANot = new System.Windows.Forms.RichTextBox();
            this.CmbASehir = new System.Windows.Forms.ComboBox();
            this.MskATelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtASoyadi = new System.Windows.Forms.TextBox();
            this.TxtAAdi = new System.Windows.Forms.TextBox();
            this.MskATC = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbTeslimTuru = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtAgirlik = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MskKargoNo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.RchGAdres);
            this.groupBox1.Controls.Add(this.MskGTarih);
            this.groupBox1.Controls.Add(this.CmbGSehir);
            this.groupBox1.Controls.Add(this.MskGTelefon);
            this.groupBox1.Controls.Add(this.TxtGSoyadı);
            this.groupBox1.Controls.Add(this.TxtGAdı);
            this.groupBox1.Controls.Add(this.MskGTC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(387, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gönderen ";
            // 
            // RchGAdres
            // 
            this.RchGAdres.Location = new System.Drawing.Point(180, 331);
            this.RchGAdres.Name = "RchGAdres";
            this.RchGAdres.Size = new System.Drawing.Size(172, 151);
            this.RchGAdres.TabIndex = 7;
            this.RchGAdres.Text = "";
            // 
            // MskGTarih
            // 
            this.MskGTarih.Location = new System.Drawing.Point(180, 282);
            this.MskGTarih.Mask = "00/00/0000";
            this.MskGTarih.Name = "MskGTarih";
            this.MskGTarih.Size = new System.Drawing.Size(172, 29);
            this.MskGTarih.TabIndex = 6;
            this.MskGTarih.ValidatingType = typeof(System.DateTime);
            // 
            // CmbGSehir
            // 
            this.CmbGSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGSehir.FormattingEnabled = true;
            this.CmbGSehir.Items.AddRange(new object[] {
            "Bartın ",
            "Ankara",
            "Zonguldak",
            "İstanbul"});
            this.CmbGSehir.Location = new System.Drawing.Point(180, 232);
            this.CmbGSehir.Name = "CmbGSehir";
            this.CmbGSehir.Size = new System.Drawing.Size(172, 29);
            this.CmbGSehir.TabIndex = 5;
            // 
            // MskGTelefon
            // 
            this.MskGTelefon.Location = new System.Drawing.Point(179, 183);
            this.MskGTelefon.Mask = "(999) 000-0000";
            this.MskGTelefon.Name = "MskGTelefon";
            this.MskGTelefon.Size = new System.Drawing.Size(173, 29);
            this.MskGTelefon.TabIndex = 4;
            // 
            // TxtGSoyadı
            // 
            this.TxtGSoyadı.Location = new System.Drawing.Point(180, 133);
            this.TxtGSoyadı.Name = "TxtGSoyadı";
            this.TxtGSoyadı.Size = new System.Drawing.Size(172, 29);
            this.TxtGSoyadı.TabIndex = 3;
            // 
            // TxtGAdı
            // 
            this.TxtGAdı.Location = new System.Drawing.Point(180, 84);
            this.TxtGAdı.Name = "TxtGAdı";
            this.TxtGAdı.Size = new System.Drawing.Size(172, 29);
            this.TxtGAdı.TabIndex = 2;
            // 
            // MskGTC
            // 
            this.MskGTC.Location = new System.Drawing.Point(179, 39);
            this.MskGTC.Mask = "00000000000";
            this.MskGTC.Name = "MskGTC";
            this.MskGTC.Size = new System.Drawing.Size(173, 29);
            this.MskGTC.TabIndex = 1;
            this.MskGTC.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gönderen Şehir :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox2.Controls.Add(this.RchAAdres);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.RchANot);
            this.groupBox2.Controls.Add(this.CmbASehir);
            this.groupBox2.Controls.Add(this.MskATelefon);
            this.groupBox2.Controls.Add(this.TxtASoyadi);
            this.groupBox2.Controls.Add(this.TxtAAdi);
            this.groupBox2.Controls.Add(this.MskATC);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(417, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 505);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alıcı ";
            // 
            // RchAAdres
            // 
            this.RchAAdres.Location = new System.Drawing.Point(130, 282);
            this.RchAAdres.Name = "RchAAdres";
            this.RchAAdres.Size = new System.Drawing.Size(172, 104);
            this.RchAAdres.TabIndex = 22;
            this.RchAAdres.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Adres :";
            // 
            // RchANot
            // 
            this.RchANot.Location = new System.Drawing.Point(130, 406);
            this.RchANot.Name = "RchANot";
            this.RchANot.Size = new System.Drawing.Size(172, 53);
            this.RchANot.TabIndex = 14;
            this.RchANot.Text = "";
            // 
            // CmbASehir
            // 
            this.CmbASehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbASehir.FormattingEnabled = true;
            this.CmbASehir.Items.AddRange(new object[] {
            "Bartın ",
            "Ankara",
            "Zonguldak",
            "İstanbul"});
            this.CmbASehir.Location = new System.Drawing.Point(130, 232);
            this.CmbASehir.Name = "CmbASehir";
            this.CmbASehir.Size = new System.Drawing.Size(172, 29);
            this.CmbASehir.TabIndex = 12;
            // 
            // MskATelefon
            // 
            this.MskATelefon.Location = new System.Drawing.Point(129, 183);
            this.MskATelefon.Mask = "(999) 000-0000";
            this.MskATelefon.Name = "MskATelefon";
            this.MskATelefon.Size = new System.Drawing.Size(173, 29);
            this.MskATelefon.TabIndex = 11;
            // 
            // TxtASoyadi
            // 
            this.TxtASoyadi.Location = new System.Drawing.Point(130, 133);
            this.TxtASoyadi.Name = "TxtASoyadi";
            this.TxtASoyadi.Size = new System.Drawing.Size(172, 29);
            this.TxtASoyadi.TabIndex = 10;
            // 
            // TxtAAdi
            // 
            this.TxtAAdi.Location = new System.Drawing.Point(130, 84);
            this.TxtAAdi.Name = "TxtAAdi";
            this.TxtAAdi.Size = new System.Drawing.Size(172, 29);
            this.TxtAAdi.TabIndex = 9;
            // 
            // MskATC
            // 
            this.MskATC.Location = new System.Drawing.Point(129, 39);
            this.MskATC.Mask = "00000000000";
            this.MskATC.Name = "MskATC";
            this.MskATC.Size = new System.Drawing.Size(173, 29);
            this.MskATC.TabIndex = 8;
            this.MskATC.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Not :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Alıcı Şehir :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Telefon :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Soyadı :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Adı :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "TC No :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.CmbTeslimTuru);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.TxtAgirlik);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.TxtAdet);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.CmbUrun);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.MskKargoNo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(793, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 505);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kargonun ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(305, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 21);
            this.label20.TabIndex = 35;
            this.label20.Text = "KG";
            // 
            // CmbTeslimTuru
            // 
            this.CmbTeslimTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTeslimTuru.FormattingEnabled = true;
            this.CmbTeslimTuru.Items.AddRange(new object[] {
            "Adrese Teslim",
            "Şubeye Teslim"});
            this.CmbTeslimTuru.Location = new System.Drawing.Point(131, 251);
            this.CmbTeslimTuru.Name = "CmbTeslimTuru";
            this.CmbTeslimTuru.Size = new System.Drawing.Size(172, 29);
            this.CmbTeslimTuru.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 21);
            this.label19.TabIndex = 32;
            this.label19.Text = "Teslim Türü :";
            // 
            // TxtAgirlik
            // 
            this.TxtAgirlik.Location = new System.Drawing.Point(132, 196);
            this.TxtAgirlik.Name = "TxtAgirlik";
            this.TxtAgirlik.Size = new System.Drawing.Size(172, 29);
            this.TxtAgirlik.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 21);
            this.label18.TabIndex = 30;
            this.label18.Text = "Ağırlık :";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Location = new System.Drawing.Point(132, 140);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(172, 29);
            this.TxtAdet.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 21);
            this.label17.TabIndex = 28;
            this.label17.Text = "Adet :";
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Items.AddRange(new object[] {
            "Koli",
            "Önemli Evrak",
            "Dosya",
            "Paket"});
            this.CmbUrun.Location = new System.Drawing.Point(132, 88);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(172, 29);
            this.CmbUrun.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 21);
            this.label16.TabIndex = 26;
            this.label16.Text = "Ürün :";
            // 
            // MskKargoNo
            // 
            this.MskKargoNo.Location = new System.Drawing.Point(131, 39);
            this.MskKargoNo.Mask = "00000000000";
            this.MskKargoNo.Name = "MskKargoNo";
            this.MskKargoNo.Size = new System.Drawing.Size(173, 29);
            this.MskKargoNo.TabIndex = 15;
            this.MskKargoNo.ValidatingType = typeof(int);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Kargo No :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "save.png");
            this.ımageList1.Images.SetKeyName(1, "trash.png");
            this.ımageList1.Images.SetKeyName(2, "plus.png");
            this.ımageList1.Images.SetKeyName(3, "plus (1).png");
            this.ımageList1.Images.SetKeyName(4, "refresh (1).png");
            this.ımageList1.Images.SetKeyName(5, "refresh.png");
            this.ımageList1.Images.SetKeyName(6, "logout.png");
            this.ımageList1.Images.SetKeyName(7, "calculator.png");
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "save.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(167, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = " Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "calculator.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(167, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 65);
            this.button2.TabIndex = 36;
            this.button2.Text = "Hesapla";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmKargoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1153, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmKargoEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Ekle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RchGAdres;
        private System.Windows.Forms.MaskedTextBox MskGTarih;
        private System.Windows.Forms.ComboBox CmbGSehir;
        private System.Windows.Forms.MaskedTextBox MskGTelefon;
        private System.Windows.Forms.TextBox TxtGSoyadı;
        private System.Windows.Forms.TextBox TxtGAdı;
        private System.Windows.Forms.MaskedTextBox MskGTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RchANot;
        private System.Windows.Forms.ComboBox CmbASehir;
        private System.Windows.Forms.MaskedTextBox MskATelefon;
        private System.Windows.Forms.TextBox TxtASoyadi;
        private System.Windows.Forms.TextBox TxtAAdi;
        private System.Windows.Forms.MaskedTextBox MskATC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CmbTeslimTuru;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtAgirlik;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox MskKargoNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RchAAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}