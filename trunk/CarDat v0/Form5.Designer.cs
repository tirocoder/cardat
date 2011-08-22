namespace CarDat_v0
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_what = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimepicker_repair = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_success = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_location = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_addrep = new System.Windows.Forms.Button();
            this.btn_addfiles = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Was wurde repariert?";
            // 
            // rtb_what
            // 
            this.rtb_what.Location = new System.Drawing.Point(126, 52);
            this.rtb_what.Name = "rtb_what";
            this.rtb_what.Size = new System.Drawing.Size(313, 77);
            this.rtb_what.TabIndex = 4;
            this.rtb_what.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(kurze Beschreibung)";
            // 
            // datetimepicker_repair
            // 
            this.datetimepicker_repair.Location = new System.Drawing.Point(126, 26);
            this.datetimepicker_repair.Name = "datetimepicker_repair";
            this.datetimepicker_repair.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker_repair.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum der Reparatur";
            // 
            // combobox_success
            // 
            this.combobox_success.FormattingEnabled = true;
            this.combobox_success.Items.AddRange(new object[] {
            "ja",
            "nein"});
            this.combobox_success.Location = new System.Drawing.Point(401, 195);
            this.combobox_success.Name = "combobox_success";
            this.combobox_success.Size = new System.Drawing.Size(38, 21);
            this.combobox_success.TabIndex = 8;
            this.combobox_success.Text = "ja";
            this.combobox_success.SelectedIndexChanged += new System.EventHandler(this.combobox_success_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reparatur erfolgreich?";
            // 
            // rtb_location
            // 
            this.rtb_location.Location = new System.Drawing.Point(126, 135);
            this.rtb_location.Name = "rtb_location";
            this.rtb_location.Size = new System.Drawing.Size(313, 47);
            this.rtb_location.TabIndex = 10;
            this.rtb_location.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ort der Reparatur";
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(126, 195);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_cost.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kosten der Reparatur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "€";
            // 
            // btn_addrep
            // 
            this.btn_addrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addrep.Location = new System.Drawing.Point(283, 238);
            this.btn_addrep.Name = "btn_addrep";
            this.btn_addrep.Size = new System.Drawing.Size(156, 23);
            this.btn_addrep.TabIndex = 15;
            this.btn_addrep.Text = "Reparatur einbuchen";
            this.btn_addrep.UseVisualStyleBackColor = true;
            this.btn_addrep.Click += new System.EventHandler(this.btn_addrep_Click);
            // 
            // btn_addfiles
            // 
            this.btn_addfiles.Location = new System.Drawing.Point(15, 238);
            this.btn_addfiles.Name = "btn_addfiles";
            this.btn_addfiles.Size = new System.Drawing.Size(156, 23);
            this.btn_addfiles.TabIndex = 16;
            this.btn_addfiles.Text = "Dateien anhängen";
            this.btn_addfiles.UseVisualStyleBackColor = true;
            this.btn_addfiles.Click += new System.EventHandler(this.btn_addfiles_Click);
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(178, 238);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(99, 23);
            this.btn_abort.TabIndex = 17;
            this.btn_abort.Text = "Abbrechen";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 273);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.btn_addfiles);
            this.Controls.Add(this.btn_addrep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobox_success);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetimepicker_repair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_what);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.ShowInTaskbar = false;
            this.Text = "Reparatur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_what;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepicker_repair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox_success;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_location;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_addrep;
        private System.Windows.Forms.Button btn_addfiles;
        private System.Windows.Forms.Button btn_abort;
    }
}