using System.Linq.Expressions;

namespace _0313_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int a, b, c;
                a = 15;
                b = 2;
                c = a/b;

                string[] names = new string[5];
                string id = names[6];

                if (b > 10)
                {
                    throw new ArithmeticException("大於10");
                }
                if (a > 10)
                {
                    throw new MyExce("A大於10");
                }
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Erro1");
                Console.WriteLine(ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Erro2");
                Console.WriteLine(ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Erro3");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("無論跑啥都執行");
            }
                


        }
    }
}
