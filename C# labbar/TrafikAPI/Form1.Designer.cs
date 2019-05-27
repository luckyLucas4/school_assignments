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
            this.searchResults = new System.Windows.Forms.ListView();
            this.fetchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_Fetch = new System.Windows.Forms.Label();
            this.rtb_xml = new System.Windows.Forms.RichTextBox();
            this.rb_fetch1 = new System.Windows.Forms.RadioButton();
            this.rb_fetch2 = new System.Windows.Forms.RadioButton();
            this.rb_fetch3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(55, 82);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(197, 28);
            this.searchInput.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(258, 78);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 32);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Sök";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchResults
            // 
            this.searchResults.Location = new System.Drawing.Point(55, 146);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(348, 247);
            this.searchResults.TabIndex = 2;
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.View = System.Windows.Forms.View.List;
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(232, 23);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(122, 31);
            this.fetchButton.TabIndex = 3;
            this.fetchButton.Text = "Hämta data";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.FetchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 0;
            // 
            // syncTimer
            // 
            this.syncTimer.Interval = 200;
            this.syncTimer.Tick += new System.EventHandler(this.SyncTimer_Tick);
            // 
            // lbl_Fetch
            // 
            this.lbl_Fetch.AutoSize = true;
            this.lbl_Fetch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Fetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fetch.Location = new System.Drawing.Point(375, 27);
            this.lbl_Fetch.Name = "lbl_Fetch";
            this.lbl_Fetch.Padding = new System.Windows.Forms.Padding(2);
            this.lbl_Fetch.Size = new System.Drawing.Size(134, 24);
            this.lbl_Fetch.TabIndex = 4;
            this.lbl_Fetch.Text = "Ingen data hämtad";
            // 
            // rtb_xml
            // 
            this.rtb_xml.Location = new System.Drawing.Point(455, 146);
            this.rtb_xml.Name = "rtb_xml";
            this.rtb_xml.ReadOnly = true;
            this.rtb_xml.Size = new System.Drawing.Size(366, 247);
            this.rtb_xml.TabIndex = 7;
            this.rtb_xml.Text = "";
            // 
            // rb_fetch1
            // 
            this.rb_fetch1.AutoSize = true;
            this.rb_fetch1.Location = new System.Drawing.Point(559, 32);
            this.rb_fetch1.Name = "rb_fetch1";
            this.rb_fetch1.Size = new System.Drawing.Size(95, 21);
            this.rb_fetch1.TabIndex = 8;
            this.rb_fetch1.TabStop = true;
            this.rb_fetch1.Text = "Väderdata";
            this.rb_fetch1.UseVisualStyleBackColor = true;
            // 
            // rb_fetch2
            // 
            this.rb_fetch2.AutoSize = true;
            this.rb_fetch2.Location = new System.Drawing.Point(559, 59);
            this.rb_fetch2.Name = "rb_fetch2";
            this.rb_fetch2.Size = new System.Drawing.Size(132, 21);
            this.rb_fetch2.TabIndex = 9;
            this.rb_fetch2.TabStop = true;
            this.rb_fetch2.Text = "Tågmeddelande";
            this.rb_fetch2.UseVisualStyleBackColor = true;
            // 
            // rb_fetch3
            // 
            this.rb_fetch3.AutoSize = true;
            this.rb_fetch3.Location = new System.Drawing.Point(559, 86);
            this.rb_fetch3.Name = "rb_fetch3";
            this.rb_fetch3.Size = new System.Drawing.Size(94, 21);
            this.rb_fetch3.TabIndex = 10;
            this.rb_fetch3.TabStop = true;
            this.rb_fetch3.Text = "Request 3";
            this.rb_fetch3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.rb_fetch3);
            this.Controls.Add(this.rb_fetch2);
            this.Controls.Add(this.rb_fetch1);
            this.Controls.Add(this.rtb_xml);
            this.Controls.Add(this.lbl_Fetch);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchInput);
            this.Name = "Form1";
            this.Text = "Trafikverkets API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView searchResults;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.Label lbl_Fetch;
        private System.Windows.Forms.RichTextBox rtb_xml;
        private System.Windows.Forms.RadioButton rb_fetch1;
        private System.Windows.Forms.RadioButton rb_fetch2;
        private System.Windows.Forms.RadioButton rb_fetch3;
    }
}

