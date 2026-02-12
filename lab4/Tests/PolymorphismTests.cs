using lab4.Models;

namespace lab4.Tests;

[TestClass]
public class PolymorphismTests
{
    [TestMethod]
    public void TestPolymorphism_GetInfo_Method()
    {
        var books = new Book[]
        {
                new Book {Title = "Generic Book", Author = "John Doe"},
                new Magazine {Title = "Tech Weekly", Author = "Jane Smith", IssueNumber = 12},
                new EBook {Title = "C# Programming", Author = "Alice Johnson", FileSizeMB = 5},
        };

        Assert.AreEqual("\tCategory: Book" +
            "\n\tTitle: Generic Book" +
            "\n\tAuthor: John Doe", books[0].GetInfo());
        Assert.AreEqual("\tCategory: Magazine" +
            "\n\tTitle: Tech Weekly" +
            "\n\tAuthor: Jane Smith" +
            "\n\tIssue Number: 12", books[1].GetInfo());
        Assert.AreEqual("\tCategory: E-Book" +
            "\n\tTitle: C# Programming" +
            "\n\tAuthor: Alice Johnson" +
            "\n\tFile Size: 5 MB", books[2].GetInfo());
    }
}