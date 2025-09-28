using Tyuiu.VegerinaVV.Sprint1.Task5.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Вегерина В.В. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и  Class Convert                             *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Вегерина Виктория Вячеславовна | ИИПб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
        Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
        Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение f (0<f<360): ");
        double f = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = Convert.ToInt32(ds.AngleToHoursMinutes(f));
        Console.WriteLine("Полное количество часов прошедших от начала суток: " + res);

        Console.ReadKey();
        

    }
}