namespace SelectionStatementExcercise
{
    internal class Program
    {// tried to make a method here to keep practicing, it's not necessarily working the way i wanted it too
        public static void  Guess()
        {
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
        }
        
       
        
        
        // excercise 1
        static void Main(string[] args)
        {
            int favNumber = 100;
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            

            if (userInput == favNumber)
            {
                Console.WriteLine("You got it");
            }
            
            else if (userInput > favNumber) 

            {
                Console.WriteLine("Too high");
            }

           else
            {
                Console.WriteLine("Too Low");
            }


            // Exercise 2
            Console.WriteLine("what is your favorite school subject");
            var subject = Console.ReadLine(); 

            switch(subject)
            {
                case "math":
                    Console.WriteLine("yessir math is the best");
                    break;
                case "science":
                    Console.WriteLine("we use it everday we just dont know");
                    break;
                case "history":
                    Console.WriteLine("to be readyfor the future must understand our past");
                    break ;
                case "english":
                    Console.WriteLine("to be or not to be") ;
                    break ;
                case "gym":
                    Console.WriteLine("trying to look like the hulk this summer");
                    break;
                default: Console.WriteLine("i have no clue wht that is did you even go to school");
                    break;
                
            }

        }
    
    }
}