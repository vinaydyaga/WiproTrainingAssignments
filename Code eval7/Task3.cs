using System;
using System.Reflection;
[AttributeUsage(AttributeTargets.Class | 
                AttributeTargets.Method | 
                AttributeTargets.Property)]
public class InfoAttribute : Attribute
{
    public string Description { get; set; }
    public int Version { get; set; }
    public InfoAttribute(string description, int version)
    {
        Description = description;
        Version = version;
    }
}
[Info("This is a sample class.", 1)]
public class SampleClass
{
    [Info("This is a sample method.", 2)]
    public void SampleMethod()
    {
    }
    [Info("This is a sample property.", 3)]
    public string SampleProperty { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(SampleClass);
        InfoAttribute classAttr = (InfoAttribute)Attribute.GetCustomAttribute(type, typeof(InfoAttribute));
        if (classAttr != null)
        {
            Console.WriteLine($"Class Description: {classAttr.Description}, Version: {classAttr.Version}");
        }
        MethodInfo method = type.GetMethod("SampleMethod");
        InfoAttribute methodAttr = (InfoAttribute)Attribute.GetCustomAttribute(method, typeof(InfoAttribute));
        if (methodAttr != null)
        {
            Console.WriteLine($"Method Description: {methodAttr.Description}, Version: {methodAttr.Version}");
        }
        PropertyInfo property = type.GetProperty("SampleProperty");
        InfoAttribute propertyAttr = (InfoAttribute)Attribute.GetCustomAttribute(property, typeof(InfoAttribute));
        if (propertyAttr != null)
        {
            Console.WriteLine($"Property Description: {propertyAttr.Description}, Version: {propertyAttr.Version}");
        }
    }
}