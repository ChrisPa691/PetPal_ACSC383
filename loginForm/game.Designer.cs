namespace loginForm
{
    partial class gameF
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
            this.petPic = new System.Windows.Forms.PictureBox();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sleepBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.foodBar = new System.Windows.Forms.ProgressBar();
            this.petBtn = new System.Windows.Forms.Button();
            this.feedBtn = new System.Windows.Forms.Button();
            this.sleepBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.exciteBar = new System.Windows.Forms.ProgressBar();
            this.deadLbl = new System.Windows.Forms.Label();
            this.retryBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bg1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bg2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bg3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.petPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // petPic
            // 
            this.petPic.Location = new System.Drawing.Point(270, 263);
            this.petPic.Name = "petPic";
            this.petPic.Size = new System.Drawing.Size(375, 375);
            this.petPic.TabIndex = 0;
            this.petPic.TabStop = false;
            // 
            // healthBar
            // 
            this.healthBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.healthBar.ForeColor = System.Drawing.Color.Red;
            this.healthBar.Location = new System.Drawing.Point(1024, 103);
            this.healthBar.Margin = new System.Windows.Forms.Padding(0);
            this.healthBar.Minimum = 5;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(625, 38);
            this.healthBar.Step = 5;
            this.healthBar.TabIndex = 1;
            this.healthBar.Tag = "";
            this.healthBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(885, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(885, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sleep ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sleepBar
            // 
            this.sleepBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sleepBar.ForeColor = System.Drawing.Color.Red;
            this.sleepBar.Location = new System.Drawing.Point(1024, 208);
            this.sleepBar.Margin = new System.Windows.Forms.Padding(0);
            this.sleepBar.Minimum = 5;
            this.sleepBar.Name = "sleepBar";
            this.sleepBar.Size = new System.Drawing.Size(625, 38);
            this.sleepBar.Step = 5;
            this.sleepBar.TabIndex = 3;
            this.sleepBar.Tag = "";
            this.sleepBar.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(894, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Food ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodBar
            // 
            this.foodBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.foodBar.ForeColor = System.Drawing.Color.Red;
            this.foodBar.Location = new System.Drawing.Point(1024, 319);
            this.foodBar.Margin = new System.Windows.Forms.Padding(0);
            this.foodBar.Minimum = 5;
            this.foodBar.Name = "foodBar";
            this.foodBar.Size = new System.Drawing.Size(625, 38);
            this.foodBar.Step = 5;
            this.foodBar.TabIndex = 5;
            this.foodBar.Tag = "";
            this.foodBar.Value = 100;
            // 
            // petBtn
            // 
            this.petBtn.BackColor = System.Drawing.Color.Transparent;
            this.petBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.petBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.petBtn.ForeColor = System.Drawing.Color.Black;
            this.petBtn.Location = new System.Drawing.Point(1361, 646);
            this.petBtn.Name = "petBtn";
            this.petBtn.Size = new System.Drawing.Size(103, 64);
            this.petBtn.TabIndex = 7;
            this.petBtn.Text = "Pet";
            this.petBtn.UseVisualStyleBackColor = true;
            this.petBtn.Click += new System.EventHandler(this.petBtn_Click);
            // 
            // feedBtn
            // 
            this.feedBtn.BackColor = System.Drawing.Color.Transparent;
            this.feedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.feedBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.feedBtn.ForeColor = System.Drawing.Color.Black;
            this.feedBtn.Location = new System.Drawing.Point(1043, 646);
            this.feedBtn.Name = "feedBtn";
            this.feedBtn.Size = new System.Drawing.Size(103, 64);
            this.feedBtn.TabIndex = 8;
            this.feedBtn.Text = "Give food";
            this.feedBtn.UseVisualStyleBackColor = true;
            this.feedBtn.Click += new System.EventHandler(this.feedBtn_Click);
            // 
            // sleepBtn
            // 
            this.sleepBtn.BackColor = System.Drawing.Color.Transparent;
            this.sleepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sleepBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.sleepBtn.ForeColor = System.Drawing.Color.Black;
            this.sleepBtn.Location = new System.Drawing.Point(876, 646);
            this.sleepBtn.Name = "sleepBtn";
            this.sleepBtn.Size = new System.Drawing.Size(103, 64);
            this.sleepBtn.TabIndex = 9;
            this.sleepBtn.Text = "Put to sleep";
            this.sleepBtn.UseVisualStyleBackColor = true;
            this.sleepBtn.Click += new System.EventHandler(this.sleepBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.playBtn.ForeColor = System.Drawing.Color.Black;
            this.playBtn.Location = new System.Drawing.Point(1213, 646);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(103, 64);
            this.playBtn.TabIndex = 10;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(818, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Excitement";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exciteBar
            // 
            this.exciteBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exciteBar.ForeColor = System.Drawing.Color.Red;
            this.exciteBar.Location = new System.Drawing.Point(1024, 402);
            this.exciteBar.Margin = new System.Windows.Forms.Padding(0);
            this.exciteBar.Minimum = 5;
            this.exciteBar.Name = "exciteBar";
            this.exciteBar.Size = new System.Drawing.Size(625, 38);
            this.exciteBar.Step = 5;
            this.exciteBar.TabIndex = 11;
            this.exciteBar.Tag = "";
            this.exciteBar.Value = 100;
            // 
            // deadLbl
            // 
            this.deadLbl.AutoSize = true;
            this.deadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadLbl.Location = new System.Drawing.Point(549, 357);
            this.deadLbl.Name = "deadLbl";
            this.deadLbl.Size = new System.Drawing.Size(609, 52);
            this.deadLbl.TabIndex = 13;
            this.deadLbl.Text = "Your pet has died! Try again!";
            this.deadLbl.Visible = false;
            // 
            // retryBtn
            // 
            this.retryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryBtn.Location = new System.Drawing.Point(679, 495);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(350, 65);
            this.retryBtn.TabIndex = 14;
            this.retryBtn.Text = "Try again";
            this.retryBtn.UseVisualStyleBackColor = true;
            this.retryBtn.Visible = false;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1673, 38);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bg1,
            this.Bg2,
            this.Bg3});
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.backgroundToolStripMenuItem.Text = "Background";
            // 
            // Bg1
            // 
            this.Bg1.Name = "Bg1";
            this.Bg1.Size = new System.Drawing.Size(179, 26);
            this.Bg1.Text = "Background1";
            this.Bg1.Click += new System.EventHandler(this.Bg1_Click);
            // 
            // Bg2
            // 
            this.Bg2.Name = "Bg2";
            this.Bg2.Size = new System.Drawing.Size(179, 26);
            this.Bg2.Text = "Background2";
            this.Bg2.Click += new System.EventHandler(this.Bg2_Click);
            // 
            // Bg3
            // 
            this.Bg3.Name = "Bg3";
            this.Bg3.Size = new System.Drawing.Size(179, 26);
            this.Bg3.Text = "Background3";
            this.Bg3.Click += new System.EventHandler(this.Bg3_Click);
            // 
            // gameF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1338, 803);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.deadLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exciteBar);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.sleepBtn);
            this.Controls.Add(this.feedBtn);
            this.Controls.Add(this.petBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.foodBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sleepBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.petPic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gameF";
            this.Text = "game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox petPic;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar sleepBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar foodBar;
        private System.Windows.Forms.Button petBtn;
        private System.Windows.Forms.Button feedBtn;
        private System.Windows.Forms.Button sleepBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar exciteBar;
        private System.Windows.Forms.Label deadLbl;
        private System.Windows.Forms.Button retryBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bg1;
        private System.Windows.Forms.ToolStripMenuItem Bg2;
        private System.Windows.Forms.ToolStripMenuItem Bg3;
    }
}