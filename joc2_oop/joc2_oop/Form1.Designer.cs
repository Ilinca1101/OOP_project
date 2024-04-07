namespace joc2_oop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jocNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurareJocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incepatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avansatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.jocToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "&Meniu";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // jocToolStripMenuItem
            // 
            this.jocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jocNouToolStripMenuItem,
            this.configurareJocToolStripMenuItem});
            this.jocToolStripMenuItem.Name = "jocToolStripMenuItem";
            this.jocToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.jocToolStripMenuItem.Text = "&Joc";
            // 
            // jocNouToolStripMenuItem
            // 
            this.jocNouToolStripMenuItem.Name = "jocNouToolStripMenuItem";
            this.jocNouToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.jocNouToolStripMenuItem.Text = "Joc nou";
            // 
            // configurareJocToolStripMenuItem
            // 
            this.configurareJocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incepatorToolStripMenuItem,
            this.mediuToolStripMenuItem,
            this.avansatToolStripMenuItem});
            this.configurareJocToolStripMenuItem.Name = "configurareJocToolStripMenuItem";
            this.configurareJocToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.configurareJocToolStripMenuItem.Text = "Configurare joc";
            // 
            // incepatorToolStripMenuItem
            // 
            this.incepatorToolStripMenuItem.Name = "incepatorToolStripMenuItem";
            this.incepatorToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.incepatorToolStripMenuItem.Text = "Incepator";
            // 
            // mediuToolStripMenuItem
            // 
            this.mediuToolStripMenuItem.Name = "mediuToolStripMenuItem";
            this.mediuToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.mediuToolStripMenuItem.Text = "Mediu";
            // 
            // avansatToolStripMenuItem
            // 
            this.avansatToolStripMenuItem.Name = "avansatToolStripMenuItem";
            this.avansatToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.avansatToolStripMenuItem.Text = "Avansat";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.exportToolStripMenuItem.Text = "&Export";
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.imprimareToolStripMenuItem.Text = "&Imprimare";
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(12, 93);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(1089, 858);
            this.p.TabIndex = 1;
            this.p.TabStop = false;
            this.p.Click += new System.EventHandler(this.p_Click);
            this.p.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1130, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 1055);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.p);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Joc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem meniuToolStripMenuItem;
        private ToolStripMenuItem despreToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private ToolStripMenuItem jocToolStripMenuItem;
        private ToolStripMenuItem jocNouToolStripMenuItem;
        private ToolStripMenuItem configurareJocToolStripMenuItem;
        private ToolStripMenuItem incepatorToolStripMenuItem;
        private ToolStripMenuItem mediuToolStripMenuItem;
        private ToolStripMenuItem avansatToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem imprimareToolStripMenuItem;
        private PictureBox p;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
    }
}