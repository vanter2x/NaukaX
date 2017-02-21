using System;
using System.Collections;
using System.IO;
using System.Text;

namespace SeeSharpBasics.Training3.Homework.SlawekKowal
{
    public class SlawekKCodeGenerator: CodeGenerator
    {
       public Hashtable BanksList { get; set; } //= new Hashtable();

        public SlawekKCodeGenerator()
        {
            BanksList = new Hashtable();
            var cc = AppDomain.CurrentDomain.BaseDirectory;
            StreamReader str = new StreamReader(AppDomain.CurrentDomain.BaseDirectory +"//banki.txt", Encoding.Default);

            string line = "";
            string[] split = null;
            while (!str.EndOfStream)
            {
                line = str.ReadLine();
                split = line.Split(new[] { " \t" }, StringSplitOptions.None);
                BanksList.Add(split[0],split[1]);
            }
            str.Close();
           
        }


        public override string GetHashmapCode()
        {
            throw new System.NotImplementedException();
        }
    }
}