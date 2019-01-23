namespace Mediaregistret
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addBook = new System.Windows.Forms.TabPage();
            this.lbl_bookMissing = new System.Windows.Forms.Label();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.nr_nrPages = new System.Windows.Forms.NumericUpDown();
            this.lbl_nrPages = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.tb_bookTitle = new System.Windows.Forms.TextBox();
            this.lbl_bookTitle = new System.Windows.Forms.Label();
            this.addMovie = new System.Windows.Forms.TabPage();
            this.lbl_movMissing = new System.Windows.Forms.Label();
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.nr_length = new System.Windows.Forms.NumericUpDown();
            this.lbl_length = new System.Windows.Forms.Label();
            this.tb_director = new System.Windows.Forms.TextBox();
            this.lbl_director = new System.Windows.Forms.Label();
            this.tb_movTitle = new System.Windows.Forms.TextBox();
            this.lbl_movTitle = new System.Windows.Forms.Label();
            this.rtb_media = new System.Windows.Forms.RichTextBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.box_show = new System.Windows.Forms.GroupBox();
            this.rb_movies = new System.Windows.Forms.RadioButton();
            this.rb_books = new System.Windows.Forms.RadioButton();
            this.lbl_register = new System.Windows.Forms.Label();
            this.gb_remove = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.num_choice = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_nrPages)).BeginInit();
            this.addMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_length)).BeginInit();
            this.box_show.SuspendLayout();
            this.gb_remove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addBook);
            this.tabControl1.Controls.Add(this.addMovie);
            this.tabControl1.Location = new System.Drawing.Point(38, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // addBook
            // 
            this.addBook.Controls.Add(this.lbl_bookMissing);
            this.addBook.Controls.Add(this.btn_addBook);
            this.addBook.Controls.Add(this.nr_nrPages);
            this.addBook.Controls.Add(this.lbl_nrPages);
            this.addBook.Controls.Add(this.tb_author);
            this.addBook.Controls.Add(this.lbl_author);
            this.addBook.Controls.Add(this.tb_bookTitle);
            this.addBook.Controls.Add(this.lbl_bookTitle);
            this.addBook.Location = new System.Drawing.Point(4, 25);
            this.addBook.Name = "addBook";
            this.addBook.Padding = new System.Windows.Forms.Padding(3);
            this.addBook.Size = new System.Drawing.Size(393, 273);
            this.addBook.TabIndex = 0;
            this.addBook.Text = "Lägg till bok";
            this.addBook.UseVisualStyleBackColor = true;
            // 
            // lbl_bookMissing
            // 
            this.lbl_bookMissing.AutoSize = true;
            this.lbl_bookMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookMissing.Location = new System.Drawing.Point(140, 180);
            this.lbl_bookMissing.Name = "lbl_bookMissing";
            this.lbl_bookMissing.Size = new System.Drawing.Size(116, 17);
            this.lbl_bookMissing.TabIndex = 16;
            this.lbl_bookMissing.Text = "Värden saknas";
            this.lbl_bookMissing.Visible = false;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(260, 220);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(95, 27);
            this.btn_addBook.TabIndex = 13;
            this.btn_addBook.Text = "Lägg till bok";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // nr_nrPages
            // 
            this.nr_nrPages.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nr_nrPages.Location = new System.Drawing.Point(140, 130);
            this.nr_nrPages.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nr_nrPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nr_nrPages.Name = "nr_nrPages";
            this.nr_nrPages.Size = new System.Drawing.Size(70, 22);
            this.nr_nrPages.TabIndex = 5;
            this.nr_nrPages.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbl_nrPages
            // 
            this.lbl_nrPages.AutoSize = true;
            this.lbl_nrPages.Location = new System.Drawing.Point(30, 130);
            this.lbl_nrPages.Name = "lbl_nrPages";
            this.lbl_nrPages.Size = new System.Drawing.Size(79, 17);
            this.lbl_nrPages.TabIndex = 4;
            this.lbl_nrPages.Text = "Antal sidor:";
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(140, 80);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(148, 22);
            this.tb_author.TabIndex = 3;
            this.tb_author.Click += new System.EventHandler(this.tb_author_Click);
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(30, 80);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(74, 17);
            this.lbl_author.TabIndex = 2;
            this.lbl_author.Text = "Författare:";
            // 
            // tb_bookTitle
            // 
            this.tb_bookTitle.Location = new System.Drawing.Point(140, 30);
            this.tb_bookTitle.Name = "tb_bookTitle";
            this.tb_bookTitle.Size = new System.Drawing.Size(215, 22);
            this.tb_bookTitle.TabIndex = 1;
            this.tb_bookTitle.Click += new System.EventHandler(this.tb_bookTitle_Click);
            // 
            // lbl_bookTitle
            // 
            this.lbl_bookTitle.AutoSize = true;
            this.lbl_bookTitle.Location = new System.Drawing.Point(30, 30);
            this.lbl_bookTitle.Name = "lbl_bookTitle";
            this.lbl_bookTitle.Size = new System.Drawing.Size(39, 17);
            this.lbl_bookTitle.TabIndex = 0;
            this.lbl_bookTitle.Text = "Titel:";
            // 
            // addMovie
            // 
            this.addMovie.Controls.Add(this.lbl_movMissing);
            this.addMovie.Controls.Add(this.btn_addMovie);
            this.addMovie.Controls.Add(this.nr_length);
            this.addMovie.Controls.Add(this.lbl_length);
            this.addMovie.Controls.Add(this.tb_director);
            this.addMovie.Controls.Add(this.lbl_director);
            this.addMovie.Controls.Add(this.tb_movTitle);
            this.addMovie.Controls.Add(this.lbl_movTitle);
            this.addMovie.Location = new System.Drawing.Point(4, 25);
            this.addMovie.Name = "addMovie";
            this.addMovie.Padding = new System.Windows.Forms.Padding(3);
            this.addMovie.Size = new System.Drawing.Size(393, 273);
            this.addMovie.TabIndex = 1;
            this.addMovie.Text = "Lägg till film";
            this.addMovie.UseVisualStyleBackColor = true;
            // 
            // lbl_movMissing
            // 
            this.lbl_movMissing.AutoSize = true;
            this.lbl_movMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movMissing.Location = new System.Drawing.Point(140, 180);
            this.lbl_movMissing.Name = "lbl_movMissing";
            this.lbl_movMissing.Size = new System.Drawing.Size(116, 17);
            this.lbl_movMissing.TabIndex = 15;
            this.lbl_movMissing.Text = "Värden saknas";
            this.lbl_movMissing.Visible = false;
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.Location = new System.Drawing.Point(260, 220);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(95, 27);
            this.btn_addMovie.TabIndex = 12;
            this.btn_addMovie.Text = "Lägg till film";
            this.btn_addMovie.UseVisualStyleBackColor = true;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // nr_length
            // 
            this.nr_length.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nr_length.Location = new System.Drawing.Point(140, 130);
            this.nr_length.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nr_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nr_length.Name = "nr_length";
            this.nr_length.Size = new System.Drawing.Size(78, 22);
            this.nr_length.TabIndex = 11;
            this.nr_length.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(30, 130);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(75, 17);
            this.lbl_length.TabIndex = 10;
            this.lbl_length.Text = "Spellängd:";
            // 
            // tb_director
            // 
            this.tb_director.Location = new System.Drawing.Point(140, 80);
            this.tb_director.Name = "tb_director";
            this.tb_director.Size = new System.Drawing.Size(153, 22);
            this.tb_director.TabIndex = 9;
            this.tb_director.Click += new System.EventHandler(this.tb_director_Click);
            // 
            // lbl_director
            // 
            this.lbl_director.AutoSize = true;
            this.lbl_director.Location = new System.Drawing.Point(30, 80);
            this.lbl_director.Name = "lbl_director";
            this.lbl_director.Size = new System.Drawing.Size(68, 17);
            this.lbl_director.TabIndex = 8;
            this.lbl_director.Text = "Regissör:";
            // 
            // tb_movTitle
            // 
            this.tb_movTitle.Location = new System.Drawing.Point(140, 30);
            this.tb_movTitle.Name = "tb_movTitle";
            this.tb_movTitle.Size = new System.Drawing.Size(218, 22);
            this.tb_movTitle.TabIndex = 7;
            this.tb_movTitle.Click += new System.EventHandler(this.tb_movTitle_Click);
            // 
            // lbl_movTitle
            // 
            this.lbl_movTitle.AutoSize = true;
            this.lbl_movTitle.Location = new System.Drawing.Point(30, 30);
            this.lbl_movTitle.Name = "lbl_movTitle";
            this.lbl_movTitle.Size = new System.Drawing.Size(39, 17);
            this.lbl_movTitle.TabIndex = 6;
            this.lbl_movTitle.Text = "Titel:";
            // 
            // rtb_media
            // 
            this.rtb_media.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_media.Location = new System.Drawing.Point(502, 58);
            this.rtb_media.Name = "rtb_media";
            this.rtb_media.ReadOnly = true;
            this.rtb_media.Size = new System.Drawing.Size(519, 449);
            this.rtb_media.TabIndex = 1;
            this.rtb_media.Text = "";
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(16, 21);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(52, 21);
            this.rb_all.TabIndex = 0;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "Alla";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // box_show
            // 
            this.box_show.Controls.Add(this.rb_movies);
            this.box_show.Controls.Add(this.rb_books);
            this.box_show.Controls.Add(this.rb_all);
            this.box_show.Location = new System.Drawing.Point(42, 353);
            this.box_show.Name = "box_show";
            this.box_show.Size = new System.Drawing.Size(228, 56);
            this.box_show.TabIndex = 3;
            this.box_show.TabStop = false;
            this.box_show.Text = "Visa";
            // 
            // rb_movies
            // 
            this.rb_movies.AutoSize = true;
            this.rb_movies.Location = new System.Drawing.Point(153, 21);
            this.rb_movies.Name = "rb_movies";
            this.rb_movies.Size = new System.Drawing.Size(67, 21);
            this.rb_movies.TabIndex = 2;
            this.rb_movies.Text = "Filmer";
            this.rb_movies.UseVisualStyleBackColor = true;
            this.rb_movies.CheckedChanged += new System.EventHandler(this.rb_movies_CheckedChanged);
            // 
            // rb_books
            // 
            this.rb_books.AutoSize = true;
            this.rb_books.Location = new System.Drawing.Point(74, 21);
            this.rb_books.Name = "rb_books";
            this.rb_books.Size = new System.Drawing.Size(73, 21);
            this.rb_books.TabIndex = 1;
            this.rb_books.Text = "Böcker";
            this.rb_books.UseVisualStyleBackColor = true;
            this.rb_books.CheckedChanged += new System.EventHandler(this.rb_books_CheckedChanged);
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register.Location = new System.Drawing.Point(498, 24);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(80, 20);
            this.lbl_register.TabIndex = 4;
            this.lbl_register.Text = "Register";
            // 
            // gb_remove
            // 
            this.gb_remove.Controls.Add(this.btn_remove);
            this.gb_remove.Controls.Add(this.num_choice);
            this.gb_remove.Location = new System.Drawing.Point(276, 353);
            this.gb_remove.Name = "gb_remove";
            this.gb_remove.Size = new System.Drawing.Size(163, 56);
            this.gb_remove.TabIndex = 5;
            this.gb_remove.TabStop = false;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(65, 18);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(92, 27);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Text = "Ta bort";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // num_choice
            // 
            this.num_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_choice.Location = new System.Drawing.Point(9, 18);
            this.num_choice.Name = "num_choice";
            this.num_choice.Size = new System.Drawing.Size(50, 27);
            this.num_choice.TabIndex = 0;
            this.num_choice.ValueChanged += new System.EventHandler(this.num_choice_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 556);
            this.Controls.Add(this.gb_remove);
            this.Controls.Add(this.lbl_register);
            this.Controls.Add(this.box_show);
            this.Controls.Add(this.rtb_media);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mediaregistret";
            this.tabControl1.ResumeLayout(false);
            this.addBook.ResumeLayout(false);
            this.addBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_nrPages)).EndInit();
            this.addMovie.ResumeLayout(false);
            this.addMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nr_length)).EndInit();
            this.box_show.ResumeLayout(false);
            this.box_show.PerformLayout();
            this.gb_remove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addBook;
        private System.Windows.Forms.NumericUpDown nr_nrPages;
        private System.Windows.Forms.Label lbl_nrPages;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox tb_bookTitle;
        private System.Windows.Forms.Label lbl_bookTitle;
        private System.Windows.Forms.TabPage addMovie;
        private System.Windows.Forms.NumericUpDown nr_length;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox tb_director;
        private System.Windows.Forms.Label lbl_director;
        private System.Windows.Forms.TextBox tb_movTitle;
        private System.Windows.Forms.Label lbl_movTitle;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.Button btn_addMovie;
        private System.Windows.Forms.RichTextBox rtb_media;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.GroupBox box_show;
        private System.Windows.Forms.RadioButton rb_movies;
        private System.Windows.Forms.RadioButton rb_books;
        private System.Windows.Forms.Label lbl_bookMissing;
        private System.Windows.Forms.Label lbl_movMissing;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.GroupBox gb_remove;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.NumericUpDown num_choice;
    }
}

