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

            //int[] arr1 = { 9, 2, 4, 8, 22 };
            //int[] arr2 = { 6, 9, 8, 12, 110 };
            //int[] arr3 = new int[arr1.Length + arr2.Length];

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    if (i < arr1.Length)
            //    {
            //        arr3[i] = arr1[i];
            //    }
            //    else
            //    {
            //        arr3[i] = arr2[i - arr1.Length];
            //    }
            //}

            //Array.Sort(arr3);

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}

            #endregion

            #region Q4: Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 1, 5, 7, 1 };
            //int count = 0;
            //int[] sorted = new int[arr.Length];
            //sorted = arr;
            //Array.Sort(sorted);

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (sorted[i] == sorted[i + 1])
            //    {
            //        count++;
            //    }
            //    else {
            //        Console.WriteLine($"Number {sorted[i]} is repeated {count + 1} times");
            //        count = 0;
            //    }

            //}

            #endregion

            #region Q5: Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 1, 5, 7, 1 };

            //int max = -999999999;
            //int min = 999999999;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (max < arr[i]) {
            //        max = arr[i];
            //    }
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"Max = {max}\nMin ={min}");

            #endregion

            #region Q6: Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 12, 35, 1, 10, 34, 1 ,55};

            //Array.Sort(arr);
            //Array.Reverse(arr);

            //int largest = arr[0];
            //int secondLargest = -99999999;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < largest)
            //    {
            //        secondLargest = arr[i];
            //        break;
            //    }
            //}


            //    Console.WriteLine("The second largest element is: " + secondLargest);


            #endregion

            #region Q7: write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the elements of the array:");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);

            #endregion

            #region Q8: Given a list of space separated words, reverse the order of the words.

            //Console.WriteLine("Enter the sentence you want to reverse: ");
            //string str = Console.ReadLine();

            //string[] arr = str.Split(' ');

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            #endregion

            #region Q9: Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.


            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter value for arr1[{i},{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //Console.WriteLine("\nThe second array is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Q10: Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            #endregion

            #region Q11: Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //In C#, pass by value creates a copy of the variable and does not affect the original
            //while pass by reference passes the actual reference[location], so changes inside the method affect the original variable

            //int a = 10;
            //Console.WriteLine("Before pass by value: " + a);
            //Dummy1(a);
            //Console.WriteLine("After pass by value: " + a); // a remains the same

            //int b = 20;
            //Console.WriteLine("Before pass by reference: " + b);
            //Dummy2(ref b);
            //Console.WriteLine("After pass by reference: " + b); // b changes

            #endregion

            #region Q12: Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = SumOfDigits(number);

            //Console.WriteLine("The sum of the digits of the number " + number + " is: " + sum);

            #endregion

            #region Q13: Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (IsPrime(number))
            //{
            //    Console.WriteLine(number + " is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is not a prime number.");
            //}

            #endregion

            #region Q14:   Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //long result = Factorial(number);
            //Console.WriteLine("The factorial of " + number + " is: " + result);

            #endregion

            #region Q15:  Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter .

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position of the character to change: ");
            //int position = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = char.Parse(Console.ReadLine());

            //string result = ChangeChar(input, position, newChar);
            //Console.WriteLine("Modified string: " + result);

            #endregion

        }

        static void Dummy1(int x) { 
            x = 50; 
        }
        static void Dummy2(ref int y) {
            y = 100; 
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static int Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i; // Multiply the result by each number from 1 to num
            }
            return result;
        }

        static string ChangeChar(string str, int pos, char newChar)
        {
            if (pos < 0 || pos >= str.Length)
            {
                return "Invalid position!";
            }

            char[] charArray = str.ToCharArray();

            charArray[pos] = newChar;

            return new string(charArray);
        }

    }
}
