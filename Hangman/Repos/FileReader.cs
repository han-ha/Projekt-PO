using System;

namespace HangmanUI.Repos
{
    /// <summary>
    /// Klasa odpowiadająca za odczytywanie danych z pliku.
    /// </summary>
    public class FileReader
    {
        /// <summary>
        /// Tablica słów odczytanych z pliku.
        /// </summary>
        private string[] lines;

        /// <summary>
        /// Konstruktor parametryczny dla klasy FileReader.
        /// </summary>
        /// <param name="path">Ścieżka do pliku ze słowami do losowania.</param>
        public FileReader(string path)
        {
            try
            {
                lines = System.IO.File.ReadAllLines(path);
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }
            catch(ArgumentException)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }            
        }

        /// <summary>
        /// Losuje słowo z tablicy słów odczytanych z pliku.
        /// </summary>
        /// <returns>Losowe słowo z tablicy.</returns>
        public string ChooseRandomWord() => lines[new Random().Next(lines.Length)];
    }
}
