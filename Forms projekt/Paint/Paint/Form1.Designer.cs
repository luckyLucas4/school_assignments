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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbx_layer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_drawArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_layer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_drawArea
            // 
            this.pbx_drawArea.BackColor = System.Drawing.Color.White;
            this.pbx_drawArea.Location = new System.Drawing.Point(172, 32);
            this.pbx_drawArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_drawArea.Name = "pbx_drawArea";
            this.pbx_drawArea.Size = new System.Drawing.Size(394, 419);
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
            this.groupBox1.Location = new System.Drawing.Point(22, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(86, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brush";
            // 
            // cb_color
            // 
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(16, 65);
            this.cb_color.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(54, 21);
            this.cb_color.TabIndex = 3;
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(16, 26);
            this.cb_size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(53, 21);
            this.cb_size.TabIndex = 2;
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Checked = true;
            this.rb_line.Location = new System.Drawing.Point(22, 63);
            this.rb_line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(45, 17);
            this.rb_line.TabIndex = 2;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "Line";
            this.rb_line.UseVisualStyleBackColor = true;
            // 
            // rb_rectangle
            // 
            this.rb_rectangle.AutoSize = true;
            this.rb_rectangle.Location = new System.Drawing.Point(22, 85);
            this.rb_rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_rectangle.Name = "rb_rectangle";
            this.rb_rectangle.Size = new System.Drawing.Size(74, 17);
            this.rb_rectangle.TabIndex = 3;
            this.rb_rectangle.TabStop = true;
            this.rb_rectangle.Text = "Rectangle";
            this.rb_rectangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(22, 107);
            this.Circle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(51, 17);
            this.Circle.TabIndex = 4;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // rb_free
            // 
            this.rb_free.AutoSize = true;
            this.rb_free.Location = new System.Drawing.Point(22, 129);
            this.rb_free.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(70, 17);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "Image";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openImageToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save as...";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(314, 85);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(276, 168);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 41);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pbx_layer
            // 
            this.pbx_layer.Location = new System.Drawing.Point(170, 31);
            this.pbx_layer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbx_layer.Name = "pbx_layer";
            this.pbx_layer.Size = new System.Drawing.Size(403, 431);
            this.pbx_layer.TabIndex = 9;
            this.pbx_layer.TabStop = false;
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(583, 472);
            this.Controls.Add(this.pbx_layer);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rb_free);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.rb_rectangle);
            this.Controls.Add(this.rb_line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbx_drawArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_drawArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_layer)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbx_layer;
    }
}

