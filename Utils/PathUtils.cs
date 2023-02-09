using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickyNotes.Utils
{
    public class PathUtils
    {
        public static string pathStartEnd(string fullPath)
        {
            int startLength = 20;
            int endLength = 20;

            int fullPathLength = fullPath.Length;

            if (fullPathLength <= startLength || fullPathLength<=startLength+endLength)
            {
                return fullPath;
            }

            return fullPath.Substring(0, 10) + "..." +fullPath.Substring(fullPathLength-endLength);
        }
    }
}
