using System;
class Atm
{
    int x = 1000;
    public void avalibleamount()
    {
        // this.x = x;
        Console.WriteLine(x);
    }
    public void deposit(int y)
    {
        x += y;
        Console.WriteLine(x);
    }
    public void withdraw(int u)
    {
        if (x < 500 || x < u)
        {
            Console.WriteLine("insufficeint fund" + " " + x);
        }
        else
        {
            x -= u;
            Console.WriteLine("sucess");
        }
    }
}
namespace P {
    class H {
    static void Main()
        {
            Atm a = new Atm();
            bool n = true;
            while(n){
            Console.WriteLine("select 1 for amount checking");
            Console.WriteLine("select 2 for amount deposit");
            Console.WriteLine("select 3 for amount withdraw");
                int am = Convert.ToInt32(Console.ReadLine());
                switch (am)
                {
                    case 1:
                        {
                            a.avalibleamount();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter the amount to deposit");
                            int h = Convert.ToInt32(Console.ReadLine());
                            a.deposit(h);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter amount to withdraw");
                            int d = Convert.ToInt32(Console.ReadLine());
                            a.withdraw(d);
                            break;
                        }
                }
                Console.WriteLine("if u wants to go for main menu type YES , to exit NO");
                string t = Console.ReadLine();
                if (t == "yes" || t =="YES")
                {
                    n = true;
                }
                if(t=="no" || t == "NO")
                {
                    n = false;
                }
            }
            Console.WriteLine("Thanks for visit");
        }
    }
}