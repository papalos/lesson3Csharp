using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    class Conveyer
    {
        /*Перечисление первому элементу задаем 37, последующие сами инкрементируются*/
        public enum action {BACK=37, START, FORWAR, STOP};
        
        /// <param name="command">Значение из перечисления</param>
        /// <returns> Возвращает строку соответствующую нажатой клавише</returns>
        public string conveyerControl(action command)
        {
            switch (command)
            {
                case (action.BACK): return "\nПеремещение назад!";
                case (action.FORWAR): return "\nПеремещение вперед!";
                case (action.START): return "\nЗапуск!";
                case (action.STOP): return "\nОстановка!";
                default:return "\nКоманда не распознана!!!";
            }
        }


        public bool keyRead()
        {
            /*Читаем из консоли код введенного символа, 
             * приводим его к созданному нами типу перечисление
             сохраняем в переменную типа созданного нами перечисления*/
            action key = (action) Console.ReadKey().Key;

            /*Реализуем выход из программы
             если код введенного символа не 27 (соответствует клавише esc)
             продолжаем работу, если же это 27 метод возвращает false, что мы используем потом*/
            if ((int)key != 27)
            {
                /*Console.WriteLine выведет нам строку возвращенную conveyerControl
                 conveyerControl получает на вход код введенного символа
                 далее мы возвращаем из метода true, что используем потом*/
                Console.WriteLine(conveyerControl(key));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
