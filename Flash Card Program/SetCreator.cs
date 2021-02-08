using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flash_Card_Program
{
    public partial class SetCreator : Form
    {
        public string winDir = System.Environment.GetEnvironmentVariable("windir");

        
        public SetCreator()
        {
            InitializeComponent();
        }

    //Creates a really simple class to hold all of the different card values to be created.
    public class Card
        {
            public string cardFront;
            public string cardBack;

        }

        //Variable used to hold the value of the current card number that is being added to the deck.
        public int cardCounter = 1;

        //Initializing a list of objects to hold all of the cards from the set. Not sure if it's the most efficient method but it
        //seems like it?
        public List<Card> cards = new List<Card>();

        private void addCardButton_Click(object sender, EventArgs e)
        {
            //
            //
            //I intend to work on creating a dynamic view of what is being typed into the cardTextInput boxes to display to the right
            //of the boxes (not in this block of course).
            // 
            //

            //When the button is clicked add the text inside of the box as a new Card object with Card.cardFront and Card.cardBack
            cards.Add(new Card() { cardFront = cardTextInputBoxFront.Text, cardBack = cardTextInputBoxBack.Text });
            
            //Clear the textboxes for new entry
            cardTextInputBoxFront.Text = "";
            cardTextInputBoxBack.Text = "";

            //Increment the number of cards. (Displaying the current card number that hasn't been created yet.)
            cardCounter += 1;

            //Changes the label to show user what card he/she is on.
            deckCreatorLenLabel.Text = "Card " + cardCounter.ToString();
            
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            //
            //
            //Working on File I/O to save Flash Card sets to txt so they can be reloaded from the main menu when wanting to be used.
            //
            //
            
            //Path to save newly created text file that will hold the information for the decks.
            //Will add ability to name decks of cards and then add name to this path string.
            string path = @"C:\Users\trevo\OneDrive\Documents\FlashCardTextFiles\testFile3.txt";
            
            //Checks if file does not exist already. Not actually needed at the moment but keeping it up so I remember to maybe use it
            //later. (Want to add in pop up saying "This file already exists do you want to replace it?" to else statement).
            if (!File.Exists(path))
            {

                using (TextWriter tw = new StreamWriter(path))
                {
                    foreach (var item in cards)
                    {
                        //Writes formatted lines for front and back into text file.

                        tw.WriteLine(string.Format("{0},\t{1}", item.cardFront, item.cardBack));
                    }
                }
            }

            else
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    foreach (var item in cards)
                    {
                        //Writes formatted lines for front and back into text file.

                        tw.WriteLine(string.Format("{0},\t{1}", item.cardFront, item.cardBack));
                    }
                }
            }

            //Exits the form leaving only the main menu up.
            this.Close();
            

        }
    }
}
