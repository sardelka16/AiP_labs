// на вход подаётся строка из латинскиих букв (могут быть и маленькие и большие, все одинаковые)
//необходимо определить символ реже всего встречающийся в подстроке a*b, где * исходный символ (если таких символов несколько - выдать их все)

using System;
class HelloWorld
{

    static void Main()
    {
        string s = Console.ReadLine();
        s = s.ToLower();
        string abba = ""; //строка со всеми звездочками
        for (int i =1; i<=s.Length - 2; i++)
        {
            if ((s[i - 1] == 'a')&& (s[i + 1] == 'b'))
            {
                abba += s[i];
            }
        }//записали все звёздочки
        int count = 1;
        string amount = "";//строка в которой будут записаны количества всех букв
        string letters = "";//строка в которой будут записаны буквы по очереди вхождения
        while (abba != "")
        {
            for (int i=1; i<=abba.Length - 1; i++)
            {
                if (abba[0] == abba[i])
                {
                    count++;
                }
            }
            amount += count.ToString();
            letters += abba[0];
            count = 1;
            abba = abba.Replace(abba[0].ToString(), "");
        }
        Console.WriteLine(letters);
        Console.WriteLine(amount);
        if (letters == "")
        {
            Console.WriteLine("Нет подходящих символов");
        }//Проверяем на наличие таких символов
        int min = 100;
        for (int i = 0; i<amount.Length; i++)
        {
            if (Convert.ToInt32(amount[i]) < min)
            {
                min= Convert.ToInt32(amount[i]);
            }
        }//Нашли минимум среди подходящих символов
        for(int i=0;i<amount.Length; i++)
        {
            if(amount[i] == min)
            {
                Console.Write(letters[i] + " ");
            }

        }
    }
}