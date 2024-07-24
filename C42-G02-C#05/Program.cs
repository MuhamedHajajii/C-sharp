using System.Text;

namespace C42_G02_C_05
{
    internal class DataQ3
    {
        public int Sum { get; set; }
        public int Sup { get; set; }
    }


    internal class Program
    {
        static void Main()
        {
            #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // Passing Value Type By Value 
            //int a = 10, b = 20;

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");
            //Swap(a,b);
            //Console.WriteLine("==========================");
            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");

            //static void Swap(int A, int B)
            //{
            //    int Temp = A;
            //    A = B;
            //    B = Temp;

            //}

            /*
            // In this case nothing will happen for the original value because i only send the value of it 
            // ot instance for the value 
            // 1- Clr Create a stack frame for the main function 
            // 2- Allocate The Local Variables a,b
            // 3- Call The Console.write Function() Then Remove it
            // 4- Call The Swap Function in a new stack frame and allocate the parameters and the local variables
            // end the logic of the block of code then remove it nothing will affecet the original value */

            //int a = 10, b = 20;

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");
            //Swap(ref a,ref b);
            //Console.WriteLine("==========================");
            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");

            //static void Swap(ref int A,ref int B)
            //{
            //    int Temp = A;
            //    A = B;
            //    B = Temp;

            //}

            /*
             * In This Case Passing The parameter with reference
             * 1- The Clr Will Call The main Function And allocate the local variables and call the console.write and remove the stackframe
             * 2- call the swap function but this time will not allocate the params in the stack frame of it because it passing by the reference
             * 3- will just change it name for the original name of it and because this behave will change the original value  os swap now 
             * works with the variables
             * **/


            #endregion

            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            ///** First Passing The Reference Type By The Value
            // * 1- Delcaler a Reference From Type Array
            // * 2- it will allocate the requierd bytes in the heap then assign it with the defult value then call the user constructor function if exsist
            // * then assign the object to the address
            // * 3- Clr When init the stack frame of the GetSum Will Allocate the parameter Arr with the value which will be the same address of the Numbers
            // * 4- So when try to Make any modification on the address both of them will effected
            // */

            ///** Second Passing The Reference Type By The Value
            // * 1- Delcaler a Reference From Type Array
            // * 2- it will allocate the requierd bytes in the heap then assign it with the defult value then call the user constructor function if exsist
            // * then assign the object to the address
            // * 3- Clr When init the stack frame of the GetSum Will Allocate the parameter Arr with the value which will be the same object 
            // * 4- So when try to Make any modification on the address both of them will effected
            // */

            //// Declare The Reference And Allcoate it in the Heap And The Address In the Stack
            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //// Print The Value Of The Reference Of index[0] Before Edit It Value
            //Console.WriteLine(Numbers[0]);

            //// receive The return in a variable
            //int result = GetSum(Numbers);

            //// Print The Total
            //Console.WriteLine(result);

            //// Print The Value Of The Reference Of index[0] After Edit The Value 
            //Console.WriteLine(Numbers[0]);


            //static int GetSum(int[] Arr){
            //    int Total = 0 ;
            //    Arr[0] = 100;
            //    foreach(int i in Arr) Total += i ;

            //    return Total ;
            //}

            //// Declare The Reference And Allcoate it in the Heap And The Address In the Stack
            //int[] Numbers02 = { 1, 2, 3, 4, 5 };

            //// Print The Value Of The Reference Of index[0] Before Edit It Value
            //Console.WriteLine(Numbers[0]);

            //// receive The return in a variable
            //int result2 = GetSum2(ref Numbers);

            //// Print The Total
            //Console.WriteLine(result);

            //// Print The Value Of The Reference Of index[0] After Edit The Value 
            //Console.WriteLine(Numbers[0]);


            //static int GetSum2(ref int[] Arr)
            //{
            //    int Total = 0;
            //    Arr[0] = 100;
            //    foreach (int i in Arr) Total += i;

            //    return Total;
            //}

            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //        Console.WriteLine("Please Enter 4 Values To Make The Operation On Them:");
            //        int[] Numbers = new int[4];
            //        Console.WriteLine("======================================");

            //        for (int i = 0; i < Numbers.Length; i++)
            //            Numbers[i] = getValidInput();


            //        DataQ3 dataQ3 = GetSumSup(Numbers);

            //        Console.WriteLine("======================================");
            //        Console.WriteLine($"The Summition = {dataQ3.Sum}");
            //        Console.WriteLine($"The Subtracting = {dataQ3.Sup}");
            //        Console.WriteLine("======================================");

            //        /** Hanlde The Summation And subtracting */
            //        static DataQ3 GetSumSup(int[] Arr)
            //        {
            //            int Sum = Arr[0] + Arr[1];
            //            int Sup = Arr[2] - Arr[3];

            //            return new DataQ3 {Sum = Sum, Sup = Sup } ;
            //}


            //        /** Handle Get Valid Integer From The User */
            //        static int getValidInput()
            //        {
            //            Console.Write("Enter Number: ");
            //            string input = Console.ReadLine() ?? "";
            //            while (true)
            //            {
            //                if (int.TryParse(input,out int Number))
            //                return Number;
            //            else
            //            {

            //                    Console.Write("Please Enter A Valid Number:");
            //                    input = Console.ReadLine() ?? "";
            //                }
            //            }
            //        }


            #endregion

            #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            /**
             *  Output should be like 
             *  Enter a number: 25                                                                                            
             *  The sum of the digits of the number 25 is: 7
             */

            //Console.Write("Please Enter A Valid Number To Get The Individual Digits: ");
            //int Input = GetValidNumber();

            //CalcIndividualDigits(Input);

            ///** Handle Calc The Individual Digits */
            //static void CalcIndividualDigits(int Num)
            //{
            //    int IndividualDigits = 0;
            //    while (Num != 0)
            //    {
            //        IndividualDigits += Num % 10;
            //        Num /= 10;
            //    }
            //    Console.WriteLine(IndividualDigits);

            //}

            ///** Handle Get Valid Number From The User */
            //static int GetValidNumber()
            //{
            //    string Input = Console.ReadLine() ?? "0";
            //    while (true)
            //    {
            //        if (int.TryParse(Input, out int Number) && Number > 0)
            //        {
            //            return Number;
            //        }
            //        else
            //        {
            //            Console.Write("Please Enter A Valid Number: ");
            //            Input = Console.ReadLine() ?? "0";
            //        }
            //    }
            //}

            #endregion

            #region 4-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.Write("Enter A Number To Check Is Prime: ");
            //int Input = GetValidNumber();
            //bool result = IsPrime(Input);
            //Console.WriteLine(result);


            ///** Handle Prime Numbers */
            //static bool IsPrime(int Num)
            //{
            //    if (Num <= 1) return false;

            //    if (Num == 2) return true;

            //    for (int i = 3; i < Math.Sqrt(Num); i++)
            //    {
            //        if (Num % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;

            //}

            ///** Handle Get Valid Number From The User */
            //static int GetValidNumber()
            //{
            //    string Input = Console.ReadLine() ?? "0";
            //    while (true)
            //    {
            //        if (int.TryParse(Input, out int Number) && Number > 0)
            //        {
            //            return Number;
            //        }
            //        else
            //        {
            //            Console.Write("Please Enter A Valid Number: ");
            //            Input = Console.ReadLine() ?? "0";
            //        }
            //    }
            //}

            #endregion

            #region 5-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //// init Array Size 
            //Console.WriteLine("Please Enter The Array Size: ");
            //Console.WriteLine("========================");
            //int ArraySize = GetValidNumber();

            //// Init Array Values
            //Console.WriteLine("========================");
            //int[] Numbers = new int[ArraySize];
            //for(int i = 0; i < ArraySize; i++)
            //    Numbers[i] = GetValidNumber();

            //Console.WriteLine("========================");
            //Console.WriteLine($"Max Value is: {MinMaxArray(Numbers)[0]}");
            //Console.WriteLine($"Min Value is: {MinMaxArray(Numbers)[1]}");
            //Console.WriteLine("========================");

            //static int[] MinMaxArray(int[] Arr)
            //{
            //    int Max = Arr.Max();
            //    int Min = Arr.Min();
            //    return new int[] {Max, Min};
            //}

            ///** Handle Get Valid Number From The User */
            //static int GetValidNumber()
            //{
            //    string Input = Console.ReadLine() ?? "0";
            //    while (true)
            //    {
            //        if (int.TryParse(Input, out int Number) && Number > 0)
            //        {
            //            return Number;
            //        }
            //        else
            //        {
            //            Console.Write("Please Enter A Valid Number: ");
            //            Input = Console.ReadLine() ?? "0";
            //        }
            //    }
            //}
            #endregion

            #region 6-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.WriteLine("Please Enter A Number To Calc The Factorial Of It:");
            //Console.WriteLine("========================================");

            //int Input = GetValidNumber();
            //Console.WriteLine("========================================");

            //Console.WriteLine(CalcFactorial(Input));
            //Console.WriteLine("========================================");

            ///** Handle Factorial Number */
            //static int CalcFactorial(int Num)
            //{
            //    int Factorial = 1;
            //    for(int i = 1; i <= Num; i++)
            //    {
            //        Factorial *= i;
            //    }
            //    return Factorial;
            //}

            ///** Handle Get Valid Number From The User */
            //static int GetValidNumber()
            //{
            //    string Input = Console.ReadLine() ?? "0";
            //    while (true)
            //    {
            //        if (int.TryParse(Input, out int Number) && Number > 0)
            //        {
            //            return Number;
            //        }
            //        else
            //        {
            //            Console.Write("Please Enter A Valid Number: ");
            //            Input = Console.ReadLine() ?? "0";
            //        }
            //    }
            //}
            #endregion

            #region 7-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.WriteLine("Please Enter The Message Want To Change: ");
            //Console.WriteLine("====================================");
            //StringBuilder Message = new StringBuilder(Console.ReadLine());

            //Console.WriteLine("Please Enter The Char You Want To Change: ");
            //Console.WriteLine("====================================");
            //string CharExsist = Console.ReadLine()??"";

            //Console.WriteLine("Please Enter The Char You Want To Modify: ");
            //Console.WriteLine("====================================");
            //string CharModify = Console.ReadLine() ?? "";

            //Console.WriteLine("====================================");

            //Console.WriteLine("Your New Message:");
            //Console.WriteLine(ChangeChar(Message, CharExsist, CharModify));

            //static StringBuilder ChangeChar(StringBuilder Message, string CharExsist, string CharModify)
            //{
            //    Message.Replace(CharExsist, CharModify);
            //    return Message;
            //}

            ///** Handle Get Valid Number From The User */
            //static int GetValidNumber()
            //{
            //    string Input = Console.ReadLine() ?? "0";
            //    while (true)
            //    {
            //        if (int.TryParse(Input, out int Number) && Number > 0)
            //        {
            //            return Number;
            //        }
            //        else
            //        {
            //            Console.Write("Please Enter A Valid Number: ");
            //            Input = Console.ReadLine() ?? "0";
            //        }
            //    }
            //}
            #endregion
        }



    }
}
