namespace SeeSharpBasics.Training3.Hashmaps
{
    public class MultiDimensionalTables
    {
        private int[,] table = new int[8,8]; //tablica 2 wymiarowa
        private int[,,] threedimensions = new int[3,3,3];

        private int[][] tableOfTables = new int[8][];
        //
        // 1 4 4 3
        // 2 5 3 4 2
        // 3 3 1

        public void Test()
        {
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table.GetLength(i); j++)
                {
                    table[i, j] = 4;
                }
            }
        }

        public void Test2()
        {
            for (int i = 0; i < tableOfTables.Length; i++)
            {
                tableOfTables[i] = new int[i];
                tableOfTables[0][1] = 2;
            }
        }
    }
}