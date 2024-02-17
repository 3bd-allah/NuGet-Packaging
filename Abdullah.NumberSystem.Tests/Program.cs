using Abdullah.NumberSystem.Models;

namespace Abdullah.NumberSystem.Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new DecimalSystem("15");
            var binary = d.To(NumberBase.BINARY);
            var octal= d.To(NumberBase.OCTAL);
            var hexaDecimal = d.To(NumberBase.HEXADECIMAL);


            Console.WriteLine($"({d.Value})10  = ({binary}){(int)NumberBase.BINARY} ");
            Console.WriteLine($"({d.Value})10  = ({octal}){(int)NumberBase.OCTAL} ");
            Console.WriteLine($"({d.Value})10  = ({hexaDecimal}){(int)NumberBase.HEXADECIMAL} ");

        }
    }
}