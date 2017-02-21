using System;
using NpgsqlTypes;
using SeeSharpBasics.Training5.Chess;


namespace SeeSharpBasics.Training6.ExtensionMethods
{
    public static class Extensions
    {
        public static bool RookMove(this Figure obj, int srcX)
        {
            //obj.Move()
            return true;
        }

        public static T DoSomething<T>(this T obj) where T : Bishop, IDisposable
        {
            //obj.RookMove()
            return default(T);
        }
    }
}