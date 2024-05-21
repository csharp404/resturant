using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Tuple<string, string, string>> meals = new List<Tuple<string, string, string>>() {
       new Tuple<string,string,string>("mansaf","10$","meat"),
       new Tuple<string,string,string>("shawema","20$","chicken"),
       new Tuple<string,string,string>("sajeah","50$","meat and veg"),
        };
    back:
        {
            Console.WriteLine("enter the number of the option please :");
            Console.WriteLine("1.Main menu");
            Console.WriteLine("2.Add item");
            Console.WriteLine("3.Search");
            int fc = 0;
            if (int.TryParse(Console.ReadLine(), out int o))
            {
                fc = o;
            }
            if (fc == 1)
            {
                for (var i = 0; i < meals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{meals[i].Item1}");
                }
                Console.WriteLine("please enter the meal number :");
                int meall = int.Parse(Console.ReadLine());
                meall--;
                Console.WriteLine($"information meal is : {meals[meall].Item1} {meals[meall].Item2} {meals[meall].Item3}");
                goto back;
            }
            else if (fc == 2)
            {
                string name, price, des;
                Console.WriteLine("what is the name of meal :");
                name = Console.ReadLine();
                Console.WriteLine("what is the price :");
                price = Console.ReadLine();
                Console.WriteLine("what is the description :");
                des = Console.ReadLine();
                meals.Add(new Tuple<string, string, string>(name, price, des));
                goto back;
            }
            else
            {
                Console.WriteLine("what is the name of the meal that you want ?");
                string sr = Console.ReadLine();
                bool flag = true;
                foreach (var m in meals)
                {

                    if (sr == m.Item1)
                    {

                        Console.WriteLine($"the meal found  :) {m.Item1} {m.Item2} {m.Item3}");
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("the meal not found");
                }
                goto back;

            }


        }


    }
}