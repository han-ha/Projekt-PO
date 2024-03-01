using System.Collections.Generic;


namespace HangmanUI.Repos
{
    /// <summary>
    /// Klasa odpowiadająca za przechowywanie informacji o użyciu liter w zgadywanym słowie.
    /// </summary>
    public class WordChecker
    {
        /// <summary>
        /// Lista zawierająca użyte litery.
        /// </summary
        private List<char> usedLetters;

        /// <summary>
        /// Konstruktor domyślny dla klasy WordChecker.
        /// </summary>
        public WordChecker() => usedLetters = new List<char>();

        /// <summary>
        /// Sprawdza, czy podana litera została użyta.
        /// </summary>
        /// <param name="letter">Litera, dla której chcemy sprawdzić, czy została wykorzystana.</param>
        /// <returns>true - gdy podana litera została już wykorzystana (niezależnie od jej wystąpienia w słowie),
        /// false - wpp.</returns>
        public bool IsUsed(char letter) => usedLetters.Contains(letter);

        /// <summary>
        /// Zaznacza użycie podanej litery.
        /// </summary>
        /// <param name="letter">Litera, której użycie chcemy zaznaczyć.</param>
        public void Use(char letter) => usedLetters.Add(letter);
    }
}
