using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Models;

public class EBook : Book
{
    public int FileSizeMB { get; set; }
    public override string Category => "E-Book";

    public override string GetInfo()
    {
        return $"{base.GetInfo()}" +
            $"\n\tFile Size: {FileSizeMB} MB";
    }
}
