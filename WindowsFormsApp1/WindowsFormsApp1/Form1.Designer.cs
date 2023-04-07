namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лБ1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычисленияВыраженияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лБ2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лБ3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лБ4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лБ56ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лР7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лБ1ToolStripMenuItem,
            this.лБ2ToolStripMenuItem,
            this.лБ3ToolStripMenuItem,
            this.лБ4ToolStripMenuItem,
            this.лБ56ToolStripMenuItem,
            this.лР7ToolStripMenuItem});
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            // 
            // лБ1ToolStripMenuItem
            // 
            this.лБ1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычисленияToolStripMenuItem,
            this.вычисленияВыраженияToolStripMenuItem});
            this.лБ1ToolStripMenuItem.Name = "лБ1ToolStripMenuItem";
            this.лБ1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лБ1ToolStripMenuItem.Text = "ЛР1";
            // 
            // вычисленияToolStripMenuItem
            // 
            this.вычисленияToolStripMenuItem.Name = "вычисленияToolStripMenuItem";
            this.вычисленияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вычисленияToolStripMenuItem.Text = "a+b";
            this.вычисленияToolStripMenuItem.Click += new System.EventHandler(this.вычисленияToolStripMenuItem_Click);
            // 
            // вычисленияВыраженияToolStripMenuItem
            // 
            this.вычисленияВыраженияToolStripMenuItem.Name = "вычисленияВыраженияToolStripMenuItem";
            this.вычисленияВыраженияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вычисленияВыраженияToolStripMenuItem.Text = "Вычисления выражения";
            this.вычисленияВыраженияToolStripMenuItem.Click += new System.EventHandler(this.вычисленияВыраженияToolStripMenuItem_Click);
            // 
            // лБ2ToolStripMenuItem
            // 
            this.лБ2ToolStripMenuItem.Name = "лБ2ToolStripMenuItem";
            this.лБ2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лБ2ToolStripMenuItem.Text = "ЛР2";
            this.лБ2ToolStripMenuItem.Click += new System.EventHandler(this.лБ2ToolStripMenuItem_Click);
            // 
            // лБ3ToolStripMenuItem
            // 
            this.лБ3ToolStripMenuItem.Name = "лБ3ToolStripMenuItem";
            this.лБ3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лБ3ToolStripMenuItem.Text = "ЛР3";
            this.лБ3ToolStripMenuItem.Click += new System.EventHandler(this.лБ3ToolStripMenuItem_Click);
            // 
            // лБ4ToolStripMenuItem
            // 
            this.лБ4ToolStripMenuItem.Name = "лБ4ToolStripMenuItem";
            this.лБ4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лБ4ToolStripMenuItem.Text = "ЛР4";
            this.лБ4ToolStripMenuItem.Click += new System.EventHandler(this.лБ4ToolStripMenuItem_Click);
            // 
            // лБ56ToolStripMenuItem
            // 
            this.лБ56ToolStripMenuItem.Name = "лБ56ToolStripMenuItem";
            this.лБ56ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лБ56ToolStripMenuItem.Text = "ЛР5-6";
            this.лБ56ToolStripMenuItem.Click += new System.EventHandler(this.лБ56ToolStripMenuItem_Click);
            // 
            // лР7ToolStripMenuItem
            // 
            this.лР7ToolStripMenuItem.Name = "лР7ToolStripMenuItem";
            this.лР7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лР7ToolStripMenuItem.Text = "ЛР7";
            this.лР7ToolStripMenuItem.Click += new System.EventHandler(this.лР7ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лБ1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычисленияВыраженияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лБ2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лБ3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лБ4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лБ56ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лР7ToolStripMenuItem;
    }
}

