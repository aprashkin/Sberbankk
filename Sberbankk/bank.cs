using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sberbankk
{
    internal class Bank
    {
        private int nom;
        private string name;
        private float sum;

        public void open(int nom, string name, float sum)
        {
            this.nom = nom;
            this.name = name;
            this.sum = sum;
        }

        public void Out()
        {
            Console.WriteLine($"Номер счёта: {nom}. ФИО: {name}.Сумма: {sum}.");
        }

        public void popolnenie(float money)
        {
            Console.WriteLine("Вы успешно добавили на счёт " + money);
            sum += money;
            Console.WriteLine($"Ваш баланс: {sum}");
        }

        public void spisanie(float money)
        {
            Console.WriteLine("Вы успешно сняли со счёта " + money);
            sum -= money;
            if (sum < 0)
            {
                Console.WriteLine("Ваш баланс отрицателен. За вами уже едут, я договорился");
            }
            Console.WriteLine($"Ваш баланс: {sum}");
        }

        public void obnul()
        {
            Console.WriteLine("Вы успешно сняли всю сумму.\nС вашего счёта списано " + sum);
            sum = 0;
        }

        public void perevod(float money)
        {
            Console.WriteLine($"Вы успешно перевели {money} на счет другого клиента");
            if (sum < 0)
            {
                Console.WriteLine("Ваш баланс отрицательный. За вами уже едут, я договорился");
            }

        }

    }
    //рекламы не будет. сбербанк не одобряет

}