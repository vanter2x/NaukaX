

namespace SeeSharpBasics.SlawekKowal
{
    public class SlawekKTableOperations
    {
        public int[] BubbleSort(int[] tableToSort)
        {
            for (int i = 0; i < tableToSort.Length; i++)
            {
                for (int j = 0; j < tableToSort.Length - 1; j++)
                {
                    int tempInt;
                    if (tableToSort[j] > tableToSort[j + 1])
                    {
                        tempInt = tableToSort[j];
                        tableToSort[j] = tableToSort[j + 1];
                        tableToSort[j + 1] = tempInt;
                    }
                }

            }
            return tableToSort;
        }
    }
}