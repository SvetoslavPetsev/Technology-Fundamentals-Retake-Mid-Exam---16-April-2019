using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main()
        {
            List<string> shopLIst = Console.ReadLine().Split().ToList();
            int numberCommads = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCommads; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Include")
                {
                    string shop = command[1];
                    shopLIst.Add(shop);
                }
                else if (command[0] == "Visit")
                {
                    string direction = command[1];
                    int numberOfShops = int.Parse(command[2]);
                    if (numberOfShops <= shopLIst.Count)
                    {
                        if (direction == "first")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shopLIst.RemoveAt(0);
                            }
                        }
                        else if (direction == "last")
                        {
                            for (int k = 0; k < numberOfShops; k++)
                            {
                                shopLIst.RemoveAt(shopLIst.Count - 1);
                            }
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int shopIndex1 = int.Parse(command[1]);
                    int shopIndex2 = int.Parse(command[2]);
                    if ((shopIndex1 >= 0 && shopIndex1 < shopLIst.Count) && (shopIndex2 >= 0 && shopIndex2 < shopLIst.Count))
                    {
                        string shop1 = shopLIst[shopIndex1];
                        string shop2 = shopLIst[shopIndex2];

                        shopLIst.Insert(shopIndex1, shop2);
                        shopLIst.RemoveAt(shopIndex1 + 1);
                        shopLIst.Insert(shopIndex2, shop1);
                        shopLIst.RemoveAt(shopIndex2 + 1);
                    }
                }
                else if (command[0] == "Place")
                {
                    string shop = command[1];
                    int index = int.Parse(command[2]) + 1;

                    if (index >= 0 && index < shopLIst.Count)
                    {
                        shopLIst.Insert(index, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shopLIst));
        }
    }
}
