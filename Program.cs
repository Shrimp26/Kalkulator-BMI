using System;

class Program {
    //Zaimplementuj kalkulator BMI (wskaźnik masy ciała, ang. body mass index) masa ciała [kg]/wzrost^2 [m].
    //Użytkownik jest proszony o podanie swojej wagi i wzrostu. Wynik obliczeń wyświetl w konsoli.
    static void Main()
    {
        Console.WriteLine("Kalkulator BMI");

        Console.WriteLine("Wprowadź proszę swoją wagę w kilogramach");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadź swój wzrost w metrach");
        double height = double.Parse(Console.ReadLine());

        double bmi = CalculateBMI(weight, height);

        Console.WriteLine($"Twoje BMI wynosi: ; {bmi:F2}");

        InterpretBMI(bmi);
    }

    static double CalculateBMI(double weight, double height)
    {return weight / (height* height); }


    static void InterpretBMI(double bmi)

    {
        if (bmi < 18.5)
        {
            Console.WriteLine("Niedowaga");
        }
        else if (bmi < 24.9)
        {
            Console.WriteLine("Waga normalna");
        }
        else if (bmi < 29.9)
        {
            Console.WriteLine("Nadwaga");
        }
        else
        {
            Console.WriteLine("Otyłość");
        }
    }
}