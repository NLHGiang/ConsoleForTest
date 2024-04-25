using ConditionStringToLinqExpressionConverter;

var listDemo = new List<DemoObject>
{
    new() { Field1 = "Obj 1", Field2 = 5, Field3 = true },
    new() { Field1 = "Ob 2", Field2 = 10, Field3 = false },
    new() { Field1 = "Obj 3", Field2 = 7, Field3 = false },
    new() { Field1 = "Ob 4", Field2 = 3, Field3 = true }
}.AsQueryable();

List<PropertyCondition> conditions = new()
{
    new PropertyCondition
    {
        PropertyName = nameof(DemoObject.Field1),
        Condition = "Name.Contains(\"Obj\")",
        MarkKey = "Name"
    },
    new PropertyCondition
    {
        PropertyName = nameof(DemoObject.Field2),
        Condition = "value > 1 && value < 10",
        MarkKey = "value"
    }
};

LinqExpressionConverter.ResultOfConvertToLinqExpression(listDemo, conditions.Take(1).ToList());
LinqExpressionConverter.ResultOfConvertToLinqExpression(listDemo, conditions.Skip(1).Take(1).ToList());
LinqExpressionConverter.ResultOfConvertToLinqExpression(listDemo, conditions);