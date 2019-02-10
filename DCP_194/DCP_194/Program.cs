using System;

namespace DCP_194
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
           // string mobileNumber;
                 
            n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
             string  mobileNumber = Console.ReadLine();

                var Number = mobileNumber.Split(' ');
                double mobile =Convert.ToDouble (Number[0]);

                if (mobileNumber[0] == '8')
                {
                    if (mobileNumber[4] == '1')
                    {
                        Console.WriteLine($"{mobile} Citycell");
                    }
                    else if (mobileNumber[4] == '5')
                    {
                        Console.WriteLine($"{mobile} Teletalk");
                    }
                    else if (mobileNumber[4] == '6')
                    {
                        Console.WriteLine($"{mobile} Airtel");
                    }
                    else if (mobileNumber[4] == '7')
                    {
                        Console.WriteLine($"{mobile} Grameenphone");
                    }
                    else if (mobileNumber[4] == '8')
                    {
                        Console.WriteLine($"{mobile} Robi");
                    }
                    else if (mobileNumber[4] == '9')
                    {
                        Console.WriteLine($"{mobile} Banglalink");
                    }
                }
                else if(mobileNumber[0]=='0')
                {
                    if (mobileNumber[2] == '1')
                    {
                        Console.WriteLine($"880{mobile} Citycell");
                    }
                    else if (mobileNumber[2] == '5')
                    {
                        Console.WriteLine($"880{mobile} Teletalk");
                    }
                    else if (mobileNumber[2] == '6')
                    {
                        Console.WriteLine($"880{mobile} Airtel");
                    }
                    else if (mobileNumber[2] == '7')
                    {
                        Console.WriteLine($"880{mobile} Grameenphone");
                    }
                    else if (mobileNumber[2] == '8')
                    {
                        Console.WriteLine($"880{mobile} Robi");
                        //Console.WriteLine("v:880{0}", mobile );
                    }
                    else if (mobileNumber[2] == '9')
                    {
                        Console.WriteLine($"880{mobile} Banglalink");
                    }


                }
                
            }
           

        }
    }
}
