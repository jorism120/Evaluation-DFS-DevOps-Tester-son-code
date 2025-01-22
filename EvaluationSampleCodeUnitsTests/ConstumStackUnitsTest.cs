using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitsTests;

[TestClass]
public sealed class ConstumStackUnitsTest
{
    private CustomStack _customStack;
    
    [TestInitialize]
    public void Initialize()
    {
        _customStack = new CustomStack();
    }
    
    [TestMethod]
    public void Push_VerifyAddIntergersElementsInList_AddElementInList()
    {
        _customStack.Push(1);
        Assert.AreEqual(1, _customStack.Count());
    }
    
    [TestMethod]
    public void Count_VerifyCountIntergersElementsInList_NumberElements()
    {
        _customStack.Push(1);
        _customStack.Push(2);
        Assert.AreEqual(2, _customStack.Count());
    }
    
    [TestMethod]
    public void Pop_DeleteLastIntergerElementInList_ElementDeleted()
    {
        _customStack.Push(1);
        _customStack.Push(2);
        _customStack.Pop();
        Assert.AreEqual(1,  _customStack.Count());
    }
    
    [TestMethod]
    public void Pop_DeleteLastIntergerElementInListWhithException_Exception()
    {
        _customStack = new CustomStack();
        Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() =>
        {
            _customStack.Pop();

        });
    }
    
    
    
}