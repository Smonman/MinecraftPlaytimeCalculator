using System;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinecraftPlaytimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string playerName;
        private string dirPath;

        private TimeSpan totalPlayTime = new TimeSpan();

        private void SearchLogFile(string path)
        {
            DateTime start = File.GetLastWriteTime(path).Date;
            TimeSpan dif = new TimeSpan();
            string line = "";

            bool hasStart = false;

            using (Stream fileStream = File.OpenRead(path), zippedStream = new GZipStream(fileStream, CompressionMode.Decompress))
            {
                using (StreamReader reader = new StreamReader(zippedStream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if ((line.Contains(playerName + " joined the game") || line.Contains("Connecting to")) && !hasStart)
                        {
                            start = GetTime(line, path);
                            hasStart = true;
                        }
                        if ((line.Contains("Stopping server") || line.Contains("Stopping!")) && hasStart)
                        {
                            dif = dif.Add(GetTime(line, path).Subtract(start));
                            hasStart = false;
                        }
                    }
                }
            }

            if (dif != new TimeSpan())
            {
                totalPlayTime += dif;
                listBox_output.Items.Add(String.Format("{0:[dd. MM. yyyy] [hh:mm:ss]} : {1}\tminutes", start, dif.TotalMinutes.ToString("0.00")));
            }
        }

        private DateTime GetTime(string line, string path)
        {
            string fileModifyDate = File.GetLastWriteTime(path).Date.ToString();
            string time = Regex.Match(line, @"\d+[:]\d+[:]\d+", RegexOptions.ECMAScript).Value;
            string dateTime = fileModifyDate.Substring(0, 11) + time;
            return Convert.ToDateTime(dateTime);
        }

        private void LoadDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.gz"))
            {
                SearchLogFile(fileInfo.FullName);
            }

            label_playtime.Text = GetTotalPlaytimeString();

            listBox_output.Items.Add("Finished");
            listBox_output.Items.Add(GetTotalPlaytimeString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_playtime.Text = String.Format(GetTotalPlaytimeString());
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            totalPlayTime = new TimeSpan();

            listBox_output.Items.Clear();

            playerName = textBox_playerName.Text;
            playerName = playerName.Replace(" ", string.Empty);

            if (playerName.Length == 0)
            {
                return;
            }

            if (textBox_dir.Text != string.Empty)
            {
                dirPath = textBox_dir.Text;
            }
            else
            {
                return;
            }

            LoadDirectory(dirPath);
        }

        private void button_openFolderDialoge_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dirPath = fbd.SelectedPath;
                textBox_dir.Text = dirPath;
            }
        }

        private string GetTotalPlaytimeString()
        {
            //return String.Format("Total playtime: {0} d {1} h {2} m Total hours: {3}", totalPlayTime.Days, totalPlayTime.Hours, totalPlayTime.Minutes, Math.Round(totalPlayTime.TotalHours, 0));
            return String.Format("Total playtime: {0} Total hours: {1}", totalPlayTime, Math.Round(totalPlayTime.TotalHours, 0));
        }
    }
}
