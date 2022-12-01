using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using System.Text.RegularExpressions;
using Account;
using System.Reflection.Metadata;
using accounts;
using automatedTellerMachine;
using Bank;
class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        System.Globalization.CultureInfo customCulture=(System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
        customCulture.NumberFormat.NumberDecimalSeparator = ".";
        System.Threading.Thread.CurrentThread.CurrentCulture= customCulture;

        Accout account = new Accout(500);
        Accounts numbers = new Accounts(200,200);
        AutomatedTellerMachine bankomat = new AutomatedTellerMachine(5000);
        bank bankk = new bank();
        account.Added += Show_Message;
        account.Withdrawn += Color_Message;
        int summ;
        account.Withdrawn -= Show_Message;
        //account.UnregisterHandler(Color_Message);
        int sum;
        
        numbers.Number += Show_Message;
        numbers.Password += Show_Message;
        bankomat.Bankomat += Show_Message;
        bankk.Bank += Show_Message;

        bool ok;
        int menu;
        do { 
        do
        {
            Console.Write("\nВведіть пункт меню :");
                Console.Write("\n1. Авторизація :");
                Console.Write("\n2. Перевірити кількість грошей на рахунку:");
                Console.Write("\n3. Покласти гроші :");
                Console.Write("\n4. Зняти гроші :");
                Console.Write("\n5. Поповнення карти за номером :");
                Console.Write("\n6. Перелік наявних банкоматів в місті : \n");
                Console.Write("\n0. Завершення роботи: \n");
                ok = int.TryParse(Console.ReadLine(), out menu);
            if (!ok || menu < 0 || menu > 11)
                Console.WriteLine(" Помилка введення. Будь-ласка повторіть введення значення ще раз!");
        } while (!ok || menu < 0 || menu > 11);
        switch (menu)
        { case 1:
                    { 
                   
                       Int64 number = 0;
                        int pass = 0;
                        number = Int64.Parse(Console.ReadLine());
                        pass = int.Parse(Console.ReadLine());

                        Console.Write($"За картою зареєстровано   \n" );

                        numbers.Numbercard(number, pass);


                        break;
                    }
            case 2:
                    {
                        Console.Write("\nПеревірити кількість грошей на рахунку:");

                        account.countmoney();
                        break;
                    }
            

            case 3 :
                    {
                        Console.Write("\nВведіть кількість грошей, які хочете покласти :");

                        sum = int.Parse(Console.ReadLine());
                    account.Put(sum);
                    break;
                }
            case 4:
                {
                        Console.Write("\nВведіть кількість грошей, яку хочете зняти :");

                        summ = int.Parse(Console.ReadLine());
                        bankomat.kasa(summ);
                        break;
                        account.Withdraw(summ);

                        
                       

                    break;
                }

             case 5:
                    {
                        Int64 number2 = 0;
                         Console.Write("Введіть номер карти на яку потрібно кинути гроші  ");
                        number2 = Int64.Parse(Console.ReadLine());
                        Console.Write("Введіть суму поповнення карти ");
                        sum = int.Parse(Console.ReadLine());
                        account.Putcard(sum);

                        break;
                    }
                case 6:
                    {
                       
                        bankk.kasa();


                        break;
                    }
                




            }
    }while (menu != 0) ;
        
    }     private static void Show_Message(string message)
    {
        Console.WriteLine(message);
    }

    private static void Color_Message(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

    

}


