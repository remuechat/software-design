using lab4.Models;

namespace lab4.Tests;

[TestClass]
public class BookExceptionHandlingTests
{
    [TestMethod]
    public void TestBookWithEmptyTitle()
    {
        var book = new Book { Title = "", Author = "John Smith" };
        Assert.AreEqual("", book.Title);
        Assert.AreEqual("John Smith", book.Author);
        StringAssert.Contains(book.GetInfo(), "Title: ");
    }

    [TestMethod]
    public void TestMagazineWithNegativeIssueNumber()
    {
        var magazine = new Magazine { Title = "Tech Today", Author = "Jane Doe", IssueNumber = -5 };
        Assert.AreEqual(-5, magazine.IssueNumber);
        StringAssert.Contains(magazine.GetInfo(), "Issue Number: -5");
    }

    [TestMethod]
    public void TestTextbookWithEmptySubject()
    {
        var textbook = new TextBook { Title = "Physics 101", Author = "Dr. Albert", Subject = "" };
        Assert.AreEqual("", textbook.Subject);
        StringAssert.Contains(textbook.GetInfo(), "Subject: ");

    }
}
