using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace File_Creator
{
    public class CopyManager : IWriteOnlyProperties
    {
        private string _path;
        private bool _chkExclude;
        private List<string> _excludeFolders = new List<string>();
        private List<string> _allFolders = new List<string>();
        private int _totalData;

        public void SetPath(string value) => _path = value;
        public void SetChkExclude(bool value) => _chkExclude = value;
        public void SetExcludeFolders(List<string> folders) => _excludeFolders = folders;



        // Properti ini bisa dibaca dari luar tetapi tidak bisa diubah dari luar
        public List<string> ValidFolders { get; private set; } = new List<string>();
        public List<string> IndexLocations { get; private set; } = new List<string>();

        private int _processed;
        private int _progress;

        public CopyManager()
        {}

        public int GetTotalData()
        {
            _allFolders = Directory.GetDirectories(_path, "*", SearchOption.AllDirectories).ToList();
            _totalData = _allFolders.Count;
            return _totalData;
        }

        public void ScanFolders(string path, BackgroundWorker worker)
        {
            ValidFolders.Clear();
            IndexLocations.Clear();

            _processed = 0;
            _progress = 0;
            RecursiveScan(path, worker);
            _processed = _totalData;
            _progress = 100;
            worker.ReportProgress(_progress);
        }

        private void RecursiveScan(string path, BackgroundWorker worker)
        {
            try
            {
                if (worker.CancellationPending) return;

                string[] items = Directory.GetFileSystemEntries(path);
                List<string> folders = new List<string>();

                _processed += items.Count();
                //_processed++;

                foreach (var item in items)
                {
                    //_processed ++;
                    string itemName = Path.GetFileName(item);
                    if (itemName == "." || itemName == "..") continue;

                    if (this._chkExclude && this._excludeFolders.Contains(itemName))
                    {
                        // Jika folder ada dalam daftar yang dikecualikan, hentikan proses scanning lebih dalam
                        return;
                    }

                    if (Directory.Exists(item))
                    {
                        folders.Add(item);
                    }
                    else
                    {
                        //files.Add(item);
                    }
                }

                // Urutkan secara alfabetis
                folders.Sort();
                _progress = _totalData > 0 ? (int)((_processed / (double)_totalData) * 100) : 0;
                _progress = Math.Max(0, Math.Min(100, _progress)); // Pastikan progress antara 0-100

                // Laporkan progress ke UI
                worker.ReportProgress(_progress, _processed);

                // Cek apakah folder ini memiliki file index.php atau index.html
                string[] indexFiles = Directory.GetFiles(path, "index.php")
                    .Concat(Directory.GetFiles(path, "index.html"))
                    .ToArray();

                if (indexFiles.Length > 0)
                {
                    IndexLocations.AddRange(indexFiles);
                }
                else
                {
                    ValidFolders.Add(path);
                    // **Pastikan DataGridView diperbarui dengan UserState**
                    worker.ReportProgress(_progress, path);
                }

                // Rekursif untuk subfolder
                foreach (var folder in folders)
                {
                    RecursiveScan(folder, worker);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error scanning: {ex.Message}");
            }
        }

        public bool DoCopy(string indexPath, string indexContent)
        {
            try
            {
                if (!System.IO.File.Exists(indexPath))
                {
                    Console.WriteLine($"✅ Index Created: {indexPath}");
                    System.IO.File.WriteAllText(indexPath, indexContent);
                }
                if (!System.IO.File.Exists(indexPath))
                {
                    Console.WriteLine($"Creating Files: {indexPath} Failed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during  Creating Files: {ex.Message}");
                return false;
            }
            Console.WriteLine($"Creating Files: {indexPath} Successed");
            return true;
        }

        public static string GetIndexLocation(string rootPath, string folder)
        {
            int depth = folder.Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar).Length;
            return new string('.', depth) + "/index.php";
        }
    }
}
