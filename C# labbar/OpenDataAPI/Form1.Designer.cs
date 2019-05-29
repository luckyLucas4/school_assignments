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
            this.ch_tags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_tags = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.rtb_search = new System.Windows.Forms.RichTextBox();
            this.force = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.direction = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_lat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lon)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(520, 103);
            this.searchInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(197, 28);
            this.searchInput.TabIndex = 0;
            this.searchInput.Text = "Temp";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(740, 102);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 32);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Sök";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lv_searchResults
            // 
            this.lv_searchResults.Location = new System.Drawing.Point(866, 265);
            this.lv_searchResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_searchResults.Name = "lv_searchResults";
            this.lv_searchResults.Size = new System.Drawing.Size(25, 22);
            this.lv_searchResults.TabIndex = 2;
            this.lv_searchResults.UseCompatibleStateImageBehavior = false;
            this.lv_searchResults.View = System.Windows.Forms.View.Tile;
            this.lv_searchResults.Visible = false;
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(377, 48);
            this.fetchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(123, 31);
            this.fetchButton.TabIndex = 3;
            this.fetchButton.Text = "Hämta data";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
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
            this.lbl_Fetch.Location = new System.Drawing.Point(197, 79);
            this.lbl_Fetch.Name = "lbl_Fetch";
            this.lbl_Fetch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_Fetch.Size = new System.Drawing.Size(134, 22);
            this.lbl_Fetch.TabIndex = 4;
            this.lbl_Fetch.Text = "Ingen data hämtad";
            // 
            // rtb_xml
            // 
            this.rtb_xml.Location = new System.Drawing.Point(519, 349);
            this.rtb_xml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_xml.Name = "rtb_xml";
            this.rtb_xml.ReadOnly = true;
            this.rtb_xml.Size = new System.Drawing.Size(322, 166);
            this.rtb_xml.TabIndex = 7;
            this.rtb_xml.Text = "";
            // 
            // rb_fetch1
            // 
            this.rb_fetch1.AutoSize = true;
            this.rb_fetch1.Checked = true;
            this.rb_fetch1.Location = new System.Drawing.Point(35, 48);
            this.rb_fetch1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_fetch1.Name = "rb_fetch1";
            this.rb_fetch1.Size = new System.Drawing.Size(95, 21);
            this.rb_fetch1.TabIndex = 8;
            this.rb_fetch1.TabStop = true;
            this.rb_fetch1.Text = "Väderdata";
            this.rb_fetch1.UseVisualStyleBackColor = true;
            this.rb_fetch1.CheckedChanged += new System.EventHandler(this.Rb_fetch1_CheckedChanged);
            // 
            // rb_fetch2
            // 
            this.rb_fetch2.AutoSize = true;
            this.rb_fetch2.Location = new System.Drawing.Point(35, 78);
            this.rb_fetch2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_fetch2.Name = "rb_fetch2";
            this.rb_fetch2.Size = new System.Drawing.Size(132, 21);
            this.rb_fetch2.TabIndex = 9;
            this.rb_fetch2.Text = "Tågmeddelande";
            this.rb_fetch2.UseVisualStyleBackColor = true;
            this.rb_fetch2.CheckedChanged += new System.EventHandler(this.Rb_fetch2_CheckedChanged);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(1167, 114);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 17);
            this.lbl_error.TabIndex = 11;
            // 
            // rtb_smhi
            // 
            this.rtb_smhi.Location = new System.Drawing.Point(1169, 146);
            this.rtb_smhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_smhi.Name = "rtb_smhi";
            this.rtb_smhi.ReadOnly = true;
            this.rtb_smhi.Size = new System.Drawing.Size(176, 106);
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
            this.num_lat.Location = new System.Drawing.Point(1272, 74);
            this.num_lat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_lat.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.num_lat.Name = "num_lat";
            this.num_lat.Size = new System.Drawing.Size(75, 24);
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
            this.num_lon.Location = new System.Drawing.Point(1169, 74);
            this.num_lon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_lon.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.num_lon.Name = "num_lon";
            this.num_lon.Size = new System.Drawing.Size(77, 24);
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
            this.lbl__long.Location = new System.Drawing.Point(1165, 48);
            this.lbl__long.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl__long.Name = "lbl__long";
            this.lbl__long.Size = new System.Drawing.Size(64, 18);
            this.lbl__long.TabIndex = 15;
            this.lbl__long.Text = "Longitud";
            // 
            // lbl_lat
            // 
            this.lbl_lat.AutoSize = true;
            this.lbl_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lat.Location = new System.Drawing.Point(1268, 48);
            this.lbl_lat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lat.Name = "lbl_lat";
            this.lbl_lat.Size = new System.Drawing.Size(51, 18);
            this.lbl_lat.TabIndex = 15;
            this.lbl_lat.Text = "Latitud";
            // 
            // lbl_smhi
            // 
            this.lbl_smhi.AutoSize = true;
            this.lbl_smhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_smhi.Location = new System.Drawing.Point(1165, 11);
            this.lbl_smhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_smhi.Name = "lbl_smhi";
            this.lbl_smhi.Size = new System.Drawing.Size(149, 20);
            this.lbl_smhi.TabIndex = 16;
            this.lbl_smhi.Text = "Väder från SMHI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data från Trafikverket";
            // 
            // lv_tags
            // 
            this.lv_tags.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_tags});
            this.lv_tags.Location = new System.Drawing.Point(897, 146);
            this.lv_tags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_tags.Name = "lv_tags";
            this.lv_tags.Size = new System.Drawing.Size(216, 244);
            this.lv_tags.TabIndex = 30;
            this.lv_tags.UseCompatibleStateImageBehavior = false;
            this.lv_tags.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ch_tags
            // 
            this.ch_tags.Text = "Taggar i data";
            this.ch_tags.Width = 80;
            // 
            // lbl_tags
            // 
            this.lbl_tags.AutoSize = true;
            this.lbl_tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tags.Location = new System.Drawing.Point(893, 112);
            this.lbl_tags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tags.Name = "lbl_tags";
            this.lbl_tags.Size = new System.Drawing.Size(93, 18);
            this.lbl_tags.TabIndex = 18;
            this.lbl_tags.Text = "Taggar i data";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(516, 79);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(165, 18);
            this.lbl_search.TabIndex = 19;
            this.lbl_search.Text = "Sök information i taggar";
            // 
            // rtb_search
            // 
            this.rtb_search.Location = new System.Drawing.Point(520, 149);
            this.rtb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_search.Name = "rtb_search";
            this.rtb_search.ReadOnly = true;
            this.rtb_search.Size = new System.Drawing.Size(321, 163);
            this.rtb_search.TabIndex = 31;
            this.rtb_search.Text = "";
            // 
            // force
            // 
            this.force.AutoSize = true;
            this.force.Location = new System.Drawing.Point(236, 191);
            this.force.Name = "force";
            this.force.Size = new System.Drawing.Size(16, 17);
            this.force.TabIndex = 32;
            this.force.Text = "0";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(236, 219);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(16, 17);
            this.temp.TabIndex = 32;
            this.temp.Text = "0";
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Location = new System.Drawing.Point(236, 247);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(16, 17);
            this.direction.TabIndex = 32;
            this.direction.Text = "0";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(236, 279);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(16, 17);
            this.amount.TabIndex = 32;
            this.amount.Text = "0";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(236, 308);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(16, 17);
            this.humidity.TabIndex = 32;
            this.humidity.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Vindstyrka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Temperatur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Vindriktning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Luftfuktighet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Typ av nederbörd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 555);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.force);
            this.Controls.Add(this.rtb_search);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.RichTextBox rtb_search;
        private System.Windows.Forms.Label force;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

