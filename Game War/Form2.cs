using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_War
{
    public partial class Fmain : Form
    {
        Tmain fplay;
        ImageCardGenerator generator;
        Deck deck = null;

        Player player1;
        Player player2;

        CardEnumerator player1CardEnumerator;
        CardEnumerator player2CardEnumerator;
        public Fmain(Form f)
        {
            InitializeComponent();
            fplay = (Tmain)f;
            generator = new ImageCardGenerator();

            player1 = new Player("Player1");
            player2 = new Player("Player2");

            if (deck == null)
            {
                deck = new Deck();

                int i = 0;
                foreach (var card in deck.GeneratedDeck)
                {
                    if (i % 2 == 0)
                    {
                        player1.Cards.Add(card);
                    }
                    else
                    {
                        player2.Cards.Add(card);
                    }
                    i++;
                }
            }

            player1CardEnumerator = player1.GetEnumerator();
            player2CardEnumerator = player2.GetEnumerator();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fplay.Show();
        }

        private void cardPicturePlayer2_Click(object sender, EventArgs e)
        {

        }

        private void Fmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            cardPicturePlayer1.Visible = true;
            cardPicturePlayer2.Visible = true;

            if (player1CardEnumerator.HasNext() && player2CardEnumerator.HasNext())
            {
                cardPicturePlayer1.Image = generator.GetCardImage(player1CardEnumerator.Next().CardName);
                cardPicturePlayer2.Image = generator.GetCardImage(player2CardEnumerator.Next().CardName);

                if (player1.CurrentCard.value > player2.CurrentCard.value)
                {
                    player1WinnerLabel.Visible = true;
                    player2WinnerLabel.Visible = false;
                    drawLabel.Visible = false;
                    player1.Score += 1;
                }
                else if (player2.CurrentCard.value > player1.CurrentCard.value)
                {
                    player2WinnerLabel.Visible = true;
                    player1WinnerLabel.Visible = false;
                    drawLabel.Visible = false;
                    player2.Score += 1;
                }
                else
                {
                    drawLabel.Visible = true;
                    player1WinnerLabel.Visible = false;
                    player2WinnerLabel.Visible = false;
                }
            }
            else
            {
                if(player1.Score > player2.Score)
                {
                    player1WinnerLabel.Text = $"Game Winner with {player1.Score} points";
                    player1WinnerLabel.Visible = true;
                    player2WinnerLabel.Visible = false;
                    drawLabel.Visible = false;
                }
                else if(player1.Score < player2.Score)
                {
                    player2WinnerLabel.Text = $"Game Winner with {player2.Score} points";
                    player2WinnerLabel.Visible = true;
                    player1WinnerLabel.Visible = false;
                    drawLabel.Visible = false;
                }
                else
                {
                    drawLabel.Text = "Game Draw";
                    drawLabel.Visible = true;
                    player1WinnerLabel.Visible = false;
                    player2WinnerLabel.Visible = false;
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
           
                deck = new Deck();

                int i = 0;
                foreach (var card in deck.GeneratedDeck)
                {
                    if (i % 2 == 0)
                    {
                        player1.Cards.Add(card);
                    }
                    else
                    {
                        player2.Cards.Add(card);
                    }
                    i++;
                }

            player1CardEnumerator = player1.GetEnumerator();
            player2CardEnumerator = player2.GetEnumerator();

            player1.Score = 0; 
            player2.Score = 0;

            player1WinnerLabel.Text = "Winner";
            player2WinnerLabel.Text = "Winner";
            drawLabel.Text = "Draw";

            cardPicturePlayer1.Visible = false; 
            cardPicturePlayer2.Visible = false;

            drawLabel.Visible = false;
            player1WinnerLabel.Visible = false;
            player2WinnerLabel.Visible = false;
        }
    }
}
