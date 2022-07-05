using System;
using System.Diagnostics;

namespace lab_assignment
{
    class timer
    {
        private int I_Timer = 0;
        private int I_Countdown_Interval = 1;
        private char C_Response_1;
        private bool B_Simple_Timer = false;

        static void Main()
        {
            Console.WriteLine("                 ______________________________________\n");
            Console.WriteLine("                /|                                    |\n");
            Console.WriteLine("               | |       THIS IS A COUNTDOWN          |\n");
            Console.WriteLine("               | |            PROGRAM!                |\n");
            Console.WriteLine("               | |____________________________________|\n");
            Console.WriteLine("               |/____________________________________/  ");

            Console.WriteLine("\n \n  _____________________");
            Console.WriteLine("\n | SET THE TIME [T]   |");
            if (B_Simple_Timer == true)
            {
                Console.WriteLine("\n ----------------------");
                Console.WriteLine("\n | SIMPLE TIMER [A]   |");
            }
            Console.WriteLine("\n ----------------------");
            Console.WriteLine("\n | SETTINGS [S]       |");
            Console.WriteLine("\n ----------------------");
            Console.WriteLine("\n | EXIT [X]           |");

            Console.WriteLine("\n \n:");

            char C_Response_1 = char.Parse(Console.ReadLine());



            if (C_Response_1 == 'T' || C_Response_1 == 't')

                Clock_Featured_Timer_Section();

            else if (C_Response_1 == 'X' || C_Response_1 == 'x')

                Process.Start("exit");

            else if (C_Response_1 == 's' || C_Response_1 == 'S')

                Setting_Section();

            else if (C_Response_1 == 'a' || C_Response_1 == 'A')

                Simple_Timer_Section();

            else

            {
                Process.Start("cls");
                timer.Main();
            }

        }

        void Simple_Timer_Section()
        {

            int I_Current_Time = 0;
            int I_Elasped_Time = 0;


            Process.Start("cls");

            Console.WriteLine("\n \n SET THE TIME TO: ");
            I_Timer = int.Parse(Console.ReadLine());



            while (I_Timer > 0)
            {
                if (I_Timer < 10)
                {
                    Process.Start("cls");
                    Console.WriteLine("  ____________________________________ \n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine($"|               {I_Timer--}          |\n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine(" |____________________________________|\n \n");

                    Console.WriteLine(" COUNTDOWN IN PROGRESS!                 \n");
                }
                else if (I_Timer >= 10 && I_Timer < 100)
                {
                    Process.Start("cls");
                    Console.WriteLine("  ____________________________________ \n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine($"|                {I_Timer--}          |\n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine(" |____________________________________|\n \n");

                    Console.WriteLine(" COUNTDOWN IN PROGRESS!                 \n");


                }
                else if (I_Timer >= 100 && I_Timer < 1000)
                {

                    Process.Start("cls");
                    Console.WriteLine("  ____________________________________ \n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine($"|                {I_Timer--}          |\n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine(" |____________________________________|\n \n");

                    Console.WriteLine(" COUNTDOWN IN PROGRESS!                 \n");
                }

                I_Current_Time = time(NULL);
                //wait
                do
                {

                    I_Elasped_Time = time(NULL);

                } while (I_Elasped_Time - I_Current_Time < I_Countdown_Interval);


                if (I_Timer == 0)
                {
                    Process.Start("cls");
                    Console.WriteLine("  ____________________________________ \n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine(" |                0                   |\n");
                    Console.WriteLine(" |                                    |\n");
                    Console.WriteLine(" |____________________________________|\n \n");
                    Console.WriteLine("\n THE COUNTDOWN IS COMPLETE! \n");

                    Return_Home_Section();
                }

            }

        }

        void Setting_Section()
        {

            char C_Response_2;

            char C_Response_5 = 's';

            Process.Start("cls");

            Console.WriteLine("         _______________________________________\n");
            Console.WriteLine("        |                                       |\n");
            Console.WriteLine($"       |      COUNTDOWN INTERVAL VALUE:{I_Countdown_Interval}    |\n");
            Console.WriteLine("        |      CLOCK FEATURE:[ON]              |\n");
            Console.WriteLine("        |_______________________________________|\n");
            Console.WriteLine("\n  ______________________________________");
            Console.WriteLine("\n | CHANGE COUNTDOWN INTERVAL VALUE [C]  |");
            Console.WriteLine("\n  --------------------------------------");
            Console.WriteLine("\n | TURN CLOCK FEATURE ON or OFF [Z]     |");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n | RETURN HOME [H]                      |");
            Console.WriteLine("\n ---------------------------------------");
            Console.WriteLine("\n | EXIT [X]                             |");

            Console.WriteLine("\n \n:");

            C_Response_2 = char.Parse(Console.ReadLine());


            if (C_Response_2 == 'c' || C_Response_2 == 'C')
            {

                Console.WriteLine("ENTER NEW VALUE:");
                I_Countdown_Interval = int.Parse(Console.ReadLine());

                Process.Start("cls");
                Console.WriteLine("the value has been set to:%d \n ", I_Countdown_Interval);

                Return_Home_Section();

            }

            else if (C_Response_2 == 'h' || C_Response_2 == 'H')

                Return_Home_Section();

            else if (C_Response_2 == 'z' || C_Response_2 == 'Z')
            {
                Console.WriteLine("ARE YOU SURE THAT YOU WANT TO TURN CLOCK FEATURE OFF?[Y/N]");

                C_Response_5 = char.Parse(Console.ReadLine());
            }

            if (C_Response_5 == 'y' || C_Response_5 == 'Y')

            {

                Console.WriteLine("CLOCK FEATURE IS NOW OFF. \n ");

                B_Simple_Timer = true;

                Return_Home_Section();

            }
        }

        void Clock_Featured_Timer_Section()
        {
            int I_Current_Time = 0;
            int I_Elasped_Time = 0;
            int hours = 0, minutes = 0, seconds = 0;
            int I_Time_Intake = 1;
            bool input_format_error_flag = false;
            bool input_value_error_flag = false;
            string str_Response_10;

            Process.Start("cls");

            Console.WriteLine("         _______________________________________\n");
            Console.WriteLine("        |                                       |\n");
            Console.WriteLine("        |             SET THE TIME              |\n");
            Console.WriteLine("        |           (Hour/Minute/Sec            |\n");
            Console.WriteLine("        |_______________________________________|\n");

            do
            {
                string hold = Console.ReadLine();
                string[] arr = hold.Split('/');
                hours = int.Parse(arr[0]);
                minutes = int.Parse(arr[1]);
                seconds = int.Parse(arr[2]);

                if (input_value_error_flag)
                {
                    Console.WriteLine("Error! time cannot be less than zero");
                }
                if (input_format_error_flag)
                    Console.WriteLine("Error! Wrong format");

                if (!input_format_error_flag || !input_value_error_flag)
                {

                    Console.WriteLine("\n\n ENTER (GO) TO START THE TIMER:");
                    str_Response_10 = Console.ReadLine();

                    I_Time_Intake = (hours * 3600) + (minutes * 60) + (seconds);

                    if (str_Response_10.ToUpper() == "GO")
                    {

                        while (I_Time_Intake > 0)
                        {

                            seconds = I_Time_Intake;

                            hours = seconds / 3600;

                            minutes = seconds / 60;

                            minutes = minutes % 60;

                            seconds = seconds % 60;

                            Process.Start("cls");
                            Console.WriteLine("\n                         ++++++++++++++++++++++++++++");
                            Console.WriteLine("\n                         |                          |");
                            Console.WriteLine($"\n                             {hours} | {minutes} | {seconds}");
                            Console.WriteLine("\n                         |                          |");
                            Console.WriteLine("\n                         ++++++++++++++++++++++++++++ \n");

                            I_Current_Time = time(NULL);

                            do
                            {

                                I_Elasped_Time = time(NULL);

                            } while (I_Elasped_Time - I_Current_Time < I_Countdown_Interval);

                            I_Time_Intake--;


                        }
                    }

                    if (I_Time_Intake == 0)
                    {
                        Process.Start("cls");
                        Console.WriteLine("\n           ++++++++++++++++++++++++++++");
                        Console.WriteLine("\n           |                          |");
                        Console.WriteLine($"\n              {hours} | {minutes} | 0 |");
                        Console.WriteLine("\n           |                          |");
                        Console.WriteLine("\n           ++++++++++++++++++++++++++++ \n");
                        Console.WriteLine("\n  \n THE COUNTDOWN IS COMPLETE! \n");

                        Return_Home_Section();
                    }
                    else
                    {
                        Console.WriteLine("YOUR INPUT WAS DIFFRENT FROM (GO)");
                        Return_Home_Section();
                    }
                }
            } while (input_format_error_flag || input_value_error_flag);

        }

        void Return_Home_Section()
        {
            Console.WriteLine("WOULD YOU LIKE TO RETURN HOME NOW? [Y/N] \n :");

            C_Response_1 = char.Parse(Console.ReadLine());

            if (C_Response_1 == 'y' || C_Response_1 == 'Y')
            {
                Process.Start("cls");
                timer.Main();
            }
            else if (C_Response_1 == 'n' || C_Response_1 == 'N')
                Process.Start("exit");

            else
                Return_Home_Section();
        }

    }
}
