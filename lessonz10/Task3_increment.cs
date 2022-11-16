using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonz10
{
    internal class Task3_increment
    {
        public void Start()
        {
            int i = 0;
            //i++ - постфиксный инкремент (после суффикса)
            //++i - префиксный инкремент (после суффикса)

            //i-- - постфиксный декремент (после суффикса)
            //--i - префиксный декремент (после суффикса)

            //когда ++ стоит справа, сначала берется старое значение переменной для операции, а потом происходит увеличение
            //когда ++ стоит слева, сначала увеличивается переменная, а потом выполняется операция с новым значением

            //Пример префиксного
            Console.WriteLine(++i); //1
            Console.WriteLine(i); //1

            //Пример постфиксного
            int j = 0;
            Console.WriteLine(j++); //0 //берется старое значение, потом увеличивается
            Console.WriteLine(j); //1


        }
    }
}
