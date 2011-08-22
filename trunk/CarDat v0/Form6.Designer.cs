namespace CarDat_v0
{
    partial class Form6
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
            this.btn_abort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_location = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_what = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_success = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(341, 208);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(99, 23);
            this.btn_abort.TabIndex = 32;
            this.btn_abort.Text = "zurück";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kosten der Reparatur";
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(127, 181);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.ReadOnly = true;
            this.tb_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_cost.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ort der Reparatur";
            // 
            // rtb_location
            // 
            this.rtb_location.Location = new System.Drawing.Point(127, 121);
            this.rtb_location.Name = "rtb_location";
            this.rtb_location.ReadOnly = true;
            this.rtb_location.Size = new System.Drawing.Size(313, 47);
            this.rtb_location.TabIndex = 25;
            this.rtb_location.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Reparatur erfolgreich?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Datum der Reparatur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "(kurze Beschreibung)";
            // 
            // rtb_what
            // 
            this.rtb_what.Location = new System.Drawing.Point(127, 38);
            this.rtb_what.Name = "rtb_what";
            this.rtb_what.ReadOnly = true;
            this.rtb_what.Size = new System.Drawing.Size(313, 77);
            this.rtb_what.TabIndex = 19;
            this.rtb_what.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Was wurde repariert?";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(127, 9);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(224, 20);
            this.tb_date.TabIndex = 33;
            // 
            // tb_success
            // 
            this.tb_success.Location = new System.Drawing.Point(401, 181);
            this.tb_success.Name = "tb_success";
            this.tb_success.ReadOnly = true;
            this.tb_success.Size = new System.Drawing.Size(39, 20);
            this.tb_success.TabIndex = 34;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 243);
            this.Controls.Add(this.tb_success);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_what);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.ShowInTaskbar = false;
            this.Text = "Reparatur";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_what;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_success;
    }
}