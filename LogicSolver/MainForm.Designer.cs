namespace LogicSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inputTextBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pageLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.andButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.orButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.impliesButton = new System.Windows.Forms.Button();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(46, 67);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(879, 113);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(871, 75);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rút gọn biểu thức logic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(103, 21);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(659, 30);
            this.inputTextBox1.TabIndex = 1;
            this.inputTextBox1.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đề bài:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.inputTextBox2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(871, 75);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm chứng suy luận";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(103, 24);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(659, 30);
            this.inputTextBox2.TabIndex = 10;
            this.inputTextBox2.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Đề bài:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.inputTextBox3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(871, 75);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rút gọn hàm bool";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Location = new System.Drawing.Point(104, 19);
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.Size = new System.Drawing.Size(708, 30);
            this.inputTextBox3.TabIndex = 10;
            this.inputTextBox3.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 9;
            this.label12.Text = "Đề bài:";
            // 
            // pageLabel
            // 
            this.pageLabel.Location = new System.Drawing.Point(829, 318);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(87, 36);
            this.pageLabel.TabIndex = 8;
            this.pageLabel.Text = "0/0";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(878, 357);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(43, 41);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(829, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trang";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(829, 357);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(43, 41);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(824, 194);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(97, 45);
            this.solveButton.TabIndex = 4;
            this.solveButton.Text = "Tính";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(154, 194);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(659, 351);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // andButton
            // 
            this.andButton.Location = new System.Drawing.Point(571, 12);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(83, 48);
            this.andButton.TabIndex = 2;
            this.andButton.Text = "and";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Click += new System.EventHandler(this.andButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phím tắt:";
            // 
            // orButton
            // 
            this.orButton.Location = new System.Drawing.Point(660, 12);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(83, 48);
            this.orButton.TabIndex = 4;
            this.orButton.Text = "or";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Click += new System.EventHandler(this.orButton_Click);
            // 
            // notButton
            // 
            this.notButton.Location = new System.Drawing.Point(749, 12);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(83, 48);
            this.notButton.TabIndex = 5;
            this.notButton.Text = "not";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // impliesButton
            // 
            this.impliesButton.Location = new System.Drawing.Point(838, 12);
            this.impliesButton.Name = "impliesButton";
            this.impliesButton.Size = new System.Drawing.Size(83, 48);
            this.impliesButton.TabIndex = 6;
            this.impliesButton.Text = "implies";
            this.impliesButton.UseVisualStyleBackColor = true;
            this.impliesButton.Click += new System.EventHandler(this.impliesButton_Click);
            // 
            // waitingLabel
            // 
            this.waitingLabel.AutoSize = true;
            this.waitingLabel.Location = new System.Drawing.Point(37, 235);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(110, 25);
            this.waitingLabel.TabIndex = 9;
            this.waitingLabel.Text = "Đang tính...";
            this.waitingLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(979, 571);
            this.Controls.Add(this.waitingLabel);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.impliesButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải Toán Rời Rạc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button impliesButton;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inputTextBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label waitingLabel;
    }
}