using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HangmanUI.Repos
{
    /// <summary>
    /// Klasa odpowiadająca za przechowywanie obrazków wisielca do wyświetlania w trakcie gry.
    /// </summary>
    public class Drawing
    {
        /// <summary>
        /// Indeks dla listy, w której przechowywane są obrazki, będące reprezentacją kolejnych stanów rysunku wisielca.
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        /// Lista, w której przechowywane są obrazki, będące reprezentacją kolejnych stanów rysunku wisielca.
        /// </summary>
        private readonly List<Image> images;

        /// <summary>
        /// Konstruktor parametryczny dla klasy Drawing.
        /// </summary>
        /// <param name="folderPath">Ścieżka do folderu, w którym znajdują się pliki - obrazki wisielca.</param>
        public Drawing(string folderPath, int howMany)
        {
            images = new List<Image>();

            for (int i=0; i<howMany; i++)
            {
                try
                {
                    // nazwy wszystkich obrazków w folderze (o ile program uruchomiono zgodnie z instrukcją)
                    // to kolejne liczby naturalne
                    Image loadedImage = Image.FromFile($"{folderPath}{i}.png");
                    images.Add(loadedImage);
                }    
                catch (System.IO.FileNotFoundException) { continue; }
                catch (ArgumentException) { continue; }
            }
        }

        /// <summary>
        /// Konstruktor domyślny dla klasy Drawing.
        /// </summary>
        public Drawing() : this("Images/", 12) { }

        /// <summary>
        /// Zwiększa indeks dla listy obrazków.
        /// </summary>
        public void Next() => Index++;

        /// <summary>
        /// Sprawdza, czy zostały jeszcze niewykorzystane obrazki w liście obrazków.
        /// </summary>
        /// <returns>true - gdy nie ma więcej obrazków, false - wpp.</returns>
        public bool IsEnd() => Index == images.Count - 1;

        /// <summary>
        /// Zwraca obrazek, na który obecnie wskazuje indeks listy obrazków.
        /// </summary>
        /// <returns>Obrazek z listy, na który wskazuje indeks.</returns>
        public Image getImage() => images[Index];
    }
}
    