using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Printing;
using Nearest_Launcher.Properties;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Google.Apis;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
using Google.Apis.Download;
using Google.Apis.Services;
using System.Reflection;
using System.Resources;

namespace Nearest_Launcher
{
    public partial class MainWindow : Form
    {
        private static int Colour = 0;
        private static System.Timers.Timer MainTimer;
        private static bool BackGroundShadow = true;
        private static int BackGroundImage_Num = 0;
        private static bool BackGroundImageChange = true;
        private static System.Drawing.Image BackGroundImage0 = Resources.BackGroundImage0;
        private static System.Drawing.Image BackGroundImage1 = Resources.BackGroundImage1;
        private static string LaucherDirrectory = Environment.CurrentDirectory;
        private static bool Only_download = false;
        private static bool Process_Checked = false;

        public MainWindow()
        {
            InitializeComponent();

          MainTimer = new System.Timers.Timer();
          
          MainTimer.Interval = 10;
          
          MainTimer.Elapsed += Update;
          
          MainTimer.AutoReset = true;
          
          MainTimer.Enabled = true;

        }

        private void Update(object sender, ElapsedEventArgs e)
        {
            if (Process_Checked)
            {
                if (Play_button.Visible)
                {
                    if (Play_button.InvokeRequired)
                    {
                        Play_button.Invoke(new Action(() =>
                        {

                            Play_button.Visible = false;
                        }));
                    }
                    else
                        Play_button.Visible = false;
                }

                if (SaveLogsCheck.Visible)
                {
                    if (SaveLogsCheck.InvokeRequired)
                    {
                        SaveLogsCheck.Invoke(new Action(() =>
                        {

                            SaveLogsCheck.Visible = false;
                        }));
                    }
                    else
                        SaveLogsCheck.Visible = false;
                }


                if (Check_Update_Button.Visible)
                {
                    if (Check_Update_Button.InvokeRequired)
                    {
                        Check_Update_Button.Invoke(new Action(() =>
                        {

                            Check_Update_Button.Visible = false;
                        }));
                    }
                    else
                        Check_Update_Button.Visible = false;
                }
            }
            else
            {

                if (!Play_button.Visible)
                {
                    if (Play_button.InvokeRequired)
                    {
                        Play_button.Invoke(new Action(() =>
                        {

                            Play_button.Visible = true;
                        }));
                    }
                    else
                        Play_button.Visible = true;
                }

                if (!SaveLogsCheck.Visible)
                {
                    if (SaveLogsCheck.InvokeRequired)
                    {
                        SaveLogsCheck.Invoke(new Action(() =>
                        {

                            SaveLogsCheck.Visible = true;
                        }));
                    }
                    else
                        SaveLogsCheck.Visible = true;
                }

                if (!Check_Update_Button.Visible)
                {
                    if (Check_Update_Button.InvokeRequired)
                    {
                        Check_Update_Button.Invoke(new Action(() =>
                        {

                            Check_Update_Button.Visible = true;
                        }));
                    }
                    else
                        Check_Update_Button.Visible = true;
                }
            }
            if (Colour == 255)
                BackGroundShadow = false;

            if (Colour == 0)
                BackGroundShadow = true;


            if (BackGroundShadow)
                Colour++;
            else
                Colour--;

            if (Colour < 256)
            {
                MainWindowSlide.BackColor = System.Drawing.Color.FromArgb(Colour, 0, 0, 0);
            }

            if (Colour == 255)
            {
                if (BackGroundImage_Num == 0)
                    BackGroundImageChange = false;

                if (BackGroundImage_Num == 1)
                    BackGroundImageChange = true;

                if (BackGroundImageChange)
                    BackGroundImage_Num--;
                else
                    BackGroundImage_Num++;


                if (BackGroundImage_Num == 0)
                    this.BackgroundImage = BackGroundImage0;
                else if (BackGroundImage_Num == 1)
                    this.BackgroundImage = BackGroundImage1;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VK_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/neareststage");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/QrMx4Fy6Kw");
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            // Путь к вашему файлу ключа JSON служебного аккаунта (Зашито в EXE) (БАЙТЫ)
            ResourceManager resourceManager = new ResourceManager("Nearest_Launcher.Properties.Resources", Assembly.GetExecutingAssembly());
            byte[] data = (byte[])resourceManager.GetObject("secret_json");
            Stream serviceAccountKeyFilePath = new MemoryStream(data);

            // Теперь у вас есть поток для чтения содержимого файла
            // Вы можете использовать этот поток, например, для чтения содержимого файла ключа служебного аккаунта
            // Например:

            // Email адрес вашего служебного аккаунта
            string serviceAccountEmail = "neareststage-cloud@innate-grail-416517.iam.gserviceaccount.com";

            // ID папки на Google Диске, к которой вы предоставили доступ вашему служебному аккаунту
            string folderId = "1WnIUBn6v2B23QckNUJCs2_uorkCcHSJA";
            LastTotalSize = 0;

            if (GetEnableDownload() == 0)
            {
                // Создаем экземпляр службы Google Drive с использованием служебного аккаунта
                var service = GetDriveServiceAsync(serviceAccountKeyFilePath, serviceAccountEmail);
                // Получаем список файлов в корневой директории Google Drive

                Debug.WriteLine("Start Downloading : " + GetEnableDownload());
                Task.Run(() => DownloadFiles(service, folderId, LaucherDirrectory, false));


                // Создаем и запускаем таймер
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += OnTimerElapsed;
                timer.AutoReset = true; // Устанавливаем значение true, чтобы таймер запускался снова после каждого истечения интервала
                timer.Start();
            }
            else
            {
                Debug.WriteLine("Start Downloading : " + GetEnableDownload());
            }
        }

        private void GameStart()
        {
            string Starter = LaucherDirrectory + "\\bin\\xrEngine.exe";

            string Args = "";

            if (SaveLogsCheck.Checked)
                Args = "-save_old_logs";

            if (System.IO.File.Exists(Starter))
            {
                System.Diagnostics.Process.Start(Starter, Args);
            }
            else
            {
                string messageBoxText = "Не найден xrEngine.exe! Убедитесь, что лаунчер находится в корневой папке игры!";
                string caption = "NearestLauncher";
                MessageBox.Show(messageBoxText, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string LogFolder = LaucherDirrectory + "\\_appdata_\\zalupa\\";

            if (Directory.Exists(LogFolder))
            {
                DateTime dt = new DateTime(1990, 1, 1);
                string fileName = "";
                FileSystemInfo[] fileSystemInfo = new DirectoryInfo(LogFolder).GetFileSystemInfos();
                foreach (FileSystemInfo fileSI in fileSystemInfo)
                {
                    if (fileSI.Extension == ".log")
                    {
                        if (dt < Convert.ToDateTime(fileSI.CreationTime))
                        {
                            dt = Convert.ToDateTime(fileSI.CreationTime);
                            fileName = fileSI.Name;
                        }
                    }
                }


                System.Diagnostics.Process.Start(LogFolder + fileName);
               // File.Open(LogFolder + fileName, FileMode.Open);
            }
            else
            {
                MessageBox.Show("Не найдена папка с Логами!", "NearestLaucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static DriveService GetDriveServiceAsync(Stream serviceAccountKeyFilePath, string serviceAccountEmail)
        {
            // Чтение файла ключа JSON служебного аккаунта

            string[] scopes = { "https://www.googleapis.com/auth/drive" };

            GoogleCredential credential = GoogleCredential.FromStream(serviceAccountKeyFilePath)
                                        .CreateScoped(scopes)
                                        .CreateWithUser(serviceAccountEmail);

            // Создаем службу Google Drive
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "NearestStage"
            });
        }

        long LastTotalSize = 0;
        long CurrentMB = 0;

        void SetLabel2Text(string label)
        {
            Debug.WriteLine(label);
        }

        void SetProgressBar (int value, bool view)
        {
            if (Download_progress.InvokeRequired)
            {
                Download_progress.Invoke(new Action(() =>
                {
                    Download_progress.Visible = view;
                    Download_progress.Value = value;
                }));
            }
            else
            {
                Download_progress.Visible = view;
                Download_progress.Value = value;
            }

            SetPercentText(value.ToString() + "%", view);
        }

        void SetPercentText(string percent, bool view)
        {
            if (Percent_label.InvokeRequired)
            {
                Percent_label.Invoke(new Action(() =>
                {
                    Percent_label.Visible = view;
                    Percent_label.Text = percent;
                }));
            }
            else
            {
                Percent_label.Visible = view;
                Percent_label.Text = percent;
            }
        }

        void SetLabel1Text(string s)
        {
            if (Download_Label.InvokeRequired)
            {
                Download_Label.Invoke(new Action(() => {
                    Download_Label.Visible = true;
                    Download_Label.Text = s; }));
            }
            else
            {
                Download_Label.Visible = true;
                Download_Label.Text = s;
            }
        }

        void OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                long Val = CurrentMB; //CurrentValueBytes / (1024 / 1024)
                long Total = LastTotalSize;

                SetLabel2Text("Recived: " + Val + " MB / Total: " + Total + " MB");


                //  Debug.WriteLine("Recived: " + CurrentValueBytes);
                //  SetLabel2Text("Recived: " + CurrentValueBytes / (1024 / 1024) + " MB");

                // LastSended = CurrentValueBytes;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }


        private void UpdateProgressBar(IDownloadProgress progress, long sizefile)
        {
            // Обновляем прогресс-бар в соответствии с полученным прогрессом.
            if (progress.Status == DownloadStatus.Completed)
            {
                SetLabel1Text($"Все обновления установленны!");
                SetProgressBar(100, false); // Загрузка завершена

                int sizeMB = (int)progress.BytesDownloaded / 1024 / 1024;
                Interlocked.Add(ref LastTotalSize, sizeMB);
            }
            else if (progress.Status == DownloadStatus.Failed)
            {
                SetLabel1Text($"Ошибка загрузки!!");
                SetProgressBar(0, false); // Обработка ошибки загрузки, если необходимо.
            }
            else
            {
                // Обновляем прогресс-бар в соответствии с текущим прогрессом.
                Debug.WriteLine("Downloaded: " + progress.BytesDownloaded + "| FileSize: " + sizefile);
                SetProgressBar((int)(progress.BytesDownloaded * 100 / sizefile), true);

                CurrentMB = progress.BytesDownloaded / 1024 / 1024;
            }
        }

        private int EnableDownload = 0;

        void SetEnableDownload(int value)
        {
            EnableDownload = value;
        }

        int GetEnableDownload()
        {
            return EnableDownload;
        }

        async void DownloadFiles(DriveService service, string folderId, string destinationDirectory, bool recurcive)
        {

            Process_Checked = true;
            Debug.WriteLine("LOCK Downloading");

            SetEnableDownload(GetEnableDownload() + 1);


            var request = service.Files.List();
            request.Q = $"'{folderId}' in parents";
            var results = request.Execute().Files;

            if (results != null && results.Count > 0)
            {

                if (Directory.Exists(destinationDirectory))
                    if ((destinationDirectory == "NearestStage\\bin" || destinationDirectory == "NearestStage\\resources" || destinationDirectory == "NearestStage") && (destinationDirectory != "NearestStage\\_appdata_"))
                    {
                        // Получаем список файлов в указанной папке (После удаляем если не находим файл)
                        // Debug.WriteLine("Dest: " + destinationDirectory);
                        string[] files = Directory.GetFiles(destinationDirectory);

                        // Выводим список файлов на консоль
                        Debug.WriteLine("Список файлов в папке:");
                        foreach (string file_name in files)
                        {
                            bool Finder = false;


                            foreach (var file in results)
                            {
                                // Debug.WriteLine("Файл с Репы: " + Path.GetFileName(file_name) + "|" +  file.Name);
                                if (file.Name == Path.GetFileName(file_name))
                                {
                                    Finder = true;
                                    break;
                                }
                            }

                            if (!Finder)
                                System.IO.File.Delete(file_name);
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Cant Find Dest: " + destinationDirectory + " | " + "NearestStage\\bin" + " | " + "NearestStage\\resources");
                    }


                foreach (var file in results)
                {
                    // Debug.WriteLine("File: " + file.Name);

                    if (file.MimeType == "application/vnd.google-apps.folder")
                    {
                        // If the file is a folder, recursively call DownloadFiles with the folder ID.
                        DownloadFiles(service, file.Id, Path.Combine(destinationDirectory, file.Name), true);
                    }
                    else
                    {
                        if (!Directory.Exists(destinationDirectory))
                            Directory.CreateDirectory(destinationDirectory);

                        SetProgressBar(0, true);

                        // Recive Data From server (GOOGLE)
                        var fileRequest = service.Files.Get(file.Id);
                        fileRequest.Fields = "md5Checksum, size, name";
                        var FileRecived = fileRequest.Execute();

                        // MD5
                        string MD5Check = FileRecived.Md5Checksum;

                        Debug.WriteLine($"MD5: {MD5Check}");
                        string filePath = Path.Combine(destinationDirectory, file.Name);

                        string FileMD5_Checksum = "";

                        if (System.IO.File.Exists(filePath))
                        {
                            using (var md5 = System.Security.Cryptography.MD5.Create())
                            {
                                using (var stream = System.IO.File.OpenRead(filePath))
                                {
                                    if (stream != null)
                                        FileMD5_Checksum = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                                }
                            }
                        }


                        // File Checked
                        long sizeFile = FileRecived.Size != 0 ? FileRecived.Size.Value : 1;
                        var DownloadReqvest = service.Files.Get(file.Id);
                        SetLabel1Text($"Загружаем: {file.Name}");

                        if (FileMD5_Checksum != MD5Check)
                        {
                            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                            {
                                while (true)
                                {
                                    try
                                    {


                                        DownloadReqvest.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                                        {
                                            // Вызываем колбэк для обновления прогресс-бара.
                                            UpdateProgressBar(progress, sizeFile);
                                        };

                                        var value = DownloadReqvest.DownloadWithStatus(stream);



                                        //   DownloadReqvest.DownloadRange(, )

                                        if (value.Status == DownloadStatus.Failed)
                                        {
                                            stream.Position = 0;
                                            SetLabel1Text($"Перезагружаю: {file.Name}");
                                            Console.WriteLine($"HTTP Problem Resume Download {value.Exception.Message}");
                                            continue;
                                        }
                                        else
                                            break;
                                    }
                                    catch (Google.GoogleApiException ex) when (ex.HttpStatusCode == System.Net.HttpStatusCode.RequestedRangeNotSatisfiable)
                                    {
                                        SetLabel1Text($"Перезагружаю_ex: {file.Name}");
                                        stream.Position = 0;
                                        Console.WriteLine($"HTTP Problem Resume Download {ex.Message}");
                                        continue;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"An error occurred: {ex.Message}");
                                        break;
                                    }
                                }
                            }
                        }

                        SetLabel1Text($"Загружаем: {file.Name}");
                    }
                }

                {
                    Debug.WriteLine("Stop Downloading");
                    SetEnableDownload(GetEnableDownload() - 1);
                }
            }
            else
            {
                Debug.WriteLine("No files found.");

                SetEnableDownload(GetEnableDownload() - 1);
            }

            if (GetEnableDownload() == 0)
            {
                Process_Checked = false;
                SetLabel1Text($"Все обновления установленны!");
                SetProgressBar(100, false);

                if(!Only_download)
                    GameStart();

                Only_download = false;
            }
        }

        private void Check_Update_Button_Click(object sender, EventArgs e)
        {
            Only_download = true;
            // Путь к вашему файлу ключа JSON служебного аккаунта (Зашито в EXE) (БАЙТЫ)
            ResourceManager resourceManager = new ResourceManager("Nearest_Launcher.Properties.Resources", Assembly.GetExecutingAssembly());
            byte[] data = (byte[])resourceManager.GetObject("secret_json");
            Stream serviceAccountKeyFilePath = new MemoryStream(data);

            // Теперь у вас есть поток для чтения содержимого файла
            // Вы можете использовать этот поток, например, для чтения содержимого файла ключа служебного аккаунта
            // Например:

            // Email адрес вашего служебного аккаунта
            string serviceAccountEmail = "neareststage-cloud@innate-grail-416517.iam.gserviceaccount.com";

            // ID папки на Google Диске, к которой вы предоставили доступ вашему служебному аккаунту
            string folderId = "1WnIUBn6v2B23QckNUJCs2_uorkCcHSJA";
            LastTotalSize = 0;

            if (GetEnableDownload() == 0)
            {
                // Создаем экземпляр службы Google Drive с использованием служебного аккаунта
                var service = GetDriveServiceAsync(serviceAccountKeyFilePath, serviceAccountEmail);
                // Получаем список файлов в корневой директории Google Drive

                Debug.WriteLine("Start Downloading : " + GetEnableDownload());
                Task.Run(() => DownloadFiles(service, folderId, LaucherDirrectory, false));


                // Создаем и запускаем таймер
                System.Timers.Timer timer = new System.Timers.Timer(1000);
                timer.Elapsed += OnTimerElapsed;
                timer.AutoReset = true; // Устанавливаем значение true, чтобы таймер запускался снова после каждого истечения интервала
                timer.Start();
            }
            else
            {
                Debug.WriteLine("Start Downloading : " + GetEnableDownload());
            }


        }
    }
}
