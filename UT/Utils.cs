
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using AddressPicker;
using NUnit.Framework;        
            
[TestFixture]
class Utils_Test
{

public void Assert(bool val)
{
    //Call Nunit Assert Here
    NUnit.Framework.Assert.True(val);
}


[TestCase]
public void Test1_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test2_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test3_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test4_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test5_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test6_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-100,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test7_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test8_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test9_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test10_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test11_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test12_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(-1,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test13_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test14_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test15_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test16_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test17_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test18_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(0,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test19_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test20_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test21_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test22_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test23_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test24_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(1,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test25_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test26_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test27_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test28_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test29_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test30_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(100,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test31_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,-100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test32_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,-1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test33_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,0);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test34_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,1);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test35_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,100);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}
[TestCase]
public void Test36_retConst()
{
            Utils obj= new Utils();
            System.Int32 retVal = obj.retConst(9999,9999);
            if (retVal==1000)
            {
                Assert(true);
            }else{
                Assert(false);
            }
        
                
}

}
