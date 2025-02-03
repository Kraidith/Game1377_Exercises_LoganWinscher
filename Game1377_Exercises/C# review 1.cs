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
            Console.WriteLine("local int is {0}, local float is {1}" + localInt, localFloat);

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
            // declare multiple variables 
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
            Console.WriteLine("Enter your name");
            String? name = Console.ReadLine(); //nullable type
            if (name != null)
            {
                Console.WriteLine("Your name is " + name);
            }
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
            subtractAssign -= 2;  //same as subtractAssign = subtractAssign - 2;

            int multiplyAssign = 3;
            multiplyAssign *= 2;

            int divideAssign = 3;
            divideAssign /= 2; //why is this the answer? how can i get the decimal answer
        }

        static void IncrementAndDecrement()
        {
            //increment and decrement
            int TempIncrementInt = 0;

            int preIncrementAssign = 0;
            TempIncrementInt = ++preIncrementAssign; //does increment first then value
            Console.WriteLine(TempIncrementInt); //variable is now 1

            int postIncrementAssign = 0;
            TempIncrementInt = postIncrementAssign++; //value first then +/- increment
            Console.WriteLine(TempIncrementInt);

            int preDecrementAssign = 0;
            TempIncrementInt = --preDecrementAssign;
            Console.WriteLine(TempIncrementInt);

            int postDecrementAssign = 0;
            TempIncrementInt = postDecrementAssign--;
            Console.WriteLine(TempIncrementInt);

        }
        static void ComparisonOperators()
        {
            int comparisonValue1 = 0;
            int comparisonValue2 = 5;
            Console.WriteLine(comparisonValue1 == comparisonValue2); //equals(2 equals is a comparison)
            Console.WriteLine(comparisonValue1 != comparisonValue2); //not equals True
            Console.WriteLine(comparisonValue1 > comparisonValue2);  // greater than False
            Console.WriteLine(comparisonValue1 < comparisonValue2);  // less than True
            Console.WriteLine(comparisonValue1 >= comparisonValue2); // greater than or equalsFalse
            Console.WriteLine(comparisonValue1 <= comparisonValue2); // less than or equals to True   
        }
        static void StringAndStringMethods()
        {
            //strings
            string helloWorldString = "Hello, World.";
            Console.Write(helloWorldString);
            Console.Write(helloWorldString + "\n"); // \n is used for separate line
            Console.WriteLine(helloWorldString); //writeline adds to end of line, doesnt start a new line, that is \n  
            Console.WriteLine(helloWorldString + " " + helloWorldString.Length);
            Console.WriteLine(helloWorldString.Substring(7)); //it would say World since the W is the 7th index is the 8th character
            Console.WriteLine(helloWorldString.Substring(3, 2)); //it would start at the index which is 3, the 2 is how many letters so it would be lo
            string helloWorldStringCapitalized = helloWorldString.ToUpper();
            Console.WriteLine(helloWorldString.ToUpper());
            helloWorldStringCapitalized.ToLower();
            Console.WriteLine(helloWorldString.ToLower());
            Console.WriteLine("\t" + "\'" + helloWorldString + "\'\nNow with an extra line!"); //\t tabs over \' puts it in single quotes
        }

        static void BooleansAndConditionals()
        {
            int x = 0, y = 1, z = 2;
            bool isXGreaterThanY = false; //false
            bool isXEqualtoZ = x == z; //false
            x = z; //still false

            if (isXEqualtoZ)
            {
                Console.WriteLine("X is equal to Z according to the variable"); //will this execute? no cause false
            }
            else
            {
                Console.WriteLine("X is not equal to Z according to the variable"); //true
            }
            if (x == z)
            {
                Console.WriteLine("X is equal to Z"); //false
            }
            if (x == z && y > x)
            {
                Console.WriteLine("X is equal to Z and Y is greater than X"); //false cause both arent true 
            }
            if (x == z || y > x)
            {
                Console.WriteLine("Either X is equal to Z or Y is greater than X"); //true since Y is greater than Y 
            }
        }


    }
}
   
