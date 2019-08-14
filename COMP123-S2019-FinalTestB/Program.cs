using COMP123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * STUDENT NAME: Koolait Roa
 * STUDENT ID: 301034220
 * DESCRIPTION: This is the driver class for the application
 */

namespace COMP123_S2019_FinalTestB
{
    public static class Program
    {
        public static CharacterGeneratorForm characterForm;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGeneratorForm();

            Application.Run(characterForm);
        }
    }
}
