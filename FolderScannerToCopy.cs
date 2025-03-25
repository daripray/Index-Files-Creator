using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator
{
    public class FolderScannerToCopy
    {
        private List<string> excludeFolders;
        public List<string> ValidFolders { get; private set; } = new List<string>();
        public List<string> IndexLocations { get; private set; } = new List<string>();

        public FolderScannerToCopy(List<string> excludeFolders)
        {
            this.excludeFolders = excludeFolders;
        }

        public void ScanFolders(string path)
        {
            ValidFolders.Clear();
            IndexLocations.Clear();
            RecursiveScan(path);
        }

        private void RecursiveScan(string path)
        {
            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    string folderName = Path.GetFileName(dir);
                    if (excludeFolders.Contains(folderName)) continue;

                    string[] indexFiles = Directory.GetFiles(dir, "index.php")
                        .Concat(Directory.GetFiles(dir, "index.html"))
                        .ToArray();

                    if (indexFiles.Length > 0)
                    {
                        IndexLocations.AddRange(indexFiles);
                    }
                    else
                    {
                        ValidFolders.Add(dir);
                    }

                    RecursiveScan(dir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error scanning: {ex.Message}");
            }
        }

    }
}
