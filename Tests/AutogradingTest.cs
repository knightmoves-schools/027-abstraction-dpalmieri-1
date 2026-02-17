namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
should hide the `Rate`
- should hide the `CalculateExempt` method
- should hide the `CalculateNonExempt` method
    */

    [Fact]
    public void Should_Hide_The_Rate(){
        FieldInfo[] fields = typeof(TaxCalculator).GetFields(
                         BindingFlags.NonPublic | 
                         BindingFlags.Instance);
        Assert.Equal(1, fields.Length);
        Assert.Equal("Rate", fields[0].Name);
    }

    [Fact]
    public void Should_Hide_The_CalculateExempt_Method(){
        MethodInfo[] methods = typeof(TaxCalculator).GetMethods(
                         BindingFlags.NonPublic | 
                         BindingFlags.Instance);
        Assert.True(methods.Length > 0);
        
        bool foundMethodName = false;

        foreach(MethodInfo methodInfo in methods){
            if(methodInfo.Name == "CalculateExempt"){
                foundMethodName = true;
            }
        }

        Assert.True(foundMethodName);
    }

    [Fact]
    public void Should_Hide_The_CalculateNonExempt_Method(){
        MethodInfo[] methods = typeof(TaxCalculator).GetMethods(
                         BindingFlags.NonPublic | 
                         BindingFlags.Instance);
        Assert.True(methods.Length > 0);
        
        bool foundMethodName = false;

        foreach(MethodInfo methodInfo in methods){
            if(methodInfo.Name == "CalculateNonExempt"){
                foundMethodName = true;
            }
        }

        Assert.True(foundMethodName);
    }
}