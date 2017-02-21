using System.Collections;

namespace SeeSharpBasics.Training3.Homework
{
    public class BartekZapartMoneyValue : MoneyValue
    {
        private Hashtable Digits = new Hashtable
        {
            { 1, "jeden" },
            { 2, "dwa" },
            { 3, "trzy" },
        };

        public override string GetMoneyValue(string money)
        {
            return string.Empty;
        }
    }
}