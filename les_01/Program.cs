﻿using System;

namespace les_01
{
    class Programm
   {


        public static void Resume()
        {
            string name, surname;
            byte age;
            double height, width;

            Console.WriteLine(@"
  _      __  ____  __     _____  ____    __  ___  ____
 | | /| / / / __/ / /    / ___/ / __ \  /  |/  / / __/
 | |/ |/ / / _/  / /__  / /__  / /_/ / / /|_/ / / _/  
 |__/|__/ /___/ /____/  \___/  \____/ /_/  /_/ /___/   

   ___    __  __  ___    ___    __  __
  / _ )  / / / / / _ \  / _ \   \ \/ /
 / _  | / /_/ / / // / / // /    \  / 
/____/  \____/ /____/ /____/     /_/                                                                                                                                                                                               
");

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Full information: ");
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}");

            Console.WriteLine($"Your index mass index body is : {width/height*height}");


        }


        public static double Distance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void Reverse(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"First method: a = {a}, b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Second method: a = {a}, b = {b}");
            
        }

        public static void PersonalData()
        {
            string greeting = @"
________                .__             _____                         ___________    .__               _____       .__       
\______ \   ____   ____ |__| ______   _/ ____\______  ____   _____    \__    ___/___ |  |             /  _  \___  _|__|__  __
 |    |  \_/ __ \ /    \|  |/  ___/   \   __\\_  __ \/  _ \ /     \     |    |_/ __ \|  |    ______  /  /_\  \  \/ /  \  \/ /
 |    `   \  ___/|   |  \  |\___ \     |  |   |  | \(  <_> )  Y Y  \    |    |\  ___/|  |__ /_____/ /    |    \   /|  |\   / 
/_______  /\___  >___|  /__/____  >    |__|   |__|   \____/|__|_|  /    |____| \___  >____/         \____|__  /\_/ |__| \_/  
        \/     \/     \/        \/                               \/                \/                       \/               
            
";
            Console.SetCursorPosition((Console.WindowWidth - greeting.Length) / 2, Console.CursorTop);
            Console.WriteLine(greeting);
        }

        public static void Main(string[] args)
        {
            Resume();

            Console.WriteLine($"Distance: {Distance(-1, -3, 5, 5)}");

            Reverse(3, 5);

            PersonalData();

            Console.ReadKey();
        }
    }
}