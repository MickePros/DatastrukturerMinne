using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            bool keepAlive = true;
            List<string> theList = new List<string>(2);
            do
            {
                Console.WriteLine("Use + or - to modify the list and 0 to return to main menu.");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        //theList.TrimExcess();
                        break;
                    case '0':
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Start your input with + or - to add or remove from the list.");
                        break;
                }
                Console.WriteLine($"List counts: {theList.Count}");
                Console.WriteLine($"List capacity: {theList.Capacity}");
            } while (keepAlive);
            Main();
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            bool keepAlive = true;
            Queue<string> theQueue = new Queue<string>();
            do
            {
                Console.WriteLine("Use + or - to modify the queue and 0 to return to main menu.");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        break;
                    case '-':
                        theQueue.Dequeue();
                        break;
                    case '0':
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Start your input with + or - to add or remove from the queue.");
                        break;
                }
                Console.WriteLine("Currently the queue is looking like this:");
                foreach (string element in theQueue)
                {
                    Console.WriteLine(element);
                }
            } while (keepAlive);
            Main();
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            bool keepAlive = true;
            Stack<string> theStack = new Stack<string>();
            do
            {
                Console.WriteLine("Use +string or - to modify the stack or *string to have read it back in reverse and 0 to return to main menu.");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        break;
                    case '-':
                        theStack.Pop();
                        break;
                    case '*':
                        ReverseText(value);
                        break;
                    case '0':
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Start your input with +string or - to add or remove from the stack.");
                        break;
                }
                Console.WriteLine("Currently the stack is looking like this:");
                foreach (string element in theStack)
                {
                    Console.WriteLine(element);
                }
            } while (keepAlive);
            Main();
        }

        static void ReverseText(string text)
        {
            string reversedString = "";
            Stack<char> reverseThis = new Stack<char>();
            foreach (var letter in text)
            {
                reverseThis.Push(letter);
            }
            while (reverseThis.Count > 0)
            {
                reversedString += reverseThis.Pop();
            }
            Console.WriteLine($"After reversing the input: {reversedString}");
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            Console.WriteLine("Give me a string and I will tell you if it contains valid paranthesis structure.");
            char[] checkSymbols = ['(', '[', '{', ')', ']', '}'];

            string input = Console.ReadLine();
            Stack<char> checkStack = new Stack<char>();
            foreach (var letter in input.ToCharArray())
            {
                if (!checkSymbols.Contains(letter))
                {
                    continue;   //Check if letter is unimportant and if so continue.
                }
                else if (letter == '(')
                {
                    checkStack.Push(')');   //Look for opening paranthesis and add closing pair to stack.
                }
                else if (letter == '[')
                {
                    checkStack.Push(']');
                }
                else if (letter == '{')
                {
                    checkStack.Push('}');
                }
                else if (checkStack.Count == 0 || checkStack.Pop() != letter)
                {
                    Console.WriteLine("Input contains invalid parathesis structure.");  //If letter is a paranthesis but not an opening one, we assume it is a closing paranthesis, so we check if it pairs with our latest stack element.
                }
            }
            //Todo: write success message
        }
    }
}

