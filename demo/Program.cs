using System.Globalization;

namespace demo
{
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

            #endregion

            #region Passing Parameters

            #endregion

        }
    }
}
