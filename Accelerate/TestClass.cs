using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Accelerate
{
    class TestClass
    {
        public List<ActualFunction> ActualFunctions { get; set; }
        public string ClassPrologue { get; set; }
        public string ClassBody { get; set; }
        public string ClassEpilogue { get; set; }
        public string ClassName { get; set; }
        public string Namespace { get; set; }
        public TestClass()
        {
            ActualFunctions = new List<ActualFunction>();
        }
        public void CreateTestClass()
        {

            ClassPrologue += @"
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework; 
using System.Text;  
using " + Namespace+@";        
            ";

            ClassPrologue += @"
[TestFixture]
class " +ClassName+ @"_Test
{

public void Assert(bool val)
{
    //Call Nunit Assert Here
    NUnit.Framework.Assert.True(val);
}


";

            ClassEpilogue = @"
}
";


            foreach (ActualFunction item in ActualFunctions)
            {
                foreach (Test t in item.Tests)
                {
                    ClassBody += t.FunctionBody;
                    ClassBody += @"
";
                }
            }
            ClassBody = ClassPrologue + ClassBody + ClassEpilogue;


        }
        public void WriteToFile(string path)
        {
            CreateTestClass();
            Stream s = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(s);
            writer.Write(ClassBody);
            writer.Flush();
            s.Close();
        }

    }
}
