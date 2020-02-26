using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main()
        {
            List<string> giftList = Console.ReadLine().Split().ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No Money")
                {
                    break;
                }
                string currGift = "";
                string[] command = input.Split().ToArray();
                if (command[0] == "OutOfStock")
                {
                    currGift = command[1];
                    for (int i = 0; i < giftList.Count; i++)
                    {
                        if (giftList[i] == currGift)
                        {
                            giftList[i] = "None";
                        }
                    }
                }
                else if (command[0] == "Required")
                {
                    currGift = command[1];
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < giftList.Count)
                    {
                        giftList.Insert(index, currGift);
                        giftList.RemoveAt(index + 1);
                    }
                }
                else if (command[0] == "JustInCase")
                {
                    currGift = command[1];
                    giftList.Insert(giftList.Count - 1, currGift);
                    giftList.RemoveAt(giftList.Count - 1);
                }
            }
            Console.WriteLine(string.Join(" ", giftList.Where(x => x != "None")));
        }
    }
}
