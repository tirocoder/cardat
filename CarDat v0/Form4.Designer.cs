namespace CarDat_v0
{
    partial class Form4
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.btn_modifycar = new System.Windows.Forms.Button();
            this.btn_closeform = new System.Windows.Forms.Button();
            this.btn_changepic = new System.Windows.Forms.Button();
            this.ofd_newpic = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_tiredims = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_weight3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_weight4 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_weight2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_weight1 = new System.Windows.Forms.TextBox();
            this.tb_seats = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_manu = new System.Windows.Forms.TextBox();
            this.tb_type2 = new System.Windows.Forms.TextBox();
            this.tb_natcode = new System.Windows.Forms.TextBox();
            this.tb_constr = new System.Windows.Forms.TextBox();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.combobox_type1 = new System.Windows.Forms.ComboBox();
            this.tb_year_firstcarreg = new System.Windows.Forms.TextBox();
            this.combobox_month_firstcarreg = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_power = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.combobox_action = new System.Windows.Forms.ComboBox();
            this.btn_action = new System.Windows.Forms.Button();
            this.lb_repairs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_previewpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vorschau:";
            // 
            // btn_modifycar
            // 
            this.btn_modifycar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_modifycar.Location = new System.Drawing.Point(14, 36);
            this.btn_modifycar.Name = "btn_modifycar";
            this.btn_modifycar.Size = new System.Drawing.Size(141, 23);
            this.btn_modifycar.TabIndex = 28;
            this.btn_modifycar.Text = "Fahrzeug bearbeiten";
            this.btn_modifycar.UseVisualStyleBackColor = false;
            this.btn_modifycar.Click += new System.EventHandler(this.btn_modifycar_Click);
            // 
            // btn_closeform
            // 
            this.btn_closeform.BackColor = System.Drawing.SystemColors.Control;
            this.btn_closeform.Location = new System.Drawing.Point(714, 4);
            this.btn_closeform.Name = "btn_closeform";
            this.btn_closeform.Size = new System.Drawing.Size(141, 23);
            this.btn_closeform.TabIndex = 29;
            this.btn_closeform.Text = "Fenster schliessen";
            this.btn_closeform.UseVisualStyleBackColor = false;
            this.btn_closeform.Visible = false;
            this.btn_closeform.Click += new System.EventHandler(this.btn_closeform_Click);
            // 
            // btn_changepic
            // 
            this.btn_changepic.BackColor = System.Drawing.SystemColors.Control;
            this.btn_changepic.Location = new System.Drawing.Point(559, 277);
            this.btn_changepic.Name = "btn_changepic";
            this.btn_changepic.Size = new System.Drawing.Size(296, 23);
            this.btn_changepic.TabIndex = 30;
            this.btn_changepic.Text = "Bild ändern";
            this.btn_changepic.UseVisualStyleBackColor = false;
            this.btn_changepic.Visible = false;
            this.btn_changepic.Click += new System.EventHandler(this.btn_changepic_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Dimensionen";
            // 
            // rtb_tiredims
            // 
            this.rtb_tiredims.Location = new System.Drawing.Point(82, 227);
            this.rtb_tiredims.Name = "rtb_tiredims";
            this.rtb_tiredims.ReadOnly = true;
            this.rtb_tiredims.Size = new System.Drawing.Size(430, 51);
            this.rtb_tiredims.TabIndex = 70;
            this.rtb_tiredims.Text = "-";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 188);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 69;
            this.label23.Text = "Stütz-/Sattellast";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(161, 188);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 68;
            this.label22.Text = "kg";
            // 
            // tb_weight3
            // 
            this.tb_weight3.Location = new System.Drawing.Point(99, 185);
            this.tb_weight3.Name = "tb_weight3";
            this.tb_weight3.ReadOnly = true;
            this.tb_weight3.Size = new System.Drawing.Size(56, 20);
            this.tb_weight3.TabIndex = 67;
            this.tb_weight3.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(347, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "kg";
            // 
            // tb_weight4
            // 
            this.tb_weight4.Location = new System.Drawing.Point(274, 185);
            this.tb_weight4.Name = "tb_weight4";
            this.tb_weight4.ReadOnly = true;
            this.tb_weight4.Size = new System.Drawing.Size(67, 20);
            this.tb_weight4.TabIndex = 65;
            this.tb_weight4.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(347, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 64;
            this.label20.Text = "kg";
            // 
            // tb_weight2
            // 
            this.tb_weight2.Location = new System.Drawing.Point(274, 159);
            this.tb_weight2.Name = "tb_weight2";
            this.tb_weight2.ReadOnly = true;
            this.tb_weight2.Size = new System.Drawing.Size(67, 20);
            this.tb_weight2.TabIndex = 63;
            this.tb_weight2.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(161, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "kg";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(188, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Gesamtgewicht";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(188, 188);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Anhängelast";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 59;
            this.label16.Text = "Rad/Reifen";
            // 
            // tb_weight1
            // 
            this.tb_weight1.Location = new System.Drawing.Point(88, 159);
            this.tb_weight1.Name = "tb_weight1";
            this.tb_weight1.ReadOnly = true;
            this.tb_weight1.Size = new System.Drawing.Size(67, 20);
            this.tb_weight1.TabIndex = 58;
            this.tb_weight1.Text = "0";
            // 
            // tb_seats
            // 
            this.tb_seats.Location = new System.Drawing.Point(395, 133);
            this.tb_seats.Name = "tb_seats";
            this.tb_seats.ReadOnly = true;
            this.tb_seats.Size = new System.Drawing.Size(41, 20);
            this.tb_seats.TabIndex = 57;
            this.tb_seats.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Farbe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Sitzplätze";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Eigengewicht";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Marke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Bezeichnung";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Nat. Code";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Aufbau";
            // 
            // tb_manu
            // 
            this.tb_manu.Location = new System.Drawing.Point(231, 80);
            this.tb_manu.Name = "tb_manu";
            this.tb_manu.ReadOnly = true;
            this.tb_manu.Size = new System.Drawing.Size(100, 20);
            this.tb_manu.TabIndex = 49;
            this.tb_manu.Text = "Marke eingeben";
            // 
            // tb_type2
            // 
            this.tb_type2.Location = new System.Drawing.Point(412, 80);
            this.tb_type2.Name = "tb_type2";
            this.tb_type2.ReadOnly = true;
            this.tb_type2.Size = new System.Drawing.Size(100, 20);
            this.tb_type2.TabIndex = 48;
            this.tb_type2.Text = "Bez. eingeben";
            // 
            // tb_natcode
            // 
            this.tb_natcode.Location = new System.Drawing.Point(72, 107);
            this.tb_natcode.Name = "tb_natcode";
            this.tb_natcode.ReadOnly = true;
            this.tb_natcode.Size = new System.Drawing.Size(110, 20);
            this.tb_natcode.TabIndex = 47;
            this.tb_natcode.Text = "Code eingeben";
            // 
            // tb_constr
            // 
            this.tb_constr.Location = new System.Drawing.Point(72, 133);
            this.tb_constr.Name = "tb_constr";
            this.tb_constr.ReadOnly = true;
            this.tb_constr.Size = new System.Drawing.Size(110, 20);
            this.tb_constr.TabIndex = 46;
            this.tb_constr.Text = "Name eingeben";
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(231, 133);
            this.tb_color.Name = "tb_color";
            this.tb_color.ReadOnly = true;
            this.tb_color.Size = new System.Drawing.Size(100, 20);
            this.tb_color.TabIndex = 45;
            this.tb_color.Text = "Farbe eingeben";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "Fahrzeugtyp";
            // 
            // combobox_type1
            // 
            this.combobox_type1.Enabled = false;
            this.combobox_type1.FormattingEnabled = true;
            this.combobox_type1.Items.AddRange(new object[] {
            "KFZ",
            "LKW",
            "Motorrad",
            "andere..."});
            this.combobox_type1.Location = new System.Drawing.Point(82, 80);
            this.combobox_type1.Name = "combobox_type1";
            this.combobox_type1.Size = new System.Drawing.Size(100, 21);
            this.combobox_type1.TabIndex = 43;
            this.combobox_type1.Text = "KFZ";
            // 
            // tb_year_firstcarreg
            // 
            this.tb_year_firstcarreg.Location = new System.Drawing.Point(243, 298);
            this.tb_year_firstcarreg.Name = "tb_year_firstcarreg";
            this.tb_year_firstcarreg.ReadOnly = true;
            this.tb_year_firstcarreg.Size = new System.Drawing.Size(51, 20);
            this.tb_year_firstcarreg.TabIndex = 79;
            this.tb_year_firstcarreg.Text = "2011";
            // 
            // combobox_month_firstcarreg
            // 
            this.combobox_month_firstcarreg.Enabled = false;
            this.combobox_month_firstcarreg.FormattingEnabled = true;
            this.combobox_month_firstcarreg.Items.AddRange(new object[] {
            "Jan.",
            "Feb.",
            "Mar.",
            "Apr.",
            "Mai",
            "Jun.",
            "Jul.",
            "Aug.",
            "Sep.",
            "Okt.",
            "Nov.",
            "Dez."});
            this.combobox_month_firstcarreg.Location = new System.Drawing.Point(191, 297);
            this.combobox_month_firstcarreg.Name = "combobox_month_firstcarreg";
            this.combobox_month_firstcarreg.Size = new System.Drawing.Size(42, 21);
            this.combobox_month_firstcarreg.TabIndex = 78;
            this.combobox_month_firstcarreg.Text = "Jan.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(115, 301);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 77;
            this.label25.Text = "Erstzulassung";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(489, 301);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(21, 13);
            this.label26.TabIndex = 76;
            this.label26.Text = "PS";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(389, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 74;
            this.label27.Text = "Leistung";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(11, 301);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 72;
            this.label28.Text = "Baujahr";
            // 
            // tb_power
            // 
            this.tb_power.Location = new System.Drawing.Point(438, 297);
            this.tb_power.Name = "tb_power";
            this.tb_power.ReadOnly = true;
            this.tb_power.Size = new System.Drawing.Size(45, 20);
            this.tb_power.TabIndex = 75;
            this.tb_power.Text = "0";
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(60, 298);
            this.tb_year.Name = "tb_year";
            this.tb_year.ReadOnly = true;
            this.tb_year.Size = new System.Drawing.Size(47, 20);
            this.tb_year.TabIndex = 73;
            this.tb_year.Text = "0";
            // 
            // combobox_action
            // 
            this.combobox_action.FormattingEnabled = true;
            this.combobox_action.Items.AddRange(new object[] {
            "AddRepair",
            "AddFueling"});
            this.combobox_action.Location = new System.Drawing.Point(14, 9);
            this.combobox_action.Name = "combobox_action";
            this.combobox_action.Size = new System.Drawing.Size(154, 21);
            this.combobox_action.TabIndex = 81;
            this.combobox_action.Text = "AddRepair";
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.SystemColors.Control;
            this.btn_action.Location = new System.Drawing.Point(174, 7);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(41, 23);
            this.btn_action.TabIndex = 82;
            this.btn_action.Text = "Go";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // lb_repairs
            // 
            this.lb_repairs.FormattingEnabled = true;
            this.lb_repairs.Location = new System.Drawing.Point(14, 356);
            this.lb_repairs.Name = "lb_repairs";
            this.lb_repairs.Size = new System.Drawing.Size(120, 95);
            this.lb_repairs.TabIndex = 85;
            this.lb_repairs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_repairs_MouseDoubleClick);
            this.lb_repairs.DoubleClick += new System.EventHandler(this.lb_repairs_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Reparaturen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(14, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 3);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(559, 270);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(296, 1);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(559, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 237);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(854, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 237);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(559, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 1);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pb_previewpic
            // 
            this.pb_previewpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_previewpic.Location = new System.Drawing.Point(559, 33);
            this.pb_previewpic.Name = "pb_previewpic";
            this.pb_previewpic.Size = new System.Drawing.Size(296, 237);
            this.pb_previewpic.TabIndex = 22;
            this.pb_previewpic.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_repairs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.combobox_action);
            this.Controls.Add(this.tb_year_firstcarreg);
            this.Controls.Add(this.combobox_month_firstcarreg);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tb_power);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtb_tiredims);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tb_weight3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_weight4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_weight2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_weight1);
            this.Controls.Add(this.tb_seats);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_manu);
            this.Controls.Add(this.tb_type2);
            this.Controls.Add(this.tb_natcode);
            this.Controls.Add(this.tb_constr);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.combobox_type1);
            this.Controls.Add(this.btn_changepic);
            this.Controls.Add(this.btn_closeform);
            this.Controls.Add(this.btn_modifycar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_previewpic);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.ShowInTaskbar = false;
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_previewpic;
        private System.Windows.Forms.Button btn_modifycar;
        private System.Windows.Forms.Button btn_closeform;
        private System.Windows.Forms.Button btn_changepic;
        private System.Windows.Forms.OpenFileDialog ofd_newpic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb_tiredims;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox tb_weight3;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox tb_weight4;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tb_weight2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox tb_weight1;
        public System.Windows.Forms.TextBox tb_seats;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tb_manu;
        public System.Windows.Forms.TextBox tb_type2;
        public System.Windows.Forms.TextBox tb_natcode;
        public System.Windows.Forms.TextBox tb_constr;
        public System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox combobox_type1;
        private System.Windows.Forms.TextBox tb_year_firstcarreg;
        private System.Windows.Forms.ComboBox combobox_month_firstcarreg;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_power;
        public System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.ComboBox combobox_action;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListBox lb_repairs;
    }
}