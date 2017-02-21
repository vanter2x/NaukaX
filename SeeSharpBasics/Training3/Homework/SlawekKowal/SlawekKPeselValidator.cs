using System.Linq;

namespace SeeSharpBasics.Training3.Homework.SlawekKowal
{
    public class SlawekKPeselValidator: PeselValidator
    {
        
        public override bool IsPeselValid(string peselCandidate)
        {
            if (peselCandidate.Length != 11) return false;
            int[] pslNbrs = new int[peselCandidate.Length]; //tablica cyfr z numery PESEL
            int[] chckNmbrs = new int[] {1,3,7,9,1,3,7,9,1,3};//1×a + 3×b + 7×c + 9×d + 1×e + 3×f + 7×g + 9×h + 1×i + 3×j
            int result = 0;
            // wycinanie roku,miesiąca i dnia
            string year = peselCandidate.Substring(0,2); 
            string month = peselCandidate.Substring(2, 2);
            string day = peselCandidate.Substring(4, 2);

            for (int i = 0; i < pslNbrs.Length; i++) // sprawdzam liczbę kontrolną
            {
                pslNbrs[i] = int.Parse(peselCandidate[i].ToString());
                if (i < pslNbrs.Length - 1) result += pslNbrs[i] * chckNmbrs[i];
            }

            result = result%10; // rzultat mnozenia mod 10
            // dwie możliwości wystąpienia poprawnego PESELU
            if((result==0 && pslNbrs[pslNbrs.Length-1] == 0) && (IsPeselDateValid(year, month, day))) return true;
            if ((result != 0 && pslNbrs[pslNbrs.Length - 1] == 10-result) && (IsPeselDateValid(year, month, day))) return true;
            
            return false;
        }

        protected override bool IsPeselDateValid(string year, string month, string day) //88-08-08
        {
            //zamiana string na int oraz sprawdzenie poprawności daty.
            int  intYear = GetYear(int.Parse(year), int.Parse(month));
            int  intMonth = GetMonth(int.Parse(month));
            int  intDay = int.Parse(day);
            if (CheckDays(intYear, intMonth, intDay) && ChechMonth(intMonth)) return true;
            return false;
        }
        // poprawność miesiąca
        public bool ChechMonth(int month)
        {
            if (month > 0 && month < 13) return true;
            return false;
        }
        // zwraca rok w zależności od postaci miesiąca()
        public int GetYear(int year, int month)
        {
            if (month > 0 && month < 13)  return 1900 + year;
            if (month > 20 && month < 33)  return 2000 + year;
            if (month > 40 && month < 53)  return 2100 + year;
            if (month > 60 && month < 73)  return 2200 + year;
            if (month > 80 && month < 93)  return 1800 + year;
            return -1;
        }
        // zwraca miesiąc w zależności od jego postaci 
        public int GetMonth(int month)
        {
            if (month > 0 && month < 13) return month;
            if (month > 20 && month < 33) return month - 20;
            if (month > 40 && month < 53) return month - 40;
            if (month > 60 && month < 73) return month - 60;
            if (month > 80 && month < 93) return month - 80;
            return -1;
        }

        //sprawdza czy rok jest przestępny
        public bool IsLeapYear(int year)
        {
            if ((year%4 == 0 && year%100 != 0) || year%400 == 0) return true;
            return false;
        }

        //sprawdza poprawność dni
        public bool CheckDays(int year, int month, int day)
        {
            
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (day > 0 && day < 32) return true;
                    break;
                case 4: case 6: case 9: case 11:
                    if (day > 0 && day < 31) return true;
                    break;
                case 2:
                    if ((IsLeapYear(year) && day > 0 && day < 30) || (day > 0 && day < 29 && !IsLeapYear(year)))
                        return true; 
                    break;
            }
            return false;
        }
    }
}