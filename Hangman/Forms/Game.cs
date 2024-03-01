using System;
using System.Windows.Forms;
using HangmanUI.Repos;
using static HangmanUI.Repos.InputManager;

namespace HangmanUI.Forms
{
    /// <summary>
    /// Klasa odpowiadająca za rozgrywkę.
    /// </summary>
    public partial class Game : Form
    {
        /// <summary>
        /// Obiekt odpowiadający za przechowywanie obrazków ze stanem wisielca i danych o nich.
        /// </summary>
        private readonly Drawing drawings;

        /// <summary>
        /// Obiekt odpowiadający za operacje na odczytanym wejściu.
        /// </summary>
        private readonly InputManager inputManager;

        /// <summary>
        /// Konstruktor domyślny dla klasy Game.
        /// </summary>
        public Game()
        {
            InitializeComponent();

            drawings = new Drawing("Images/", 12);
            inputManager = new InputManager("hangman_data.txt");

            pbImages.Image = drawings.getImage();
            lblWord.Text = inputManager.Word.ShowWord();
        }

        /// <summary>
        /// Zamyka okno gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Game_FormClosing(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
        /// <summary>
        /// Rozpoczyna ruch gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputConfirmButton_Click(object sender, EventArgs e) => Play();

        /// <summary>
        /// Wykonuje ruch gracza i akcje z nim związane, zależne od wyniku zgadywania.
        /// </summary>
        public void Play()
        {
            EWordStatus message = inputManager.ApplyInput(txtInput.Text);

            if (message == EWordStatus.BAD_INPUT)
                txtLogs.AppendText("Nieprawidłowy input." + "\n");
            else if (message == EWordStatus.LETTER_USED)
                txtLogs.AppendText("Podana litera została już użyta." + "\n");
            else
            {
                bool wordChanged = inputManager.Word.Guess(txtInput.Text[0]);
                lblWord.Text = inputManager.Word.ShowWord();
                txtUsedLetters.AppendText(txtInput.Text.ToUpper() + " ");

                if (!wordChanged)
                {
                    drawings.Next();
                    pbImages.Image = drawings.getImage();

                    if (drawings.IsEnd())
                    {
                        EndOfGame end = new EndOfGame(false)
                        {
                            Owner = this
                        };
                        Hide();
                        end.ShowDialog();
                        Close();
                    }
                        
                }
                if (inputManager.Word.IsGuessed())
                {
                    EndOfGame end = new EndOfGame(true)
                    {
                        Owner = this
                    };
                    Hide();
                    end.ShowDialog();
                    Close();
                }
            }
            txtInput.Text = "";
        }

        /// <summary>
        /// Zamyka okno gry. Wywoływane przez kliknięcie przycisku "Poddaję się".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGiveUp_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

    }
}
