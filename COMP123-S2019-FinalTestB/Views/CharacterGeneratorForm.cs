using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// For TextReader and TextWriter
using System.IO;

/*
 * STUDENT NAME: Koolait Roa
 * STUDENT ID: 301034220
 * DESCRIPTION: This is the Character Generator  Form - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public List<string> FirstNameList = new List<string>();
        public List<string> LastNameList = new List<string>();

        // Random object that would generate a random number
        public Random random = new Random();

        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This method  loads the entire firstNames.txt and lastNames.txt file into FirstNameList and LastNameList lists
        /// </summary>
        public void LoadNames()
        {
            // textreader object to store the files
            TextReader firstNamesFile = new StreamReader("..\\..\\Data\\firstNames.txt");
            TextReader lastNamesText = new StreamReader("..\\..\\Data\\lastNames.txt");

            // reads a line of characters from the text reader object
            string line = firstNamesFile.ReadLine();

            // loop that would read every line of the file and add each to the list
            while (line != null)
            {
                FirstNameList.Add(line);
                line = firstNamesFile.ReadLine();
            }
            FirstNameList.Add(line);
            firstNamesFile.Close();


            line = lastNamesText.ReadLine();
            while (line != null)
            {
                LastNameList.Add(line);
                line = lastNamesText.ReadLine();
            }
            LastNameList.Add(line);
            lastNamesText.Close();
        }

        /// <summary>
        ///  Method that will randomly pick First Names and Last Names from 
        ///  the FirstNameList and LastNameList controls and set the 
        ///  FirstNameDataLabel and LastNameDataLabel with these values 
        /// </summary>
        public void GenerateNames()
        {
            // gets the number of elements contained in the List
            int listCount = FirstNameList.Count;
            FirstNameDataLabel.Text = FirstNameList[random.Next(0, (listCount - 1))];
            
            listCount = LastNameList.Count;
            string lname = LastNameList[random.Next(0, (listCount - 1))];
            LastNameDataLabel.Text = lname;
        }

        
    }
}
