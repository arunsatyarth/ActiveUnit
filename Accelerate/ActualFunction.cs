using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Accelerate
{
    class ActualFunction
    {
        public string ClassName { get; set; }
        public string FunctionName { get; set; }
        public Type Type { get; set; }
        public MethodInfo MethodInfo { get; set; }
        public List<ParameterInfo>  Parameters { get; set; }
        public List<Test> Tests { get; set; }
        int test_id = 1;

        Hashtable m_Possibilities = new Hashtable();
        public ActualFunction()
        {
            Parameters = new List<ParameterInfo>();
            Tests = new List<Test>();

            List<object> values = new List<object>();
            values.Add(-100);
            values.Add(-1);
            values.Add(0);
            values.Add(1);
            values.Add(100);
            values.Add(9999);
            m_Possibilities.Add(100.GetType().ToString(), values);
        }

        object [,] m_ParameterCombinations;

        public void GenerateTests()
        {
            //find maximum depth
            int m=0,n=0;
            n=Parameters.Count;
            foreach (ParameterInfo parameter in Parameters)
            {
                List<object> possibilities = m_Possibilities[parameter.ParameterType.ToString()] as List<object>;
                if (possibilities.Count>m )
                    m=possibilities.Count;

            }
            m_ParameterCombinations=new object [m,n];
            for (int i = 0; i < m; i++)
			{
                for (int j = 0; j < n; j++)
			    {
                    m_ParameterCombinations[i,j]=null;
			    }
			}


            int row = 0, col = 0;

            foreach (ParameterInfo parameter in Parameters)
            {
                List<object> possibilities = m_Possibilities[parameter.ParameterType.ToString()] as List<object>;
                foreach (object possibility in possibilities)
                {
                    m_ParameterCombinations[col, row] = possibility;
                    col++;
                }
                row++;
                col = 0;
            }
            int column = 0;
            for ( row = 0; row < m; row++)
            {
                //iterate the first column
                Test t = new Test();
                t.Parameters.Add(m_ParameterCombinations[row, column]);
                rec(t, column+1,m,n);
            }

            //by now all tests know what parameters to use
            foreach (Test test in Tests)
            {
                test.TestId = test_id++;
                test.MethodInfo = MethodInfo;
                test.Type = Type;

                test.CreateFuncHeader();
                test.FindExpectedvalue();
                test.CreateBody();

            }

        }
        public void rec(Test test, int column,int m,int n)
        {
            if(column==n)
            {
                Tests.Add(test);
                return;
            }
            for (int i = 0; i < m; i++)
            {
                Test t = test.Clone() as Test;
                if (m_ParameterCombinations[i, column] == null)
                    break;
                t.Parameters.Add(m_ParameterCombinations[i, column]);
                rec(t, column + 1, m, n);
                
            }
        }

    }
}
