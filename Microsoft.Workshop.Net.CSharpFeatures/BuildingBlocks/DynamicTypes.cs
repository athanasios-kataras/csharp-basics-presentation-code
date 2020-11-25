using System.Dynamic;
using System.Text.Json;
using Newtonsoft.Json;

namespace Microsoft.Workshop.Net.CSharpFeatures.BuildingBlocks
{
    class ExampleClass
    {
        public void Test() { }
    }

    public class DynamicTypes
    {
        public void CallDynamicNonExistent()
        {
            dynamic test = new ExampleClass();
            test.Test();
            test.Test2();
        }

        public void AssignWrongTypeToDynamic()
        {
            dynamic test = 1;
            test = "Test";
            test = new DynamicTypes();
        }

        public void ShowCaseExpandoObject()
        {
            dynamic test = new ExpandoObject();
            test.Company = new ExpandoObject();
            test.Company.Worker = new ExpandoObject();
            test.Company.Worker.Name = "Thanos";
            test.Company.Worker.Surname = "Kataras";
            System.Console.WriteLine(JsonConvert.SerializeObject(test));
        }
    }
}