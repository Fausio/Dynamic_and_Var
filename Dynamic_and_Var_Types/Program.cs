using System;

namespace Dynamic_and_Var_Types
{
    class Program
    {

        static void SumResult(dynamic fist, dynamic last)
        {
            Console.WriteLine("the sum of {0} and {1} is iqual to:   "+ (fist + last), fist, last);
        }


        static void Main(string[] args)
        {
            #region var type
            //var Name = " is String";  // the type it will be defined in copiler 
            //Console.Write("var value is " + Name);
            #endregion
            #region Dynamic type
            SumResult(1.25, 87);    // Dynameic type change the type of the variable at the runing time moment 
            SumResult(5, 1.7);
            SumResult(5, 5);
            SumResult(2, "string");
            SumResult("string", 3);
            SumResult('M', '4');
            SumResult("string", 'F');
            #endregion





            Console.ReadKey();
        }
    }
}
