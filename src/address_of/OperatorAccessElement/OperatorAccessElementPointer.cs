namespace Examples.OperatorAccessElement;
public class OperatorAccessElementPointer
{
    // p[n] <--> *(p + n)
    public static unsafe void ExecuteExample() {
        char* pointerFirst = stackalloc char[123];

        Console.Write("Block of memory allowed: ");

        for(int index = 65; index < 123; index++) {
            pointerFirst[index] = (char)index;
        }

        for (int index = 65; index < 91; index++) {
            Console.Write(pointerFirst[index]);
        }

        Console.WriteLine();
    }
}
