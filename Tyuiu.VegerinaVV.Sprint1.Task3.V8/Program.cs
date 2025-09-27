using Tyuiu.VegerinaVV.Sprint1.Task3.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;
        Console.WriteLine(" Величина вклада (руб.) -> ");
        x = Convert.ToDouble(Console.ReadLine());

        double y;
        Console.WriteLine(" Процентная ставка (годовых) -> ");
        y = Convert.ToDouble(Console.ReadLine());

        double z;
        Console.WriteLine(" Срок вклада (дней) -> ");
        z = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(" Доход по вкладу = " + ds.IncomeAmount(x, y, z));

        double s = x + ds.IncomeAmount(x, y, z);
        Console.WriteLine(" Сумма по окончании срока вклада = " + s);


        Console.ReadLine();

    }
}