using sberbankk;


Random random = new Random();


string hello = @"
                                                                                           
          _._._                       _._._
         _|   |_                     _|   |_
         | ... |_._._._._._._._._._._| ... |
         | ||| |  o   SBERBANK    o  | ||| |
         | """""" |  """"""    """"""    """"""  | """""" |
    ())  |[-|-]| [-|-]  [-|-]  [-|-] |[-|-]|  ()
    ())) |     |---------------------|     | (())
  (())())| """""" |  """"""    """"""    """"""  | """""" |(())())
  (()))()|[-|-]|  :::   .-""-.   :::  |[-|-]|(()))()
  ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
     ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
  ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^

                                                                                                                                                                                                                                                                                     
";
Console.WriteLine(hello + "\nДобро пожаловать в Сбербанк! Оператор Даниил на связи!\n ");




int Number = 1;
string fio = "IVANOV IVAN IVANOVICH";
float balance = random.Next(0, 100000);

int shetNumber2 = 2;
string fio2 = "PETROV PETR PETROVICH";
float balance2 = random.Next(0, 100000);


Bank[] Schet = new Bank[3];
Schet[0] = new Bank();
Schet[1] = new Bank();
Schet[2] = new Bank();

Console.WriteLine("Открываем счет...");
Console.Write("Введите ваше ФИО: ");
int shetNumber3 = 3;
string fio3 = Console.ReadLine();
float balance3 = 0;

Schet[0].open(Number, fio, balance);
Schet[1].open(shetNumber2, fio2, balance2);
Schet[2].open(shetNumber3, fio3, balance3);

    
    
while (true)
{
    Console.WriteLine("Все счета в нашем банке: ");
    for (int i = 0; i < Schet.Length; i++)
    {
        Console.Write(i + 1 + " - ");
        Schet[i].Out();
    }

    Console.Write("\nВведите номер личного счета пользователя: ");
    int id = int.Parse(Console.ReadLine()) - 1;

    Console.Clear(); 
    
    Console.WriteLine(
        "\n\nВыберите действие:\n1 - показать информацию \n2 - положить деньги на счёт\n3 - снять деньги со счёта\n4 - Обналичить счёт полностью\n5 - Перевести клиенту банка");
    Console.Write("Ввод: ");
    int choise = int.Parse(Console.ReadLine());

    if (choise == 1)
    {
        Console.Clear();
        Schet[id].Out();

    }

    if (choise == 2)
    {
        Console.Clear();
        Console.WriteLine("Пополнение счета");
        Console.Write("Положите купюры в купюроприемник (до 200 шт.): ");
        float money = float.Parse(Console.ReadLine());

        Schet[id].popolnenie(money);
    }

    if (choise == 3)
    {
        Console.Clear();
        Console.WriteLine("Снятие денег со счета.");
        Console.Write("Введите сумму: ");
        float money = float.Parse(Console.ReadLine());

        Schet[id].spisanie(money);
    }

    if (choise == 4)
    {
        Console.Clear();
        Console.WriteLine("Обналичивание всего счета.");
        Schet[id].obnul();
        Schet[id].Out();
    }

    if (choise == 5)
    {
        Console.Clear();
        for (int i = 0; i < Schet.Length; i++)
        {
            Console.Write(i + 1 + " - ");
            Schet[i].Out();
        }

        Console.Write("Перевод с вашего счёта на счет другого клиента банка.\nВведите айди клиента на который хотите сделать перевод: ");

        int id2 = int.Parse(Console.ReadLine()) - 1;
        Console.Write("Введите сумму: ");
        float money = float.Parse(Console.ReadLine());

        Schet[id].perevod(money, Schet[id2]);
    }

}
//ПРОДАМ ГАРАЖ 25 М.КВ. 
