namespace TrafikAPI
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
            this.components = new System.ComponentModel.Container();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.lv_searchResults = new System.Windows.Forms.ListView();
            this.fetchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Fetch = new System.Windows.Forms.Label();
            this.rtb_xml = new System.Windows.Forms.RichTextBox();
            this.rb_fetch1 = new System.Windows.Forms.RadioButton();
            this.rb_fetch2 = new System.Windows.Forms.RadioButton();
            this.lbl_error = new System.Windows.Forms.Label();
            this.rtb_smhi = new System.Windows.Forms.RichTextBox();
            this.num_lat = new System.Windows.Forms.NumericUpDown();
            this.num_lon = new System.Windows.Forms.NumericUpDown();
            this.lbl__long = new System.Windows.Forms.Label();
            this.lbl_lat = new System.Windows.Forms.Label();
            this.lbl_smhi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_tags = new System.Windows.Forms.ListView();
            this.lbl_tags = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.ch_tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.num_lat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lon)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(386, 82);
            this.searchInput.Margin = new System.Windows.Forms.Padding(2);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(149, 24);
            this.searchInput.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(539, 82);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(39, 26);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Sök";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lv_searchResults
            // 
            this.lv_searchResults.Location = new System.Drawing.Point(386, 117);
            this.lv_searchResults.Margin = new System.Windows.Forms.Padding(2);
            this.lv_searchResults.Name = "lv_searchResults";
            this.lv_searchResults.Size = new System.Drawing.Size(262, 201);
            this.lv_searchResults.TabIndex = 2;
            this.lv_searchResults.UseCompatibleStateImageBehavior = false;
            this.lv_searchResults.View = System.Windows.Forms.View.List;
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(283, 39);
            this.fetchButton.Margin = new System.Windows.Forms.Padding(2);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(92, 25);
            this.fetchButton.TabIndex = 3;
            this.fetchButton.Text = "Hämta data";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(148, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Arlanda";
            // 
            // syncTimer
            // 
            this.syncTimer.Enabled = true;
            this.syncTimer.Interval = 200;
            this.syncTimer.Tick += new System.EventHandler(this.SyncTimer_Tick);
            // 
            // lbl_Fetch
            // 
            this.lbl_Fetch.AutoSize = true;
            this.lbl_Fetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fetch.Location = new System.Drawing.Point(148, 64);
            this.lbl_Fetch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fetch.Name = "lbl_Fetch";
            this.lbl_Fetch.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Fetch.Size = new System.Drawing.Size(114, 19);
            this.lbl_Fetch.TabIndex = 4;
            this.lbl_Fetch.Text = "Ingen data hämtad";
            // 
            // rtb_xml
            // 
            this.rtb_xml.Location = new System.Drawing.Point(22, 119);
            this.rtb_xml.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_xml.Name = "rtb_xml";
            this.rtb_xml.ReadOnly = true;
            this.rtb_xml.Size = new System.Drawing.Size(325, 201);
            this.rtb_xml.TabIndex = 7;
            this.rtb_xml.Text = "";
            // 
            // rb_fetch1
            // 
            this.rb_fetch1.AutoSize = true;
            this.rb_fetch1.Checked = true;
            this.rb_fetch1.Location = new System.Drawing.Point(26, 39);
            this.rb_fetch1.Margin = new System.Windows.Forms.Padding(2);
            this.rb_fetch1.Name = "rb_fetch1";
            this.rb_fetch1.Size = new System.Drawing.Size(74, 17);
            this.rb_fetch1.TabIndex = 8;
            this.rb_fetch1.TabStop = true;
            this.rb_fetch1.Text = "Väderdata";
            this.rb_fetch1.UseVisualStyleBackColor = true;
            this.rb_fetch1.CheckedChanged += new System.EventHandler(this.Rb_fetch1_CheckedChanged);
            // 
            // rb_fetch2
            // 
            this.rb_fetch2.AutoSize = true;
            this.rb_fetch2.Location = new System.Drawing.Point(26, 63);
            this.rb_fetch2.Margin = new System.Windows.Forms.Padding(2);
            this.rb_fetch2.Name = "rb_fetch2";
            this.rb_fetch2.Size = new System.Drawing.Size(102, 17);
            this.rb_fetch2.TabIndex = 9;
            this.rb_fetch2.Text = "Tågmeddelande";
            this.rb_fetch2.UseVisualStyleBackColor = true;
            this.rb_fetch2.CheckedChanged += new System.EventHandler(this.Rb_fetch2_CheckedChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(875, 93);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 11;
            // 
            // rtb_smhi
            // 
            this.rtb_smhi.Location = new System.Drawing.Point(877, 119);
            this.rtb_smhi.Name = "rtb_smhi";
            this.rtb_smhi.ReadOnly = true;
            this.rtb_smhi.Size = new System.Drawing.Size(133, 87);
            this.rtb_smhi.TabIndex = 12;
            this.rtb_smhi.Text = "";
            // 
            // num_lat
            // 
            this.num_lat.DecimalPlaces = 2;
            this.num_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_lat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_lat.Location = new System.Drawing.Point(954, 60);
            this.num_lat.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.num_lat.Name = "num_lat";
            this.num_lat.Size = new System.Drawing.Size(56, 21);
            this.num_lat.TabIndex = 14;
            this.num_lat.Value = new decimal(new int[] {
            58,
            0,
            0,
            0});
            this.num_lat.ValueChanged += new System.EventHandler(this.Num_lat_ValueChanged);
            // 
            // num_lon
            // 
            this.num_lon.DecimalPlaces = 2;
            this.num_lon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_lon.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.num_lon.Location = new System.Drawing.Point(877, 60);
            this.num_lon.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.num_lon.Name = "num_lon";
            this.num_lon.Size = new System.Drawing.Size(58, 21);
            this.num_lon.TabIndex = 14;
            this.num_lon.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.num_lon.ValueChanged += new System.EventHandler(this.Num_lon_ValueChanged);
            // 
            // lbl__long
            // 
            this.lbl__long.AutoSize = true;
            this.lbl__long.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl__long.Location = new System.Drawing.Point(874, 39);
            this.lbl__long.Name = "lbl__long";
            this.lbl__long.Size = new System.Drawing.Size(55, 15);
            this.lbl__long.TabIndex = 15;
            this.lbl__long.Text = "Longitud";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lat.Location = new System.Drawing.Point(951, 39);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(44, 15);
            this.lbl_lat.TabIndex = 15;
            this.lbl_lat.Text = "Latitud";
            // 
            // lbl_smhi
            // 
            this.lbl_smhi.AutoSize = true;
            this.lbl_smhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smhi.Location = new System.Drawing.Point(874, 9);
            this.lbl_smhi.Name = "lbl_smhi";
            this.lbl_smhi.Size = new System.Drawing.Size(121, 16);
            this.lbl_smhi.TabIndex = 16;
            this.lbl_smhi.Text = "Väder från SMHI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data från Trafikverket";
            // 
            // lv_tags
            // 
            this.lv_tags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_tags});
            this.lv_tags.Location = new System.Drawing.Point(673, 119);
            this.lv_tags.Margin = new System.Windows.Forms.Padding(2);
            this.lv_tags.Name = "lv_tags";
            this.lv_tags.Size = new System.Drawing.Size(163, 199);
            this.lv_tags.TabIndex = 30;
            this.lv_tags.UseCompatibleStateImageBehavior = false;
            this.lv_tags.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lbl_tags
            // 
            this.lbl_tags.AutoSize = true;
            this.lbl_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tags.Location = new System.Drawing.Point(695, 93);
            this.lbl_tags.Name = "lbl_tags";
            this.lbl_tags.Size = new System.Drawing.Size(79, 15);
            this.lbl_tags.TabIndex = 18;
            this.lbl_tags.Text = "Taggar i data";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(399, 45);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(109, 13);
            this.lbl_search.TabIndex = 19;
            this.lbl_search.Text = "Sök information i data";
            // 
            // ch_tags
            // 
            this.ch_tags.Text = "Taggar i data";
            this.ch_tags.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 366);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_tags);
            this.Controls.Add(this.lv_tags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_smhi);
            this.Controls.Add(this.lbl_lat);
            this.Controls.Add(this.lbl__long);
            this.Controls.Add(this.num_lon);
            this.Controls.Add(this.num_lat);
            this.Controls.Add(this.rtb_smhi);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.rb_fetch2);
            this.Controls.Add(this.rb_fetch1);
            this.Controls.Add(this.rtb_xml);
            this.Controls.Add(this.lbl_Fetch);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.lv_searchResults);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Öppen data från Trafikverket och SMHI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_lat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView lv_searchResults;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.Label lbl_Fetch;
        private System.Windows.Forms.RichTextBox rtb_xml;
        private System.Windows.Forms.RadioButton rb_fetch1;
        private System.Windows.Forms.RadioButton rb_fetch2;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.RichTextBox rtb_smhi;
        private System.Windows.Forms.NumericUpDown num_lat;
        private System.Windows.Forms.NumericUpDown num_lon;
        private System.Windows.Forms.Label lbl__long;
        private System.Windows.Forms.Label lbl_lat;
        private System.Windows.Forms.Label lbl_smhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_tags;
        private System.Windows.Forms.Label lbl_tags;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.ColumnHeader ch_tags;
    }
}

