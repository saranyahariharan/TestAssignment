using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Finder.Test.Framework
{
    /// <summary>
    /// Enumerations for this Frameworks
    /// </summary>
    public class Enumerations
    {
        public enum Driver
        {
            Chrome,
            InternetExplorer,
            Safari,
            FireFox
        };

        public enum ControlWait
        {
            Excellent = 1,
            Average = 3,
            Worst = 5,
            TooWorst = 10
        }
    }
}
