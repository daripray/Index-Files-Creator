using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator.helper
{
    class PathHelper
    {
        public static string GetRelativeIndexPath(string rootPath, string targetPath)
        {
            // Pastikan path dalam format absolut & normalisasi
            string absoluteRoot = Path.GetFullPath(rootPath).TrimEnd(Path.DirectorySeparatorChar);
            string absoluteTarget = Path.GetFullPath(targetPath).TrimEnd(Path.DirectorySeparatorChar);

            // Jika path target berada di dalam rootPath
            if (!absoluteTarget.StartsWith(absoluteRoot, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Target path tidak berada dalam rootPath.");
            }

            // Hitung jumlah parent directory (depth) dengan memotong root dari target
            string relativePath = absoluteTarget.Substring(absoluteRoot.Length).TrimStart(Path.DirectorySeparatorChar);
            int depth = relativePath.Split(Path.DirectorySeparatorChar, (char)StringSplitOptions.RemoveEmptyEntries).Length;

            // Generate jumlah "../" yang benar
            return string.Concat(Enumerable.Repeat("../", depth));// + "index.php";
        }


        private static string GetRelativePath(string rootPath, string targetPath)
        {
            return GetRelativePath(rootPath, targetPath);
        }

        public static string GetBacktrackPath(string rootPath, string targetPath)
        {
            string relativePath = GetRelativePath(rootPath, targetPath);
            int depth = relativePath.Split(Path.DirectorySeparatorChar).Length;
            return string.Join("/", Enumerable.Repeat("..", depth));
        }
    }
}
