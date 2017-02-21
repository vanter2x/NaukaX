using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SeeSharpBasics.SlawekKowal;

using SeeSharpBasics.Training4.Db;
using SeeSharpBasics.Training4.minesweeper;

namespace SeeSharpBasics
{
    class Program
    {

        static void Main(string[] args)
        {


          

           // mnswp.Show(mnswp.BombsCount(10, 20, 10));

            //PostgresqlDbClient client = new PostgresqlDbClient();

            //client.Insert("insert into toci ( name, surname,telephone) values ( 'tomasz', 'kowalski', '5551122')");
            //client.Insert("insert into toci ( name, surname,telephone) values ( 'bartek', 'zapart', '5551122')");

            //client.Select("select * from toci;");

            /*
             * komentarz blokowy
            
            int liczbaCalkowita = 8;
            string zmiennaTextowa = "text w zmiennej textowej";
            int a8sd = 9;
            char literka = 'a';

            int position = LetterPosition("beatka", 'k');
            
            ReverseString("beatka");

            liczbaCalkowita = 8 + 7;

            double zmiennaZmiennoprezcinkowa = 2.45 + liczbaCalkowita; // - * / + ++ -- += -= *= /=

            liczbaCalkowita--;

            liczbaCalkowita = liczbaCalkowita / 5;
            liczbaCalkowita *= 5;

            zmiennaZmiennoprezcinkowa = (int)zmiennaZmiennoprezcinkowa;

            bool zmiennaLogiczna = liczbaCalkowita == 10; //false
            string[] listaImion = new string[15];

            listaImion[0] = "beatka";
            listaImion[1] = "bartlomiej";
            listaImion[9] = "bartlomiej";
            listaImion[10] = "bartlomiej";

            BartekZapartStringOperations strOp = new BartekZapartStringOperations();

            //*************************************
            //string strOlek = new strOlek("");
            //OlekStringOperations strOlek = new OlekStringOperations();
            //strOlek.Substring();
            TomaszKilianStringOperations stro = new TomaszKilianStringOperations();
            TomaszKilianTableOperations stras = new TomaszKilianTableOperations();
            KarolZarebaStringOperations gras = new KarolZarebaStringOperations();


            int pozycja = gras.LetterPositionInString("bartlomiej", 'r');
            string wezimie = gras.GetName();
            string jazda = gras.Substring("bartlomiej",0, 3);
            string wynik = stro.Substring("beatka", 1, 3);
           int wynik4 = stro.CountOccurences("beatka", 'a');
            Console.WriteLine("TUTAJ JEST WYNIKKK{0}", wynik4);
            int wynik5 = stro.LetterPositionInString("bartek", 'k');
            Console.WriteLine("wynik5");

            Console.WriteLine("pozycja");
           string wynik6 = stro.LetterReplace("aaaaaabbbbbccccc", 'a', 's');
            
            Console.WriteLine(wynik6);
           //string wynik7 = stro.StringReplace("bbaabbaaaacccc", "aaaa", "zzzz");
          //Console.WriteLine("wynik stringreplace@@@@@@@@@@@ {0}",wynik7);

            string metoda = gras.GlueBeginingEnd("bartlomiej");
            Console.WriteLine("Tu wynik kleju, {0}", metoda);

            if (wezimie == "KarolZareba")
            {
                Console.WriteLine("działa z imieniem");
            }
            else
            {
                Console.WriteLine("nie działa z imieniem");
            }
            if (jazda == "bart")
            {
                Console.WriteLine("dziala");

            }
            else
            {
                Console.WriteLine("dupa");
            }

            string wynik2 = stro.GlueBeginingEnd("beatka");
                Console.WriteLine("TUTTAJJJJ JEST TEN WYNIK!!!{0}",wynik2);

            OlekStringOperations strOpOlek = new OlekStringOperations();

            string result = strOpOlek.Substring("beatka", 1, 3);
            if (result == "eat")
            {
                Console.WriteLine("dziala");
            }

            result = strOpOlek.Substring("bartek", 2, 4);
            if (result == "rtek")
            {
                Console.WriteLine("dziala");
            }
            //*************************************


            result = strOp.Substring("beatka", 1, 3);
            if (result == "eat")
            {
                Console.WriteLine("dziala");
            }

            //wczytywac do tablicy imion w forze elementy

            for (int i = 0; i < listaImion.Length; i++)
            {
                Console.WriteLine("Podaj imie dla index {0}", i);
                //listaImion[i] = Console.ReadLine();
            }

            foreach (string imie in listaImion)
            {
                Console.WriteLine("Imiona w foreachu: {0}", imie);
            }

            zmiennaLogiczna = zmiennaZmiennoprezcinkowa > liczbaCalkowita; // >= <= > < == 

            Console.WriteLine("Liczba calkowita, zmienna liczbaCalkowita rowna sie {0} {1}", liczbaCalkowita, zmiennaTextowa);
            liczbaCalkowita = 9;

            if (liczbaCalkowita > 9) //false
            {
                Console.WriteLine("jestesmy w if");

                if (zmiennaLogiczna)
                {

                }
            }
            else if (liczbaCalkowita < 8)
            {
                Console.WriteLine("jestesmy w else if");
            }
            else
            {
                
            }

            Console.WriteLine("Podaj imie zenskie: ");
            string text = Console.ReadLine();

            Console.WriteLine("Wprowadziles: {0}", text);
            */
            Console.ReadLine();
        }
                                      // beatka          e
        public static int LetterPosition(string candidate, char needle) // beatka, e => 1
        {
               // deklaracje zmiennych
                                // awrunek zakonczenia dzialania petli
                                       // operacje po kazdym obejsciu petli
            for (int i = 0, j = 9; i < j || j == 4; i++, j--) // 4 czy 5 ? && AND || OR
            {
                Console.WriteLine("Wartosc i = {0}, j = {1}", i, j);
            }
            
            for (int i = 0; i < candidate.Length; i++)
            {
                Console.WriteLine("Zawartosc indexu i: {0}  wartosc: {1}", i, candidate[i]);

                if (candidate[i] == needle)
                {
                    return i;
                }
            }
            

            return -1;
        }
        
        
        
        public static string ReverseString(string candidate)
        {
            // candidate = beatka aktaeb
            string result = "";
            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                
                // a k t a e b 
                result = result + candidate[i];

                Console.WriteLine("Znaczek dla i: {0}, result : {1}", candidate[i], result); //a
            }

            return result;
            
        }
    }
}
