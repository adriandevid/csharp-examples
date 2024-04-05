using Examples.Base;

namespace Examples.Address;
public class AddressOfExample
{
    public AddressOfExample()
    {
    }


    public static unsafe void ExecuteExample() {
        int number = 30000;
        byte* p = (byte*)&number;

        Console.WriteLine("The address: {0:X}", (long)p);
        Console.WriteLine(" {0:X2} ", *p);
        Console.Write("The 4 bytes:  - {0} -", (long)p);

        for (int i = 0; i < sizeof(int); ++i) {
            Console.Write(" {0:X2} ", *p);
            p++;
        }

        Console.WriteLine("");
    }
}
