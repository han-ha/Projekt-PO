using HangmanUI.Repos;
using System;
using System.Windows.Forms;

namespace HangmanUI.Forms
{
    /// <summary>
    /// Klasa odpowiadająca za okno zakończenia gry.
    /// </summary>
    public partial class EndOfGame : Form
    {
        /// <summary>
        /// Obiekt przechowujący informacje o obrazkach używanych w oknie zakończenia gry.
        /// </summary>
        private readonly Drawing endDrawing;
        
        /// <summary>
        /// Konstruktor parametryczny dla klasy EndOfGame.
        /// </summary>
        /// <param name="res">true - gdy wygrał użytkownik, false - wpp.</param>
        public EndOfGame(bool res)
        {
            InitializeComponent();
            endDrawing = new Drawing("Result/", 2);
            if (res)
            {
                endDrawing.Next();
                resultLabel.Text = "WYGRYWASZ! :D";
            }
            else
                resultLabel.Text = "Przegrywasz... :(";

            resultPB.Image = endDrawing.getImage();
        }

        /// <summary>
        /// Zamyka okno końca gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndOfGame_FormClosing(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        /// <summary>
        /// Zamyka okno końca gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitEndOfGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
