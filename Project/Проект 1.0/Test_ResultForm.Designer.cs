namespace OurProject._0
{
    partial class Test_ResultForm
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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LevelOfTestLabel = new System.Windows.Forms.Label();
            this.NumberOfRightAnwerLabel = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.AllAnswer = new System.Windows.Forms.Label();
            this.AllAnswerInTestLabel = new System.Windows.Forms.Label();
            this.ResultMark = new System.Windows.Forms.Label();
            this.MarkOfTestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContinueButton.Location = new System.Drawing.Point(40, 230);
            this.ContinueButton.Margin = new System.Windows.Forms.Padding(4);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(120, 28);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.Continue_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.Location = new System.Drawing.Point(215, 230);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(120, 28);
            this.MenuButton.TabIndex = 1;
            this.MenuButton.Text = "Меню";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.Menu_Click);
            // 
            // LevelOfTestLabel
            // 
            this.LevelOfTestLabel.AutoSize = true;
            this.LevelOfTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelOfTestLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LevelOfTestLabel.Location = new System.Drawing.Point(103, 29);
            this.LevelOfTestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LevelOfTestLabel.Name = "LevelOfTestLabel";
            this.LevelOfTestLabel.Size = new System.Drawing.Size(149, 39);
            this.LevelOfTestLabel.TabIndex = 2;
            this.LevelOfTestLabel.Text = "Хорошо";
            // 
            // NumberOfRightAnwerLabel
            // 
            this.NumberOfRightAnwerLabel.AutoSize = true;
            this.NumberOfRightAnwerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfRightAnwerLabel.Location = new System.Drawing.Point(29, 130);
            this.NumberOfRightAnwerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberOfRightAnwerLabel.Name = "NumberOfRightAnwerLabel";
            this.NumberOfRightAnwerLabel.Size = new System.Drawing.Size(192, 20);
            this.NumberOfRightAnwerLabel.TabIndex = 3;
            this.NumberOfRightAnwerLabel.Text = "Правильных ответов:";
            // 
            // RightAnswer
            // 
            this.RightAnswer.AutoSize = true;
            this.RightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAnswer.Location = new System.Drawing.Point(267, 130);
            this.RightAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(26, 29);
            this.RightAnswer.TabIndex = 4;
            this.RightAnswer.Text = "0";
            // 
            // AllAnswer
            // 
            this.AllAnswer.AutoSize = true;
            this.AllAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAnswer.Location = new System.Drawing.Point(267, 98);
            this.AllAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllAnswer.Name = "AllAnswer";
            this.AllAnswer.Size = new System.Drawing.Size(26, 29);
            this.AllAnswer.TabIndex = 6;
            this.AllAnswer.Text = "0";
            // 
            // AllAnswerInTestLabel
            // 
            this.AllAnswerInTestLabel.AutoSize = true;
            this.AllAnswerInTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAnswerInTestLabel.Location = new System.Drawing.Point(29, 94);
            this.AllAnswerInTestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllAnswerInTestLabel.Name = "AllAnswerInTestLabel";
            this.AllAnswerInTestLabel.Size = new System.Drawing.Size(138, 20);
            this.AllAnswerInTestLabel.TabIndex = 5;
            this.AllAnswerInTestLabel.Text = "Всего ответов:";
            // 
            // ResultMark
            // 
            this.ResultMark.AutoSize = true;
            this.ResultMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultMark.Location = new System.Drawing.Point(267, 160);
            this.ResultMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultMark.Name = "ResultMark";
            this.ResultMark.Size = new System.Drawing.Size(26, 29);
            this.ResultMark.TabIndex = 8;
            this.ResultMark.Text = "0";
            // 
            // MarkOfTestLabel
            // 
            this.MarkOfTestLabel.AutoSize = true;
            this.MarkOfTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkOfTestLabel.Location = new System.Drawing.Point(29, 167);
            this.MarkOfTestLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarkOfTestLabel.Name = "MarkOfTestLabel";
            this.MarkOfTestLabel.Size = new System.Drawing.Size(76, 20);
            this.MarkOfTestLabel.TabIndex = 7;
            this.MarkOfTestLabel.Text = "Оценка:";
            // 
            // ResultFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 290);
            this.ControlBox = false;
            this.Controls.Add(this.ResultMark);
            this.Controls.Add(this.MarkOfTestLabel);
            this.Controls.Add(this.AllAnswer);
            this.Controls.Add(this.AllAnswerInTestLabel);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.NumberOfRightAnwerLabel);
            this.Controls.Add(this.LevelOfTestLabel);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.ContinueButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(394, 337);
            this.MinimumSize = new System.Drawing.Size(394, 337);
            this.Name = "ResultFormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reзультаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Label LevelOfTestLabel;
        private System.Windows.Forms.Label NumberOfRightAnwerLabel;
        private System.Windows.Forms.Label RightAnswer;
        private System.Windows.Forms.Label AllAnswer;
        private System.Windows.Forms.Label AllAnswerInTestLabel;
        private System.Windows.Forms.Label ResultMark;
        private System.Windows.Forms.Label MarkOfTestLabel;
    }
}