using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LogicSolver
{
    public partial class MainForm : Form
    {
        TextBox focusedTextBox;

        string document;
        string beginDoc = @"
            \documentclass[12pt,a4paper]{report}
            \usepackage{amssymb}
            \usepackage{amsmath}
            \usepackage[utf8]{inputenc}
            \usepackage[vietnamese]{babel}
            \usepackage[landscape,margin=0.5cm]{geometry}
            \begin{document}
            \pagestyle{empty}
            \fussy
            {\Huge";
        string endDoc = @"}\end{document}";

        StreamReader reader;
        StreamWriter writer;

        int waitingTime = 30000;

        int imageIndex = 0;
        int imageCount = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        public void InsertSymbol(string symbol)
        {
            if (focusedTextBox != null)
            {
                int selectionStart = focusedTextBox.SelectionStart;
                focusedTextBox.Text = focusedTextBox.Text.Insert(selectionStart, symbol);
                focusedTextBox.Focus();
                focusedTextBox.DeselectAll();
                focusedTextBox.SelectionStart = selectionStart + symbol.Length;
            }
        }

        public string Solve(string input, int type)
        {
            writer = File.CreateText("input.mpl");
            writer.WriteLine("packageDir:= cat(currentdir(), kernelopts(dirsep) , \"DoAn.mla\"):");
            writer.WriteLine("march('open', packageDir):");
            writer.WriteLine("with(Logic);");
            switch (type)
            {
                case 0: // rut gon bieu thuc logic
                    writer.WriteLine("P := " + input + ";");
                    writer.WriteLine("ExportResult(P, BooleanSimplify(P), SimplifyLogicExpression(P));");
                    break;
                case 1: // kiem chung suy luan
                    string[] strs = input.Split(new string[] { "SPLIT" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] hypos = strs[0].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    string h = "";
                    foreach (string s in hypos)
                    {
                        h += ("(" + s + ") &and");
                    }
                    h = h.Remove(h.Length - 4);
                    writer.WriteLine("P := " + h + " ;");
                    writer.WriteLine("Q := " + strs[1] + " ;");
                    writer.WriteLine("T := EvaluateReasoning(P, Q);");
                    writer.WriteLine("ExportResult2(P, Q, T[1], T[2]);");
                    break;
                case 2: // rut gon ham bool
                    input += inputTextBox3.Text;
                    break;
            }
            writer.Close();

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "solve.bat";
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            Process process = Process.Start(processInfo);
            process.WaitForExit();

            reader = File.OpenText("input.tex");
            string text = reader.ReadToEnd();
            reader.Close();

            return text;
        }

        public void DisplayText(string text)
        {
            try
            {
                document += text;
                document += endDoc;
                File.WriteAllText("input.tex", document);

                Process process = new Process();
                process.StartInfo.FileName = "display.bat";
                process.StartInfo.Arguments = "input";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit(waitingTime);

                string pattern = "output*.png";
                string[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory(), pattern);
                if (dirs.Length == 0)
                {
                    pictureBox.Image = Properties.Resources.error;
                    imageIndex = -1;
                    imageCount = 0;
                }
                else if (dirs.Length == 1)
                {
                    pictureBox.ImageLocation = "output.png";
                    imageIndex = 0;
                    imageCount = 1;
                }
                else
                {
                    pictureBox.ImageLocation = "output-0.png";
                    imageIndex = 0;
                    imageCount = dirs.Length;
                }
                pageLabel.Text = (imageIndex + 1) + "/" + imageCount;
                prevButton.Enabled = false;
                if (imageCount <= 1)
                    nextButton.Enabled = false;
                else
                    nextButton.Enabled = true;

                document = beginDoc;
            }
            catch
            {
                pictureBox.Image = Properties.Resources.error;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            focusedTextBox = (TextBox)sender;
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            InsertSymbol("&and");
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            InsertSymbol("&or");
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            InsertSymbol("&not");
        }

        private void impliesButton_Click(object sender, EventArgs e)
        {
            InsertSymbol("&implies");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            document = beginDoc;
            andButton.Text = "\u2227\r\n&&and";
            orButton.Text = "\u2228\r\n&&or";
            notButton.Text = "\u00ac\r\n&&not";
            impliesButton.Text = "\u2192\r\n&&implies";
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            string pattern = "output*.png";
            string[] dirs = Directory.GetFiles(Directory.GetCurrentDirectory(), pattern);
            foreach (string dir in dirs)
                File.Delete(dir);

            waitingLabel.Visible = true;

            string input = "";
            switch (tabControl.SelectedIndex)
            {
                case 0: // rut gon bieu thuc logic
                    if (inputTextBox1.Text == "") { waitingLabel.Visible = false; return; }
                    input += inputTextBox1.Text;
                    break;
                case 1: // kiem chung suy luan
                    if (inputTextBox2a.Text == "" || inputTextBox2b.Text == "") { waitingLabel.Visible = false; return; }
                    input += inputTextBox2a.Text;
                    input += "SPLIT";
                    input += inputTextBox2b.Text;
                    break;
                case 2: // rut gon ham bool
                    if (inputTextBox3.Text == "") { waitingLabel.Visible = false; return; }
                    input += inputTextBox3.Text;
                    break;
            }
            string text = Solve(input, tabControl.SelectedIndex);
            DisplayText(text);

            waitingLabel.Visible = false;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (imageIndex > 0)
            {
                imageIndex--;
                pictureBox.ImageLocation = "output-" + imageIndex + ".png";
                pageLabel.Text = (imageIndex + 1) + "/" + imageCount;
                if (imageIndex == 0)
                    prevButton.Enabled = false;
                nextButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (imageIndex < imageCount - 1)
            {
                imageIndex++;
                pictureBox.ImageLocation = "output-" + imageIndex + ".png";
                pageLabel.Text = (imageIndex + 1) + "/" + imageCount;
                if (imageIndex == imageCount - 1)
                    nextButton.Enabled = false;
                prevButton.Enabled = true;
            }
        }
    }
}
