using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_War
{
    /// <summary>
    /// ImageCardGenerator.
    /// This class generates images for each card.
    /// </summary>
    public class ImageCardGenerator
    {
        public String GetCardPath(string card)
        {
            #region Hearts

            switch (label2.Text)
            {
                case "2 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\2_of_hearts.png");
                    break;
                case "3 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\3_of_hearts.png");
                    break;
                case "4 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\4_of_hearts.png");
                    break;
                case "5 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\5_of_hearts.png");
                    break;
                case "6 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\6_of_hearts.png");
                    break;
                case "7 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\7_of_hearts.png");
                    break;
                case "8 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\8_of_hearts.png");
                    break;
                case "9 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\9_of_hearts.png");
                    break;
                case "10 of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\10_of_hearts.png");
                    break;
                case "Jack of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\jack_of_hearts2.png");
                    break;
                case "Queen of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\queen_of_hearts2.png");
                    break;
                case "King of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\king_of_hearts2.png");
                    break;
                case "Ace of Hearts":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\ace_of_hearts.png");
                    break;
            }

            #endregion

            #region Clubs

            switch (label2.Text)
            {
                case "2 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\2_of_clubs.png");
                    break;
                case "3 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\3_of_clubs.png");
                    break;
                case "4 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\4_of_clubs.png");
                    break;
                case "5 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\5_of_clubs.png");
                    break;
                case "6 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\6_of_clubs.png");
                    break;
                case "7 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\7_of_clubs.png");
                    break;
                case "8 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\8_of_clubs.png");
                    break;
                case "9 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\9_of_clubs.png");
                    break;
                case "10 of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\10_of_clubs.png");
                    break;
                case "Jack of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\jack_of_clubs2.png");
                    break;
                case "Queen of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\queen_of_clubs2.png");
                    break;
                case "King of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\king_of_clubs2.png");
                    break;
                case "Ace of Clubs":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\ace_of_clubs.png");
                    break;
            }

            #endregion

            #region Spades

            switch (label2.Text)
            {
                case "2 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\2_of_spades.png");
                    break;
                case "3 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\3_of_spades.png");
                    break;
                case "4 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\4_of_spades.png");
                    break;
                case "5 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\5_of_spades.png");
                    break;
                case "6 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\6_of_spades.png");
                    break;
                case "7 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\7_of_spades.png");
                    break;
                case "8 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\8_of_spades.png");
                    break;
                case "9 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\9_of_spades.png");
                    break;
                case "10 of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\10_of_spades.png");
                    break;
                case "Jack of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\jack_of_spades2.png");
                    break;
                case "Queen of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\queen_of_spades2.png");
                    break;
                case "King of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\king_of_spades2.png");
                    break;
                case "Ace of Spades":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\ace_of_spades2.png");
                    break;
            }

            #endregion

            #region Diamonds

            switch (card)
            {
                case "2 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\2_of_diamonds.png");
                    break;
                case "3 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\3_of_diamonds.png");
                    break;
                case "4 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\4_of_diamonds.png");
                    break;
                case "5 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\5_of_diamonds.png");
                    break;
                case "6 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\6_of_diamonds.png");
                    break;
                case "7 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\7_of_diamonds.png");
                    break;
                case "8 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\8_of_diamonds.png");
                    break;
                case "9 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\9_of_diamonds.png");
                    break;
                case "10 of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\10_of_diamonds.png");
                    break;
                case "Jack of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\jack_of_diamonds2.png");
                    break;
                case "Queen of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\queen_of_diamonds2.png");
                    break;
                case "King of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\king_of_diamonds2.png");
                    break;
                case "Ace of Diamonds":
                    pictureBox1.Image = Image.FromFile("D:\\idkkk\\RAZBOI\\RAZBOI\\CardImages\\ace_of_diamonds.png");
                    break;
            }

            #endregion
        }
    }
}
