namespace HangmanUI.Repos
{
    /// <summary>
    /// Klasa odpowiadająca za operacje na inpucie.
    /// </summary>
    public class InputManager
    {
        /// <summary>
        /// Obiekt odpowiadający za słowo, które należy odgadnąć.
        /// </summary>
        public Word Word { get; private set; }
        /// <summary>
        /// Obiekt odpowiadający za sprawdzanie użycia liter.
        /// </summary>
        public WordChecker WordChecker { get; private set; }

        /// <summary>
        /// Enumerator dla komunikatów zwrotnych o przebiegu ruchu gracza (niepoprawne wejście,
        /// litera została wcześniej użyta lub litera zostaje wykorzystana).
        /// </summary>
        public enum EWordStatus { BAD_INPUT, LETTER_USED, LETTER_GIVEN };

        /// <summary>
        /// Konstruktor parametryczny dla klasy InputManager.
        /// </summary>
        /// <param name="path">Ścieżka do pliku ze słowami do losowania.</param>
        public InputManager(string path)
        {
            FileReader fReader = new FileReader(path);
            Word = new Word(fReader.ChooseRandomWord());
            WordChecker = new WordChecker();
        }

        /// <summary>
        /// Sprawdza, czy podane wejście spełnia warunki gry (jest długości 1, jest literą).
        /// </summary>
        /// <param name="inputString">Wejście do sprawdzenia.</param>
        /// <returns>true - gdy wejście spełnia warunki, false - wpp.</returns>
        public bool IsGoodInput(string inputString)
        {
            if (inputString.Length != 1)
                return false;

            char input = inputString.ToLower()[0];
            bool result = (input <= 'z' && input >= 'a');
            return result;
        }

        /// <summary>
        /// Wykonuje ruch gracza i zwraca komunikat o przebiegu ruchu gracza.
        /// </summary>
        /// <param name="inputString">Input do sprawdzenia.</param>
        /// <returns>Komunikat o przebiegu wykonania ruchu.</returns>
        public EWordStatus ApplyInput(string inputString)
        {           
            if (!IsGoodInput(inputString))
                return EWordStatus.BAD_INPUT;

            char letter = inputString.ToLower()[0];
            if (WordChecker.IsUsed(letter))
                return EWordStatus.LETTER_USED;

            WordChecker.Use(letter);
            return EWordStatus.LETTER_GIVEN;
        }        
    }
}
