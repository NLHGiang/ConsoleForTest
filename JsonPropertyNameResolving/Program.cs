// Create a sample object

using JsonPropertyNameResolving;

DemoObject demoObject = new()
{
    Field1 = "abc",
    Field2 = 99,
    Field3 = true
};

// Serialize the object using the custom contract resolver
Console.WriteLine("===json1===");
var json1 = JsonMapper.MapObjectToJson(demoObject, PropertyMapping.ObjectDemoMapping_ver1);
Console.WriteLine(json1);

Console.WriteLine("===json2===");
var json2 = JsonMapper.MapObjectToJson(demoObject, PropertyMapping.ObjectDemoMapping_ver2);
Console.WriteLine(json2);

Console.WriteLine("===json1===");
var json3 = JsonMapper.MapObjectToJson(demoObject, PropertyMapping.ObjectDemoMapping_ver3);
Console.WriteLine(json3);