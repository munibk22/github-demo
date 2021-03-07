using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Functions_and_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {

             decimal Multiply(decimal a, decimal b,decimal c)
            {
              
                decimal result = a * b * c;
                Console.WriteLine(result);
                return result;
            }

            Multiply(5, 5, 2);

            bool CheckSum(int number1, int number2)
            {
                if (number1 == 20 || number2 == 20)
                {
                    return true;
                }
                else if (number1 + number2 == 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool result2 = CheckSum(10, 20);
            Console.WriteLine(result2);


            string ConverttoLowerCase(string stringtoconvert)
            {
                return stringtoconvert.ToLower();
            }


            string resultC = ConverttoLowerCase("CONVERT THIS LOUD SENTENCE TO LOWERCASE");
            Console.WriteLine(resultC);


            string ChecknReplace(string stringtoCheck)
            {
                if (stringtoCheck.Contains("$url") == true)
                {
                    return stringtoCheck.Replace("$url", "https://myurl.com");
                }

                return stringtoCheck;
            }

            string result4 = ChecknReplace("The address to my poorfolio is: $url");
            Console.WriteLine(result4);


            int listCount(List<int> listNum)
            {
                //List<int> list = new List<int>() { 0,3, 2, 5, 4, 5 };
                //Console.WriteLine(list.Count);
                return listNum.Count;
            }

            List<int> listA = new List<int>() { 0,1,12,3, 2, 5, 4, 5 };
            int result5 = listCount(listA);
            Console.WriteLine(result5);

            List<string> newList(List<string> oldList)
            {

                //oldList[oldList.FindIndex(ind => ind.Equals("5"))] = "30";

                for (int i = 0; i < oldList.Count; i++)
                {

                    if (oldList[i].Contains("5"))
                    {
                        oldList[i] = "30";
                        return oldList;
                    }


                }
                return oldList;

            }

                List<string> listB = new List<string>() { "0", "1", "12", "3", "2", "5", "4", "5" };

                List<string> result6 = newList(listB);
                Console.WriteLine(result6);


            

            }
        }
    }

