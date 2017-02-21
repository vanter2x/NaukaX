using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using SeeSharpBasics.Training5.Chess;
using SeeSharpBasics.Training6.ExtensionMethods;

namespace SeeSharpBasics.Training6.Generics
{
    public class MyGenerics<T1, T2> where T2 : IDisposable
    {
        private T1[] _items;
        private T2 field;

        public void Test()
        {
            List<int> listaIntow = new List<int>();
            List<string> listaStringow = new List<string>();

            field.Dispose();

            listaIntow.Add(8);
            listaIntow[0] = 9;

            int[] items = listaIntow.ToArray();

            //Hashtable//

            Dictionary<string, Figure> slownikFigurSzachowych = new Dictionary<string, Figure>();

            StreamReader sr = new StreamReader("");

            //sr.Peek()

            slownikFigurSzachowych.Where((m) => (m.Key == "Skoczek"));

            slownikFigurSzachowych.Add("Skoczek", new Knight());
            slownikFigurSzachowych.Add("Krol", new King());
            //slownikFigurSzachowych["krol"].Move()
        }
    }

    public class Test
    {
        public void Generic()
        {
            MyGenerics<string, SqlConnection> test = new MyGenerics<string, SqlConnection>();

            Figure f = new Bishop();

            f.RookMove(8);

            //"".DoSomething();
        }

        public void Generic<T>()
        {
            T whatever ;//= new T();
        }
    }
}