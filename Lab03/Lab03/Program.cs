using System;
using System.IO;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int[] array2 = new int[] { 500, 300, 5, 800, 2 };
            string filePath = "../../../words.txt";

            //MultiplyThreeNums();
            //RandomNumber()
            //Ascii();
            //Challenge4(array);
            //Console.WriteLine(Challenge5(array2));
            //Challenge6(filePath);
            //Challenge7(filePath);
            //Challenge8(filePath);
            //Challenge9();

        }
        //public static int MultiplyThreeNums()
        // {


        //     Console.WriteLine("Please Enter Three Numbers Seperated by spaces.");

        //     string[] theString = Console.ReadLine().Split(" ");

        //     int[] blah = new int[input.Length];
        //     for (int i=0; i < input.Length; i++) 
        //     {
        //        blah = Convert.ToInt32(input[i]);
        //     }


        //     int result = blah[0] * input[1] * input[2];
        //     Console.WriteLine($"The product of your three numbers is: {result}");
        //     return result;

        // }

        //     static int RandomNumber()
        //     {
        //         Console.WriteLine("Please enter a number between 2-10.");
        //         int ranNum = Convert.ToInt32(Console.ReadLine());
        //         int[] numArray = new int[ranNum];
        //         for (int i = 0; i < ranNum; i++)
        //         {
        //             Console.WriteLine($"{i + 1} of {ranNum} - Enter a number: ");
        //             numArray[i] = Convert.ToInt32(Console.Read());
        //         }
        //         int sumNum = 0;
        //         int numAvg = 0;
        //         for (int i = 0; i < numArray.Length; i++)
        //         {
        //             sumNum += numArray[i];
        //             numAvg = sumNum / numArray.Length;
        //         }
        //         Console.WriteLine($"The average of these {numArray.Length} numbers is: {numAvg}");
        //         return numAvg;

        //      }

        static void Ascii()
        {
            Console.WriteLine(" " + " " + " " + " " + "*" + " " + " " + " " + " ");
            Console.WriteLine(" " + " " + " " + "*" + "*" + "*" + " " + " " + " ");
            Console.WriteLine(" " + " " + "*" + "*" + "*" + "*" + "*" + " " + " ");
            Console.WriteLine(" " + "*" + "*" + "*" + "*" + "*" + "*" + "*" + " ");
            Console.WriteLine("*" + "*" + "*" + "*" + "*" + "*" + "*" + "*" + "*");
            Console.WriteLine(" " + "*" + "*" + "*" + "*" + "*" + "*" + "*" + " ");
            Console.WriteLine(" " + " " + "*" + "*" + "*" + "*" + "*" + " " + " ");
            Console.WriteLine(" " + " " + " " + "*" + "*" + "*" + " " + " " + " ");
            Console.WriteLine(" " + " " + " " + " " + "*" + " " + " " + " " + " ");
        }


        //static void Challenge4(int[] arr)
        //{
        //    int count = 0;
        //    for(int i=0; i < arr.Length; i++)
        //    {
        //       if( arr[i] == arr[i+1])
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            i++;
        //        }

        //    }

        //}

        public static int Challenge5(int[] arr)
        {
            int ans = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    ans = arr[i];
                }
            }
            return ans;
        }
        public static void Challenge6(string file)
        {
            Console.WriteLine("----- ADD LINES -----");
            string phrase = "is it working?";
            File.AppendAllText(file, "\r\n");
            File.AppendAllText(file, phrase);


        }

        public static void Challenge7(string file)
        {
            Console.WriteLine("----- READ AS STRING -----");
            string myFileContents = File.ReadAllText(file);
            Console.WriteLine(myFileContents);
        }
        public static void Challenge8(string path)
        {

            //Read the info in
            string feedback = File.ReadAllText(path);
            string[] stringArr = feedback.Split("\r\n");
            string[] newArray = new string[stringArr.Length - 1];
            for (int i = 1; i < stringArr.Length; i++)
            {

                newArray[i - 1] = stringArr[i];

            }
            string joined = String.Join("\r\n", newArray);
            File.WriteAllText(path, joined);

            Console.WriteLine(String.Join("\r\n", newArray));
        }
        public static string[] Challenge9()
        {
            Console.WriteLine("add a bunch of words separated by spaces please thanks");
            string preArrayInput = Console.ReadLine();
            string[] splittedInput = preArrayInput.Split(" ");
            string[] theArray = new string[splittedInput.Length];
            for (int i = 0; i < splittedInput.Length; i++)
            {
                theArray[i] = ($"{splittedInput[i]}: {splittedInput[i].Length}");
                Console.WriteLine(theArray[i]);
            }



            return theArray;
        }

        
    }
}
