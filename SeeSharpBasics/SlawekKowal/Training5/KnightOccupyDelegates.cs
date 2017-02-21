using System;

namespace SeeSharpBasics.SlawekKowal.Training5
{
    public class KnightOccupyDelegates
    {
        public Func<int,int> XDelegate { get; set; }
        public Func<int, int> YDelegate { get; set; }
        public Func<int, int, bool> BoolDelegate { get; set; }
    }
}