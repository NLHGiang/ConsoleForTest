using System.Linq.Dynamic.Core;
using System.Reflection;

namespace ConditionStringToLinqExpressionConverter;

internal static class LinqExpressionConverter
{
    public static string ReplaceMarkKeyWithPropertyName(List<PropertyCondition> conditions)
    {
        var conditionString = string.Empty;

        for (var i = 0; i < conditions.Count; i++)
        {
            var con = conditions[i];

            var replacedString = con.Condition.Replace(con.MarkKey, con.PropertyName);

            if (i == 0)
                conditionString += replacedString;
            else
                conditionString += " && " + replacedString;
        }

        return conditionString;
    }

    public static IQueryable<T> FilterList<T>(IQueryable<T> list, string conditionString)
    {
        var filteredList = list.Where(conditionString);
        return filteredList;
    }

    public static IQueryable<T> ConvertToLinqExpression<T>(IQueryable<T> list, List<PropertyCondition> conditions)
    {
        var conditionString = ReplaceMarkKeyWithPropertyName(conditions);

        return FilterList(list, conditionString);
    }

    public static void ResultOfConvertToLinqExpression<T>(IQueryable<T> list, List<PropertyCondition> conditions)
    {
        var conditionString = ReplaceMarkKeyWithPropertyName(conditions);

        var filteredList = ConvertToLinqExpression(list, conditions);

        var type = typeof(T);

        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        Console.WriteLine($"[Condition: {conditionString}]");

        foreach (var property in properties) Console.Write($"{property.Name}\t");

        Console.WriteLine();

        foreach (var item in filteredList)
        {
            foreach (var property in properties) Console.Write($"{property.GetValue(item)}\t");

            Console.WriteLine();
        }
    }
}