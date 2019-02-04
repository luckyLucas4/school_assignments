namespace Paint
{
    partial class MyPaint
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
            this.pbx_drawArea = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.rb_rectangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.rb_free = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_drawArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_drawArea
            // 
            this.pbx_drawArea.BackColor = System.Drawing.Color.White;
            this.pbx_drawArea.Location = new System.Drawing.Point(229, 39);
            this.pbx_drawArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbx_drawArea.Name = "pbx_drawArea";
            this.pbx_drawArea.Size = new System.Drawing.Size(525, 516);
            this.pbx_drawArea.TabIndex = 0;
            this.pbx_drawArea.TabStop = false;
            this.pbx_drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_drawArea_Paint);
            this.pbx_drawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pbx_drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbx_drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pbx_drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_color);
            this.groupBox1.Controls.Add(this.cb_size);
            this.groupBox1.Location = new System.Drawing.Point(29, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(115, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brush";
            // 
            // cb_color
            // 
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(21, 80);
            this.cb_color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(71, 24);
            this.cb_color.TabIndex = 3;
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(21, 32);
            this.cb_size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(69, 24);
            this.cb_size.TabIndex = 2;
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Checked = true;
            this.rb_line.Location = new System.Drawing.Point(29, 78);
            this.rb_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(56, 21);
            this.rb_line.TabIndex = 2;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "Line";
            this.rb_line.UseVisualStyleBackColor = true;
            // 
            // rb_rectangle
            // 
            this.rb_rectangle.AutoSize = true;
            this.rb_rectangle.Location = new System.Drawing.Point(29, 105);
            this.rb_rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_rectangle.Name = "rb_rectangle";
            this.rb_rectangle.Size = new System.Drawing.Size(93, 21);
            this.rb_rectangle.TabIndex = 3;
            this.rb_rectangle.TabStop = true;
            this.rb_rectangle.Text = "Rectangle";
            this.rb_rectangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(29, 132);
            this.Circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(64, 21);
            this.Circle.TabIndex = 4;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // rb_free
            // 
            this.rb_free.AutoSize = true;
            this.rb_free.Location = new System.Drawing.Point(29, 159);
            this.rb_free.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(90, 21);
            this.rb_free.TabIndex = 5;
            this.rb_free.TabStop = true;
            this.rb_free.Text = "Freehand";
            this.rb_free.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(777, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.fileToolStripMenuItem.Text = "Image";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.openImageToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save as...";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(777, 581);
            this.Controls.Add(this.rb_free);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.rb_rectangle);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbx_drawArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_drawArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_drawArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.RadioButton rb_line;
        private System.Windows.Forms.RadioButton rb_rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton rb_free;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

