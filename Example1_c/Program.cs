
            //Добавить диалог с использованием switch демонстрирующий работу класса.
            //Тарорико Мария
            Complex z1 = new Complex(2, 3);
            System.Console.WriteLine(z1);

            Complex z2 = new (4, 5);
            System.Console.WriteLine(z2);
            
            Complex z3;
            z3 = z1 + z2;
            System.Console.WriteLine($"Сумма равна = {z3}");

            Complex z4;
            z4 = z1 - z2;
            System.Console.WriteLine($"Разность равна = {z4}");

            Complex z5;
            z5 = z1*z2;
            System.Console.WriteLine($"Произведение равно = {z5}");


    int i = int.Parse(System.Console.ReadLine());
switch (i)
{
    case 3:
    System.Console.WriteLine($"{z3}");
    break;

    case 4:
    System.Console.WriteLine($"{z4}");
    break;

    case 5:
    System.Console.WriteLine($"{z5}");
    break;
}



  


        

