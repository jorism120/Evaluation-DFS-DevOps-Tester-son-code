using EvaluationSampleCode;

namespace EvaluationSampleCodeUnitsTests;

[TestClass]
public class HtmlFormatHelperUnitsTests
{
    private HtmlFormatHelper _htmlFormatHelper;
    
    [TestInitialize]
    public void Initialize()
    {
        _htmlFormatHelper = new HtmlFormatHelper();
    }
    
    
    [TestMethod]
    public void GetBoldFormat_VerifyReturnHtmlBoldText_HtmlBoldText()
    {
       Assert.AreEqual(_htmlFormatHelper.GetBoldFormat("Hello"), "<b>Hello</b>");
    }
    
    [TestMethod]
    public void GetItalicFormat_VerifyReturnHtmlItalicText_HtmlItalicText()
    {
        Assert.AreEqual(_htmlFormatHelper.GetItalicFormat("Hello"), "<i>Hello</i>");
    }
    
    [TestMethod]
    public void GetFormattedListElements_VerifyFormattedListElements_ListElements()
    {
        List<string> list = new List<string>();
        list.Add("Hello");
        list.Add("World");
        Assert.AreEqual(_htmlFormatHelper.GetFormattedListElements(list), "<ul><li>Hello</li><li>World</li></ul>");
    }
}