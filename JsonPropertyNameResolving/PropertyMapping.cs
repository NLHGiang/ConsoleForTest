namespace JsonPropertyNameResolving
{
    public static class PropertyMapping
    {
        public static Dictionary<string, string> ObjectDemoMapping_ver1 = new()
        {
            { nameof(DemoObject.Field1), "name" },
            { nameof(DemoObject.Field2), "age" },
            { nameof(DemoObject.Field3), "married" }
        };

        public static Dictionary<string, string> ObjectDemoMapping_ver2 = new()
        {
            { nameof(DemoObject.Field1), "subject" },
            { nameof(DemoObject.Field2), "score" },
            { nameof(DemoObject.Field3), "passed" }
        };

        public static Dictionary<string, string> ObjectDemoMapping_ver3 = new()
        {
            { nameof(DemoObject.Field1), "process" },
            { nameof(DemoObject.Field2), "percent" },
            { nameof(DemoObject.Field3), "incompleted" }
        };
    }
}
