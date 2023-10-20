

using static ApplicationDevelopment.Dz2.implicitСast;

namespace ApplicationDevelopment.Dz2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bits byteBits = new Bits((byte)5);
            Bits shortBits = new Bits((short)10);
            Bits intBits = new Bits(20);
            Bits longBits = new Bits((long)30);

            Console.WriteLine(byteBits.GetBit(0));
            Console.WriteLine(shortBits.GetBit(0));
            Console.WriteLine(intBits.GetBit(0));
            Console.WriteLine(longBits.GetBit(0));
        }
    }
}
