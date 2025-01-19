namespace loginForm
{
    partial class choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choose));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.dogOpt = new System.Windows.Forms.PictureBox();
            this.catOpt = new System.Windows.Forms.PictureBox();
            this.pigOpt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogOpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catOpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigOpt)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(397, 36);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(298, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Choose between the 3 pet animals";
            // 
            // dogOpt
            // 
            this.dogOpt.Image = ((System.Drawing.Image)(resources.GetObject("dogOpt.Image")));
            this.dogOpt.Location = new System.Drawing.Point(23, 97);
            this.dogOpt.Name = "dogOpt";
            this.dogOpt.Size = new System.Drawing.Size(310, 384);
            this.dogOpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dogOpt.TabIndex = 7;
            this.dogOpt.TabStop = false;
            this.dogOpt.Click += new System.EventHandler(this.dogOpt_Click);
            // 
            // catOpt
            // 
            this.catOpt.Image = ((System.Drawing.Image)(resources.GetObject("catOpt.Image")));
            this.catOpt.Location = new System.Drawing.Point(385, 97);
            this.catOpt.Name = "catOpt";
            this.catOpt.Size = new System.Drawing.Size(310, 384);
            this.catOpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.catOpt.TabIndex = 8;
            this.catOpt.TabStop = false;
            this.catOpt.Click += new System.EventHandler(this.catOpt_Click);
            // 
            // pigOpt
            // 
            this.pigOpt.Image = ((System.Drawing.Image)(resources.GetObject("pigOpt.Image")));
            this.pigOpt.Location = new System.Drawing.Point(749, 97);
            this.pigOpt.Name = "pigOpt";
            this.pigOpt.Size = new System.Drawing.Size(310, 384);
            this.pigOpt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pigOpt.TabIndex = 9;
            this.pigOpt.TabStop = false;
            this.pigOpt.Click += new System.EventHandler(this.pigOpt_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 539);
            this.Controls.Add(this.pigOpt);
            this.Controls.Add(this.catOpt);
            this.Controls.Add(this.dogOpt);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "choose";
            this.Text = "choose";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogOpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catOpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pigOpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox dogOpt;
        private System.Windows.Forms.PictureBox pigOpt;
        private System.Windows.Forms.PictureBox catOpt;
    }
}