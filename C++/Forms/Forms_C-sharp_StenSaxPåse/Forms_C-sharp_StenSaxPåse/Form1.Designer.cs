namespace Forms_C_sharp_StenSaxPåse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pcbScissors = new System.Windows.Forms.PictureBox();
            this.pcbPaper = new System.Windows.Forms.PictureBox();
            this.pcbCompPaper = new System.Windows.Forms.PictureBox();
            this.pcbRock = new System.Windows.Forms.PictureBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.pcbCompRock = new System.Windows.Forms.PictureBox();
            this.pcbCompScissors = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer\'s choice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statistics:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "You:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Computer:";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(434, 339);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(23, 25);
            this.lblComputer.TabIndex = 3;
            this.lblComputer.Text = "0";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(278, 336);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(23, 25);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "0";
            // 
            // pcbScissors
            // 
            this.pcbScissors.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Scissor;
            this.pcbScissors.Location = new System.Drawing.Point(44, 264);
            this.pcbScissors.Name = "pcbScissors";
            this.pcbScissors.Size = new System.Drawing.Size(114, 100);
            this.pcbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbScissors.TabIndex = 0;
            this.pcbScissors.TabStop = false;
            this.pcbScissors.Click += new System.EventHandler(this.pcbScissors_Click);
            // 
            // pcbPaper
            // 
            this.pcbPaper.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Paper;
            this.pcbPaper.Location = new System.Drawing.Point(44, 158);
            this.pcbPaper.Name = "pcbPaper";
            this.pcbPaper.Size = new System.Drawing.Size(114, 100);
            this.pcbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPaper.TabIndex = 0;
            this.pcbPaper.TabStop = false;
            this.pcbPaper.Click += new System.EventHandler(this.pcbPaper_Click);
            // 
            // pcbCompPaper
            // 
            this.pcbCompPaper.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Paper;
            this.pcbCompPaper.Location = new System.Drawing.Point(308, 133);
            this.pcbCompPaper.Name = "pcbCompPaper";
            this.pcbCompPaper.Size = new System.Drawing.Size(114, 100);
            this.pcbCompPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCompPaper.TabIndex = 0;
            this.pcbCompPaper.TabStop = false;
            this.pcbCompPaper.Visible = false;
            // 
            // pcbRock
            // 
            this.pcbRock.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Rock;
            this.pcbRock.Location = new System.Drawing.Point(44, 52);
            this.pcbRock.Name = "pcbRock";
            this.pcbRock.Size = new System.Drawing.Size(114, 100);
            this.pcbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRock.TabIndex = 0;
            this.pcbRock.TabStop = false;
            this.pcbRock.Click += new System.EventHandler(this.pcbRock_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(27, 386);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(153, 54);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot!";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // pcbCompRock
            // 
            this.pcbCompRock.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Rock;
            this.pcbCompRock.Location = new System.Drawing.Point(308, 133);
            this.pcbCompRock.Name = "pcbCompRock";
            this.pcbCompRock.Size = new System.Drawing.Size(114, 100);
            this.pcbCompRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCompRock.TabIndex = 5;
            this.pcbCompRock.TabStop = false;
            this.pcbCompRock.Visible = false;
            // 
            // pcbCompScissors
            // 
            this.pcbCompScissors.Image = global::Forms_C_sharp_StenSaxPåse.Properties.Resources.Scissor;
            this.pcbCompScissors.Location = new System.Drawing.Point(308, 133);
            this.pcbCompScissors.Name = "pcbCompScissors";
            this.pcbCompScissors.Size = new System.Drawing.Size(114, 100);
            this.pcbCompScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCompScissors.TabIndex = 6;
            this.pcbCompScissors.TabStop = false;
            this.pcbCompScissors.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(329, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 36);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 475);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pcbCompScissors);
            this.Controls.Add(this.pcbCompRock);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbScissors);
            this.Controls.Add(this.pcbPaper);
            this.Controls.Add(this.pcbCompPaper);
            this.Controls.Add(this.pcbRock);
            this.Name = "Form1";
            this.Text = "Rock, paper and scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pcbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbRock;
        private System.Windows.Forms.PictureBox pcbPaper;
        private System.Windows.Forms.PictureBox pcbScissors;
        private System.Windows.Forms.PictureBox pcbCompPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.PictureBox pcbCompRock;
        private System.Windows.Forms.PictureBox pcbCompScissors;
        private System.Windows.Forms.Button btnReset;
    }
}

