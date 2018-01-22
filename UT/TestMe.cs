
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using AddressPicker;
using NUnit.Framework;        
            
[TestFixture]
class TestMe_Test
{

public void Assert(bool val)
{
    //Call Nunit Assert Here
    NUnit.Framework.Assert.True(val);
}


[TestCase]
public void Test1_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,-100);
            if (retVal==-200)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test2_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,-1);
            if (retVal==-101)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test3_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,0);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test4_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,1);
            if (retVal==-99)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test5_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,100);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test6_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-100,9999);
            if (retVal==9899)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test7_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,-100);
            if (retVal==-101)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test8_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,-1);
            if (retVal==-2)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test9_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,0);
            if (retVal==-1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test10_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,1);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test11_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,100);
            if (retVal==99)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test12_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(-1,9999);
            if (retVal==9998)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test13_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,-100);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test14_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,-1);
            if (retVal==-1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test15_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test16_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,1);
            if (retVal==1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test17_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,100);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test18_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(0,9999);
            if (retVal==9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test19_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,-100);
            if (retVal==-99)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test20_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,-1);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test21_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,0);
            if (retVal==1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test22_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,1);
            if (retVal==2)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test23_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,100);
            if (retVal==101)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test24_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(1,9999);
            if (retVal==10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test25_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,-100);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test26_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,-1);
            if (retVal==99)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test27_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,0);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test28_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,1);
            if (retVal==101)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test29_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,100);
            if (retVal==200)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test30_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(100,9999);
            if (retVal==10099)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test31_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,-100);
            if (retVal==9899)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test32_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,-1);
            if (retVal==9998)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test33_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,0);
            if (retVal==9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test34_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,1);
            if (retVal==10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test35_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,100);
            if (retVal==10099)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test36_function()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function(9999,9999);
            if (retVal==19998)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test1_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,-100);
            if (retVal==10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test2_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,-1);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test3_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test4_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,1);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test5_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,100);
            if (retVal==-10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test6_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-100,9999);
            if (retVal==-999900)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test7_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,-100);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test8_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,-1);
            if (retVal==1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test9_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test10_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,1);
            if (retVal==-1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test11_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,100);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test12_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(-1,9999);
            if (retVal==-9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test13_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,-100);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test14_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,-1);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test15_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test16_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,1);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test17_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,100);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test18_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(0,9999);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test19_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,-100);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test20_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,-1);
            if (retVal==-1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test21_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test22_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,1);
            if (retVal==1)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test23_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,100);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test24_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(1,9999);
            if (retVal==9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test25_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,-100);
            if (retVal==-10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test26_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,-1);
            if (retVal==-100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test27_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test28_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,1);
            if (retVal==100)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test29_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,100);
            if (retVal==10000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test30_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(100,9999);
            if (retVal==999900)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test31_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,-100);
            if (retVal==-999900)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test32_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,-1);
            if (retVal==-9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test33_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,0);
            if (retVal==0)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test34_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,1);
            if (retVal==9999)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test35_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,100);
            if (retVal==999900)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test36_function2()
{
            TestMe obj= new TestMe();
            System.Int32 retVal = obj.function2(9999,9999);
            if (retVal==99980001)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}

}
