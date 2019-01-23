namespace Game_bax
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Poäng = new System.Windows.Forms.Label();
            this.pbx_Pilbåge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Pilbåge)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Poäng
            // 
            this.lbl_Poäng.AutoSize = true;
            this.lbl_Poäng.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Poäng.Location = new System.Drawing.Point(23, 21);
            this.lbl_Poäng.Name = "lbl_Poäng";
            this.lbl_Poäng.Size = new System.Drawing.Size(128, 33);
            this.lbl_Poäng.TabIndex = 1;
            this.lbl_Poäng.Text = "Poäng: 0";
            // 
            // pbx_Pilbåge
            // 
            this.pbx_Pilbåge.BackColor = System.Drawing.SystemColors.Window;
            this.pbx_Pilbåge.BackgroundImage = global::Game_bax.Properties.Resources.bow_with_arrow;
            this.pbx_Pilbåge.Image = global::Game_bax.Properties.Resources.bow_with_arrow;
            this.pbx_Pilbåge.InitialImage = null;
            this.pbx_Pilbåge.Location = new System.Drawing.Point(26, 92);
            this.pbx_Pilbåge.Name = "pbx_Pilbåge";
            this.pbx_Pilbåge.Size = new System.Drawing.Size(126, 267);
            this.pbx_Pilbåge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Pilbåge.TabIndex = 0;
            this.pbx_Pilbåge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1453, 790);
            this.Controls.Add(this.lbl_Poäng);
            this.Controls.Add(this.pbx_Pilbåge);
            this.Name = "Form1";
            this.Text = "Bow and arrow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Pilbåge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbx_Pilbåge;
        private System.Windows.Forms.Label lbl_Poäng;
    }
}

