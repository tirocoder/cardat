namespace CarDat_v0
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.listbox_cars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_formclose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_delcar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pb_previewpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewpic)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_cars
            // 
            this.listbox_cars.FormattingEnabled = true;
            this.listbox_cars.Location = new System.Drawing.Point(23, 40);
            this.listbox_cars.Name = "listbox_cars";
            this.listbox_cars.Size = new System.Drawing.Size(137, 238);
            this.listbox_cars.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listbox_cars, "Fahrzeug entfernen mit \'Entf\'");
            this.listbox_cars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_cars_MouseDoubleClick);
            this.listbox_cars.SelectedIndexChanged += new System.EventHandler(this.listbox_cars_SelectedIndexChanged);
            this.listbox_cars.DoubleClick += new System.EventHandler(this.listbox_cars_DoubleClick);
            this.listbox_cars.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listbox_cars_MouseMove);
            this.listbox_cars.MouseLeave += new System.EventHandler(this.listbox_cars_MouseLeave);
            this.listbox_cars.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listbox_cars_KeyUp);
            this.listbox_cars.Click += new System.EventHandler(this.listbox_cars_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vorschau:";
            // 
            // btn_formclose
            // 
            this.btn_formclose.Location = new System.Drawing.Point(267, 294);
            this.btn_formclose.Name = "btn_formclose";
            this.btn_formclose.Size = new System.Drawing.Size(214, 23);
            this.btn_formclose.TabIndex = 8;
            this.btn_formclose.Text = "zurück zum Hauptfenster";
            this.btn_formclose.UseVisualStyleBackColor = true;
            this.btn_formclose.Click += new System.EventHandler(this.btn_formclose_Click);
            // 
            // btn_delcar
            // 
            this.btn_delcar.Location = new System.Drawing.Point(23, 294);
            this.btn_delcar.Name = "btn_delcar";
            this.btn_delcar.Size = new System.Drawing.Size(137, 23);
            this.btn_delcar.TabIndex = 9;
            this.btn_delcar.Text = "Fahrzeug löschen";
            this.btn_delcar.UseVisualStyleBackColor = true;
            this.btn_delcar.Click += new System.EventHandler(this.btn_delcar_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(185, 277);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(296, 1);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(185, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 237);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(480, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 237);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(185, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 1);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pb_previewpic
            // 
            this.pb_previewpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_previewpic.Location = new System.Drawing.Point(185, 40);
            this.pb_previewpic.Name = "pb_previewpic";
            this.pb_previewpic.Size = new System.Drawing.Size(296, 237);
            this.pb_previewpic.TabIndex = 2;
            this.pb_previewpic.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 329);
            this.Controls.Add(this.btn_delcar);
            this.Controls.Add(this.btn_formclose);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_previewpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_cars);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 365);
            this.Name = "Form3";
            this.ShowInTaskbar = false;
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.DoubleClick += new System.EventHandler(this.Form3_DoubleClick);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_previewpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_cars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_previewpic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_formclose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_delcar;
    }
}