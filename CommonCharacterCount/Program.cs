using System;

namespace CommonCharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string firstString = Console.ReadLine();
            Console.Write("Enter another string: ");
            string secondString = Console.ReadLine();
            Console.WriteLine($"The count of common characters is {commonCharacterCount(firstString, secondString)}!");
            Console.ReadLine();
        }
        static int commonCharacterCount(string s1, string s2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                bool isDouble = false;
                bool isUsed = false;
                for (int q = i - 1; q >= 0; q--)
                {
                    if (s1[i] == s1[q])
                    {
                        isUsed = true;
                    }
                }
                if (i == 0)
                {
                    int s1count = 1;
                    int s2count = 0;
                    for (int j = i + 1; j < s1.Length - i; j++)
                    {
                        if (s1[i] == s1[j])
                        {
                            isDouble = true;
                            s1count++;
                        }
                    }
                    if (isDouble == true)
                    {
                        for (int k = 0; k < s2.Length; k++)
                        {
                            if (s1[i] == s2[k])
                            {
                                s2count++;
                            }
                        }
                    }
                    if (s1count < s2count)
                    {
                        count += s1count;
                    }
                    else
                    {
                        count += s2count;
                    }
                }
                else if (i == s1.Length - 1)
                {
                    if (isUsed == false)
                    {
                        for (int k = 0; k < s2.Length; k++)
                        {
                            if (s1[i] == s2[k])
                            {
                                count++;
                                isUsed = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    int s1count = 1;
                    int s2count = 0;
                    if (isUsed == false)
                    {
                        for (int j = i + 1; j < s1.Length - i; j++)
                        {
                            if (s1[i] == s1[j])
                            {
                                if (s1[i] == s1[j] && isUsed == false)
                                {
                                    isDouble = true;
                                    s1count++;
                                }
                            }
                        }
                        if (isDouble == true)
                        {
                            for (int k = 0; k < s2.Length; k++)
                            {
                                if (s1[i] == s2[k])
                                {
                                    s2count++;
                                }
                            }
                            if (s1count < s2count)
                            {
                                count += s1count;
                            }
                            else
                            {
                                count += s2count;
                            }
                        }
                    }
                }
                if(isDouble == false && isUsed == false)
                for (int k = 0; k < s2.Length; k++)
                {
                    if (s1[i] == s2[k])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}
