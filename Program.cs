namespace ASSIGNMENT_KO_1
{ //Lauron, Clarence Christopher L
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER USERNAME: ");
            String Kanye = Console.ReadLine();
            Console.Write("Enter Password: ");
            String password = Console.ReadLine();
            if (Kanye == "Admin" && password == "Admin1234!")
            {
                Console.WriteLine("Log in Successful!");
            }
            else
            {
                Console.WriteLine("\nIncorrect USERNAME OR PASSWORD, TRY AGAIN");
                Console.WriteLine("\t(3 attemps remaining)");

                Console.Write("ENTER USERNAME: ");
                String Kanye2 = Console.ReadLine();
                Console.Write("Enter Password: ");
                String password2 = Console.ReadLine();
                if (Kanye2 == "Admin" && password2 == "Admin1234!")
                {
                    Console.WriteLine("Log in Successful!");
                }
                else
                {
                    Console.WriteLine("\nIncorrect USERNAME OR PASSWORD, TRY AGAIN");
                    Console.WriteLine("\t(2 attemps remaining)");

                    Console.Write("ENTER USERNAME: ");
                    String Kanye3 = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    String password3 = Console.ReadLine();
                    if (Kanye == "Admin" && password == "Admin1234!")
                    {
                        Console.WriteLine("Log in Successful!");
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect USERNAME OR PASSWORD, TRY AGAIN");
                        Console.WriteLine("\t(1 attemps remaining)");

                        Console.Write("ENTER USERNAME:");
                        String Kanye4 = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        String password4 = Console.ReadLine();
                        if (Kanye == "Admin" && password == "Admin1234!")
                        {
                            Console.WriteLine("Log in Successful!");
                        }
                        else
                        {
                            Console.WriteLine("\nIncorrect USERNAME OR PASSWORD");
                            Console.WriteLine("\t(Too many attemps, Try again in 1 hour)");

                        }
                    }
                }
            }
        }
    }
}
