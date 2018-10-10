using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Core
{
    public class NameChangedEventArgs
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }

    }
}
