namespace goofy_platformer
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
            this.points = new System.Windows.Forms.Label();
            this.qtext = new System.Windows.Forms.Label();
            this.startplat = new System.Windows.Forms.PictureBox();
            this.plat2 = new System.Windows.Forms.PictureBox();
            this.plat3 = new System.Windows.Forms.PictureBox();
            this.plat4 = new System.Windows.Forms.PictureBox();
            this.plat5 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.cubius = new System.Windows.Forms.PictureBox();
            this.npctxt = new System.Windows.Forms.Label();
            this.gover = new System.Windows.Forms.Label();
            this.chatwindow = new System.Windows.Forms.PictureBox();
            this.killBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hpl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startplat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatwindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.killBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            this.SuspendLayout();
            // 
            // points
            // 
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.points.Location = new System.Drawing.Point(37, 12);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(77, 23);
            this.points.TabIndex = 0;
            this.points.Text = "score: 0";
            this.points.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qtext
            // 
            this.qtext.BackColor = System.Drawing.Color.Transparent;
            this.qtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtext.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.qtext.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.qtext.Location = new System.Drawing.Point(473, 9);
            this.qtext.Name = "qtext";
            this.qtext.Size = new System.Drawing.Size(180, 210);
            this.qtext.TabIndex = 1;
            // 
            // startplat
            // 
            this.startplat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startplat.Location = new System.Drawing.Point(12, 740);
            this.startplat.Name = "startplat";
            this.startplat.Size = new System.Drawing.Size(177, 23);
            this.startplat.TabIndex = 2;
            this.startplat.TabStop = false;
            this.startplat.Tag = "plat";
            // 
            // plat2
            // 
            this.plat2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plat2.Location = new System.Drawing.Point(174, 656);
            this.plat2.Name = "plat2";
            this.plat2.Size = new System.Drawing.Size(177, 23);
            this.plat2.TabIndex = 3;
            this.plat2.TabStop = false;
            this.plat2.Tag = "plat";
            // 
            // plat3
            // 
            this.plat3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plat3.Location = new System.Drawing.Point(422, 544);
            this.plat3.Name = "plat3";
            this.plat3.Size = new System.Drawing.Size(177, 23);
            this.plat3.TabIndex = 4;
            this.plat3.TabStop = false;
            this.plat3.Tag = "plat";
            // 
            // plat4
            // 
            this.plat4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plat4.Location = new System.Drawing.Point(138, 485);
            this.plat4.Name = "plat4";
            this.plat4.Size = new System.Drawing.Size(177, 23);
            this.plat4.TabIndex = 5;
            this.plat4.TabStop = false;
            this.plat4.Tag = "plat";
            // 
            // plat5
            // 
            this.plat5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.plat5.Location = new System.Drawing.Point(291, 369);
            this.plat5.Name = "plat5";
            this.plat5.Size = new System.Drawing.Size(351, 23);
            this.plat5.TabIndex = 6;
            this.plat5.TabStop = false;
            this.plat5.Tag = "plat";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(580, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "cubius";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player1.Location = new System.Drawing.Point(26, 701);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 20);
            this.player1.TabIndex = 8;
            this.player1.TabStop = false;
            // 
            // cubius
            // 
            this.cubius.BackColor = System.Drawing.SystemColors.Info;
            this.cubius.Location = new System.Drawing.Point(601, 343);
            this.cubius.Name = "cubius";
            this.cubius.Size = new System.Drawing.Size(20, 20);
            this.cubius.TabIndex = 9;
            this.cubius.TabStop = false;
            // 
            // npctxt
            // 
            this.npctxt.BackColor = System.Drawing.Color.Transparent;
            this.npctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npctxt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.npctxt.Location = new System.Drawing.Point(277, 160);
            this.npctxt.Name = "npctxt";
            this.npctxt.Size = new System.Drawing.Size(391, 108);
            this.npctxt.TabIndex = 10;
            this.npctxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gover
            // 
            this.gover.BackColor = System.Drawing.Color.Transparent;
            this.gover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gover.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.gover.Location = new System.Drawing.Point(169, 12);
            this.gover.Name = "gover";
            this.gover.Size = new System.Drawing.Size(294, 90);
            this.gover.TabIndex = 11;
            this.gover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chatwindow
            // 
            this.chatwindow.BackColor = System.Drawing.Color.Transparent;
            this.chatwindow.Location = new System.Drawing.Point(529, 247);
            this.chatwindow.Name = "chatwindow";
            this.chatwindow.Size = new System.Drawing.Size(57, 116);
            this.chatwindow.TabIndex = 12;
            this.chatwindow.TabStop = false;
            this.chatwindow.Tag = "chbox";
            this.chatwindow.Visible = false;
            // 
            // killBox
            // 
            this.killBox.Location = new System.Drawing.Point(195, 753);
            this.killBox.Name = "killBox";
            this.killBox.Size = new System.Drawing.Size(447, 10);
            this.killBox.TabIndex = 13;
            this.killBox.TabStop = false;
            this.killBox.Tag = "killbox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 23);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "plat";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 92);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "portal";
            // 
            // hpl
            // 
            this.hpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.hpl.Location = new System.Drawing.Point(37, 35);
            this.hpl.Name = "hpl";
            this.hpl.Size = new System.Drawing.Size(77, 23);
            this.hpl.TabIndex = 16;
            this.hpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(410, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 116);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "chbox2";
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(-10, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 738);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "killbox";
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(648, -6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(11, 738);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "killbox";
            this.pictureBox5.Visible = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(-1, 752);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(16, 11);
            this.pictureBox36.TabIndex = 107;
            this.pictureBox36.TabStop = false;
            this.pictureBox36.Tag = "killbox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(654, 761);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.hpl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.killBox);
            this.Controls.Add(this.chatwindow);
            this.Controls.Add(this.gover);
            this.Controls.Add(this.npctxt);
            this.Controls.Add(this.cubius);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plat5);
            this.Controls.Add(this.plat4);
            this.Controls.Add(this.plat3);
            this.Controls.Add(this.plat2);
            this.Controls.Add(this.startplat);
            this.Controls.Add(this.qtext);
            this.Controls.Add(this.points);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.startplat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plat5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatwindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.killBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label qtext;
        private System.Windows.Forms.PictureBox startplat;
        private System.Windows.Forms.PictureBox plat2;
        private System.Windows.Forms.PictureBox plat3;
        private System.Windows.Forms.PictureBox plat4;
        private System.Windows.Forms.PictureBox plat5;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox cubius;
        private System.Windows.Forms.Label npctxt;
        private System.Windows.Forms.Label gover;
        private System.Windows.Forms.PictureBox chatwindow;
        private System.Windows.Forms.PictureBox killBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hpl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox36;
    }
}

