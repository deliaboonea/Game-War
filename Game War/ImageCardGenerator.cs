using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        /// <summary>
        /// This method return an Image object represeting the desired card.
        /// </summary>
        /// <param name="card">Card name</param>
        /// <returns></returns>
        public Image GetCardImage(string card)
        {
            Image imageToReturn = null;


            //Mergem 2 foldere inapoi ca sa ajungem la folderul de imagini, ca sa functioneze si pe CD :)
            string currentDirectory = Directory.GetCurrentDirectory();
            string parentDirectory = Directory.GetParent(currentDirectory).FullName;
            string grandParentDirectory = Directory.GetParent(parentDirectory).FullName;

            #region Hearts

            switch (card)
            {
                case "2 of Hearts":
                    // $ - te lasa sa pui variabile in string cu {}
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\2_of_hearts.png");
                    break;
                case "3 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\3_of_hearts.png");
                    break;
                case "4 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\4_of_hearts.png");
                    break;
                case "5 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\5_of_hearts.png");
                    break;
                case "6 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\6_of_hearts.png");
                    break;
                case "7 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\7_of_hearts.png");
                    break;
                case "8 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\8_of_hearts.png");
                    break;
                case "9 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\9_of_hearts.png");
                    break;
                case "10 of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\10_of_hearts.png");
                    break;
                case "Jack of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\jack_of_hearts2.png");
                    break;
                case "Queen of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\queen_of_hearts2.png");
                    break;
                case "King of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\king_of_hearts2.png");
                    break;
                case "Ace of Hearts":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\ace_of_hearts.png");
                    break;
            }

            #endregion

            #region Clubs

            switch (card)
            {
                case "2 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\2_of_clubs.png");
                    break;
                case "3 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\3_of_clubs.png");
                    break;
                case "4 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\4_of_clubs.png");
                    break;
                case "5 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\5_of_clubs.png");
                    break;
                case "6 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\6_of_clubs.png");
                    break;
                case "7 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\7_of_clubs.png");
                    break;
                case "8 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\8_of_clubs.png");
                    break;
                case "9 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\9_of_clubs.png");
                    break;
                case "10 of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\10_of_clubs.png");
                    break;
                case "Jack of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\jack_of_clubs2.png");
                    break;
                case "Queen of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\queen_of_clubs2.png");
                    break;
                case "King of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\king_of_clubs2.png");
                    break;
                case "Ace of Clubs":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\ace_of_clubs.png");
                    break;
            }

            #endregion

            #region Spades

            switch (card)
            {
                case "2 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\2_of_spades.png");
                    break;
                case "3 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\3_of_spades.png");
                    break;
                case "4 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\4_of_spades.png");
                    break;
                case "5 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\5_of_spades.png");
                    break;
                case "6 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\6_of_spades.png");
                    break;
                case "7 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\7_of_spades.png");
                    break;
                case "8 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\8_of_spades.png");
                    break;
                case "9 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\9_of_spades.png");
                    break;
                case "10 of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\10_of_spades.png");
                    break;
                case "Jack of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\jack_of_spades2.png");
                    break;
                case "Queen of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\queen_of_spades2.png");
                    break;
                case "King of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\king_of_spades2.png");
                    break;
                case "Ace of Spades":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\ace_of_spades2.png");
                    break;
            }

            #endregion

            #region Diamonds

            switch (card)
            {
                case "2 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\2_of_diamonds.png");
                    break;
                case "3 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\3_of_diamonds.png");
                    break;
                case "4 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\4_of_diamonds.png");
                    break;
                case "5 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\5_of_diamonds.png");
                    break;
                case "6 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\6_of_diamonds.png");
                    break;
                case "7 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\7_of_diamonds.png");
                    break;
                case "8 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\8_of_diamonds.png");
                    break;
                case "9 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\9_of_diamonds.png");
                    break;
                case "10 of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\10_of_diamonds.png");
                    break;
                case "Jack of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\jack_of_diamonds2.png");
                    break;
                case "Queen of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\queen_of_diamonds2.png");
                    break;
                case "King of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\king_of_diamonds2.png");
                    break;
                case "Ace of Diamonds":
                    imageToReturn = Image.FromFile($"{grandParentDirectory}\\CardImages\\ace_of_diamonds.png");
                    break;
            }

            #endregion

            if(imageToReturn != null)
            {
                return imageToReturn;
            }
            return null;
        }
    }
}
