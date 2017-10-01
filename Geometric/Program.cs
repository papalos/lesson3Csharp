using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Program
    {        
        static void Main(string[] args)
        {
            /*Создаем объект класса Conveyer, чтобы воспользваться его методами*/
            Conveyer ControlPanel = new Conveyer();

            /*Выводим инструкции*/
            Console.WriteLine("Управление конвейером: ");
            Console.WriteLine("Стрелка вверх - Старт ");
            Console.WriteLine("Стрелка вниз - Стоп ");
            Console.WriteLine("Стрелка влево - Назад ");
            Console.WriteLine("Стрелка вправо - Вперед ");
            Console.WriteLine("Клавиша esc - Выход из программы ");

            /*Запускаем бесконечный цикл, предварительно предусмотрев реализацию выхода из него
             он будет пустым так как все действия будут выполняться в блоке условия
             метод .keyRead() объекта ControlPanel,
             который читает код введенного символа 
             и выводит нам исполняемую команду (см. реализацию метода)
             так же если методу удалось распознать команду он возвращает true,
             что заставляет цикл вращаться, если не распознает возвращает false,
             что прерывает цикл и завершает программу.*/
            while (ControlPanel.keyRead())
            {
                //Вся логика в условии.
            }
        }
    }
}
