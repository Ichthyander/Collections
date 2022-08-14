using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.    Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. 
 * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. 
 * Указание: задача решается однократным проходом по символам заданной строки слева направо; 
 * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка в строке должна 
 * соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки");
            string strInput = Console.ReadLine();

            switch (CheckBraces(strInput))
            {
                case true:
                    {
                        Console.WriteLine("Количество и расположение скобок верно");
                        break;
                    }
                case false:
                    {
                        Console.WriteLine("Количество и расположение скобок неверно");
                        break;
                    }
            }

            Console.ReadKey();
        }
        static bool CheckBraces(string strInput)
        {
            Stack<char> bracesStack = new Stack<char>();
            Dictionary<char, char> bracesPairs = new Dictionary<char, char>
        {
            { '(',')' }, {'{', '}'}, {'[', ']'}
        };

            foreach (char c in strInput)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    bracesStack.Push(bracesPairs[c]);
                }
                if (c == '}' || c == ']' || c == ')')
                {
                    if (bracesStack.Count == 0 || bracesStack.Pop() != c)
                    {
                        return false;
                    }
                }
            }

            if (bracesStack.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

   
}
