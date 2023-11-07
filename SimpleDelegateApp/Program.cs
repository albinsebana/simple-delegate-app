using System.Threading.Channels;

namespace SimpleDelegateApp
{
    internal class Program
    {
        delegate void DMyDelegate(string message);
        static void Main(string[] args)
        {
            DMyDelegate myDelegate ;
            myDelegate = ShowHelloMessage;
            myDelegate = ShowGoodByeMessage;
            
            myDelegate("Albin");

            Console.WriteLine(new string('-', 31));

            myDelegate+= ShowHelloMessage;
            myDelegate += ShowHelloMessage;
            myDelegate = ShowGoodByeMessage;
            myDelegate("Albii");

            string a = new string('i', 31);

            Console.WriteLine(new string('-', 31));
            myDelegate = ShowHelloMessage;
            myDelegate = ShowGoodByeMessage;
            myDelegate($"Albii{a}");
            Console.WriteLine(new string('-', 31));
            Console.WriteLine("\nCall back with delegate");
            PrintWizard(delegate (string studentName)//anonyums fn
            {
                Console.WriteLine("How Are You "+studentName);

            }
            );
            Console.WriteLine(new string('-', 31));
            Console.WriteLine("\nArrow fuction");
            PrintWizard((studentName) =>
            {
                Console.WriteLine("HAve a nice Day " + studentName);
            });

           PrintWizard((studentName) => Console.WriteLine("HAve a nice Day " + studentName));
        }
        static void PrintWizard(DMyDelegate myDelegate)
        {
            Console.WriteLine("Enter Your Name");
            string name=Console.ReadLine();
            myDelegate(name);
        }


        static void ShowHelloMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void ShowGoodByeMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}