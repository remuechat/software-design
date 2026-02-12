using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Models;

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public virtual string Category => "Book";

    public virtual string GetInfo()
    {
        return $"\tCategory: {Category}" +
             $"\n\tTitle: {Title}" +
             $"\n\tAuthor: {Author}";
    }
}