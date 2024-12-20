namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 :  Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.WriteLine("Enter the size of the identity matrix (n):");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++) {
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine("\n");
            //}

            #endregion

            #region Q2: Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++) {

            //    sum += arr[i];

            //}

            //Console.WriteLine($"Sum of all elements of the array: {sum}");

            #endregion

            #region Q3: Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            int[] arr1 = { 9, 2, 4, 8, 22 };
            int[] arr2 = { 6, 9, 8, 12, 110 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr3.Length; i++)
            {
                if (i < arr1.Length)
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    arr3[i] = arr2[i - arr1.Length];
                }
            }

            Array.Sort(arr3);

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            #endregion
        }
    }
}
