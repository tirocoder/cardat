namespace CarDat_v0
{
    partial class Form1
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
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolstripbutton_addcar = new System.Windows.Forms.ToolStripButton();
            this.toolstripbutton_showcars = new System.Windows.Forms.ToolStripButton();
            this.toolstripbutton_about = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_addcar = new System.Windows.Forms.ToolStripButton();
            this.tsb_listcars = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // panel_preview
            // 
            this.panel_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_preview.Location = new System.Drawing.Point(12, 90);
            this.panel_preview.Name = "panel_preview";
            this.panel_preview.Size = new System.Drawing.Size(887, 497);
            this.panel_preview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aktuelle Fahrzeuge:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolstripbutton_addcar
            // 
            this.toolstripbutton_addcar.Name = "toolstripbutton_addcar";
            this.toolstripbutton_addcar.Size = new System.Drawing.Size(23, 23);
            // 
            // toolstripbutton_showcars
            // 
            this.toolstripbutton_showcars.Name = "toolstripbutton_showcars";
            this.toolstripbutton_showcars.Size = new System.Drawing.Size(23, 23);
            // 
            // toolstripbutton_about
            // 
            this.toolstripbutton_about.Name = "toolstripbutton_about";
            this.toolstripbutton_about.Size = new System.Drawing.Size(23, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem1
            // 
            this.programmToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_exit});
            this.programmToolStripMenuItem1.Name = "programmToolStripMenuItem1";
            this.programmToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem1.Text = "Programm";
            // 
            // menu_item_exit
            // 
            this.menu_item_exit.Name = "menu_item_exit";
            this.menu_item_exit.Size = new System.Drawing.Size(120, 22);
            this.menu_item_exit.Text = "Beenden";
            this.menu_item_exit.Click += new System.EventHandler(this.menu_item_exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_addcar,
            this.tsb_listcars,
            this.tsb_help});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(914, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_addcar
            // 
            this.tsb_addcar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_addcar.Image = global::CarDat_v0.Properties.Resources.add_car_tool3;
            this.tsb_addcar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_addcar.Name = "tsb_addcar";
            this.tsb_addcar.Size = new System.Drawing.Size(28, 28);
            this.tsb_addcar.Text = "toolStripButton1";
            this.tsb_addcar.Click += new System.EventHandler(this.tsb_addcar_Click_1);
            // 
            // tsb_listcars
            // 
            this.tsb_listcars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_listcars.Image = global::CarDat_v0.Properties.Resources.list_car_tool;
            this.tsb_listcars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_listcars.Name = "tsb_listcars";
            this.tsb_listcars.Size = new System.Drawing.Size(28, 28);
            this.tsb_listcars.Text = "toolStripButton1";
            this.tsb_listcars.Click += new System.EventHandler(this.tsb_listcars_Click);
            // 
            // tsb_help
            // 
            this.tsb_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_help.Image = global::CarDat_v0.Properties.Resources.about_tool;
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(28, 28);
            this.tsb_help.Text = "toolStripButton1";
            this.tsb_help.Click += new System.EventHandler(this.tsb_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_preview);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(930, 635);
            this.MinimumSize = new System.Drawing.Size(930, 635);
            this.Name = "Form1";
            this.Text = "CarDat v0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolstripbutton_addcar;
        private System.Windows.Forms.ToolStripButton toolstripbutton_showcars;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.ToolStripButton toolstripbutton_about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_item_exit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_addcar;
        private System.Windows.Forms.ToolStripButton tsb_listcars;
        private System.Windows.Forms.ToolStripButton tsb_help;
    }
}

