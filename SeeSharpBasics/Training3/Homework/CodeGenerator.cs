using System;
using System.IO;

namespace SeeSharpBasics.Training3.Homework
{
    public abstract class CodeGenerator
    {
        //D:\Dropbox\szkolenie\v 2.0\toci sparrows\3\homework\banki.txt 
        public abstract string GetHashmapCode();
        // otworzyc plik, pobrac linijki dla poszczegolnych banbkow, wygenerowac linijke kodu hastbale.add(nr kodu, nazwa banku);

        protected virtual void OpenFile()
        {
            StreamReader str = new StreamReader(@"D:\Dropbox\szkolenie\v 2.0\toci sparrows\3\homework\banki.txt");

            string line = str.ReadLine();

            string[] split = line.Split(new[] {" \t"}, StringSplitOptions.None);

            //split[0] -> code split[1] -> bank name

            StreamWriter wtr = new StreamWriter("");

            wtr.WriteLine();
        }
    }
}