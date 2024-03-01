using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanUI.Repos
{
    /// <summary>
    /// Klasa odpowiadająca za przechowywanie danych o wylosowanym słowie.
    /// </summary>
    public class Word
    {
        /// <summary>
        /// Zawiera wylosowane słowo ukryte przed użytkownikiem.
        /// </summary>
        public char[] HiddenWord { get; private set; }

        /// <summary>
        /// Zawiera wylosowane słowo z zakrytymi nieodgadniętymi literami, do wyświetlenia dla użytkownika.
        /// </summary>
        public char[] WordToShow { get; private set; }

        /// <summary>
        /// Konstruktor parametryczny dla klasy Word.
        /// </summary>
        /// <param name="word">Słowo wylosowane z pliku, które użytkownik będzie odgadywał.</param>
        public Word(string word)
        {
            HiddenWord = word.ToCharArray();
            WordToShow = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
                WordToShow[i] = '_';
        }

        /// <summary>
        /// Sprawdza, czy słowo zostało odgadnięte.
        /// </summary>
        /// <returns>true - gdy słowo zostało odgadnięte, false - wpp.</returns>
        public bool IsGuessed()
        {
            for (int i = 0; i < HiddenWord.Length; i++)
                if (HiddenWord[i] != WordToShow[i])
                    return false;
            return true;
        }

        /// <summary>
        /// Podmienia zakryte znaki na odgadniętą literę, jeżeli taka występuje w słowie i zwraca informację o tym,
        /// czy zostały odkryte jakieś litery.
        /// </summary>
        /// <param name="letter">Litera odgadywana przez użytkownika, która ma zostać odkryta w słowie.</param>
        /// <returns>true - gdy litera znajduje się w słowie co najmniej 1 raz, false - wpp.</returns>
        public bool Guess(char letter)
        {
            int changedCount = 0;

            for (int i = 0; i < HiddenWord.Length; i++)
            {
                if (HiddenWord[i] == letter)
                {
                    changedCount++;
                    WordToShow[i] = letter;
                }
            }

            return changedCount != 0;
        }

        /// <summary>
        /// Zwraca przygotowane do wypisania słowo z odpowiednimi odstępami.
        /// </summary>
        /// <returns>Słowo przygotowane do wypisania dla użytkownika.</returns>
        public string ShowWord()
        {
            string result = "";

            foreach(char letter in WordToShow)
            {
                result += letter + " ";
            }

            return result.Trim(' ');
        }
    }
}
