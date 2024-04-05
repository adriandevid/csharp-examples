namespace Examples.BitOperation;
public class BitOperations
{
    public static void ExecuteExample() {
        uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
        uint b = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
        uint c = 0b_0000_1111_0000_1111_0000_1111_0000_1100;

        Console.WriteLine("Invert Operation: {0}", Convert.ToString(~a, toBase: 2 ));
        Console.WriteLine("Move to left: {0}", Convert.ToString(b << 4, toBase: 2 ));
        Console.WriteLine("Move to rigth: {0}", Convert.ToString(c >> 1, toBase: 2 ));
    }
}
