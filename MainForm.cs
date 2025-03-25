using File_Creator.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Creator
{
    public partial class MainForm: Form
    {
        private CopyManager copyManager;
        private DeleteManager deleteManager;

        private string _selectedRootPath = @"D:\SERVER\XAMPP-WWW"; // Default root path
        private List<string> _excludeFolders = new List<string>
        {
            "vendor",
            "node_modules",
            //"public_html", "public_html_old", "public_html_new", "public_html_backup",
            //"src", "dist", "build", "assets", "images", "css", "js", "fonts", "scss", "less", "sass", "images", "img", "uploads", "storage", "cache", "tmp", "logs", "logs_old", "logs_new", "logs_backup",
            "app", "public", "routes", "views",
            //"config", "resources", "storage", "tests", "database", "bootstrap", "node_modules", "vendor",
            "wp-admin", "wp-content", "wp-includes",
            //"wp-json", "wp-login.php", "wp-config.php", "wp-cron.php", "wp-activate.php", "wp-blog-header.php", "wp-comments-post.php", "wp-config-sample.php", "wp-links-opml.php", "wp-load.php", "wp-mail.php", "wp-settings.php", "wp-signup.php", "wp-trackback.php", "xmlrpc.php",
            "composer.json", "composer.lock", "package.json", "package-lock.json", "yarn.lock", "webpack.config.js", "gulpfile.js", "Gruntfile.js", "phpunit.xml",
            ".env",".git", ".github", ".gitignore", ".gitattributes", ".htacces", ".htpasswd", ".htaccess", ".htpasswd", ".htaccess.txt", ".htpasswd.txt",
            //"index.php", "index.html", "index.htm", "index.asp", "index.jsp", "index.cfm", "index.py", "index.pl", "index.rb", "index.cgi", "index.xml", "index.xhtml", "index.xhtm",
            //"error_log", "access_log", "error.log", "access.log", "error.txt", "access.txt", "error.php", "access.php", "error.html", "access.html", "error.htm", "access.htm",
        };
        private bool _isCopyAll = false;
        private bool _isDeleteAll = false;

        private int _processedCopy;
        private int _progressCopy;
        private int _totalDataCopy;
        private int _nomorCopy = 0;

        private int _processedDelete;
        private int _progressDelete;
        private int _totalDataDelete;
        private int _nomorDelete = 0;

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        #region Initialize

        private void Initialize()
        {
            txtRootPathCopy.Text = _selectedRootPath;
            txtExcludeParamsCopy.Text = string.Join("\r\n", _excludeFolders);
            txtRootPathDelete.Text = _selectedRootPath;
            txtExcludeParamsDelete.Text = string.Join("\r\n", _excludeFolders);

            ResetScanCopy();
            ResetScanDelete();
        }
        private void ResetScanCopy()
        {
            _totalDataCopy = 0;
            _processedCopy = 0;
            _progressCopy = 0;
            _nomorCopy = 0;
            pgBarCopy.Value = 0;
            lblProgressCopy.Text = "Proses: 0/0 (0%)";
            dataGridViewCopy.Rows.Clear();
        }
        private void ResetCopyAll()
        {
            _totalDataCopy = 0;
            _processedCopy = 0;
            _progressCopy = 0;
            _nomorCopy = 0;
            pgBarCopy.Value = 0;
            lblProgressCopy.Text = "Proses: 0/0 (0%)";

        }
        private void ResetScanDelete()
        {
            _totalDataDelete = 0;
            _processedDelete = 0;
            _progressDelete = 0;
            pgBarDelete.Value = 0;
            lblProgressDelete.Text = "Proses: 0/0 (0%)";
            dataGridViewDelete.Rows.Clear();
        }
        private void ResetDeleteAll()
        {
            _totalDataDelete = 0;
            _processedDelete = 0;
            _progressDelete = 0;
            pgBarDelete.Value = 0;
            lblProgressDelete.Text = "Proses: 0/0 (0%)";
        }

        private void InitializeCopyManager()
        {
            _selectedRootPath = txtRootPathCopy.Text;
            copyManager = new CopyManager();
            copyManager.SetPath(_selectedRootPath);
            _totalDataCopy = copyManager.GetTotalData();

            copyManager.SetChkExclude(chkExcludeCopy.Checked);

            _excludeFolders = txtExcludeParamsCopy.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            copyManager.SetExcludeFolders(_excludeFolders);
        }
        private void InitializeDeleteManager()
        {
            _selectedRootPath = txtRootPathDelete.Text;
            deleteManager = new DeleteManager();
            deleteManager.SetPath(_selectedRootPath);
            _totalDataDelete = deleteManager.GetTotalData();

            deleteManager.SetChkExclude(chkExcludeDelete.Checked);

            _excludeFolders = txtExcludeParamsDelete.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            deleteManager.SetExcludeFolders(_excludeFolders);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedRootPath = folderDialog.SelectedPath;
                    txtRootPathCopy.Text = _selectedRootPath;
                    txtRootPathDelete.Text = _selectedRootPath;

                    InitializeCopyManager();
                    InitializeDeleteManager();
                }
            }
        }

        private void UpdateProgressCopy()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateProgressCopy));
                return;
            }
            _progressCopy = _totalDataCopy > 0 ? (int)((_processedCopy / (double)_totalDataCopy) * 100) : 0;
            _progressCopy = Math.Max(0, Math.Min(100, _progressCopy)); // Pastikan progress antara 0-100
            Debug.WriteLine($"Progress Copy: {_progressCopy}");
            Debug.WriteLine($"Processed Copy: {_processedCopy}");
            bgWorkerCopy.ReportProgress(_progressCopy);
        }
        private void UpdateProgressDelete()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateProgressDelete));
                return;
            }
            _progressDelete = _totalDataDelete > 0 ? (int)((_processedDelete / (double)_totalDataDelete) * 100) : 0;
            _progressDelete = Math.Max(0, Math.Min(100, _progressDelete)); // Pastikan progress antara 0-100
            Debug.WriteLine($"Progress Copy: {_progressCopy}");
            Debug.WriteLine($"Processed Copy: {_processedCopy}");
            bgWorkerDelete.ReportProgress(_progressDelete);
        }

        private void ShowMessageBox(string message, string title, MessageBoxIcon icon)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MessageBox.Show(message, title, MessageBoxButtons.OK, icon)));
            }
            else
            {
                MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            }
        }
        private void InfoBox(string message) => ShowMessageBox(message, "Info", MessageBoxIcon.Information);
        private void WarningBox(string message) => ShowMessageBox(message, "Warning", MessageBoxIcon.Warning);
        private void ErrorBox(string message) => ShowMessageBox(message, "Error", MessageBoxIcon.Error);

        #endregion Initialize

        #region Copy

        private void btnScanCopy_Click(object sender, EventArgs e)
        {
            if (!bgWorkerCopy.IsBusy)
            {
                bgWorkerCopy.RunWorkerAsync("scan");
            }
            else
            {
                WarningBox("Proses sedang berjalan. Harap tunggu!");
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            if (!bgWorkerCopy.IsBusy)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menyalin semua file index.php?",
                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bgWorkerCopy.RunWorkerAsync("copyAll");
                }
            }
            else
            {
                WarningBox("Proses sedang berjalan. Harap tunggu!");
            }
        }

        private void dataGridViewCopy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
                {
                    DataGridViewRow row = dataGridViewCopy.Rows[e.RowIndex];
                    DataGridViewCell cellPath = row.Cells[0];
                    DataGridViewCell cellStatus = row.Cells[1];
                    DataGridViewButtonCell cellAction = (DataGridViewButtonCell)row.Cells[2];

                    if (e.ColumnIndex == 2 && cellAction.Value.ToString() != "") // Tombol "Copy"
                    {
                        string path = cellPath.Value?.ToString().Trim() ?? "";
                        if (string.IsNullOrEmpty(path)) return;

                        if (cellPath.Value != null && cellStatus.Value.ToString() != "Sukses")
                        {
                            bool result = DoCopy(path);

                            cellStatus.Style.BackColor = result ? Color.Green : Color.Red;
                            cellStatus.Value = result ? "Sukses" : "Gagal";

                            cellAction.FlatStyle = result ? FlatStyle.Flat : FlatStyle.Standard;
                            cellAction.UseColumnTextForButtonValue = result ? true : false;
                            cellAction.Value = result ? "" : "Copy";

                            if (result)          
                                InfoBox($"Berhasil menyalin index.php ke folder {path}");
                            else
                                ErrorBox($"Gagal menyalin index.php ke folder {path}");
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorBox(ex.Message);
                return;
            }
        }

        private void DoCopyAll()
        {
            _totalDataCopy = dataGridViewCopy.Rows.Count;

            foreach (DataGridViewRow row in dataGridViewCopy.Rows)
            {
                if (bgWorkerCopy.CancellationPending) return;

                _processedCopy++;
                DataGridViewCell cellPath = row.Cells[0];
                DataGridViewCell cellStatus = row.Cells[1];
                DataGridViewButtonCell cellAction = (DataGridViewButtonCell)row.Cells[2];

                string path = cellPath.Value?.ToString().Trim() ?? "";

                if (!string.IsNullOrEmpty(path) && cellStatus.Value.ToString() != "Sukses")
                {
                    try
                    {
                        bool result = DoCopy(path);

                        cellStatus.Style.BackColor = result ? Color.Green : Color.Red;
                        cellStatus.Value = result ? "Sukses" : "Gagal";

                        cellAction.FlatStyle = result ? FlatStyle.Flat : FlatStyle.Standard;
                        cellAction.UseColumnTextForButtonValue = result ? true : false;
                        cellAction.Value = result ? "" : "Copy";

                        bgWorkerCopy.ReportProgress(_progressCopy, new object[] { DateTime.Now, path, "Copy", result ? "Sukses" : "Gagal" });
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        row.Cells[1].Value = "Akses Ditolak";
                        row.Cells[1].Style.BackColor = Color.Orange;
                        LogError($"Akses ditolak saat menghapus {path}: {ex.Message}");
                    }
                    catch (IOException ex)
                    {
                        row.Cells[1].Value = "File Sedang Digunakan";
                        row.Cells[1].Style.BackColor = Color.Yellow;
                        LogError($"File sedang digunakan {path}: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        row.Cells[1].Value = "Gagal";
                        row.Cells[1].Style.BackColor = Color.Red;
                        LogError($"Error saat menghapus {path}: {ex.Message}");
                    }
                }
                UpdateProgressCopy();
            }
            InfoBox("Index.php telah disalin ke semua folder yang valid.");
        }
        

        private bool DoCopy(string path)
        {
            // set nama file index.php
            string filename = "index.php";

            // set path relative
            string relativePath = PathHelper.GetRelativeIndexPath(_selectedRootPath, path);
            string indexContent = $"<?php\ninclude '{relativePath}{filename}';";

            string indexPath = path + $"\\{filename}";

            return copyManager.DoCopy(indexPath, indexContent);
        }

        private void bgWorkerCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            string action = e.Argument.ToString();
            if (action == "scan")
            {
                ResetScanCopy();
                InitializeCopyManager();
                copyManager.ScanFolders(_selectedRootPath, bgWorkerCopy);
            }
            else if (action == "copyAll")
            {
                ResetCopyAll();
                DoCopyAll();
            }
        }

        private void bgWorkerCopy_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Tambahkan data ke DataGridView secara real-time
            if (e.UserState is string path)
            {
                dataGridViewCopy.Rows.Add(path, "", "Copy");

                dataGridViewCopy.Rows[_nomorCopy].Selected = true;
                dataGridViewCopy.FirstDisplayedScrollingRowIndex = _nomorCopy;

                if (_nomorCopy > 0)
                {
                    dataGridViewCopy.Rows[_nomorCopy - 1].Selected = false;
                }
                _nomorCopy++;
            }

            if (e.UserState is object[] logData)
            {
                // Tambahkan log ke dgvLog
                dgvLog.Rows.Add(logData);
            }
            _processedCopy = (int)((e.ProgressPercentage / 100.0) * _totalDataCopy);

            // Update ProgressBar
            if (e.ProgressPercentage >= pgBarCopy.Minimum && e.ProgressPercentage <= pgBarCopy.Maximum)
            {
                pgBarCopy.Value = e.ProgressPercentage;
            }

            // **Update Label dengan progress**
            lblProgressCopy.Text = $"Proses: {_processedCopy}/{_totalDataCopy} ({e.ProgressPercentage}%)";
        }

        private void bgWorkerCopy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //InfoBox("Proses scan selesai!", "Selesai");
        }

        #endregion Copy

        #region Delete

        private void btnScanDelete_Click(object sender, EventArgs e)
        {
            pgBarDelete.Value = 0;
            dataGridViewDelete.Rows.Clear();
            lblProgressDelete.Text = "Proses: 0/0 (0%)";

            if (!bgWorkerDelete.IsBusy)
            {
                bgWorkerDelete.RunWorkerAsync("scan");
            }
            else
            {
                WarningBox("Proses sedang berjalan. Harap tunggu!");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (!bgWorkerDelete.IsBusy)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus semua file index.php?",
                                          "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bgWorkerDelete.RunWorkerAsync("deleteAll");
                }
            }
            else
            {
                WarningBox("Proses sedang berjalan. Harap tunggu!");
            }
        }

        private void dataGridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Pastikan baris yang diklik valid
                {
                    DataGridViewRow row = dataGridViewDelete.Rows[e.RowIndex];
                    DataGridViewCell cellPath = row.Cells[0];
                    DataGridViewCell cellStatus = row.Cells[1];
                    DataGridViewButtonCell cellAction = (DataGridViewButtonCell)row.Cells[2];

                    if (e.ColumnIndex == 2 && cellAction.Value.ToString() != "") // Tombol "Delete"
                    {
                        string path = cellPath.Value?.ToString().Trim() ?? "";
                        if (string.IsNullOrEmpty(path)) return;

                        if (cellPath.Value != null && cellStatus.Value.ToString() != "Sukses")
                        {
                            bool result = deleteManager.DoDelete(path);
                            if (result)
                            {
                                row.SetValues(path, "Sukses", "");

                                // Mengubah warna background kolom 0, 1, 2 menjadi hijau
                                cellPath.Style.BackColor = Color.Green;
                                cellStatus.Style.BackColor = Color.Green;
                                cellAction.Style.BackColor = Color.Green;

                                cellAction.UseColumnTextForButtonValue = false; // Matikan tombol
                                cellAction.FlatStyle = FlatStyle.Flat; // Ubah gaya agar tidak terlihat tombolnya

                                InfoBox($"Berhasil menghapus index.php di folder {path}");
                            }
                            else
                            {
                                row.Selected = false;
                                row.SetValues(path, "Gagal", "Delete");

                                // Mengubah warna background kolom 0, 1, 2 menjadi merah
                                cellPath.Style.BackColor = Color.Red;
                                cellStatus.Style.BackColor = Color.Red;
                                cellAction.Style.BackColor = Color.Red;

                                InfoBox($"Gagal menghapus index.php di folder {path}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorBox(ex.Message);
                return;
            }
        }

        private void bgWorkerDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            string action = e.Argument.ToString();
            if (action == "scan")
            {
                ResetScanDelete();
                InitializeDeleteManager();
                deleteManager.ScanFolders(_selectedRootPath, bgWorkerDelete);
            }
            else if (action == "deleteAll")
            {
                ResetDeleteAll();
                DoDeleteAll();
            }
        }

        private void bgWorkerDelete_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Tambahkan data ke DataGridView secara real-time
            if (e.UserState is string indexPath)
            {
                dataGridViewDelete.Rows.Add(indexPath, "", "Hapus");

                dataGridViewDelete.Rows[_nomorDelete].Selected = true;
                dataGridViewDelete.FirstDisplayedScrollingRowIndex = _nomorDelete;

                if (_nomorDelete > 0)
                {
                    dataGridViewDelete.Rows[_nomorDelete - 1].Selected = false;
                }
                _nomorDelete++;
            }

            if (e.UserState is object[] logData)
            {
                // Tambahkan log ke dgvLog
                dgvLog.Rows.Add(logData);
            }

            // **Update ProgressBar dan Label**
            //int _totalDataDelete = dataGridViewDelete.Rows.Count;
            _processedDelete = (int)((e.ProgressPercentage / 100.0) * _totalDataDelete);

            // Update ProgressBar
            if (e.ProgressPercentage >= pgBarDelete.Minimum && e.ProgressPercentage <= pgBarDelete.Maximum)
            {
                pgBarDelete.Value = e.ProgressPercentage;
            }

            // **Update Label dengan progress**
            lblProgressDelete.Text = $"Proses: {_processedDelete}/{_totalDataDelete} ({e.ProgressPercentage}%)";
        }

        private void bgWorkerDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //InfoBox("Proses scan selesai!", "Selesai");
        }

        private void DoDeleteAll()
        {
            _totalDataDelete = dataGridViewDelete.Rows.Count;

            foreach (DataGridViewRow row in dataGridViewDelete.Rows)
            {
                if (bgWorkerDelete.CancellationPending) return;

                _processedDelete++;
                DataGridViewCell cellPath = row.Cells[0];
                DataGridViewCell cellStatus = row.Cells[1];
                DataGridViewButtonCell cellAction = (DataGridViewButtonCell)row.Cells[2];

                string path = cellPath.Value?.ToString().Trim() ?? "";

                if (!string.IsNullOrEmpty(path) && cellStatus.Value.ToString() != "Sukses")
                {
                    try
                    {
                        bool result = deleteManager.DoDelete(path);

                        cellStatus.Style.BackColor = result ? Color.Green : Color.Red;
                        cellStatus.Value = result ? "Sukses" : "Gagal";

                        cellAction.FlatStyle = result ? FlatStyle.Flat : FlatStyle.Standard;
                        cellAction.UseColumnTextForButtonValue = result ? true : false;
                        cellAction.Value = result ? "" : "Delete";

                        bgWorkerDelete.ReportProgress(_processedDelete, new object[] { DateTime.Now, path, "Delete", result ? "Sukses" : "Gagal" });
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        row.Cells[1].Value = "Akses Ditolak";
                        row.Cells[1].Style.BackColor = Color.Orange;
                        LogError($"Akses ditolak saat menghapus {path}: {ex.Message}");
                    }
                    catch (IOException ex)
                    {
                        row.Cells[1].Value = "File Sedang Digunakan";
                        row.Cells[1].Style.BackColor = Color.Yellow;
                        LogError($"File sedang digunakan {path}: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        row.Cells[1].Value = "Gagal";
                        row.Cells[1].Style.BackColor = Color.Red;
                        LogError($"Error saat menghapus {path}: {ex.Message}");
                    }
                }
                UpdateProgressDelete();
            }
            InfoBox("Index.php telah dihapus di semua folder yang valid.");
        }

        #endregion Global

        #region Log
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            dgvLog.Rows.Clear();
        }

        private void LogError(string message)
        {
            string logPath = Path.Combine(Application.StartupPath, "error_log.txt");
            File.AppendAllText(logPath, $"{DateTime.Now}: {message}\n");
        }

        #endregion Log

    }
}
