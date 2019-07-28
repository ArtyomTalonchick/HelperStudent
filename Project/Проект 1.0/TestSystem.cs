using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace OurProject._0
{
    //class TestSystem : Helper
    public partial class Helper
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*exe";
            string fName = "z1.exe";
            string temp = Directory.GetCurrentDirectory();
            temp = temp.Remove(temp.Length - 20);
            string backupDir = temp + @"Libraries\TestSystem\";
            if(File.Exists(Path.Combine(backupDir, fName))) 
                File.Delete(Path.Combine(backupDir, fName));
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    try
                    {
                        File.Copy(ofd.FileName, Path.Combine(backupDir, fName));
                    }

                    catch (IOException copyError)
                    {
                        MessageBox.Show(copyError.Message);
                    }

                }

                catch (DirectoryNotFoundException dirNotFound)
                {
                    MessageBox.Show(dirNotFound.Message);
                }

                Process myProcess = new Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.Arguments = @"/C cd " + backupDir + "& All_Test2.bat";
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
            }
            string path = backupDir + "z1.res";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }
        }

        private void CheckedCodeButton_Click(object sender, EventArgs e)
        {
            string fName = "z1.exe";
            string temp = Directory.GetCurrentDirectory();
            temp = temp.Remove(temp.Length - 20);
            string backupDir = temp + @"Libraries\TestSystem\";

            if (File.Exists(Path.Combine(backupDir, fName)))
                File.Delete(Path.Combine(backupDir, fName));

            if (File.Exists(@"D:\My study\Helper студента\Part2\4.5\Libraries\TestSystem\Code.cpp"))
                File.Delete(@"D:\My study\Helper студента\Part2\4.5\Libraries\TestSystem\Code.cpp");

            if (File.Exists(@"C:\Users\Lenovo\Desktop\CodeBlocks\MinGW\bin\Code.exe"))
                File.Delete(@"C:\Users\Lenovo\Desktop\CodeBlocks\MinGW\bin\Code.exe");

            if (File.Exists(@"C:\Users\Lenovo\Desktop\CodeBlocks\MinGW\bin\Code.o"))
                File.Delete(@"C:\Users\Lenovo\Desktop\CodeBlocks\MinGW\bin\Code.o");

            List<string> list = new List<string>();
            list.AddRange(richTextBox1.Lines);
            //list.Insert(0, "#include <stdio.h>");
            richTextBox1.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                richTextBox1.AppendText(list[i]);
            }


            File.WriteAllLines(Path.Combine(backupDir, "Code.cpp"), CodeTextBox.Lines);
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = @"/C cd " + backupDir + "& 2.bat";
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            try
            {
                File.Copy(@"C:\Users\Lenovo\Desktop\CodeBlocks\MinGW\bin\Code.exe", Path.Combine(backupDir, fName));
            }

            catch (IOException copyError)
            {
                MessageBox.Show("Compilation Error");
                return;
            }

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = @"/C cd " + backupDir + "& All_Test2.bat";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            milliseconds = 1000;
            Thread.Sleep(milliseconds);
            string path = backupDir + "z1.res";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            catch (Exception ew)
            {
                MessageBox.Show(ew.Message);
            }
        }
    }
}
