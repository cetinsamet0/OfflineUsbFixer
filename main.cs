using System.Diagnostics;
using System.Text.Json;
namespace OfflineUsbRepair
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
     
        public class DiskInfo
        {
            public int Number { get; set; }
            public string FriendlyName { get; set; }
            public string OperationalStatus { get; set; }
        }

        public void listdisk()
        {
            var process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "Get-Disk | Format-List Number,FriendlyName,OperationalStatus";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            richTextBox1.Clear();
            richTextBox1.Text = output.ToString();


            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show("Hata:" + error);
            }
            string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            comboBox1.Items.Clear();

            foreach (string line in lines)
            {
                comboBox1.Items.Add(line.Trim());
            }

        }
        public void addcombo()
        {
            var process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "Get-Disk | Format-List Number";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            comboBox1.Items.Clear();
            foreach (var line in lines)
            {
                comboBox1.Items.Add(line.Trim());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listdisk();
            addcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                try {
                    string selecteddisk = comboBox1.SelectedItem?.ToString();
                    string numberString = selecteddisk.Split(':')[1].Trim();
                    int diskNumber = Convert.ToInt32(numberString);

                    var ps = new Process();
                    ps.StartInfo.FileName = "powershell.exe";
                    ps.StartInfo.Arguments = $"set-disk {diskNumber} -isoffline $false";
                    ps.StartInfo.RedirectStandardError = true;
                    ps.StartInfo.RedirectStandardOutput = true;
                    ps.StartInfo.CreateNoWindow = true;
                    ps.StartInfo.UseShellExecute = false;

                    ps.Start();
                    string output = ps.StandardOutput.ReadToEnd();
                    string error = ps.StandardError.ReadToEnd();
                    ps.WaitForExit();

                    MessageBox.Show("Disk baþarýyla online moda geçti:)","Disk Düzeltildi!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                catch(Exception ex )
                {
                    MessageBox.Show("Program þu hatayla karþýlaþtý: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Lütfen bir disk seçiniz!", "Disk Seçilemedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
