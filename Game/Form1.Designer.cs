namespace Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.divider1 = new System.Windows.Forms.PictureBox();
            this.divider2 = new System.Windows.Forms.PictureBox();
            this.divider3 = new System.Windows.Forms.PictureBox();
            this.divider4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.divider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.White;
            this.divider1.Location = new System.Drawing.Point(310, -1);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(8, 105);
            this.divider1.TabIndex = 0;
            this.divider1.TabStop = false;
            // 
            // divider2
            // 
            this.divider2.BackColor = System.Drawing.Color.White;
            this.divider2.Location = new System.Drawing.Point(310, 120);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(8, 105);
            this.divider2.TabIndex = 1;
            this.divider2.TabStop = false;
            // 
            // divider3
            // 
            this.divider3.BackColor = System.Drawing.Color.White;
            this.divider3.Location = new System.Drawing.Point(310, 248);
            this.divider3.Name = "divider3";
            this.divider3.Size = new System.Drawing.Size(8, 105);
            this.divider3.TabIndex = 2;
            this.divider3.TabStop = false;
            // 
            // divider4
            // 
            this.divider4.BackColor = System.Drawing.Color.White;
            this.divider4.Location = new System.Drawing.Point(310, 374);
            this.divider4.Name = "divider4";
            this.divider4.Size = new System.Drawing.Size(8, 105);
            this.divider4.TabIndex = 3;
            this.divider4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(310, 494);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(8, 105);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(120, 354);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(72, 106);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 5;
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(12, 12);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(72, 106);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 6;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(222, 33);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(72, 106);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 7;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(493, 69);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(72, 106);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 8;
            this.enemy3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(616, 541);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.divider4);
            this.Controls.Add(this.divider3);
            this.Controls.Add(this.divider2);
            this.Controls.Add(this.divider1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.divider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox divider1;
        private System.Windows.Forms.PictureBox divider2;
        private System.Windows.Forms.PictureBox divider3;
        private System.Windows.Forms.PictureBox divider4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
    }
}

