using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicSolver
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void andButton_Click(object sender, EventArgs e)
        {

        }

        private void orButton_Click(object sender, EventArgs e)
        {

        }

        private void notButton_Click(object sender, EventArgs e)
        {

        }

        private void impliesButton_Click(object sender, EventArgs e)
        {

        }

        private void solveButton1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("input.tex", inputTextBox1.Text);

            Process p1 = new Process();
            p1.StartInfo.FileName = "batch.bat";
            p1.StartInfo.Arguments = "input";
            p1.StartInfo.UseShellExecute = false;

            p1.Start();
            p1.WaitForExit();

            pictureBox1.ImageLocation = "output.png";

        }

        private void prevbutton1_Click(object sender, EventArgs e)
        {

        }

        private void nextButton1_Click(object sender, EventArgs e)
        {

        }

        private void solveButton2_Click(object sender, EventArgs e)
        {

        }

        private void prevButton2_Click(object sender, EventArgs e)
        {

        }

        private void nextButton2_Click(object sender, EventArgs e)
        {

        }

        private void solveButton3_Click(object sender, EventArgs e)
        {

        }

        private void prevButton3_Click(object sender, EventArgs e)
        {

        }

        private void nextButton3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            inputTextBox1.Text =
                @"\documentclass[preview,12pt]{standalone}
\usepackage{amsmath}
\usepackage{tikz}

\begin{document}
PSTrick is more powerful than this one\\ \tikz \draw[red] (0,0) circle(1);
\end{document}
";

        }
    }
}
