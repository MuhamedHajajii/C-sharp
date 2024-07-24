using System.Globalization;
using System.Xml.Linq;

namespace demo
{

    class Data {
        public int Sum { get; set; }
        public int Mul { get; set; }
    }


    internal class Program
    {
        static void Main()
        {

            #region Casting [ Boxing & UnBoxing ]
            // From Value Type To Value Type [Value Type Casting]
            // From Reference Type To Reference Type [Reference Type Casting]
            // From Value Type To Reference Type [Boxing]
            // From Reference Type To Value Type [unBoxing]
            // Convert ==> {Class} Transfer from anydata type to another data type
            // parsing ==> {Method} from String To The data Type of The Caller


            #region 1- Boxing
            // From Value Type To Refernece Type
            // Value From The Stack To Heap

            //object o1; // Declare A Reference From Data Type Object in the Stack // Refer To Null
            //o1 = "Ahmed"; // Casting From String To Object [From Reference Type to Reference Type]
            //o1 = 1; // Casting From Int to Object [From Value Type to reference Type] Boxing
            //o1 = "A"; // Casting From Value Type To Reference Type Boxing
            //o1 = new Employee(); // Casting From Value Reference Type To Reference type BC The o1 can be from any data type of the parent or any other data type inherting from it like Employee And All The Data Types by defult inherit from the object [The parent for all the datatypes]

            #endregion

            #region 2- unBoxing
            // From Reference Type To Value Type
            // From The Heap To Stack

            //int x = 10;     // Value Type in The Stack
            //object obj = x; // Casting from Reference Type to Value Type [Safe Casting];
            //                // Reference From The Parent Refer To A Reference From The Child
            //                // Animal => Dog

            //object obj2 = 10;   // Casting Safe
            //int Y = (int)obj2;  // Unboxing Casting with casting operator Explicit Casting unsafe Casting
            //                    // because if the input data not int it will lead for exception error 
            //                    // Dog = Animal The int is a object // i promise you the type of the animal will be dog
            //obj2 = "10";
            //Console.WriteLine(Y); // Error Exception

            // At The End We Don't Use The Boxing or Unboxing casting because it require alot of steps and lead to full the memory or crash with alot of garbage
            // so we use generic insted of it 
            #endregion

            #endregion

            #region Nullable [Value Type]
            #region Ex01
            //// Null As A Value Is Valid Only With Reference Type 2005

            ////int x = null; // Can't Convert Null Into Integer -- Invallid
            //// int x; Only Allow integer Numbers

            ////int? y = null; // Nullable Value Type 
            ////// y allow integer Value + Null as a value 
            ////Console.WriteLine(y);

            //int? Y = null;
            //int x = 10;

            //int? Z = Y; // Nullable Can Store Nullable and integer
            //Z = x; // Casting

            //Nullable<int> K = null; // Generic Struct
            //int? A = null; // Syntax Suger

            //// Nullable Allow Null & Integer Or There Value regardless which value type it depend on generic

            //decimal Num1 = 1.1M;
            //decimal? Num2 = Num1;

            //decimal? Num3 = 1.1M;
            //decimal Num4 = (decimal)Num3; // Unsafe Casting [Excplicit Casting]

            #endregion

            #region EX02
            //int x = 10;
            //int? y = x; // Valid No Proplem But this is casting
            //            // From Int To Nullable Int Implicit Casting
            //            // No Casting Operator Needed (int)

            //int? Num1 = null;
            //int Num2 = (int)Num1; // Explicit Casting From Nullable To int 
            //                      // Need to use Casting Operator
            //                      // To Disable The Warning You can make it disabled from the progex xml

            //// -- To Make A Safe Casting and insure yourself from any exceptions 
            //// Check first if the nullable variable is null or not 
            //// in the first way we made casting but in the second and the third we take the value and don't make any casting

            //// 1- First Way
            //if (Num1 != null)
            //    Num2 = (int)Num1;
            //else Num2 = 0;

            //// 2- Second Way
            //if (Num1.HasValue)
            //    Num2 = Num1.Value;
            //else Num2 = 0;

            //// 3- Third Way
            //Num2 = Num1.HasValue ? Num1.Value : 0;

            #endregion

            #endregion

            #region Nullable [Reference Type]
            //// Null Is The Defult Value Of The Variable of type reference type

            //string message = default!;// Valid With Warning 
            //                          // Null Forgiveness operator [!] Skip The Null Warning
            //                          // String And Nullable String One Lead to warning and the other not lead for a warning
            //Console.WriteLine(message);

            //// the main Idea for this implementation is compiler enhancement

            //Employee emp01 = new Employee();
            //// 1- Allocate The Requierd Bytes In Heap
            //// 2- Assign The Allocated Bytes with the defult Value
            //// 3- Call the user defind constructor function if exsist
            //// 4- Assign the object to the reference

            //string notNull = "Hello";

            //string? NullableString = default;

            ////NullableString = notNull;
            //notNull = NullableString!;

            //Console.WriteLine(notNull);
            //Console.WriteLine(NullableString);

            #endregion

            #region Null Propagation Operator [ ? ]

            ////double x = default;
            ////Console.WriteLine(x);

            //int[] Numbers = default; // Null
            //int[]? NumbersNullable = default; // Nullable

            //// 1- Error But Can not check without if validation
            ////foreach (var item in Numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// 2- With The For loop we can check with null propgation operator
            //// Before he start propegate inside the array he will check 
            //// if it not equal null it will return true and start progate and get the length
            //// if false the will not work

            //// First Way Check for the Numbers Befor Check the length
            //for(int i = 0; (Numbers!= null) && i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}
            //// Second Way with Null propagation operator
            //for (int i = 0;i < Numbers?.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            // when to use the null progegation operator ? stop the propagation
            // Null coulescing operator ?? replacement for the null
            //int[] Numbers = default;

            //int length = Numbers?.Length ?? 0;

            //Console.WriteLine(length);


            //Employee employee01 = new Employee();
            //// employee01 is state is // id = 0 , FirstName = null , LastName = null , Department = null 

            //employee01.Department = new Department();

            //Console.WriteLine(employee01?.Department?.Name ?? "20");


            #endregion

            #region Functions
            #region Ex01
            // Functions 
            // 1- Hold a block of code which i can reuse it more than one time 
            // 2- reuse it any time or depend on specific behavior or action  
            // 3- in sql functions must return value and in the programming language functions can be void.

            // Functions 2 Steps
            // 1- Prototype return type , name , parameteres == function signetrue , Body
            // 2- calling name and arguments

            // inside any name space i can type 4 things (value type and reference type)
            // Class Struct interface enum 
            // no stand alone function in oop and c sharp is a pure oop language 
            // Name Space is like the folder and includes every thing about the project ( Class Struct Interface Enum )

            // To use any function in the class it must be calling in the main function but this happen only in the console application
            // in the desktop application there are no necessery for this step because it happen by the function call 

            // 1- Class Member Function -- Static Functino -- Calling through her class with out new keyword i can access it because it a part from the class
            // 2- object member Function -- non-Static Function -- object from the class to can access it like new object

            // Print First Ex01
            // I Don't have to use the class name because i use it from the same class if
            // i will call it from another class i should type the class name.

            //Program.PrintShape(5,"(*_*)");
            // Calling the function and passing the parameters with order
            // position parameter
            //PrintShape(5,"(*_*)");
            //// Passing parameters by name
            //PrintShape(Shape : "(*_*)",Count : 5);
            //// Calling with function with defult value
            //PrintShape();
            //// Calling with function with second vlaue only
            //PrintShape(Shape:":)");
            //// Note That The Parametes which will have defult value it must be in the end of the parameters

            // The backslash \ is a reserved word in the programming language to escap operator is use to insert special charachter in the string 
            // \n new line \t tap \' single quote \" double quote \t horizantel table 
            // @"" Escape all the escape operators 
            //Console.WriteLine(@"Hello""Hello"" 'To' \Route \Welcome \Haji");
            #endregion



            #region Reference Type Parameters
            #region passing The reference type by the value (address)
            // String Builder , String, object , Array, delegate
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //Console.WriteLine(Numbers[0]);
            //int result = GetSum(Numbers); // passing the parameters by the value even if it reference data type 
            //Console.WriteLine(result);    // You Pass the inctance of the value by the address
            //                              // Both Now include the same Address And Refer To The Same Place
            //Console.WriteLine(Numbers[0]);
            // So If I passing by value i pass the address like the value type but with different behavior

            // Fire Main Function And Create The Stack Frame Of the main 
            // Allcate The int Numbers 4bytes 
            // The object in the heap with requier and defult and the main behavior
            // call for the getsum
            // passing the parameters by value the both of them refer to the same address 
            // so any change in any one of them will effect the other 
            // First decalre the parametes the allocate the local variables

            // if the array equal null  
            #endregion



            #endregion

            #endregion

            #region Passing Parameters
            #region Value Type Parameters
            // Function Parameters
            // Passing by value , default , reference , out , params

            //1- passing parameters value type parameters
            // byte,small,int,long,float,double,decimal,charachter,boolean,datetime
            // every datatype store in the stack

            //int a = 10; int b =20;

            // In This Case We Pass a Value type data with value only
            // so nothing change for the defult variables
            // the only change and the operation happens for the parameters of the function
            // an instance from the value of the variables

            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");
            //Swap(a, b);
            //Console.WriteLine("===================================");
            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");

            // first the stack frame of the main function
            // declare the a and b 
            // the stack of the swap
            // Stack frame of the write line after it end will remove from the stack
            // declare all the local variables of the swap temp,parameters of the functions
            // Allocate The Parameters and the Temp with the defult value of the int zero
            // after end the function nothing will change in the original variables

            //int a = 10; int b = 20;
            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");
            //// 2- Passing by reference
            //Swap(ref a,ref b);
            //Console.WriteLine("===================================");
            //Console.WriteLine($"A= {a}");
            //Console.WriteLine($"B= {b}");

            // First Call The Main Function And Make the StackFrame Of ot so it will allocate the A,B
            // StackFrame Of the Swap But This Time will not Allocate space of the parameters 
            // because it passing with the reff 
            // No need to allocate the data again 
            // Will Change the name of the parameters only 
            // swap stack frame will only hold the Temp
            // So its now change the value in the base address or the original variabales because we passing the parameters by the reference 
            // passign ref with the value type
            // Passing with the ref is the same as Input output output parameters

            #endregion
            #region Passing by the ref of the reference

            #region Ex01
            //int[] Numbers2 = { 1,2,3,4,5,6,7,8,};

            //Console.WriteLine(Numbers2[0]);
            //Console.WriteLine(GetSum(ref Numbers2));
            //Console.WriteLine(Numbers2[0]);

            // The Different only in the heap no in the result 
            // The Stack Fire and call the and create the stack frame
            // paramater of the getsum is by ref so he will not declare the parameters again
            // he will just change the name and act with the original reference without declare new reference  
            #endregion

            #region Ex02

            //// When will be a different when passing with the value and passing with the ref

            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(Numbers[0]);
            //int result  = GetSum(Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]);

            //// This Time The Parameters Will refer a new object so the first array will not be affected
            //// passing with value with the new object();

            // Passing With the ref with the new object
            //int[] Numbers = { 1, 2, 3 };

            //Console.WriteLine(Numbers[0]);
            //int result = GetSum(ref Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]);

            // This time we make the originla array allocate a new object too not only the parameter
            // because it passing parameter by reference 
            // Stack frame off the get sum will not allocate any data for the parameters 
            // will depend on the previous array or the original array;

            #endregion

            #endregion
            #region passing by out and params

            // when i use the output parameter i must use the whole output parameters inside my function
            // no re initialize for them in the fucntion block because we already declare them in the paramamters
            // i have to declare the output parameters to recive the data or the output data
            //int a = 1;  int b = 2;

            //int result01;
            //int result02;

            //SumMul(a, b, out result01, out result02);
            //Console.WriteLine(result01);
            //Console.WriteLine(result02);


            // The Same As the Passing parameters by ref not the value only 

            #endregion

            #region Params

            #endregion

            #endregion

        }

        #region Functions

        //public static void SumMul(int x,int y ,out int Sum,out int Mul)
        //{
        //    Sum = x + y;
        //    Mul = x * y;
        //    //Data D = new Data();
        //    //D.Sum = Sum;
        //    //D.Mul = Mul;
        //    //return D;
        //    //return new Data { Sum = Sum, Mul = Mul };
        //}

        //public static int GetSum(ref int[] Arr)
        //{
        //    int Total = 0;
        //        Arr = new int[] {5,2};
        //    for (int i = 0; i < Arr.Length; i++)
        //        Total += Arr[i];

        //    return Total;
        //}

        // First we start with the signature of the function
        // Static because we will call it through the class not from object from the class
        //public static void PrintShape(int Count = 5 ,string Shape = ":)")
        //{
        //    for(int i  = 0 ; i < Count; i++ )
        //        Console.WriteLine(Shape);
        //}
        // static is only called by class name not with the object from the class
        //public static void Swap(int x, int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp ;
        //}
        //public static void Swap(ref int x,ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        #endregion
    }
}
