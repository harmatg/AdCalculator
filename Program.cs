using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace paksads
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.Write("How many ads?: ");
            int numberOfAds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of ads by Team (ALWAYS 30 SEC): ");
            int paksAds = Convert.ToInt32(Console.ReadLine());
            numberOfAds = numberOfAds + paksAds;                          
            string[] name = new string[numberOfAds];
            int[] lenght = new int[numberOfAds];
            int[] repeat = new int[numberOfAds];
            string[] listOfAds = new string[100];
            int RemainingLenghtOfMatch = 45 * 60;                                            //45 minutes in seconds  
            int totalLenghtOfAds = 0;


            
            for (int i = paksAds; i < numberOfAds; i++)                                     //First 4 ads are PaksAd
            {
                Console.Write("Name of ad: ");
                name[i] = Console.ReadLine();
                Console.Write("Lenght of ad (in seconds): ");
                lenght[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many times will it be repeated?: ");
                repeat[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Next");
            }



            for (int i = paksAds; i < numberOfAds; i++)
            {
               totalLenghtOfAds = lenght[i] * repeat[i];
            }
            int paksAdTimes = (RemainingLenghtOfMatch - totalLenghtOfAds) / (paksAds * 30);     //How many times PaksAd will be repeated (PAKSADS ARE ALWAYS 30 SEC)

            for (int i = 0; i < paksAds; i++)                                               //First 4 ads are PaksAd
            {
                name[i] = "TeamAd" + i;
                lenght[i] = 30;
                repeat[i] = paksAdTimes;
            }

            while (RemainingLenghtOfMatch > 0)
            {
                for (int i = 0; i < numberOfAds; i++)
                {
                    if(repeat[i] > 0)
                    {
                        listOfAds[i] = name[i];
                        RemainingLenghtOfMatch = RemainingLenghtOfMatch - lenght[i];
                        repeat[i] = repeat[i] - 1;
                        Console.Write($"{listOfAds[i]}, ");
                    }
                }
            }


            

            Console.ReadKey();
        }
    }
}
