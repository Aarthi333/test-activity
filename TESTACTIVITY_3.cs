using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace TestActivity3
{
    class Program
    {
         public void DivisibleBySeven()
        {
            Console.WriteLine("enter the 10 numbers");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the numbers DIVISIBLE by 7 are:");
            foreach (int item in num)
            {
                if (item % 7 == 0)
                Console.WriteLine(item);     
            }
        }

        public void PrimeMaxMin()
        {
            Console.WriteLine("enter the minimum value");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the maximum value");
            int max = Convert.ToInt32(Console.ReadLine());
            if (min > max)
                Console.WriteLine("enter proper min and max values");
            else
            {
                int flag;
                Console.WriteLine("\nPrime numbers between " +
                         "{0} and {1} are: ", min, max);
                for (int i = min; i <= max; i++)
                {
                    if (i == 1 || i == 0)
                        continue;
                       flag = 1;

                    for (int j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag == 1)
                        Console.WriteLine(i);
                }
            }
        }
        public void RepeatingNumbers()
        {
            Console.WriteLine("enter a number to continue.** Press a negative number  to quit**");
            List<int> sum = new List<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("exiting...");
            }
            else
            {
                    int size;
                    Console.WriteLine("please enter the count of numbers you want to enter");
                    size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the  numbers");
                    for (int i = 0; i < size; i++)
                    {
                        int num = Convert.ToInt32(Console.ReadLine());
                        sum.Add(num);
                    }
                    Console.WriteLine("the numbers repeating are");
                    for (int i = 0; i < size; i++)
                    {
                    for (int j = i+1; j < size; j++)
                    {
                        if (sum[i] == sum[j])
                        {
                            Console.WriteLine(sum[j]);
                        }
                    }
                }

            } 
        }
        public void SortingNumbers()
        {
            int n = 0;
            List<int> result = new List<int>();
            do
            {
                Console.WriteLine("ENTER THE NUMBER");
                n = Convert.ToInt32(Console.ReadLine());
                result.Add(n);
            } while (n != 0);
            result.Sort();
            Console.WriteLine("the numbers after sorting are");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void CheckLoginDeatils()
        {
            bool flag = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the username");
                string user = Console.ReadLine();
                if (user == "Admin")
                {
                    Console.WriteLine("correct username");
                    flag = true;
                }
                else
                    Console.WriteLine("incorrect username");
                Console.WriteLine("enter the password");
                string passwrd = Console.ReadLine();
                if (passwrd == "admin")
                {
                    Console.WriteLine("correct password");
                    flag = true;
                    break;
                }
                else
                    Console.WriteLine("incorrect password");
            }
            if (flag==true)
            Console.WriteLine("Welcome");
              else
                Console.WriteLine("account locked");
        }
        public void CowBullGame()
        {
            //List<string> map = new List<string>();
            //map = ["kite", "four", "neat", "play", "goal"];
            string[] secret = { "kite", "four", "neat", "play", "goal" };
            string s1 = secret[0];
            string s2 = secret[1];
            string s3 = secret[2];
            string s4 = secret[2];
            string s5 = secret[2];
            int choice = 0;
            do
            {
                Console.WriteLine("If you wish to play ,Choose a number between 1 to 5.");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your guess");
                string guess = Console.ReadLine();
                var count1 = 0;
                var count2 = 0;
                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < s1.Length; i++)
                        {
                            if (s1[i] == guess[i])
                            {
                                count1 = count1 + 1;
                            }
                        }
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (guess[i] == 'i' || guess[i] == 't' || guess[i] == 'e')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (guess[i] == 'k' || guess[i] == 't' || guess[i] == 'e')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (guess[i] == 'k' || guess[i] == 'i' || guess[i] == 'e')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (guess[i] == 'k' || guess[i] == 'i' || guess[i] == 't')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }

                        }
                        Console.WriteLine(+count1 + " COW " + count2 + "BULL");
                        //console.log(count1);
                        int win = s1.Length;
                        if (count1 == win)
                        {
                            Console.WriteLine("winner");
                        }
                        else
                        {
                            Console.WriteLine("try again!");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < s2.Length; i++)
                        {
                            if (s2[i] == guess[i])
                            {
                                count1 = count1 + 1;
                            }
                        }
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (guess[i] == 'o' || guess[i] == 'u' || guess[i] == 'r')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (guess[i] == 'f' || guess[i] == 'u' || guess[i] == 'r')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (guess[i] == 'f' || guess[i] == 'o' || guess[i] == 'r')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (guess[i] == 'f' || guess[i] == 'o' || guess[i] == 'u')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(+count1 + " COW " + count2 + "BULL");
                        //console.log(count1);
                        int win2 = s2.Length;
                        if (count1 == win2)
                        {
                            Console.WriteLine("winner");
                        }
                        else
                        {
                            Console.WriteLine("try again!");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < s3.Length; i++)
                        {
                            if (s3[i] == guess[i])
                            {
                                count1 = count1 + 1;
                            }
                        }
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (guess[i] == 'e' || guess[i] == 'a' || guess[i] == 't')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (guess[i] == 'n' || guess[i] == 'a' || guess[i] == 't')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (guess[i] == 'n' || guess[i] == 'e' || guess[i] == 't')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (guess[i] == 'n' || guess[i] == 'e' || guess[i] == 'a')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }

                        }
                        Console.WriteLine(+count1 + " COW " + count2 + "BULL");
                        //console.log(count1);
                        int win3 = s3.Length;
                        if (count1 == win3)
                        {
                            Console.WriteLine("winner");
                        }
                        else
                        {
                            Console.WriteLine("try again!");
                        }
                        break;
                    case 4:
                        for (int i = 0; i < s4.Length; i++)
                        {
                            if (s4[i] == guess[i])
                            {
                                count1 = count1 + 1;
                            }
                        }
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (guess[i] == 'l' || guess[i] == 'a' || guess[i] == 'y')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (guess[i] == 'p' || guess[i] == 'a' || guess[i] == 'y')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (guess[i] == 'p' || guess[i] == 'l' || guess[i] == 'y')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (guess[i] == 'p' || guess[i] == 'l' || guess[i] == 'a')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(+count1 + " COW " + count2 + "BULL");
                        //console.log(count1);
                        int win4 = s1.Length;
                        if (count1 == win4)
                        {
                            Console.WriteLine("winner");
                        }
                        else
                        {
                            Console.WriteLine("try again!");
                        }
                        break;
                    case 5:
                        for (int i = 0; i < s5.Length; i++)
                        {
                            if (s5[i] == guess[i])
                            {
                                count1 = count1 + 1;
                            }
                        }
                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (guess[i] == 'o' || guess[i] == 'a' || guess[i] == 'l')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 1)
                            {
                                if (guess[i] == 'g' || guess[i] == 'a' || guess[i] == 'l')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 2)
                            {
                                if (guess[i] == 'g' || guess[i] == 'o' || guess[i] == 'l')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                            if (i == 3)
                            {
                                if (guess[i] == 'g' || guess[i] == 'o' || guess[i] == 'a')
                                {
                                    count2 = count2 + 1;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(+count1 + " COW " + count2 + "BULL");
                        //console.log(count1);
                        int win5 = s5.Length;
                        if (count1 == win5)
                        {
                            Console.WriteLine("winner");
                        }
                        else
                        {
                            Console.WriteLine("try again!");
                        }
                        break;
                    default:
                        Console.WriteLine("invalid guess");
                        break;
                }
            } while (choice != 6);
        }
        public int n { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public void CheckCreditCard()
        {
            int[] CardNum = new int[16];
            int[] CvvNum = new int[3];
            Console.WriteLine("please enter the card number");
            for (int i = 0; i < CardNum.Length; i++)
            {
                CardNum[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] REVCardNum = new int[16];
            for (c = REVCardNum.Length - 1, d = 0; c >= 0; c--, d++)
            {
                REVCardNum[d] = CardNum[c];
            }
            Console.WriteLine("the reversed card number is : ");
            for (int i = 0; i < REVCardNum.Length; i++)
            {
                Console.WriteLine(REVCardNum[i]);
            }
            Console.WriteLine("changing the even position");
            for (int i = 0; i < REVCardNum.Length; i++)
            {
                if (i % 2 == 0)
                {
                    REVCardNum[i + 1] = REVCardNum[i + 1] * 2;
                }
                Console.WriteLine(REVCardNum[i]);
            }
            Console.WriteLine("changing the even position sum into a single digit");
            for (int i = 0; i < REVCardNum.Length; i++)
            {
                int sum = 0;
                if (i % 2 == 0)
                {
                    if (REVCardNum[i + 1] > 10)
                    {
                        while (REVCardNum[i + 1] > 0)
                        {
                            n = REVCardNum[i + 1] % 10;
                            sum = sum + n;
                            REVCardNum[i + 1] = (REVCardNum[i + 1] / 10);
                        }
                        REVCardNum[i + 1] = sum;
                    }
                }
                Console.WriteLine(REVCardNum[i]);
            }
            Console.WriteLine(" calculating the total sum of the card number.....");
            int sum1 = 0;
            for (int i = 0; i < REVCardNum.Length; i++)
            {
                sum1 = REVCardNum[i] + sum1;
            }
            Console.WriteLine("the total sum is " + sum1);
            if (sum1 % 10 == 0)
                Console.WriteLine("the given card number is valid");
            else
                Console.WriteLine("the card number is not valid");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //new Program().DivisibleBySeven();  //q.no:1
            //new Program().PrimeMaxMin();         //q.no:2
            //new Program().RepeatingNumbers();         //q.no:3
            //new Program().SortingNumbers();           //q.no:4
            //new Program().CheckLoginDeatils();          //q.no:5
            //new Program().CowBullGame();                //q.no:6
            //new Program().CheckCreditCard();   //q.no:7
        }
    }
}
