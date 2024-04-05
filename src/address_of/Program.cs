using Examples.Address;
using Examples.BitOperation;
using Examples.OperatorAccessElement;
using Examples.OperatorAccessPointer;

Console.WriteLine("---------------- Address Example Manipulation ---------------");
// ref: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/pointer-related-operators#pointer-indirection-operator-
AddressOfExample.ExecuteExample();
Console.WriteLine("-------------------------------------------------------------");


Console.WriteLine("---------------- Operator of Pointer for access menber of type value ---------------");
// ref: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/pointer-related-operators#pointer-member-access-operator--
OperatorPointerAndMenberAccess.ExecuteExample();
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("---------------- Operator of access element pointer using stackalloc for allowed in mermory execution ---------------");
//ref: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/language-specification/unsafe-code#2364-pointer-element-access
OperatorAccessElementPointer.ExecuteExample();
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("---------------- Operator of complement bit to bit ---------------");
//ref: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
BitOperations.ExecuteExample();
Console.WriteLine("-------------------------------------------------------------");