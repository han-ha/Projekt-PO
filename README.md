### Instrukcja uruchomienia

1. Aby zapoznać się z dokumentacją, wystarczy otworzyć dowolny plik ``*.html`` z folderu ``Dokumentacja``, następnie wybrać odpowiedni odnośnik do opisu klas, plików itp. Dokumentacja została wygenerowana przy pomocy programu **Doxygen**.
2. Aby przygotować aplikację do uruchomienia, należy wybrać opcję ``Build solution`` z ustawieniem ``Debug``, a przed uruchomieniem - upewnić się, że w ``Hangman\bin\Debug`` znajdują się:
    - folder Images z 12 plikami ``*.png`` numerowanymi od 0 do 11 włącznie,
    - folder Result z plikami ``0.png`` i ``1.png``,
    - plik hangman_data.txt.
3. Aby uruchomić aplikację, należy odnaleźć plik ``HangmanUI.exe`` w ``Hangman\bin\Debug``, a następnie go otworzyć (można także uruchomić aplikację z poziomu VS Community).

### Przydatne informacje

Projekt został wykonany w **Visual Studio Community 2022 (.NET 6.0)** w języku **C#**. W razie potrzeby można w kroku 2. wybrać opcję ``Release`` i umieścić foldery ``Images`` oraz ``Result`` w ``Hangman\bin\Release``, a w kroku 3. odszukać plik ``HangmanUI.exe`` w ``Hangman\bin\Release``.