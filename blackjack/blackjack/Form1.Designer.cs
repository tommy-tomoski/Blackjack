using System.Drawing;
namespace blackjack
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbBet = new System.Windows.Forms.TextBox();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.tbEnemy = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.PictureBox();
            this.btnStand = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbYourHand = new System.Windows.Forms.PictureBox();
            this.pbEnemyHand = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYourHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::blackjack.Properties.Resources._50;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(223, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::blackjack.Properties.Resources._100;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(277, 511);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::blackjack.Properties.Resources._500;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(330, 511);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tbBet
            // 
            this.tbBet.BackColor = System.Drawing.Color.Beige;
            this.tbBet.Location = new System.Drawing.Point(387, 537);
            this.tbBet.Name = "tbBet";
            this.tbBet.ReadOnly = true;
            this.tbBet.Size = new System.Drawing.Size(129, 20);
            this.tbBet.TabIndex = 5;
            this.tbBet.TextChanged += new System.EventHandler(this.tbBet_TextChanged);
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(18, 409);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.ReadOnly = true;
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 12;
            // 
            // tbEnemy
            // 
            this.tbEnemy.Location = new System.Drawing.Point(16, 163);
            this.tbEnemy.Name = "tbEnemy";
            this.tbEnemy.ReadOnly = true;
            this.tbEnemy.Size = new System.Drawing.Size(100, 20);
            this.tbEnemy.TabIndex = 13;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::blackjack.Properties.Resources.DealBtnDiss;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(522, 511);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 51);
            this.btnStart.TabIndex = 14;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Transparent;
            this.btnHit.BackgroundImage = global::blackjack.Properties.Resources.HitBtn;
            this.btnHit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHit.Location = new System.Drawing.Point(185, 455);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(115, 50);
            this.btnHit.TabIndex = 15;
            this.btnHit.TabStop = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Transparent;
            this.btnStand.BackgroundImage = global::blackjack.Properties.Resources.StandBtn;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.Location = new System.Drawing.Point(307, 455);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(116, 50);
            this.btnStand.TabIndex = 16;
            this.btnStand.TabStop = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::blackjack.Properties.Resources.PlaceYourBet;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(12, 511);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(205, 51);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::blackjack.Properties.Resources.Woman;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(497, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(156, 378);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::blackjack.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(586, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 62);
            this.btnBack.TabIndex = 19;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblCredit.Location = new System.Drawing.Point(138, 12);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(0, 31);
            this.lblCredit.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::blackjack.Properties.Resources.Credit;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(12, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 34);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pbYourHand
            // 
            this.pbYourHand.BackColor = System.Drawing.Color.Transparent;
            this.pbYourHand.BackgroundImage = global::blackjack.Properties.Resources.YourHand;
            this.pbYourHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbYourHand.Location = new System.Drawing.Point(12, 373);
            this.pbYourHand.Name = "pbYourHand";
            this.pbYourHand.Size = new System.Drawing.Size(139, 30);
            this.pbYourHand.TabIndex = 21;
            this.pbYourHand.TabStop = false;
            // 
            // pbEnemyHand
            // 
            this.pbEnemyHand.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemyHand.BackgroundImage = global::blackjack.Properties.Resources.EnemyHand;
            this.pbEnemyHand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEnemyHand.Location = new System.Drawing.Point(12, 127);
            this.pbEnemyHand.Name = "pbEnemyHand";
            this.pbEnemyHand.Size = new System.Drawing.Size(139, 30);
            this.pbEnemyHand.TabIndex = 22;
            this.pbEnemyHand.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::blackjack.Properties.Resources.SoundOn;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(522, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(58, 62);
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::blackjack.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(656, 572);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pbEnemyHand);
            this.Controls.Add(this.pbYourHand);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbEnemy);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.tbBet);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCredit);
            this.Name = "Form1";
            this.Text = "Blackjack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYourHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.TextBox tbEnemy;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnHit;
        private System.Windows.Forms.PictureBox btnStand;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pbYourHand;
        private System.Windows.Forms.PictureBox pbEnemyHand;
        private System.Windows.Forms.PictureBox pictureBox7;


    }
}

