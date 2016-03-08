using System.Collections;
using System.Linq;

namespace Task2
{
    public class SortJuggedArray{
        public static void BubbleSort(int[][] array, IComparer ic, bool ascending){
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - i - 1; j++){
                    if ((ic.Compare(array[j], array[j + 1]) < 0) == ascending){
                        int[] temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
        }
    }

    public class ComparerMaxSumElement : IComparer{
        public int Compare(object a, object b){
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int[] arr1 = (int[])a;
            int[] arr2 = (int[])b;
            return arr1.Sum().CompareTo(arr2.Sum());
        }
    }

    public class ComparerMaxElement : IComparer{
        public int Compare(object a, object b){
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int[] arr1 = (int[])a;
            int[] arr2 = (int[])b;
            return arr1.Max().CompareTo(arr2.Max());
        }
    }

    public class ComparerMinElement : IComparer{
        public int Compare(object a, object b){
            if (a == null)
                return 1;
            if (b == null)
                return -1;
            int[] arr1 = (int[])a;
            int[] arr2 = (int[])b;
            return arr2.Min().CompareTo(arr1.Min());
        }
    }
}
