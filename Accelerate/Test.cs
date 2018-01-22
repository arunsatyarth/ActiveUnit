using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Accelerate
{
    class Test : ICloneable
    {
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
        public object ExpectedValue { get; set; }
        public List<object> Parameters { get; set; }
        public string FunctionHeader { get; set; }
        public string FunctionBody { get; set; }
        public MethodInfo MethodInfo { get; set; }
        public Type Type { get; set; }
        public int TestId { get; set; }



        public Test()
        {
            Parameters = new List<object>();
        }

        public  object Clone()
        {
            Test t= new Test();
            foreach (object o in Parameters)
            {
                t.Parameters.Add(o);
            }
            return t;
        }

        public void CreateFuncHeader()
        {
            FunctionHeader = @"[TestCase]
";
            FunctionHeader += "public void Test" +TestId.ToString()+"_"+ MethodInfo.Name + "()";
            /*
            foreach (object item in Parameters)
            {
                FunctionHeader += item.ToString() + ",";
            }
            FunctionHeader=FunctionHeader.Substring(0, FunctionHeader.Length - 1);//remove trailing comma
            FunctionHeader += ")";
             */

        }
        public void FindExpectedvalue()
        {
            try
            {
                object obj = Activator.CreateInstance(Type);
                object o = MethodInfo.Invoke(obj, Parameters.ToArray());
                ExpectedValue = o;
            }
            catch (Exception e)
            {
                //Todo: print this
                string err = "Error while creating running Test "+FunctionHeader;
            }
            
        }
        public void CreateBody()
        {
            
            FunctionBody = FunctionHeader;

            FunctionBody += @"
{
            " + Type.Name + " obj= new " + Type.Name + "();" +@"
            "+ MethodInfo.ReturnType.ToString()+" retVal = obj." + MethodInfo.Name + "(";
            foreach (object item in Parameters)
            {
                FunctionBody += item.ToString() + ",";
            }
            FunctionBody = FunctionBody.Substring(0, FunctionBody.Length - 1);//remove trailing comma
            FunctionBody += ");"+ @"
            if (retVal=="+ExpectedValue.ToString()+ @")
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}";

}
    }
}
