# ConsoleForTest
1. JsonPropertyNameResolving
2. ConditionStringToLinqExpressionConverter

## 1. JsonPropertyNameResolving
To map an object's properties with their corresponding JSON property names without using the JsonPropertyName attribute
- **DemoObject**: object to be tested
- **PropertyMapping**: define a mapping between the object's property names and their corresponding JSON property names
- **JsonMapper**: store a method that takes an object as input and converts its properties into a JSON string using the defined mapping
- **JsonPropertyNameResolver**:  designed to resolve property names during JSON serialization and deserialization. It takes a dictionary of property mappings as a constructor parameter, where the keys represent the original property names, and the values represent the desired JSON property names.
- **Program**: demonstrate the usage of the JsonMapper.MapObjectToJson method with different property mappings to serialize a DemoObject using a custom contract resolver.

## 2. ConditionStringToLinqExpressionConverter
To map an object's properties with their corresponding JSON property names without using the JsonPropertyName attribute
- **DemoObject**: object to be tested
- **PropertyCondition**: a class storing information about property conditions
- **LinqExpressionConverter**: provides several static methods for converting and filtering lists based on conditions.
- **JsonPropertyNameResolver**:  designed to resolve property names during JSON serialization and deserialization. It takes a dictionary of property mappings as a constructor parameter, where the keys represent the original property names, and the values represent the desired JSON property names.
- **Program**: demonstrate how the LinqExpressionConverter class can be used to convert and filter a list based on conditions specified as strings.
