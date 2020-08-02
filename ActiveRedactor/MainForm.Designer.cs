namespace ActiveRedactor
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.деньгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.банкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сЕдИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стройМатериалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безИзмеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деньгиToolStripMenuItem,
            this.объектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // деньгиToolStripMenuItem
            // 
            this.деньгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.банкToolStripMenuItem,
            this.кассаToolStripMenuItem});
            this.деньгиToolStripMenuItem.Name = "деньгиToolStripMenuItem";
            this.деньгиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.деньгиToolStripMenuItem.Text = "Деньги";
            // 
            // банкToolStripMenuItem
            // 
            this.банкToolStripMenuItem.Name = "банкToolStripMenuItem";
            this.банкToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.банкToolStripMenuItem.Text = "Банк";
            this.банкToolStripMenuItem.Click += new System.EventHandler(this.BankToolStripMenuItem_Click);
            // 
            // кассаToolStripMenuItem
            // 
            this.кассаToolStripMenuItem.Name = "кассаToolStripMenuItem";
            this.кассаToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.кассаToolStripMenuItem.Text = "Касса";
            this.кассаToolStripMenuItem.Click += new System.EventHandler(this.CassaToolStripMenuItem_Click);
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сЕдИзмеренияToolStripMenuItem,
            this.безИзмеренияToolStripMenuItem});
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.объектыToolStripMenuItem.Text = "Объекты";
            // 
            // сЕдИзмеренияToolStripMenuItem
            // 
            this.сЕдИзмеренияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стройМатериалToolStripMenuItem});
            this.сЕдИзмеренияToolStripMenuItem.Name = "сЕдИзмеренияToolStripMenuItem";
            this.сЕдИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сЕдИзмеренияToolStripMenuItem.Text = "С ед. измерения";
            // 
            // стройМатериалToolStripMenuItem
            // 
            this.стройМатериалToolStripMenuItem.Name = "стройМатериалToolStripMenuItem";
            this.стройМатериалToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.стройМатериалToolStripMenuItem.Text = "Строй материал";
            this.стройМатериалToolStripMenuItem.Click += new System.EventHandler(this.MaterialToolStripMenuItem_Click);
            // 
            // безИзмеренияToolStripMenuItem
            // 
            this.безИзмеренияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зданияToolStripMenuItem});
            this.безИзмеренияToolStripMenuItem.Name = "безИзмеренияToolStripMenuItem";
            this.безИзмеренияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.безИзмеренияToolStripMenuItem.Text = "Без измерения";
            // 
            // зданияToolStripMenuItem
            // 
            this.зданияToolStripMenuItem.Name = "зданияToolStripMenuItem";
            this.зданияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зданияToolStripMenuItem.Text = "Здания";
            this.зданияToolStripMenuItem.Click += new System.EventHandler(this.BuildingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 640);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem деньгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem банкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кассаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сЕдИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безИзмеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стройМатериалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зданияToolStripMenuItem;
    }
}

