using Ardalis.SmartEnum;

namespace SmartEnumExample.SmartEnums;

public class ExampleEnum1: SmartEnum<ExampleEnum1>
{
    public static readonly ExampleEnum1 One = new ExampleEnum1(nameof(One), 1);
    public static readonly ExampleEnum1 Two = new ExampleEnum1(nameof(Two), 2);
    public static readonly ExampleEnum1 Three = new ExampleEnum1(nameof(Three), 3);
    public static readonly ExampleEnum1 AnotherThree = new ExampleEnum1(nameof(AnotherThree), 3);

    private ExampleEnum1(string name, int value) : base(name, value)
    {
    }   
}