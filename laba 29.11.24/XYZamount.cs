//необходимо определить максимальную длину подпоследовательности, состоящую из троек элементов XYZ (последняя тройка может быть неполной)


using System;
class HelloWorld
{

    static void Main()
    {
        string s = Console.ReadLine();
        int max = 0;
        int count = 0;
        int lenght = s.Length;
        for (int i = 0; i < lenght; i++)
        {
            if (s[i] == 'X')
            { 
                i++;
                count++;
                if (i < lenght && s[i] == 'Y')
                { 
                    i++;
                    count++;
                    if (i < lenght && s[i] == 'Z')
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
                    } // если не Z

                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }

                    count = 0;
                } // если не Y
            }
            else
            {
                if (count > max)
                {
                    max = count;
                }
                count = 0;
            } // если не X
        }
        if (count > max)
        {
            max = count;
        }
        Console.WriteLine(max);
    }
}