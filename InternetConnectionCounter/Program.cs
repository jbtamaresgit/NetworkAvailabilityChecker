using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace InternetConnectionCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            int counter = 0;

            while (true)
            {
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    counter++;
                    Console.WriteLine($"{counter} - {DateTime.Now.ToString()}");
                    Thread.Sleep(120000); //A timer for before my connection get fully connected again
                }
            }
        }
    }
}
