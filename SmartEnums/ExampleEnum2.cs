using Ardalis.SmartEnum;

namespace SmartEnumExample.SmartEnums;

public class ExampleEnum2: SmartEnum<ExampleEnum2, ushort>
{
    public static readonly ExampleEnum2 One = new ExampleEnum2("A string!", 1);
    public static readonly ExampleEnum2 Two = new ExampleEnum2("Another string!", 2);
    public static readonly ExampleEnum2 Three = new ExampleEnum2("Yet another string!", 3);

    private ExampleEnum2(string name, ushort value) : base(name, value)
    {
    }
}