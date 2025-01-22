using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitsTests;

[TestClass]
public class MathOperationsUnitsTest
{
    
    private MathOperations _mathOperations;
    
    [TestInitialize]
    public void Initialize()
    {
        _mathOperations = new MathOperations();
    }
    
    
    [TestMethod]
    public void Add_AdditionBetweenNumbers_ResultAddition()
    {
        Assert.AreEqual(_mathOperations.Add(1,1) ,2);
    }
    
    [TestMethod]
    public void Divide_DivideBetweenNumbers_ResultDivid()
    {
        Assert.AreEqual(_mathOperations.Divide(10,2) ,5);
    }
    
    [TestMethod]
    public void Divide_DivideByZero_GenerateExceptionMessage()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            _mathOperations.Divide(2, 0);
        });
    }
    
    [TestMethod]
    public void GetOddNumbers_VerifyCreateImpairListNumber_NumberList()
    {
        List<int> list = new List<int>();
        
        list.Add(1);
        list.Add(3);
        list.Add(5);
        //Assert.AreEqual(_mathOperations.GetOddNumbers(6), list);
    }
    
    [TestMethod]
    [DataRow(-1)]
    [DataRow(-10)]
    public void GetOddNumbers_VerifyLimit_Exception(int limit)
    {

        Assert.ThrowsException<ArgumentException>(() =>
        {
            _mathOperations.GetOddNumbers(limit);
        });
    }

    
    
    
    
    
    
    
    
}