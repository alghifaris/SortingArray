using System;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Array");
            Console.Write("Array Length = ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            Console.Write("Input " + length + " elements in the array :\n");
            for (int i = 0; i < length; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(arr);
            }
        }


        private static bool MainMenu(int[] arr)
        {

            Console.WriteLine("Menu:");
            Console.WriteLine("1 Terkecil");
            Console.WriteLine("2 Terbesar");
            Console.WriteLine("3 Exit ");
            Console.Write("\r\nPilih Menu: ");
            string baa = Console.ReadLine();
            Console.Write("\n");
            int temp;
            switch (baa)
            {
                case "1":
                    // traverse 0 to array length

                    for (int i = 0; i < arr.Length - 1; i++)

                        // traverse i+1 to array length
                        for (int j = i + 1; j < arr.Length; j++)

                            // compare array element with 
                            // all next element
                            if (arr[i] > arr[j])
                            {

                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }

                    // print all element of array
                    Console.Write("Hasil Terkecil = ");
                    foreach (int value in arr)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine("\n");
                    return true;
                case "2":

                    // traverse 0 to array length
                    for (int i = 0; i < arr.Length - 1; i++)

                        // traverse i+1 to array length
                        for (int j = i + 1; j < arr.Length; j++)

                            // compare array element with 
                            // all next element
                            if (arr[i] < arr[j])
                            {

                                temp = arr[i];
                                arr[i] = arr[j];
                                arr[j] = temp;
                            }

                    // print all element of array
                    Console.Write("Hasil Terbesar = ");
                    foreach (int value in arr)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine("\n");
                    return true;
                case "3":
                    return false;
                default:
                    Console.WriteLine("Menu tidak ada");
                    Console.WriteLine("");
                    return true;
            }
        }

    }
}