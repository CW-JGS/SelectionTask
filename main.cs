using System;

class Program {
    static void Main(string[] args)
    {
        string InputUsername = "";
        string InputPassword = "";
        Console.WriteLine("Select Mode \n 1 = complex \n 2 = simple");
        Console.Write("\n Enter selection : ");
        int selection = Convert.ToInt32(Console.ReadLine());
        if (selection != 1 && selection != 2) Console.WriteLine("Error in user input");
        if (selection == 1)
        {

            Console.WriteLine("\n You have selected complex mode");
            string[] usernames = { "CW-JGS", "Coffee2022", "tim", "Johno", "student", "teacher"};
            string[] passwords = { "password", "is", "not", "a","good","password"};
            bool wasSuccessful = false;
            Console.Write("\n Enter your Username : ");
            InputUsername = Console.ReadLine();
            Console.Write("\n Enter your password : ");
            InputPassword = Console.ReadLine();
            Console.WriteLine("\n\n Validating Input");
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == InputUsername)
                {
                    if (passwords[i] == InputPassword)
                    {
                        wasSuccessful = true;
                    }
                    else
                    {
                        wasSuccessful = false;
                    }
                }
            }
            if (wasSuccessful != false)
            {
                Console.WriteLine($" Login Successful - welcome {InputUsername}");
            }else
            {
                Console.WriteLine(" Login Unsuccessful");
            }

        } else
        {
            Console.WriteLine("\n You have selected simple mode");
            string trueUsername = "Coffee2022";
            string truePassword = "incrediblyInsecure";
            Console.Write("\n Enter your Username : ");
            InputUsername = Console.ReadLine();
            Console.Write("\n Enter your Password : ");
            InputPassword = Console.ReadLine();
            if (InputUsername == trueUsername && InputPassword == truePassword) Console.WriteLine($"\n Login Successful - welcome {trueUsername} ");
            if (InputUsername != trueUsername) Console.WriteLine("\n Logon unsuccessful - User does not exist");
            if (InputUsername == trueUsername && InputPassword != truePassword) Console.WriteLine("\n Logon unsuccessful - Incorrect Password");
            
        }
    }
}
