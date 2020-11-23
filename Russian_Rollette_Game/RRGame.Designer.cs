namespace Russian_Rollette_Game
{
    partial class RRGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_form = new System.Windows.Forms.Label();
            this.pbArea = new System.Windows.Forms.PictureBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_ShootAway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1073, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_form
            // 
            this.lbl_form.AutoSize = true;
            this.lbl_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_form.Font = new System.Drawing.Font("Juice ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form.ForeColor = System.Drawing.Color.Coral;
            this.lbl_form.Location = new System.Drawing.Point(261, 22);
            this.lbl_form.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_form.Name = "lbl_form";
            this.lbl_form.Size = new System.Drawing.Size(429, 67);
            this.lbl_form.TabIndex = 1;
            this.lbl_form.Text = "Russian Roulette Game";
            // 
            // pbArea
            // 
            this.pbArea.Location = new System.Drawing.Point(29, 107);
            this.pbArea.Margin = new System.Windows.Forms.Padding(4);
            this.pbArea.Name = "pbArea";
            this.pbArea.Size = new System.Drawing.Size(810, 366);
            this.pbArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArea.TabIndex = 2;
            this.pbArea.TabStop = false;
            // 
            // Btn_Start
            // 
            this.Btn_Start.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Start.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Start.Location = new System.Drawing.Point(40, 481);
            this.Btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(319, 60);
            this.Btn_Start.TabIndex = 3;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Load.Enabled = false;
            this.Btn_Load.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Load.Location = new System.Drawing.Point(859, 107);
            this.Btn_Load.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(192, 60);
            this.Btn_Load.TabIndex = 4;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = false;
            this.Btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Spin.Enabled = false;
            this.btn_Spin.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Spin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Spin.Location = new System.Drawing.Point(859, 197);
            this.btn_Spin.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(192, 60);
            this.btn_Spin.TabIndex = 5;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Shoot.Enabled = false;
            this.btn_Shoot.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Shoot.Location = new System.Drawing.Point(859, 304);
            this.btn_Shoot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(192, 60);
            this.btn_Shoot.TabIndex = 6;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Reload.Enabled = false;
            this.btn_Reload.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Reload.Location = new System.Drawing.Point(503, 481);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(297, 60);
            this.btn_Reload.TabIndex = 7;
            this.btn_Reload.Text = "Reload Game";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click_1);
            // 
            // btn_ShootAway
            // 
            this.btn_ShootAway.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_ShootAway.Enabled = false;
            this.btn_ShootAway.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShootAway.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ShootAway.Location = new System.Drawing.Point(859, 418);
            this.btn_ShootAway.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShootAway.Name = "btn_ShootAway";
            this.btn_ShootAway.Size = new System.Drawing.Size(192, 55);
            this.btn_ShootAway.TabIndex = 8;
            this.btn_ShootAway.Text = "Shoot Away";
            this.btn_ShootAway.UseVisualStyleBackColor = false;
            this.btn_ShootAway.Click += new System.EventHandler(this.Btn_ShootAway_Click);
            // 
            // RRGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_ShootAway);
            this.Controls.Add(this.btn_Reload);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.pbArea);
            this.Controls.Add(this.lbl_form);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RRGame";
            this.Text = "RR Game Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_form;
        private System.Windows.Forms.PictureBox pbArea;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_ShootAway;
    }
}

