namespace Calculator
{
    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa un operador:");
            string op = Console.ReadLine();
            Console.WriteLine("Ingresa otro número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else
            {
                Console.WriteLine("Operador Invalido"); 
            }

        
        
        }
    }
}
