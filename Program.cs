using System;

namespace Task_Calulator
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                //modifying our console :D
                Console.Title = "Kamo's Calculator";
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                //we are nice a bit before we get into the real stuff
                Console.WriteLine("Hello, what is your name?");
                Console.ReadLine();
                Console.WriteLine("Nice to meet you! \n" + "\n So to use the calculator, " +
                    "follow the prompts in the in the console.\n ");

                //This is the calculator

                //first we set the calculator commands. This will instruct user on what to do.
                Console.WriteLine("Enter the command to be performed");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("Press 2 for Subtraction");
                Console.WriteLine("Press 3 for Multiplication");
                Console.WriteLine("Press 4 for Division \n");

                //all inputs are in string form, we have to convert them to number
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st input");
                int input_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                int input_2 = Convert.ToInt32(Console.ReadLine());


                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            result = Addition(input_1, input_2);
                            break;
                        }
                    case 2:
                        {
                            result = Subtraction(input_1, input_2);
                            break;
                        }
                    case 3:
                        {
                            result = Multiplication(input_1, input_2);
                            break;
                        }
                    case 4:
                        {
                            result = Division(input_1, input_2);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }
                Console.WriteLine("The result is {0}", result);
                Console.WriteLine("\n Good job");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n Try entering the right input");
            }
            finally
            {
                Console.WriteLine("\n In the case of a+b, \n action would be 1, \n input1 is a and input2 is b");
            }
        }
        //Addition  
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //Substraction  
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        //Multiplication  
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //Division  
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }

        
    }
}  
