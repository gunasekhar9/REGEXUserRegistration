﻿using System;

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
                Console.WriteLine("Enter the validation to Execute : \n 1. Candidate First Name \n 2. Candidate Last Name \n 3. Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}