using Examples.Base;

namespace Examples.OperatorAccessPointer;
public class OperatorPointerAndMenberAccess
{
    public static unsafe void ExecuteExample() {
        Address address = Address.Parse("Etelvino alves de lima", 450);
        Address* addressPointer = &address;

        addressPointer -> Road = "Ola mundo";
        addressPointer -> Number = 10;

        Console.WriteLine(addressPointer -> ToString());
    }
}


public struct Address {
    public Address(string road, int number)
    {
        Road = road;
        Number = number;
    }

    public string Road { get; set; }
    public int Number { get; set; }

    public override string ToString() => $"{Road} / {Number}";

    public static Address Parse(string road, int number) {
        return new Address(road, number);
    }
}