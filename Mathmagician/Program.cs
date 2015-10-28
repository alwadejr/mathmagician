using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            string prompt = "> ";
            Console.WriteLine(@" .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| | ____    ____ | || |      __      | || |  _________   | || |  ____  ____  | || | ____    ____ | || |      __      | || |    ______    | || |     _____    | || |     ______   | || |     _____    | || |      __      | || | ____  _____  | |
| ||_   \  /   _|| || |     /  \     | || | |  _   _  |  | || | |_   ||   _| | || ||_   \  /   _|| || |     /  \     | || |  .' ___  |   | || |    |_   _|   | || |   .' ___  |  | || |    |_   _|   | || |     /  \     | || ||_   \|_   _| | |
| |  |   \/   |  | || |    / /\ \    | || | |_/ | | \_|  | || |   | |__| |   | || |  |   \/   |  | || |    / /\ \    | || | / .'   \_|   | || |      | |     | || |  / .'   \_|  | || |      | |     | || |    / /\ \    | || |  |   \ | |   | |
| |  | |\  /| |  | || |   / ____ \   | || |     | |      | || |   |  __  |   | || |  | |\  /| |  | || |   / ____ \   | || | | |    ____  | || |      | |     | || |  | |         | || |      | |     | || |   / ____ \   | || |  | |\ \| |   | |
| | _| |_\/_| |_ | || | _/ /    \ \_ | || |    _| |_     | || |  _| |  | |_  | || | _| |_\/_| |_ | || | _/ /    \ \_ | || | \ `.___]  _| | || |     _| |_    | || |  \ `.___.'\  | || |     _| |_    | || | _/ /    \ \_ | || | _| |_\   |_  | |
| ||_____||_____|| || ||____|  |____|| || |   |_____|    | || | |____||____| | || ||_____||_____|| || ||____|  |____|| || |  `._____.'   | || |    |_____|   | || |   `._____.'  | || |    |_____|   | || ||____|  |____|| || ||_____|\____| | |
| |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' ");
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string response = Console.ReadLine();
            /*     string response = Console.ReadLine();
                 switch(response)
                 {
                     case "1":
                         Console.WriteLine("How many Natural Numbers?");
                         string response_length = Console.ReadLine();
                         int length;
                         bool parsed = int.TryParse(response_length, out length);
                         NaturalNumbers nats = new NaturalNumbers();
                         Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                         break;

                      case "2":
                         Console.WriteLine("How many Even numbers?");
                         private string response_length = Console.ReadLine();
                         int length;
                         bool parsed = int.TryParse(response_length, out length);
                         EvenNumbers even = new EvenNumbers();
                         Console.WriteLine(even.ToString(even.GetSequence(length)));
                         break;

                      case "3":
                         Console.WriteLine("How many Odd numbers?");
                         private string response_length = Console.ReadLine();
                         int length;
                         bool parsed = int.TryParse(response_length, out length);
                         OddNumbers odd = new OddNumbers();
                         Console.WriteLine(even.ToString(even.GetSequence(length)));
                         break;


                   }


                 }
     */

                 if (response.Equals("natural numbers"))
                 {
                     Console.WriteLine("How many?");
                     Console.Write(prompt);
                     string response_length = Console.ReadLine();
                     int length;
                     bool parsed = int.TryParse(response_length, out length);
                     if (parsed)
                     {
                         NaturalNumbers nats = new NaturalNumbers();
                         Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                     }
                     else
                     {
                         Console.WriteLine("Whoops!");
                     }

                 }
                 else if (response.Equals("even numbers"))
                 {
                     Console.WriteLine("How many?");
                     Console.Write(prompt);
                     string response_length = Console.ReadLine();
                     int length;
                     bool parsed = int.TryParse(response_length, out length);
                     if (parsed)
                     {
                         EvenNumbers even = new EvenNumbers();
                         Console.WriteLine(even.ToString(even.GetSequence(length)));
                     }
                     else
                     {
                         Console.WriteLine("Whoops!");
                     }

                 }
                 else if (response.Equals("odd numbers"))
                 {
                     Console.WriteLine("How many?");
                     Console.Write(prompt);
                     string response_length = Console.ReadLine();
                     int length;
                     bool parsed = int.TryParse(response_length, out length);
                     if (parsed)
                     {
                         OddNumbers odd = new OddNumbers();
                         Console.WriteLine(odd.ToString(odd.GetSequence(length)));
                     }
                     else
                     {
                         Console.WriteLine("Whoops!");
                     }

                 }
                 else if (response.Equals("fibonacci numbers"))
                 {
                     Console.WriteLine("How many?");
                     Console.Write(prompt);
                     string response_length = Console.ReadLine();
                     int length;
                     bool parsed = int.TryParse(response_length, out length);
                     if (parsed)
                     {
                         FibonacciNumbers fibonacci = new FibonacciNumbers();
                         Console.WriteLine(fibonacci.ToString(fibonacci.GetSequence(length)));
                     }
                     else
                     {
                         Console.WriteLine("Whoops!");
                     }

                 }
                 else if (response.Equals("prime numbers"))

                     Console.WriteLine(@"I didn't finish this on my own :( 

     ────────────────██████████
     ────────────────██████████
     ────────────────██████████
     ─────────────▄▄▄██████████▄▄▄
     ───────────────▄▀░░░░░░░░▀▄
     ──────────────▐░░▄▀▀░░▀▀▄░░▌
     ──────────────▐░░██▀░░▀██░░▌
     ──────────────▐░░░░░▀▀░░░░░▌
     ──────────────▐░░░░░░░░░░░░▌
     ──────────────▐░░░▄▀▀▀▀▄░░░▌
     ───────────────▀▄░░░▀▀░░░▄▀
     ───────────────▐▒▀▄▄▄▄▄▄▀▒▌
     ────────▄▄▄▄▄▄▀▀▒▓▓▓▓▓▓▓▓▒▀▀▄▄▄▄▄▄
     ──────▄▀▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▀▄
     ─────▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓
     ────▓▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▓
     ───▓▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▓
     ──▓▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▓");
                 else
                 {
                     Console.WriteLine("Nope! Do better next time.");
                 }

                Console.WriteLine("Press any key to exit..");
               Console.ReadKey();
                 
        }
    }
}