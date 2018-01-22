using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Accelerate
{
    public partial class Form1 : Form
    {
        //Hashtable<Type, List<object>> m_Possibilities = new Hashtable<Type, List<object>>();
        Hashtable m_Possibilities = new Hashtable();
        string m_functionBlock = "";
        public Form1()
        {
            InitializeComponent();

            List<int> values=new List<int>();
            values.Add(-100);
            values.Add(-1);
            values.Add(0);
            values.Add(1);
            values.Add(100);
            values.Add(9999);
            m_Possibilities.Add(100.GetType(), values);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = @"D:\Apps\Accelerate\AddressPicker\bin\Debug\AddressPicker.dll";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            Assembly asm = Assembly.LoadFile(path);
            if (asm!=null)
            {
                Type[] types = asm.GetTypes();
                foreach (Type classType in types)
                {
                    TestClass testclass = new TestClass();
                    testclass.ClassName = classType.Name;
                    testclass.Namespace = classType.Namespace;
                    MethodInfo[] functions = classType.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly| BindingFlags.Instance);//extend for private also
                    foreach (MethodInfo method in functions)
                    {
                        ActualFunction actualFunction = new ActualFunction();
                        ParameterInfo[] parameters = method.GetParameters();
                        foreach (ParameterInfo parameter in parameters)
                        {
                            actualFunction.Parameters.Add(parameter);
                        }
                        actualFunction.MethodInfo = method;
                        actualFunction.Type = classType;
                        actualFunction.GenerateTests();
                        testclass.ActualFunctions.Add(actualFunction);
                    }
                    FileInfo file = new FileInfo(asm.FullName);
                    testclass.WriteToFile(file.DirectoryName +@"\"+ classType.Name+".cs");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.ShowDialog();
            textBox1.Text = d.FileName;
        }
    }
}
