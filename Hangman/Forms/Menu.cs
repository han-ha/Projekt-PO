using HangmanUI.Forms;
using System;
using System.Windows.Forms;

namespace HangmanUI
{
    /// <summary>
    /// Klasa odpowiadająca za okno menu.
    /// </summary>
    public partial class Menu : Form
    {        
        /// <summary>
        /// Konstruktor domyślny dla klasy Menu.
        /// </summary>
        public Menu()
        {            
            InitializeComponent();
            Show();
        }

        /// <summary>
        /// Rozpoczęcie gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_start_Click(object sender, EventArgs e)
        {
            Game gameForm = new Game
            {
                Owner = this
            };
            Hide();
            gameForm.ShowDialog();
            Close();
            
        }

        /// <summary>
        /// Wyjście z gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }        
    }
}
