﻿using System;
class HelloWorld
{

    static void Main()
    {
        string s = Console.ReadLine();
        int max = 0;// ответом будет
        int count = 0; // счётчик 
        int step = 0;
        for (int i = 0; i < s.Length; i++)
        {// Идея идити по строке тройками и обнулять count в else
            if (s[i] == 'X')
            { // вошёл i = 0 count = 0 
                i++;
                count++;
                if (i < s.Length && s[i] == 'Y')
                { // вошёл i = 1 count = 1
                    i++;
                    count++;
                    if (i < s.Length && s[i] == 'Z')
                    {
                        count++;
                    }
                    else
                    {
                        if (count > max)
                        {
                            max = count;
                        }
                        count = 0;
                    } // else для Z

                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }

                    count = 0;
                } // else для Y
            }
            else
            {
                if (count > max)
                {
                    max = count;
                }
                count = 0;
            } // else для X
        }
        if (count > max)
        {
            max = count;
        } // если в конце не вышли
        Console.WriteLine(max);
    }
}