namespace SeeSharpBasics
{
    public abstract class StringOperations
    {
        protected readonly int whatever;
        protected StringOperations()
        {
            whatever = 1;
        }

        public void test()
        {
            //whatever = 9;
        }

        public abstract string Substring(string candidate, int start, int length); // beatka, 1, 3 => eat ; bartek, 2, 4 => rtek

        public abstract string GetName(); // zwrocic swoje imie i nazwisko

        public abstract string GlueBeginingEnd(string candidate); // bartlomiej  bjaeritmlo

        public abstract int CountOccurences(string candidate, char needle); // bartek, a => 1 beatka, a => 2, aaaaba, a => 5

        public abstract int LetterPositionInString(string candidate, char needle); // bartek, k => 5

        public abstract string LetterReplace(string candidate, char needle, char replace); // beatka, e, s => bsatka ; beatka , a , b => bebtkb

        public abstract string StringReplace(string candidate, string needle, string replace); // bartlomiej, art, beatka => bbeatkalomiej
    }
}