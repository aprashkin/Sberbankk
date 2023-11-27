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
        public float sum;
        private int id1;
        private int id2;

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

        
        public void perevod(float money, Bank id2)
        {
            Console.WriteLine($"Вы успешно перевели {money} на счет клиента {id2.name}");
    
            if (sum < money)
            {
                Console.WriteLine("Недостаточно средств для перевода.");
            }
            else
            {
                sum -= money;
                id2.sum += money;
                Console.WriteLine($"Ваш баланс: {sum}");
                Console.WriteLine($"Баланс клиента {id2.name}: {id2.sum}");
            }
        }



    }
    //рекламы не будет. сбербанк не одобряет

}