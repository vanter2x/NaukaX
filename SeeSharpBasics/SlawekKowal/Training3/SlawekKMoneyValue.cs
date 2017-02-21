using System.Collections;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.SlawekKowal.Training3
{
    public class SlawekKMoneyValue : MoneyValue
    {
        private Hashtable _digit = new Hashtable()
        {
            { 0, "" },
            { 1,"jeden "},
            { 2,"dwa " },
            { 3,"trzy " },
            { 4,"cztery " },
            { 5,"pięć " },
            { 6,"sześć " },
            { 7,"siedem " },
            { 8,"osiem " },
            { 9,"dziewięć " }
            //{ 0, "zero" },
          };

        private Hashtable _teens = new Hashtable
        {   { 0, "" },
            { 1,"jedenaście " },
            { 2,"dwanaście " },
            { 3,"trzynaście " },
            { 4,"czternaście " },
            { 5,"piętnaście " },
            { 6,"szesnaście " },
            { 7,"siedemnaście " },
            { 8,"osiemnaście " },
            { 9,"dziewiętnaście " }
           // { 0,"zero" },
          };

        private Hashtable _dozens = new Hashtable
        {
            { 0, "" },
            { 1,"dziesięć " },
            { 2,"dwadzieścia " },
            { 3,"trzydzieści " },
            { 4,"czterdzieści " },
            { 5,"pięćdziesiąt " },
            { 6,"sześćdziesiąt " },
            { 7,"siedemdziesiąt " },
            { 8,"osiemdziesiąt " },
            { 9,"dziewięćdziesiąt " }
           // { 0,"zero" },
          };

        private Hashtable _hundreds = new Hashtable
        {
            { 0, "" },
            { 1,"sto "},
            { 2,"dwieście " },
            { 3,"trzysta " },
            { 4,"czterysta " },
            { 5,"pięćset " },
            { 6,"sześćset " },
            { 7,"siedemset " },
            { 8,"osiemset " },
            { 9,"dziewięćset " }
           // { 0,"zero" },
         };

        private Hashtable _ender = new Hashtable
        {
            { 0,""},
            { 1,"tysiąc "},
            { 2,"tysiące " },
            { 3,"tysięcy " },
            { 4,"milion "},
            { 5,"miliony " },
            { 6,"milionów " }
        };
        int units = 0;
        int dozen = 0;
        int hundreds = 0;
        int teens = 0;
        private int loop = 0;
        private int ender = 0;

        public override string GetMoneyValue(string money)
        {
            int number = int.Parse(money);
            string result = "";
            if (number == 0) return "zero";

            while (number != 0)
            {
                hundreds = number % 1000 / 100;
                dozen = number % 100 / 10;
                units = number % 10;
                teens = 0;

                if (dozen == 1 && units > 0)
                {
                    teens = dozen;
                    dozen = 0;
                    units = 0;
                }
                if (units == 1 & hundreds + dozen + teens == 0)
                {
                    if (loop > 0) ender = (loop == 1) ? 1 : 4;
                }
                else if (units >= 2 && units <= 4)
                {
                    if (loop > 0) ender = (loop == 1) ? 2 : 5;
                }

                else
                {
                    if (loop > 0) ender = (loop == 1) ? 3 : 6;
                }

                if (hundreds + dozen + teens + units > 0)
                {
                    result = _hundreds[(int)hundreds].ToString() + _dozens[(int)dozen] + _teens[(int)teens]
                    + _digit[(int)units] + _ender[(int)ender] + result;
                }
                number = number / 1000;
                loop++;
            }

            //MessageBox.Show(result);
            return result;
        }





    }
}