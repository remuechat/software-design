using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Models;

public class Magazine : Book
{
    public int IssueNumber { get; set; }
    public override string Category => "Magazine";
    public override string GetInfo()
    {
        return $"{base.GetInfo()}" +
            $"\n\tIssue Number: {IssueNumber}";
    }
}
