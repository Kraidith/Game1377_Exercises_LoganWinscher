using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Game1377_Exercises
{
    internal class C__review_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Main\n");
            VariablesAndDatatypes();
            ConstantVariables();
            SingleLineMultipleVariables();
            TypeCastingAndConversions();
            GetUserName();
            ArthrimaticOperators();
            AssignmentOperators();
            ArthrimaticAssignmentOperators();
            IncrementAndDecrement();
            ComparisonOperators();
            StringAndStringMethods();
            BooleansAndConditionals();
        }
    }
    
    private static void VariablesAndDatatypes()
        {
            int localInt = 0; // 
            float localFloat = 0.1f; // stores fractional numbers, usually 6-7 decimal digits
            double localDouble = .01; // stores fractional numbers, usually upto 15 decimal digits
            bool localBoolean = false; // stores true or false
            char localCharacter = 'a'; // stores a single letter, use single quotes
            string localString = "Hello from Inside Main"; //stores a sequence of characters, use double quotes


            //Output variables
            Console.WriteLine("localInt = " + localInt);
            Console.WriteLine("local = " + localFloat);
            Console.WriteLine("local = " + localDouble);
            Console.WriteLine("local = " + localBoolean);
            Console.WriteLine("local = " + localCharacter);
            Console.WriteLine("local = " + localString + "\n");

            //change the value of a variable and output it again
            localInt = 5;
            Console.WriteLine("localInt Now= " + localInt);

            //use string Interpolation
            Console.WriteLine("local int is {0}, local float is {1}" + localInt, loca0lFloat);

        }
      static void ConstantVariables()
      {
            int localInt = 0;
            Console.WriteLine(localInt);
            //declare const variable
            const int localConstInt = 0;
            //localConstInt=1;
            Console.WriteLine("localConstInt = " + localConstInt);
      }

        static void SingleLineMultipleVariables()
        {
            // declzre multiple variables 
            int x = 1, y = 2, z = 3;
            Console.WriteLine("int i equal to " + "\n" +
                              "y is equal to " + "\n" +
                              "z is equals to" + "/n"); 
            // \n is used to put on separate line
        }

        static void TypeCastingAndConversions()
        {
            //type casting
            int localInt = 5;
            double localDouble = localInt; //implicit casting -don't need to specify when going from int to
            localInt = (int)localDouble; // what happens if i try to assign a float to an int

            // type conversion
            localDouble = 1.5;
            char localCharacter = 'a';
            Console.WriteLine(localDouble); // output localDouble variables
            Console.WriteLine(Convert.ToInt32(localDouble)); // conversion from 1.5 to an integer. 
            Console.WriteLine(localDouble); // output localDouble variable 
            Console.WriteLine(Convert.ToInt32(localCharacter)); // Conversion from char to int.
            localCharacter++;
            Console.WriteLine(Convert.ToInt32(localCharacter)); 
        }

        static void GetUserName()
        {
         
        }

        static void ArthrimaticOperators()
        {
            int sum = 10 + 15; //result of addition
            int diff = sum - 20; //result f subatraction
            int product = sum + diff; //result of multiplication
            int quotient_int = product / 10; //result of division(as an integer)
            float quotient_float = product / 10; //result of division (as a float)
            int remainder = product % 10; //remainder from division example is 30 % 7= 2
                                          //cause 30/7=28 so 2 left is remainder
        }

        static void AssignmentOperators()
        {
            int assignNow = 1; //Assign on same line as declaration, ONE equal is ASSIGNMENT
            int assignLater; //Assign on different line
            assignLater = 1; 

            Random rnd = new Random(); //
            int assignFromFunction = rnd.Next(1, 12); //Returns random number from 1-12
        }

        static void ArthrimaticAssignmentOperators()
        {
            // assignment Arthmetic Operators
            int addAssign = 3;
            addAssign += 2;  //same as addAssign = addAssign + 2;

            int subtractAssign = 3;
            subtractAssign -=2;  //same as subtractAssign = subtractAssign - 2;

            int multiplyAssign = 3;
            multiplyAssign *=2;  

            int divideAssign = 3;
            divideAssign /= 2; 
        }

        static void IncrementAndDecrement()
        {

        }
        static void ComparisonOperators()
        {

        }
}
