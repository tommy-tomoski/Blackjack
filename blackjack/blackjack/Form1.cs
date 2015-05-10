using blackjack.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace blackjack
{
    public partial class Form1 : Form
    {
        float bet, credit;
        int x, y;
        bool soundOn;
        Deck deck;
        Hand playerHand, enemyHand;
        int dealtCardIndex;
        WindowsMediaPlayer windowsMediaPlayer, p2, p3;
        public Form1()
        {
            InitializeComponent();
            bet = 0;
            credit = 1000;
            lblCredit.Text = String.Format("{0:0.00}",credit);
            btnHit.Visible = false;
            btnStand.Visible = false;
            btnStart.Enabled = false;
            tbEnemy.Visible = false;
            tbPlayer.Visible = false;
            dealtCardIndex = 0;
            pbYourHand.Visible = false;
            pbEnemyHand.Visible = false;
            soundOn = true;

            windowsMediaPlayer = new WindowsMediaPlayer();
            windowsMediaPlayer.URL = "background_music.mp3";
            windowsMediaPlayer.controls.play();
            windowsMediaPlayer.settings.setMode("Loop", true);

        }

        public void hit() {
            x += 30;
            Graphics g = this.CreateGraphics();

            playerHand.addCard(deck.dealCard());
            g.DrawImageUnscaled(playerHand.getCard(dealtCardIndex++).image, x + 30, y);
            tbPlayer.Text = playerHand.getValue().ToString();
            if (playerHand.getValue() > 21)
            {
                p3 = new WindowsMediaPlayer();
                p3.URL = "laugh.mp3";
                MessageBox.Show("You bust, dealer wins!");
                tbBet.Enabled = true;
                tbBet.Focus();
                NewGame();
            }
            if (playerHand.getValue() == 21)
            {
                p2 = new WindowsMediaPlayer();
                p2.URL = "applause.wav";
                credit += bet * 2;
                tbBet.Enabled = true;
                tbBet.Focus();
                MessageBox.Show("You win with a blackjack!");
                NewGame();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (50 <= credit)  {
                btnStart.BackgroundImage = Resources.DealBtn1;
                bet += 50;
                tbBet.Text = bet.ToString();
                credit -= 50;
                lblCredit.Text = String.Format("{0:0.00}", credit);                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (100 <= credit) {
                btnStart.BackgroundImage = Resources.DealBtn1;                
                bet += 100;
                tbBet.Text = bet.ToString();
                credit -= 100;
                lblCredit.Text = String.Format("{0:0.00}", credit);          
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (500 <= credit) {
                btnStart.BackgroundImage = Resources.DealBtn1;
                bet += 500;
                tbBet.Text = bet.ToString();
                credit -= 500;
                lblCredit.Text = String.Format("{0:0.00}", credit);          
            }
        }
        
        private void btnHit_Click(object sender, EventArgs e)
        {
            hit();
        }

        private void NewGame()
        {
            Graphics g = this.CreateGraphics();
            lblCredit.Text = String.Format("{0:0.00}", credit);
            bet = 0;
            tbBet.Text = "0";
            tbPlayer.Text = "0";
            tbEnemy.Text = "0";

            g.Clear(Color.White);
            this.BackgroundImage = Resources._8;
            btnStart.Visible = true;

            btnBack.Enabled = true;
            btnHit.Visible = false;
            btnHit.Enabled = true;
            btnStand.Visible = false;
            btnStand.Enabled = true;
            btnStart.Enabled = true;

            dealtCardIndex = 0;

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            btnBack.Enabled = false;
            btnStart.Enabled = false;
            btnHit.Visible = true;
            btnStand.Visible = true;
            tbPlayer.Visible = true;
            tbEnemy.Visible = true;



            tbBet.Enabled = false;
            tbEnemy.Enabled = false;
            tbPlayer.Enabled = false;
            x = 180;
            y = 300;

            pbYourHand.Visible = true;
            pbEnemyHand.Visible = true;
            playerHand = new Hand();
            enemyHand = new Hand();
            deck = new Deck();
            
            enemyHand.Clear();
            playerHand.Clear();
            deck.shuffle();

            for (int i = 0; i < 2; i++) {
                playerHand.addCard(deck.dealCard());
                enemyHand.addCard(deck.dealCard());
            }
                        
            Image flipped = Image.FromFile(@"Images\flipped.png");

            g.DrawImageUnscaled(playerHand.getCard(dealtCardIndex++).image, x, y);
            g.DrawImageUnscaled(playerHand.getCard(dealtCardIndex++).image, x + 30, y);
            g.DrawImageUnscaled(enemyHand.getCard(0).image, x, y - 250);
            g.DrawImageUnscaled(flipped, x + 30, y - 250);

            tbEnemy.Text = enemyHand.getValue().ToString();
            tbPlayer.Text = playerHand.getValue().ToString();
            
            if (enemyHand.getValue() == 21)
            {
                for (int i = 0; i < enemyHand.getCardCount(); i++)
                {
                    g.DrawImageUnscaled(enemyHand.getCard(i).image, x, y - 250);
                    x += 30;
                }
                p3 = new WindowsMediaPlayer();
                p3.URL = "laugh.mp3";
                tbEnemy.Text = enemyHand.getValue().ToString();
                MessageBox.Show("Enemy wins with a blackjack!");
                tbBet.Enabled = true;
                tbBet.Focus();
                NewGame();
            }
            else if (playerHand.getValue() == 21)
            {
                p2 = new WindowsMediaPlayer();
                p2.URL = "applause.wav";
                credit += bet * 2;
                MessageBox.Show("You win with a blackjack!");
                tbBet.Enabled = true;
                tbBet.Focus();
                NewGame();
            }
        }        

        private void tbBet_TextChanged(object sender, EventArgs e)
        {
            int f = 0;
            btnStart.Enabled = int.TryParse(tbBet.Text, out f) && (int.Parse(tbBet.Text) > 0);
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            stand();
        }
        public void stand() {
            Graphics g = this.CreateGraphics();

            x = 180;
            y = 300;

            btnHit.Enabled = false;
            btnStand.Enabled = false;

            Image flipped = Image.FromFile(@"Images\flipped.png");
            while (true)
            {
                if (enemyHand.getValue() > 16)
                {
                    break;
                }
                enemyHand.addCard(deck.dealCard());
                g.DrawImageUnscaled(flipped, x + 30, y - 250);
            }
            for (int i = 0; i < enemyHand.getCardCount(); i++)
            {
                g.DrawImageUnscaled(enemyHand.getCard(i).image, x, y - 250);
                x += 30;
            }
            if (enemyHand.getValue() > 21)
            {
                p2 = new WindowsMediaPlayer();
                p2.URL = "applause.wav";
                tbEnemy.Text = enemyHand.getValue().ToString();
                MessageBox.Show("The enmemy busts, and you won the game.");
                tbBet.Enabled = true;
                tbBet.Focus();
                credit += bet * 2;
            }
            else if (enemyHand.getValue() > playerHand.getValue())
            {
                p3 = new WindowsMediaPlayer();
                p3.URL = "laugh.mp3";
                tbEnemy.Text = enemyHand.getValue().ToString();
                tbBet.Enabled = true;
                tbBet.Focus();
                MessageBox.Show("The enemy wins.");
                
            }
            else if (enemyHand.getValue() < playerHand.getValue())
            {
                p2 = new WindowsMediaPlayer();
                p2.URL = "applause.wav";
                tbEnemy.Text = enemyHand.getValue().ToString();
                tbBet.Enabled = true;
                tbBet.Focus();
                MessageBox.Show("Congratulations you won!");
                credit += bet * 2;
            }
            else
            {
                p3 = new WindowsMediaPlayer();
                p3.URL = "laugh.mp3";
                tbEnemy.Text = enemyHand.getValue().ToString();
                tbBet.Enabled = true;
                tbBet.Focus();
                MessageBox.Show("It's a tie, the enemy wins.");
            }
            NewGame();
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H) {
                hit();
            }
            if (e.KeyCode == Keys.S)
            {
                stand();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            windowsMediaPlayer.controls.stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            f.Show();
            windowsMediaPlayer.controls.stop();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (soundOn)
            {
                soundOn = false;
                pictureBox7.BackgroundImage = Resources.SoundOff;
                windowsMediaPlayer.controls.stop();
            }
            else {
                soundOn = true;
                pictureBox7.BackgroundImage = Resources.SoundOn;
                windowsMediaPlayer.controls.play();
            }

        }

        
    }
}
