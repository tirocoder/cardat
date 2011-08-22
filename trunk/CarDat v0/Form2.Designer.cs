namespace CarDat_v0
{
    partial class Form2
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
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addcar = new System.Windows.Forms.Button();
            this.combobox_type1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addpreviewpic = new System.Windows.Forms.Button();
            this.ofd_previewpic = new System.Windows.Forms.OpenFileDialog();
            this.btn_formclose = new System.Windows.Forms.Button();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.tb_constr = new System.Windows.Forms.TextBox();
            this.tb_natcode = new System.Windows.Forms.TextBox();
            this.tb_type2 = new System.Windows.Forms.TextBox();
            this.tb_manu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_seats = new System.Windows.Forms.TextBox();
            this.tb_weight1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_weight2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_weight4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_weight3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.rtb_tiredims = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.combobox_month_firstcarreg = new System.Windows.Forms.ComboBox();
            this.tb_year_firstcarreg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(61, 269);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(47, 20);
            this.tb_year.TabIndex = 16;
            this.tb_year.Text = "0";
            this.tb_year.TextChanged += new System.EventHandler(this.tb_year_TextChanged);
            this.tb_year.Click += new System.EventHandler(this.tb_year_Click);
            // 
            // tb_power
            // 
            this.tb_power.Location = new System.Drawing.Point(439, 268);
            this.tb_power.Name = "tb_power";
            this.tb_power.Size = new System.Drawing.Size(45, 20);
            this.tb_power.TabIndex = 19;
            this.tb_power.Text = "0";
            this.tb_power.TextChanged += new System.EventHandler(this.tb_power_TextChanged);
            this.tb_power.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.tb_power_ChangeUICues);
            this.tb_power.Click += new System.EventHandler(this.tb_power_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baujahr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leistung";
            // 
            // btn_addcar
            // 
            this.btn_addcar.Location = new System.Drawing.Point(219, 12);
            this.btn_addcar.Name = "btn_addcar";
            this.btn_addcar.Size = new System.Drawing.Size(144, 22);
            this.btn_addcar.TabIndex = 2;
            this.btn_addcar.Text = "Fahrzeug hinzufügen";
            this.btn_addcar.UseVisualStyleBackColor = true;
            this.btn_addcar.Click += new System.EventHandler(this.btn_addcar_Click);
            // 
            // combobox_type1
            // 
            this.combobox_type1.FormattingEnabled = true;
            this.combobox_type1.Items.AddRange(new object[] {
            "KFZ",
            "LKW",
            "Motorrad",
            "andere..."});
            this.combobox_type1.Location = new System.Drawing.Point(83, 53);
            this.combobox_type1.Name = "combobox_type1";
            this.combobox_type1.Size = new System.Drawing.Size(100, 21);
            this.combobox_type1.TabIndex = 4;
            this.combobox_type1.Text = "KFZ";
            this.combobox_type1.Click += new System.EventHandler(this.combobox_type1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fahrzeugtyp";
            // 
            // btn_addpreviewpic
            // 
            this.btn_addpreviewpic.Location = new System.Drawing.Point(15, 12);
            this.btn_addpreviewpic.Name = "btn_addpreviewpic";
            this.btn_addpreviewpic.Size = new System.Drawing.Size(144, 22);
            this.btn_addpreviewpic.TabIndex = 1;
            this.btn_addpreviewpic.Text = "Bild hinzufügen";
            this.btn_addpreviewpic.UseVisualStyleBackColor = true;
            this.btn_addpreviewpic.Click += new System.EventHandler(this.btn_addpreviewpic_Click);
            // 
            // ofd_previewpic
            // 
            this.ofd_previewpic.FileName = "openFileDialog1";
            // 
            // btn_formclose
            // 
            this.btn_formclose.Location = new System.Drawing.Point(375, 12);
            this.btn_formclose.Name = "btn_formclose";
            this.btn_formclose.Size = new System.Drawing.Size(144, 22);
            this.btn_formclose.TabIndex = 3;
            this.btn_formclose.Text = "Fenster schließen";
            this.btn_formclose.UseVisualStyleBackColor = true;
            this.btn_formclose.Click += new System.EventHandler(this.btn_formclose_Click);
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(232, 106);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(100, 20);
            this.tb_color.TabIndex = 9;
            this.tb_color.Text = "Farbe eingeben";
            this.tb_color.TextChanged += new System.EventHandler(this.tb_color_TextChanged);
            this.tb_color.Click += new System.EventHandler(this.tb_color_Click);
            // 
            // tb_constr
            // 
            this.tb_constr.Location = new System.Drawing.Point(73, 106);
            this.tb_constr.Name = "tb_constr";
            this.tb_constr.Size = new System.Drawing.Size(110, 20);
            this.tb_constr.TabIndex = 8;
            this.tb_constr.Text = "Name eingeben";
            this.tb_constr.TextChanged += new System.EventHandler(this.tb_constr_TextChanged);
            this.tb_constr.Click += new System.EventHandler(this.tb_constr_Click);
            // 
            // tb_natcode
            // 
            this.tb_natcode.Location = new System.Drawing.Point(73, 80);
            this.tb_natcode.Name = "tb_natcode";
            this.tb_natcode.Size = new System.Drawing.Size(110, 20);
            this.tb_natcode.TabIndex = 7;
            this.tb_natcode.Text = "Code eingeben";
            this.tb_natcode.TextChanged += new System.EventHandler(this.tb_natcode_TextChanged);
            this.tb_natcode.Click += new System.EventHandler(this.tb_natcode_Click);
            // 
            // tb_type2
            // 
            this.tb_type2.Location = new System.Drawing.Point(413, 53);
            this.tb_type2.Name = "tb_type2";
            this.tb_type2.Size = new System.Drawing.Size(100, 20);
            this.tb_type2.TabIndex = 6;
            this.tb_type2.Text = "Bez. eingeben";
            this.tb_type2.TextChanged += new System.EventHandler(this.tb_type2_TextChanged);
            this.tb_type2.Click += new System.EventHandler(this.tb_type2_Click);
            // 
            // tb_manu
            // 
            this.tb_manu.Location = new System.Drawing.Point(232, 53);
            this.tb_manu.Name = "tb_manu";
            this.tb_manu.Size = new System.Drawing.Size(100, 20);
            this.tb_manu.TabIndex = 5;
            this.tb_manu.Text = "Marke eingeben";
            this.tb_manu.TextChanged += new System.EventHandler(this.tb_manu_TextChanged);
            this.tb_manu.Click += new System.EventHandler(this.tb_manu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aufbau";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nat. Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bezeichnung";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Marke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Eigengewicht";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Sitzplätze";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Farbe";
            // 
            // tb_seats
            // 
            this.tb_seats.Location = new System.Drawing.Point(396, 106);
            this.tb_seats.Name = "tb_seats";
            this.tb_seats.Size = new System.Drawing.Size(41, 20);
            this.tb_seats.TabIndex = 10;
            this.tb_seats.Text = "0";
            this.tb_seats.TextChanged += new System.EventHandler(this.tb_seats_TextChanged);
            this.tb_seats.Click += new System.EventHandler(this.tb_seats_Click);
            // 
            // tb_weight1
            // 
            this.tb_weight1.Location = new System.Drawing.Point(89, 132);
            this.tb_weight1.Name = "tb_weight1";
            this.tb_weight1.Size = new System.Drawing.Size(67, 20);
            this.tb_weight1.TabIndex = 11;
            this.tb_weight1.Text = "0";
            this.tb_weight1.TextChanged += new System.EventHandler(this.tb_weight1_TextChanged);
            this.tb_weight1.Click += new System.EventHandler(this.tb_weight1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Rad/Reifen";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Anhängelast";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(189, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "Gesamtgewicht";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(162, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "kg";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(348, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "kg";
            // 
            // tb_weight2
            // 
            this.tb_weight2.Location = new System.Drawing.Point(275, 132);
            this.tb_weight2.Name = "tb_weight2";
            this.tb_weight2.Size = new System.Drawing.Size(67, 20);
            this.tb_weight2.TabIndex = 12;
            this.tb_weight2.Text = "0";
            this.tb_weight2.TextChanged += new System.EventHandler(this.tb_weight2_TextChanged);
            this.tb_weight2.Click += new System.EventHandler(this.tb_weight2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(348, 161);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "kg";
            // 
            // tb_weight4
            // 
            this.tb_weight4.Location = new System.Drawing.Point(275, 158);
            this.tb_weight4.Name = "tb_weight4";
            this.tb_weight4.Size = new System.Drawing.Size(67, 20);
            this.tb_weight4.TabIndex = 14;
            this.tb_weight4.Text = "0";
            this.tb_weight4.TextChanged += new System.EventHandler(this.tb_weight4_TextChanged);
            this.tb_weight4.Click += new System.EventHandler(this.tb_weight4_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(162, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(19, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "kg";
            // 
            // tb_weight3
            // 
            this.tb_weight3.Location = new System.Drawing.Point(100, 158);
            this.tb_weight3.Name = "tb_weight3";
            this.tb_weight3.Size = new System.Drawing.Size(56, 20);
            this.tb_weight3.TabIndex = 13;
            this.tb_weight3.Text = "0";
            this.tb_weight3.TextChanged += new System.EventHandler(this.tb_weight3_TextChanged);
            this.tb_weight3.Click += new System.EventHandler(this.tb_weight3_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 161);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Stütz-/Sattellast";
            // 
            // rtb_tiredims
            // 
            this.rtb_tiredims.Location = new System.Drawing.Point(83, 200);
            this.rtb_tiredims.Name = "rtb_tiredims";
            this.rtb_tiredims.Size = new System.Drawing.Size(430, 51);
            this.rtb_tiredims.TabIndex = 15;
            this.rtb_tiredims.Text = "-";
            this.rtb_tiredims.TextChanged += new System.EventHandler(this.rtb_tiredims_TextChanged);
            this.rtb_tiredims.Click += new System.EventHandler(this.rtb_tiredims_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Dimensionen";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(490, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "PS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Erstzulassung";
            // 
            // combobox_month_firstcarreg
            // 
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
            this.combobox_month_firstcarreg.Location = new System.Drawing.Point(192, 268);
            this.combobox_month_firstcarreg.Name = "combobox_month_firstcarreg";
            this.combobox_month_firstcarreg.Size = new System.Drawing.Size(42, 21);
            this.combobox_month_firstcarreg.TabIndex = 17;
            this.combobox_month_firstcarreg.Text = "Jan.";
            // 
            // tb_year_firstcarreg
            // 
            this.tb_year_firstcarreg.Location = new System.Drawing.Point(244, 269);
            this.tb_year_firstcarreg.Name = "tb_year_firstcarreg";
            this.tb_year_firstcarreg.Size = new System.Drawing.Size(51, 20);
            this.tb_year_firstcarreg.TabIndex = 18;
            this.tb_year_firstcarreg.Text = "2011";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 304);
            this.Controls.Add(this.tb_year_firstcarreg);
            this.Controls.Add(this.combobox_month_firstcarreg);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_manu);
            this.Controls.Add(this.tb_type2);
            this.Controls.Add(this.tb_natcode);
            this.Controls.Add(this.tb_constr);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.btn_formclose);
            this.Controls.Add(this.btn_addpreviewpic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combobox_type1);
            this.Controls.Add(this.btn_addcar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_power);
            this.Controls.Add(this.tb_year);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 330);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Fahrzeug hinzufügen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addcar;
        private System.Windows.Forms.ComboBox combobox_type1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Button btn_addpreviewpic;
        private System.Windows.Forms.OpenFileDialog ofd_previewpic;
        private System.Windows.Forms.Button btn_formclose;
        public System.Windows.Forms.TextBox tb_color;
        public System.Windows.Forms.TextBox tb_constr;
        public System.Windows.Forms.TextBox tb_natcode;
        public System.Windows.Forms.TextBox tb_type2;
        public System.Windows.Forms.TextBox tb_manu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tb_seats;
        public System.Windows.Forms.TextBox tb_weight1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tb_weight2;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox tb_weight4;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox tb_weight3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox rtb_tiredims;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combobox_month_firstcarreg;
        private System.Windows.Forms.TextBox tb_year_firstcarreg;
    }
}