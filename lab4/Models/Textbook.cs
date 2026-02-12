using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Models;

public class TextBook : Book
{
    public string? Subject { get; set; }
    public override string Category => "Textbook";

    public override string GetInfo()
    {
        return $"\t{base.GetInfo()}" +
            $"\n\tSubject: {Subject}";
    }
}
