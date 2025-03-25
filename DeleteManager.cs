using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator
{

    class DeleteManager : IWriteOnlyProperties
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
        private int _totalFolder;

        public DeleteManager()
        {
        }

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
            //RecursiveScan(path, 0);

            _processed = 0;
            _progress = 0;

            //foreach (var folder in allFolders)
            //{
            //    if (worker.CancellationPending) return;

            RecursiveScan(path, 0, worker);

            // Laporkan progress ke UI
            //    processed++;
            //    int progress = (int)((processed / (double)totalFolders) * 100);
            //    worker.ReportProgress(progress);
            //}
            _processed = _totalData;
            _progress = 100;
            worker.ReportProgress(_progress);
        }

        private void RecursiveScan(string path, int depth, BackgroundWorker worker)
        {
            try
            {
                if (worker.CancellationPending) return;

                string[] items = Directory.GetDirectories(path);
                List<string> folders = new List<string>();
                //List<string> files = new List<string>();

                _processed += items.Count();

                foreach (var item in items)
                {
                    string itemName = Path.GetFileName(item);
                    if (itemName == "." || itemName == "..") continue;

                    if (_chkExclude && _excludeFolders.Contains(itemName))
                    {
                        // Jika folder/file ada dalam daftar yang dikecualikan, hentikan proses scanning lebih dalam
                        return;
                    }

                    if (Directory.Exists(item))
                    {
                        folders.Add(item);
                    }
                }

                // Hitung progress
                _progress = _totalData > 0 ? (int)((_processed / (double)_totalData) * 100) : 0;
                _progress = Math.Max(0, Math.Min(100, _progress)); // Pastikan progress antara 0-100

                // Laporkan progress ke UI
                worker.ReportProgress(_progress);

                // Cek apakah folder ini memiliki file index.php yang isinya sesuai 

                string indexPath = Path.Combine(path, "index.php");
                if (File.Exists(indexPath))
                {
                    string expectedInclude = "<?php\ninclude '" + string.Concat(Enumerable.Repeat("../", depth)) + "index.php';";
                    string fileContent = File.ReadAllText(indexPath).Trim();

                    if (fileContent == expectedInclude.Trim())
                    {
                        folders.Add(indexPath);
                        IndexLocations.Add(indexPath);
                        Console.WriteLine($"⚡ Index.php Found: {indexPath}");

                        // **Pastikan DataGridView diperbarui dengan UserState**
                        worker.ReportProgress(_progress, indexPath);
                    }
                }

                // Urutkan secara alfabetis
                folders.Sort();
                IndexLocations.Sort();

                // Rekursif untuk subfolder
                foreach (var folder in folders)
                {
                    RecursiveScan(folder, depth + 1, worker);
                }
            }
            catch (Exception ex)
            {
                return;
                Console.WriteLine($"Error scanning: {ex.Message}");
            }
        }

        public bool DoDelete(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                if (File.Exists(filePath))
                {
                    Console.WriteLine($"Deleting Files: {filePath} Failed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during  Creating Files: {ex.Message}");
                return false;
            }
            Console.WriteLine($"Deleting Files: {filePath} Successed");
            return true;
        }
    }
}
