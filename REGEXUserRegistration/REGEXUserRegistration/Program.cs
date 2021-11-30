using System;

namespace REGEXUserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to REGEX User Registration");
            UserRegistration validation = new UserRegistration();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the User Registration validation program");
                Console.WriteLine("Enter the validation to Execute : \n 1. Candidate First Name \n 2. Candidate Last Name \n 3. Candidate Email \n 4. Mobile Number \n 5. Password Rule=1 \n 6. Password Rule=2 \n 7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(validation.ValidateFirstName("Gunasekhar"));
                        break;
                    case 2:
                        Console.WriteLine(validation.ValidateLastName("Satharajupalli"));
                        break;
                    case 3:
                        Console.WriteLine(validation.ValidateEmail("gunasekhar.abc@bl.co.in"));
                        break;
                    case 4:
                        Console.WriteLine(validation.ValidateMobile("91 9848032919"));
                        break;
                    case 5:
                        Console.WriteLine(validation.ValidatePassword1("gunanani"));
                        break;
                    case 6:
                        Console.WriteLine(validation.ValidatePassword2("Gunanani"));
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}