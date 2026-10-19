namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Task 1");
            DrawSquare(']', 4);
            #endregion task1


            #region task2
            Console.WriteLine("Task 2");
            Console.WriteLine(isPolindrom(12331));
            #endregion task2


            #region task3
            Console.WriteLine("Task 3");
            //          |||
            // function |||
            //          vvv
            #endregion task3
        }
        static void DrawSquare(char _s, int width)
        {
            string s = _s.ToString();
            s += s; // for perfect square
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }

        static bool isPolindrom(long num)
        {
            string s = num.ToString();
            for (int i = 0; i < s.Length/2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) { return false; }
            }
            return true;
        }

        static void Filter(ref int[] array, int[] filt)
        {
            int[] fArr = new int[array.Length];
            int size = 0;
            foreach (int i in array)
            {
                bool k = true;
                foreach (int j in filt)
                {
                    if (i == j) { k = false; break; }
                }
                if (k)
                {
                    fArr[size] = i;
                    size++;
                }
            }
            int[] fArr_temp = new int[size];
            for (int i = 0; i < size; i++)
            {
                fArr_temp[i] = fArr[i];
            }
            array = fArr_temp;
        }
    }
}
