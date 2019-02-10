using System;

namespace DCP_273
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string s;
            n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                s = Console.ReadLine();
                //var k = s.Split(' ');
                //var v = Convert.ToString(k[0]);
                int n1 = s.Length;
                // Console.WriteLine(n1);
                int y = 0;
                for(int j=0; j<n1; j++)
                {

                    if (s[j] == 'r')
                    {
                        y++;
                        break;
                    }
                }
                
                if (y == 1)
                {
                    Console.WriteLine("Not vely easy");

                }
                else
                {
                    Console.WriteLine("Vely easy");
                }

            }
        }
    }
}
