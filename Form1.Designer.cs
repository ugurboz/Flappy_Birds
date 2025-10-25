namespace Flappy_Birds
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
            this.pictureBox_up = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_up
            // 
            this.pictureBox_up.Image = global::Flappy_Birds.Properties.Resources.pipedown;
            this.pictureBox_up.Location = new System.Drawing.Point(544, -4);
            this.pictureBox_up.Name = "pictureBox_up";
            this.pictureBox_up.Size = new System.Drawing.Size(138, 243);
            this.pictureBox_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_up.TabIndex = 0;
            this.pictureBox_up.TabStop = false;
            this.pictureBox_up.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::Flappy_Birds.Properties.Resources.pipe;
            this.pictureBox_down.Location = new System.Drawing.Point(386, 484);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(145, 258);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_down.TabIndex = 1;
            this.pictureBox_down.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = global::Flappy_Birds.Properties.Resources.bird;
            this.pictureBox_bird.Location = new System.Drawing.Point(63, 199);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(76, 90);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 2;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Image = global::Flappy_Birds.Properties.Resources.ground;
            this.pictureBox_ground.Location = new System.Drawing.Point(-24, 727);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(808, 105);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 3;
            this.pictureBox_ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.game_timer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(755, 827);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ground);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_up);
            this.Name = "Form1";
            this.Text = "Flappy Birds ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_up;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

