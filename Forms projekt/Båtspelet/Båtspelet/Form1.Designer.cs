namespace Båtspelet
{
    partial class båtspelet
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
            this.vatten = new System.Windows.Forms.Panel();
            this.barrier4 = new System.Windows.Forms.PictureBox();
            this.barrier5 = new System.Windows.Forms.PictureBox();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier3 = new System.Windows.Forms.PictureBox();
            this.submarine3 = new System.Windows.Forms.PictureBox();
            this.submarine2 = new System.Windows.Forms.PictureBox();
            this.submarine1 = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.ariel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_restart = new System.Windows.Forms.Button();
            this.scoreText = new System.Windows.Forms.Label();
            this.lbl_poäng = new System.Windows.Forms.Label();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.lv_resultat = new System.Windows.Forms.ListView();
            this.ch_position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_namn = new System.Windows.Forms.Label();
            this.tb_namn = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_varning = new System.Windows.Forms.Label();
            this.vatten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ariel)).BeginInit();
            this.SuspendLayout();
            // 
            // vatten
            // 
            this.vatten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vatten.Controls.Add(this.barrier4);
            this.vatten.Controls.Add(this.barrier5);
            this.vatten.Controls.Add(this.barrier2);
            this.vatten.Controls.Add(this.barrier3);
            this.vatten.Controls.Add(this.submarine3);
            this.vatten.Controls.Add(this.submarine2);
            this.vatten.Controls.Add(this.submarine1);
            this.vatten.Controls.Add(this.bomb);
            this.vatten.Location = new System.Drawing.Point(1, 314);
            this.vatten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vatten.Name = "vatten";
            this.vatten.Size = new System.Drawing.Size(892, 293);
            this.vatten.TabIndex = 0;
            // 
            // barrier4
            // 
            this.barrier4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barrier4.Location = new System.Drawing.Point(309, 210);
            this.barrier4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barrier4.Name = "barrier4";
            this.barrier4.Size = new System.Drawing.Size(64, 8);
            this.barrier4.TabIndex = 3;
            this.barrier4.TabStop = false;
            // 
            // barrier5
            // 
            this.barrier5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barrier5.Location = new System.Drawing.Point(635, 202);
            this.barrier5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barrier5.Name = "barrier5";
            this.barrier5.Size = new System.Drawing.Size(155, 8);
            this.barrier5.TabIndex = 3;
            this.barrier5.TabStop = false;
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barrier2.Location = new System.Drawing.Point(171, 125);
            this.barrier2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(64, 8);
            this.barrier2.TabIndex = 3;
            this.barrier2.TabStop = false;
            // 
            // barrier3
            // 
            this.barrier3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.barrier3.Location = new System.Drawing.Point(497, 135);
            this.barrier3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barrier3.Name = "barrier3";
            this.barrier3.Size = new System.Drawing.Size(155, 8);
            this.barrier3.TabIndex = 3;
            this.barrier3.TabStop = false;
            // 
            // submarine3
            // 
            this.submarine3.Image = global::Båtspelet.Properties.Resources.sub;
            this.submarine3.Location = new System.Drawing.Point(295, 222);
            this.submarine3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submarine3.Name = "submarine3";
            this.submarine3.Size = new System.Drawing.Size(171, 59);
            this.submarine3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.submarine3.TabIndex = 0;
            this.submarine3.TabStop = false;
            // 
            // submarine2
            // 
            this.submarine2.Image = global::Båtspelet.Properties.Resources.sub;
            this.submarine2.Location = new System.Drawing.Point(276, 149);
            this.submarine2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submarine2.Name = "submarine2";
            this.submarine2.Size = new System.Drawing.Size(206, 50);
            this.submarine2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.submarine2.TabIndex = 0;
            this.submarine2.TabStop = false;
            // 
            // submarine1
            // 
            this.submarine1.BackColor = System.Drawing.Color.Transparent;
            this.submarine1.Image = global::Båtspelet.Properties.Resources.sub;
            this.submarine1.Location = new System.Drawing.Point(78, 59);
            this.submarine1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submarine1.Name = "submarine1";
            this.submarine1.Size = new System.Drawing.Size(91, 62);
            this.submarine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.submarine1.TabIndex = 0;
            this.submarine1.TabStop = false;
            // 
            // bomb
            // 
            this.bomb.Image = global::Båtspelet.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(22, 0);
            this.bomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(19, 42);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb.TabIndex = 2;
            this.bomb.TabStop = false;
            this.bomb.Visible = false;
            // 
            // ship
            // 
            this.ship.Image = global::Båtspelet.Properties.Resources.ship;
            this.ship.Location = new System.Drawing.Point(172, 252);
            this.ship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(252, 58);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ship.TabIndex = 1;
            this.ship.TabStop = false;
            // 
            // ariel
            // 
            this.ariel.BackColor = System.Drawing.Color.Transparent;
            this.ariel.Image = global::Båtspelet.Properties.Resources.ariel;
            this.ariel.Location = new System.Drawing.Point(749, 192);
            this.ariel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ariel.Name = "ariel";
            this.ariel.Size = new System.Drawing.Size(144, 118);
            this.ariel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ariel.TabIndex = 3;
            this.ariel.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(16, 22);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(90, 46);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Starta om";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(103, 167);
            this.scoreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(25, 26);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            // 
            // lbl_poäng
            // 
            this.lbl_poäng.AutoSize = true;
            this.lbl_poäng.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poäng.Location = new System.Drawing.Point(18, 164);
            this.lbl_poäng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_poäng.Name = "lbl_poäng";
            this.lbl_poäng.Size = new System.Drawing.Size(86, 28);
            this.lbl_poäng.TabIndex = 6;
            this.lbl_poäng.Text = "Poäng:";
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_gameOver.Location = new System.Drawing.Point(288, 81);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(254, 43);
            this.lbl_gameOver.TabIndex = 7;
            this.lbl_gameOver.Text = "Spelet är slut!";
            this.lbl_gameOver.Visible = false;
            // 
            // lv_resultat
            // 
            this.lv_resultat.BackColor = System.Drawing.SystemColors.Window;
            this.lv_resultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_resultat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_position,
            this.ch_name,
            this.ch_score});
            this.lv_resultat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lv_resultat.Location = new System.Drawing.Point(611, 11);
            this.lv_resultat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv_resultat.Name = "lv_resultat";
            this.lv_resultat.Size = new System.Drawing.Size(271, 177);
            this.lv_resultat.TabIndex = 8;
            this.lv_resultat.UseCompatibleStateImageBehavior = false;
            this.lv_resultat.View = System.Windows.Forms.View.Details;
            // 
            // ch_position
            // 
            this.ch_position.Text = "#";
            this.ch_position.Width = 38;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Namn";
            this.ch_name.Width = 150;
            // 
            // ch_score
            // 
            this.ch_score.Text = "Poäng";
            this.ch_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_score.Width = 62;
            // 
            // lbl_namn
            // 
            this.lbl_namn.AutoSize = true;
            this.lbl_namn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_namn.Location = new System.Drawing.Point(20, 81);
            this.lbl_namn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_namn.Name = "lbl_namn";
            this.lbl_namn.Size = new System.Drawing.Size(54, 19);
            this.lbl_namn.TabIndex = 9;
            this.lbl_namn.Text = "Namn:";
            // 
            // tb_namn
            // 
            this.tb_namn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namn.Location = new System.Drawing.Point(22, 110);
            this.tb_namn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_namn.Name = "tb_namn";
            this.tb_namn.Size = new System.Drawing.Size(173, 26);
            this.tb_namn.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(124, 21);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 47);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Spara poäng";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_varning
            // 
            this.lbl_varning.AutoSize = true;
            this.lbl_varning.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_varning.Location = new System.Drawing.Point(43, 136);
            this.lbl_varning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_varning.Name = "lbl_varning";
            this.lbl_varning.Size = new System.Drawing.Size(133, 14);
            this.lbl_varning.TabIndex = 12;
            this.lbl_varning.Text = "Vänligen fyll i ditt namn!";
            this.lbl_varning.Visible = false;
            // 
            // båtspelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 606);
            this.Controls.Add(this.lbl_varning);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_namn);
            this.Controls.Add(this.lbl_namn);
            this.Controls.Add(this.lv_resultat);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.lbl_poäng);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.ariel);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.vatten);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "båtspelet";
            this.Text = "Båtspelet";
            this.Load += new System.EventHandler(this.Båtspelet_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Båtspelet_KeyPress);
            this.vatten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submarine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ariel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel vatten;
        private System.Windows.Forms.PictureBox submarine1;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.PictureBox ariel;
        private System.Windows.Forms.PictureBox submarine3;
        private System.Windows.Forms.PictureBox submarine2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label lbl_poäng;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.ListView lv_resultat;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.Label lbl_namn;
        private System.Windows.Forms.TextBox tb_namn;
        private System.Windows.Forms.ColumnHeader ch_score;
        private System.Windows.Forms.ColumnHeader ch_position;
        private System.Windows.Forms.PictureBox barrier3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox barrier4;
        private System.Windows.Forms.PictureBox barrier5;
        private System.Windows.Forms.PictureBox barrier2;
        private System.Windows.Forms.Label lbl_varning;
    }
}

