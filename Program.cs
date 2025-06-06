﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Even or Odd");
                Console.WriteLine("2. Largest of Three Numbers");
                Console.WriteLine("3. Temperature Converter");
                Console.WriteLine("4. Simple Discount Calculator");
                Console.WriteLine("5. Grading System");
                Console.WriteLine("6. Swap Two Numbers");
                Console.WriteLine("7. Days to Weeks and Days Converter");
                Console.WriteLine("8. Electricity Bill Calculator");
                Console.WriteLine("9. Simple Calculator Part 1");
                Console.WriteLine("10. Basic ATM System");
                Console.WriteLine("11. Geometry Calculator");
                Console.WriteLine("12. Factorial of a Number");
                Console.WriteLine("13. Sum of Even and Odd Numbers");
                Console.WriteLine("14. Scientific Calculator");
                Console.WriteLine("15. Print Triangle Pattern");
                Console.WriteLine("16. Print Pyramid Pattern");
                Console.WriteLine("17. Print Diamond Pattern");
                Console.WriteLine("18. Guess the Number Game");
                Console.WriteLine("19. Array Initialization");
                Console.WriteLine("20. Find Maximum & Minimum in an Array");
                Console.WriteLine("21. Count Even & Odd Numbers");
                Console.WriteLine("22. Reverse an Array");
                Console.WriteLine("23. Search for a Number in an Array");
                Console.WriteLine("24. Sorting an Array (Ascending Order)");
                Console.WriteLine("25. Merging Two Arrays");
                Console.WriteLine("26. Remove Duplicates from an Array");
                Console.WriteLine("27. Second Largest Number in an Array");


                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice : ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter number : ");
                        int num = int.Parse(Console.ReadLine());
                        string result = EvenOrOdd(num);
                        printValue(result);
                        break;
                    case 2:
                        Console.WriteLine("Enter number 1 : ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2 : ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 3 : ");
                        int num3 = int.Parse(Console.ReadLine());
                        int result2 = LargestOfThreeNumbers(num1, num2, num3);
                        printValue(result2.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Enter temperature : ");
                        double temp = double.Parse(Console.ReadLine());
                        double result3 = TemperatureConverter(temp, 0);
                        printValue(result3.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Enter price : ");
                        double price = double.Parse(Console.ReadLine());
                        double result4 = SimpleDiscountCalculator(price);
                        printValue(result4.ToString());
                        break;
                    case 5:
                        Console.WriteLine("Enter a student score : ");
                        int marks = int.Parse(Console.ReadLine());
                        int result5 = GradingSystem(marks);
                        printValue(result5.ToString());
                        break;
                    case 6:
                        Console.WriteLine("Enter number 1 : ");
                        int number1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2 : ");
                        int number2 = int.Parse(Console.ReadLine());
                        string result6 = SwapTwoNumbers(number1,number2);
                        printValue(result6);
                        break;
                    case 7:
                        Console.WriteLine("Enter number of days : ");
                        int days = int.Parse(Console.ReadLine()); 
                        string result7 = DaysToWeeksAndDaysConverter(days);
                        printValue(result7);
                        break;
                    case 8:
                        Console.WriteLine("Enter number of units : ");
                        float unitNumber = float.Parse(Console.ReadLine());
                        float result8 = ElectricityBillCalculator(unitNumber);
                        printValue(result8.ToString());
                        break;
                    case 9:
                        Console.WriteLine("Enter number 1 : ");
                        double numb1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter number 2 : ");
                        double numb2= double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Operator  (+, -, *, /) : ");
                        char Operator = char.Parse(Console.ReadLine());
                        string result9 = SimpleCalculatorpart1(numb1, numb2, Operator);
                        printValue(result9);
                        break;
                    case 10:
                        Console.WriteLine("Chose what process you want \n1. withdraw  \n2. deposit  \n3. chechBalance  \n4. Exit ");
                        int choice1 = int.Parse(Console.ReadLine());
                        string result10 = BasicATM(choice1);
                        printValue(result10);
                        break;
                    case 11:
                        Console.WriteLine("Choose a shape: Circle , Square or Triangle ( c , s or t )");
                        string choiceshape = Console.ReadLine();
                        string result11 = GeometryCalculator(choiceshape);
                        printValue(result11);

                        break;


                    case 12:
                        Console.WriteLine("Enter a number to find the factorial : ");
                        int factorialnumber = int.Parse(Console.ReadLine());
                        string result12 = Factorial(factorialnumber);
                        printValue(result12.ToString());

                        break;
                    case 13:

                        Console.WriteLine("Enter a number : ");
                        int userNumber = int.Parse(Console.ReadLine());
                        string result13 = SumEvenOdd(userNumber);
                        printValue(result13.ToString());


                        break;
                    case 14: break;
                    case 15: ScientificCalculator(); break;
                    case 16: PrintTriangle(); break;
                    case 17: PrintPyramid(); break;
                    case 18: PrintDiamond(); break;
                    case 19: GuessGame(); break;
                    case 20: ArrayInitialization(); break;
                    case 21: MaximumMinimum(); break;
                    case 22: EvenOddNumbers(); break;
                    case 23: ReverseArray(); break;
                    case 24: SearchNumberInArray(); break;
                    case 25: SortingArray(); break;
                    case 26: MergingTwoArrays(); break;
                    case 27: RemoveDuplicatesFromArray(); break;
                    case 28: SecondLargestNumberInArray(); break;



                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.WriteLine("Press any key ");
                Console.ReadLine();

            }
        }


        //part 1


        public static string EvenOrOdd(int num)
        {
            

            if (num % 2 == 0)
                return "Even number";
            else
                return "Odd number";
            
        }
        // part 1
        public static int LargestOfThreeNumbers(int num1, int num2, int num3)
        {
            //2. Largest of Three Numbers

            int larg;

            if (num1 > num2 && num1 > num3)
            {
                larg = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                larg = num2;
            }
            else
            {
                larg = num3;
            }
            return larg;

        }

        public static double TemperatureConverter(double temp, double fahrenheit)
        {
            //3. Temperature Converter


            fahrenheit = (temp * 9 / 5) + 32;
            return fahrenheit;


        }
        public static double SimpleDiscountCalculator(double price)
        {
            //4. Simple Discount Calculator

            double discount, finalPrice;


            if (price > 100)
            {
                discount = (price * 10) / 100;
                finalPrice = price - discount;
                //Console.WriteLine("The final price is  " + finalPrice);
                return finalPrice;
            }
            else
            {

                finalPrice = price;
                //Console.WriteLine(" No Discount Your final price is  " + finalPrice);
            }
            return finalPrice;
        }
        public static int GradingSystem(int marks)
        {
            //5. Grading System


           
            char grade;

            if (marks >= 90)
            {
                grade = 'A';
            }
            else if (marks >= 80)
            {
                grade = 'B';
            }
            else if (marks >= 70)
            {
                grade = 'C';
            }
            else if (marks >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            return grade;
        }
        public static string SwapTwoNumbers(int number1, int number2 )
        {
            //6. Swap Two Numbers

            
            
            
            //Swapping
           
            int first = number1;
            int second = number2;
            

            string result = second+ " - " + first;
           

            return result;
            
        }
        public static string DaysToWeeksAndDaysConverter(int days)
        {
            //7.Days to Weeks and Days Converter

            int weeks = days / 7;
            int remainingDays = days % 7;
            string result = weeks + " weeks and " + remainingDays + " days";
            return result;

        }

        public static float ElectricityBillCalculator(float unitNumber)
        {
            //8. Electricity Bill Calculator

            float bill;
            
            if (unitNumber <= 100)
            {
                bill = unitNumber * 0.5f;
                
                return bill;
            }
            else if (unitNumber > 100 && unitNumber <= 300)
            {
                bill = unitNumber * 0.75f;
                return bill;
            }
            else
            {
                bill = unitNumber * 1.0f;
                return bill;
            }
        }

        public static string SimpleCalculatorpart1(double numb1, double numb2 , char Operator)
        {
            //9. Simple Calculator

            double result;
            
            


            if (Operator == '+')
            {
                result = numb1 + numb2;
                 return "The result of addition is : " + result;
            }
            else if (Operator == '-')
            {
                result = numb1 - numb2;
                return "The result subtraction is : " + result;
            }
            else if (Operator == '*')
            {
                result = numb1 * numb2;
                return "The result multiplication is : " + result;
            }
            else if (Operator == '/')
            {
                if (numb2 == 0)
                {
                    
                    return "Cannot divide by zero";
                }
                else
                {
                    result = numb1 / numb2;
                    return "The result division is : " + result;
                }

            }
            else
            {
                return "Invalid Operator";
            }
        }

        // function 
        // to print the value
        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }


        // part 2
       
        public static string BasicATM(int choice1)
        {
            char doAgain;
            do
            {
                //Console.Clear();
                double balance = 1000;
                double withdraw, deposit;
                
                //bool isActive = false;
                switch (choice1)
                {
                    case 1:
                        if (balance == 0)
                        {
                            return "\nYour balance is : " + balance + " You cant withdraw";


                        }
                        else
                        {
                            Console.WriteLine("\nEnter amount to withdraw : \n");
                            withdraw = double.Parse(Console.ReadLine());
                            if (withdraw > balance)
                            {
                                return "Insufficient funds!";

                            }
                            else
                            {
                                balance = balance - withdraw;
                                return "Withdrawal successful! New balance: " + balance;

                            }

                        }
                        break;

                    case 2:
                        Console.WriteLine("\nEnter amount to deposit : ");
                        deposit = double.Parse(Console.ReadLine());
                        balance = balance + deposit;
                        return "Deposit successful! New balance: " + balance;
                        break;
                    case 3:
                        return "Your balance: " + balance;
                        break;
                    
                    default:
                        return "\nInvalid choice";
                        break;
                }

                Console.WriteLine("Do you want another operation ? y / n");
                doAgain = Console.ReadKey().KeyChar;

            } while (doAgain == 'y' || doAgain == 'Y');

            Console.WriteLine("\ngoodbye");

        }



        //Console.WriteLine(" -------------------------------------------------------");


        //---------------------------------------------------------------------------


        //3. Geometry Calculator
        public static string GeometryCalculator(string choiceshape)
        {
            char doingAgain;
            do
            {
                Console.Clear();
                
                double area = 0;
                double pi = 3.14159;
                
                switch (choiceshape)
                {
                    case "c":
                        double radius, circumference;
                        Console.WriteLine("Enter the radius of the circle: ");
                        radius = double.Parse(Console.ReadLine());
                        area = pi * radius * radius;
                        circumference = 2 * pi * radius;
                        return "The area of the circle is: " + area;
                        return "The circumference of the circle is: " + circumference;
                        break;
                    case "s":
                        double side, perimeter;
                        Console.WriteLine("Enter the length of the side of the square: ");
                        side = double.Parse(Console.ReadLine());
                        area = side * side;
                        perimeter = 4 * side;
                        return "The area of the square is: " + area;
                        return "The perimeter of the square is: " + perimeter;

                        break;
                    case "t":
                        double basetriangle;
                        double heighttriangle;
                        Console.WriteLine("Enter the base of the triangle: ");
                        basetriangle = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of the triangle: ");
                        heighttriangle = double.Parse(Console.ReadLine());
                        area = (basetriangle * heighttriangle) / 2;
                        return "The area of the triangle is: " + area;
                        break;
                    default:
                        return "Invalid choice";
                        break;
                }
                Console.WriteLine("Do you want to do another calculation? (y/n)");
                doingAgain = char.Parse(Console.ReadLine());

            } while (doingAgain == 'y' || doingAgain == 'Y');
            Console.WriteLine("Goodbye");
        }

        //Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------

        //4.Factorial of a Number
        public static string Factorial(int factorialnumber)
        {
            
           
            int fact = 1;
            for (int i = 1; i <= factorialnumber; i++)
            {
                fact = fact * i;
            }
            return "The factorial of " + factorialnumber + " is : " + fact;

        }
        //Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------



        //5. Sum of Even and Odd Numbers 
        public static string SumEvenOdd(int userNumber)
        {
            int sumeven = 0;
            int sumodd = 0;
            
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 2 == 0)
                {
                    sumeven = sumeven + i;
                    
                }
                else
                {
                    sumodd = sumodd + i;
                    
                }
            }
            return "Sum of Even Numbers : " + sumeven + "\n" + "Sum of Odd Numbers : " + sumodd;

        }
        // Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------



        //6. Scientific Calculator (Switch-Case & Math Functions)

        public static void ScientificCalculator()
        {
            char userChoice;
            Console.WriteLine("Choose a function : sin , cos , tan , sqrt , log , pow ( s , c , t , q , l , p )");
            userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine("\nEnter a number to find the value : ");
            double value = double.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 's':
                    Console.WriteLine("The sin value of " + value + " is : " + Math.Sin(value));
                    break;
                case 'c':

                    Console.WriteLine("The cos value of " + value + " is : " + Math.Cos(value));
                    break;
                case 't':
                    Console.WriteLine("The tan value of " + value + " is : " + Math.Tan(value));
                    break;
                case 'q':
                    Console.WriteLine("The sqrt value of " + value + " is : " + Math.Sqrt(value));
                    break;
                case 'l':
                    Console.WriteLine("The log value of " + value + " is : " + Math.Log(value));
                    break;
                case 'p':
                    Console.WriteLine("The power value of " + value + " is : " + Math.Pow(value, 2));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }

        // Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------
        // 7. Print Triangle Pattern
        public static void PrintTriangle()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));
        }

        //---------------------------------------------------------------------------


        //8. Print a Pyramid Pattern (For Loop)
        public static void PrintPyramid()
        {
            int number;
            Console.WriteLine("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            for (int index = 1; index <= number; index++)
            {
                for (int space = 1; space <= number - index; space++)
                {
                    Console.Write(" ");
                }
                for (int starnum = 1; starnum <= (2 * index - 1); starnum++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        // Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------
        //9. Print a Diamond Pattern (For Loop)
        public static void PrintDiamond()
        {

            int number;
            Console.WriteLine("Enter a number : ");
            number = int.Parse(Console.ReadLine());
            for (int index = 1; index <= number; index++)
            {
                for (int space = 1; space <= number - index; space++)
                {
                    Console.Write(" ");
                }
                for (int starnum = 1; starnum <= (2 * index - 1); starnum++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int index = number - 1; index >= 1; index--)
            {
                for (int space = 1; space <= number - index; space++)
                {
                    Console.Write(" ");
                }
                for (int starnum = 1; starnum <= (2 * index - 1); starnum++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        // Console.WriteLine(" -------------------------------------------------------");

        //---------------------------------------------------------------------------

        //10.Guess Game with helper with while loop
        public static void GuessGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            int guess, count = 1;
            Console.WriteLine("Guess the number between 1 and 100");
            guess = int.Parse(Console.ReadLine());

            while (guess != randomNumber)
            {

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low, try again");
                    guess = int.Parse(Console.ReadLine());
                    count += 1;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high, try again");
                    guess = int.Parse(Console.ReadLine());
                    count += 1;
                }
            }

            Console.WriteLine("You guessed the number!");
            Console.WriteLine("You guessed number in " + count + " time");
        }

        // part 3
        static void ArrayInitialization()
        {

            //1. Array Initialization & Output
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }


        static void MaximumMinimum()
        {
            //2. Find Maximum & Minimum in an Array

            int[] maxMinNumb = new int[10];

            Console.WriteLine("Enter 10 numbers :");
            for (int i = 0; i < 10; i++)
            {
                maxMinNumb[i] = int.Parse(Console.ReadLine());
            }
            int max = maxMinNumb[0], min = maxMinNumb[0];
            for (int i = 0; i < 10; i++)
            {
                if (maxMinNumb[i] > max)
                {
                    max = maxMinNumb[i];
                }
                if (maxMinNumb[i] < min)
                {
                    min = maxMinNumb[i];
                }
            }
            Console.WriteLine("Maximum element is " + max);
            Console.WriteLine("Minimum element is " + min);


        }

        static void EvenOddNumbers()
        {
            //3. Count Even & Odd Numbers



            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] countEvenOdd = new int[n];
            Console.WriteLine("Enter Numbers ");
            int countEven = 0, countOdd = 0;

            for (int i = 0; i < n; i++)
            {
                countEvenOdd[i] = int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < n; i++)
            {
                if (countEvenOdd[i] % 2 == 0)
                {
                    countEven = countEven + 1;
                }
                else
                {
                    countOdd = countOdd + 1;
                }
            }
            Console.WriteLine("Count of even number is " + countEven);
            Console.WriteLine("Count of odd number is " + countOdd);
        }

        static void ReverseArray()
        {
            //4. Reverse an Array


            Console.WriteLine("Enter array size");
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] reverseArray = new int[sizeOfArray];
            Console.WriteLine("Enter Numbers ");


            for (int i = 0; i < sizeOfArray; i++)
            {
                reverseArray[i] = int.Parse(Console.ReadLine());


            }

            //Array.Reverse(reverseArray);
            //Console.Write(" the reverse array is ");
            //foreach (int numb in reverseArray)
            //{

            //    Console.Write(numb + " ");
            //}
            Console.WriteLine("Reversed Array:");
            for (int i = sizeOfArray - 1; i >= 0; i--)
                Console.Write(reverseArray[i] + " ");
            Console.WriteLine();
        }

        static void SearchNumberInArray()
        {
            //5. Search for a Number in an Array

            Console.WriteLine("Enter array size");
            int size = int.Parse(Console.ReadLine());
            int[] searchArray = new int[size];
            Console.WriteLine("Enter Numbers ");
            for (int i = 0; i < size; i++)
            {
                searchArray[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Enter number to search :");
            int searchNumb = int.Parse(Console.ReadLine());
            foreach (int item in searchArray)
            {
                if (item == searchNumb)
                {
                    int index = Array.IndexOf(searchArray, searchNumb);
                    Console.WriteLine(" the index is " + index);
                }
            }
        }
        static void SortingArray()
        {
            //6. Sorting an Array (Ascending Order)

            Console.WriteLine("Enter array size");
            int sizeArray = int.Parse(Console.ReadLine());
            int[] sortArray = new int[sizeArray];
            Console.WriteLine("Enter Numbers ");
            for (int i = 0; i < sizeArray; i++)
            {
                sortArray[i] = int.Parse(Console.ReadLine());

            }

            //Array.Sort(sortArray);
            //Console.Write(" the sort array is ");
            //foreach (int numb in sortArray)
            //{

            //    Console.Write(numb + " ");
            //}

            Array.Sort(sortArray);
            Console.WriteLine("Sorted Array: " + string.Join(" ", sortArray));
        }

        static void MergingTwoArrays()
        {
            //7.Merging Two Arrays

            Console.WriteLine("Enter array 1 size");
            int sizeArr = int.Parse(Console.ReadLine());
            int[] array1 = new int[sizeArr];
            Console.WriteLine("Enter Numbers in array 1 : ");


            for (int i = 0; i < sizeArr; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());

            }

            int[] array2 = new int[sizeArr];
            Console.WriteLine("Enter Numbers in array 2 : ");
            for (int i = 0; i < sizeArr; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());

            }
            int[] arrayMarge = new int[sizeArr + sizeArr];
            //array1.CopyTo(arrayMarge, 0);
            //array2.CopyTo(arrayMarge, sizeArr);

            //Console.Write("Marged Array is : ");

            //foreach (int numb in arrayMarge)
            //{

            //    Console.Write(numb + " ");
            //}

            for (int i = 0; i < sizeArr; i++)
                arrayMarge[i] = array1[i];




            for (int i = 0; i < sizeArr; i++)
                arrayMarge[sizeArr + i] = array2[i];

            Console.WriteLine("Merged Array:");
            for (int i = 0; i < 2 * sizeArr; i++)
                Console.Write(arrayMarge[i] + " ");
            Console.WriteLine();
        }
        static void RemoveDuplicatesFromArray()
        {
            //8 .Remove Duplicates from an Array

            Console.WriteLine("Enter array size");
            int sizeArra = int.Parse(Console.ReadLine());
            int[] array = new int[sizeArra];
            Console.WriteLine("Enter Numbers ");
            for (int i = 0; i < sizeArra; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }
            // Use Distinct to get unique values
            //int[] distinct = array.Distinct().ToArray();
            //foreach (int val in distinct)
            //{
            //    Console.Write(val + " ");
            //}

            Console.WriteLine("Array without duplicates:");
            for (int i = 0; i < sizeArra; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < sizeArra; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }

        static void SecondLargestNumberInArray()
        {
            //9. Second Largest Number in an Array


            Console.WriteLine("Enter array size");
            int sizeArray1 = int.Parse(Console.ReadLine());
            int[] arrayLargest = new int[sizeArray1];
            Console.WriteLine("Enter Numbers ");
            for (int i = 0; i < sizeArray1; i++)
            {
                arrayLargest[i] = int.Parse(Console.ReadLine());

            }
            //Array.Sort(arrayLargest);
            //Console.Write("the secound largest number in array is : " + arrayLargest[sizeArray1 - 2]);
            int largest = int.MinValue, secondLargest = int.MinValue;

            for (int i = 0; i < sizeArray1; i++)
            {
                if (arrayLargest[i] > largest)
                {
                    secondLargest = largest;
                    largest = arrayLargest[i];
                }
                else if (arrayLargest[i] > secondLargest && arrayLargest[i] != largest)
                    secondLargest = arrayLargest[i];
            }
            Console.WriteLine($"Second Largest: {secondLargest}");
        }





    }
}
