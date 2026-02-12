using lab4.Models;

namespace lab4.Tests;

[TestClass]
public class BookUnitTests
{
    [TestMethod]
    public void TestBookCreation()
    {
        var book = new Book { Title = "C# Programming", Author = "John Smith" };
        Assert.AreEqual("C# Programming", book.Title);
        Assert.AreEqual("John Smith", book.Author);
        Assert.AreEqual("Book", book.Category);
    }

    [TestMethod]
    public void TestMagazineCreation()
    {
        var magazine = new Magazine { Title = "Tech Today", Author = "Jane Doe", IssueNumber = 42 };
        Assert.AreEqual("Tech Today", magazine.Title);
        Assert.AreEqual("Jane Doe", magazine.Author);
        Assert.AreEqual(42, magazine.IssueNumber);
        Assert.AreEqual("Magazine", magazine.Category);
    }
}