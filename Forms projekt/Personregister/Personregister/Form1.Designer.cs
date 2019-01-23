namespace Personregister
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
            System.Windows.Forms.Label txtb_namn;
            this.btn_nyPerson = new System.Windows.Forms.Button();
            this.btn_inIListan = new System.Windows.Forms.Button();
            this.btn_visaListan = new System.Windows.Forms.Button();
            this.btn_sortera = new System.Windows.Forms.Button();
            this.txtb_ålder = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lsbx_namn = new System.Windows.Forms.ListBox();
            this.lsbx_ålder = new System.Windows.Forms.ListBox();
            this.btn_vänd = new System.Windows.Forms.Button();
            txtb_namn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_namn
            // 
            txtb_namn.AutoSize = true;
            txtb_namn.Location = new System.Drawing.Point(558, 25);
            txtb_namn.Name = "txtb_namn";
            txtb_namn.Size = new System.Drawing.Size(45, 17);
            txtb_namn.TabIndex = 1;
            txtb_namn.Text = "Namn";
            // 
            // btn_nyPerson
            // 
            this.btn_nyPerson.Location = new System.Drawing.Point(606, 120);
            this.btn_nyPerson.Name = "btn_nyPerson";
            this.btn_nyPerson.Size = new System.Drawing.Size(109, 28);
            this.btn_nyPerson.TabIndex = 0;
            this.btn_nyPerson.Text = "Ny person";
            this.btn_nyPerson.UseVisualStyleBackColor = true;
            this.btn_nyPerson.Click += new System.EventHandler(this.btn_nyPerson_Click);
            // 
            // btn_inIListan
            // 
            this.btn_inIListan.Location = new System.Drawing.Point(606, 175);
            this.btn_inIListan.Name = "btn_inIListan";
            this.btn_inIListan.Size = new System.Drawing.Size(109, 28);
            this.btn_inIListan.TabIndex = 0;
            this.btn_inIListan.Text = "Lägg in i listan";
            this.btn_inIListan.UseVisualStyleBackColor = true;
            this.btn_inIListan.Click += new System.EventHandler(this.btn_inIListan_Click);
            // 
            // btn_visaListan
            // 
            this.btn_visaListan.Location = new System.Drawing.Point(606, 230);
            this.btn_visaListan.Name = "btn_visaListan";
            this.btn_visaListan.Size = new System.Drawing.Size(109, 28);
            this.btn_visaListan.TabIndex = 0;
            this.btn_visaListan.Text = "Visa listan";
            this.btn_visaListan.UseVisualStyleBackColor = true;
            this.btn_visaListan.Click += new System.EventHandler(this.btn_visaListan_Click);
            // 
            // btn_sortera
            // 
            this.btn_sortera.Location = new System.Drawing.Point(606, 285);
            this.btn_sortera.Name = "btn_sortera";
            this.btn_sortera.Size = new System.Drawing.Size(109, 28);
            this.btn_sortera.TabIndex = 0;
            this.btn_sortera.Text = "Sortera listan";
            this.btn_sortera.UseVisualStyleBackColor = true;
            this.btn_sortera.Click += new System.EventHandler(this.btn_sortera_Click);
            // 
            // txtb_ålder
            // 
            this.txtb_ålder.AutoSize = true;
            this.txtb_ålder.Location = new System.Drawing.Point(558, 65);
            this.txtb_ålder.Name = "txtb_ålder";
            this.txtb_ålder.Size = new System.Drawing.Size(41, 17);
            this.txtb_ålder.TabIndex = 1;
            this.txtb_ålder.Text = "Ålder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(617, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 2;
            // 
            // lsbx_namn
            // 
            this.lsbx_namn.FormattingEnabled = true;
            this.lsbx_namn.ItemHeight = 16;
            this.lsbx_namn.Location = new System.Drawing.Point(148, 90);
            this.lsbx_namn.Name = "lsbx_namn";
            this.lsbx_namn.Size = new System.Drawing.Size(156, 292);
            this.lsbx_namn.TabIndex = 3;
            // 
            // lsbx_ålder
            // 
            this.lsbx_ålder.FormattingEnabled = true;
            this.lsbx_ålder.ItemHeight = 16;
            this.lsbx_ålder.Location = new System.Drawing.Point(330, 90);
            this.lsbx_ålder.Name = "lsbx_ålder";
            this.lsbx_ålder.Size = new System.Drawing.Size(156, 292);
            this.lsbx_ålder.TabIndex = 3;
            // 
            // btn_vänd
            // 
            this.btn_vänd.Location = new System.Drawing.Point(606, 338);
            this.btn_vänd.Name = "btn_vänd";
            this.btn_vänd.Size = new System.Drawing.Size(173, 28);
            this.btn_vänd.TabIndex = 0;
            this.btn_vänd.Text = "Vänd sorteringen";
            this.btn_vänd.UseVisualStyleBackColor = true;
            this.btn_vänd.Click += new System.EventHandler(this.btn_vänd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbx_ålder);
            this.Controls.Add(this.lsbx_namn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtb_ålder);
            this.Controls.Add(txtb_namn);
            this.Controls.Add(this.btn_vänd);
            this.Controls.Add(this.btn_sortera);
            this.Controls.Add(this.btn_visaListan);
            this.Controls.Add(this.btn_inIListan);
            this.Controls.Add(this.btn_nyPerson);
            this.Name = "Form1";
            this.Text = "Personregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nyPerson;
        private System.Windows.Forms.Button btn_inIListan;
        private System.Windows.Forms.Button btn_visaListan;
        private System.Windows.Forms.Button btn_sortera;
        private System.Windows.Forms.Label txtb_ålder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lsbx_namn;
        private System.Windows.Forms.ListBox lsbx_ålder;
        private System.Windows.Forms.Button btn_vänd;
    }
}

