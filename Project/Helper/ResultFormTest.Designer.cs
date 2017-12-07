namespace Проект_1._0
{
    partial class ResultFormTest
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
            this.Continue = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.Label();
            this.RightAnwerText = new System.Windows.Forms.Label();
            this.RightAnswer = new System.Windows.Forms.Label();
            this.AllAnswer = new System.Windows.Forms.Label();
            this.AllAnswerText = new System.Windows.Forms.Label();
            this.ResultMark = new System.Windows.Forms.Label();
            this.MarkText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Continue.Location = new System.Drawing.Point(30, 187);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(90, 23);
            this.Continue.TabIndex = 0;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Location = new System.Drawing.Point(161, 187);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(90, 23);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark.ForeColor = System.Drawing.Color.Coral;
            this.Mark.Location = new System.Drawing.Point(88, 28);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(103, 31);
            this.Mark.TabIndex = 2;
            this.Mark.Text = "Норма";
            // 
            // RightAnwerText
            // 
            this.RightAnwerText.AutoSize = true;
            this.RightAnwerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAnwerText.Location = new System.Drawing.Point(22, 106);
            this.RightAnwerText.Name = "RightAnwerText";
            this.RightAnwerText.Size = new System.Drawing.Size(148, 16);
            this.RightAnwerText.TabIndex = 3;
            this.RightAnwerText.Text = "Правильных ответов:";
            // 
            // RightAnswer
            // 
            this.RightAnswer.AutoSize = true;
            this.RightAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAnswer.Location = new System.Drawing.Point(200, 106);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(20, 24);
            this.RightAnswer.TabIndex = 4;
            this.RightAnswer.Text = "0";
            // 
            // AllAnswer
            // 
            this.AllAnswer.AutoSize = true;
            this.AllAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAnswer.Location = new System.Drawing.Point(200, 80);
            this.AllAnswer.Name = "AllAnswer";
            this.AllAnswer.Size = new System.Drawing.Size(20, 24);
            this.AllAnswer.TabIndex = 6;
            this.AllAnswer.Text = "0";
            // 
            // AllAnswerText
            // 
            this.AllAnswerText.AutoSize = true;
            this.AllAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllAnswerText.Location = new System.Drawing.Point(22, 76);
            this.AllAnswerText.Name = "AllAnswerText";
            this.AllAnswerText.Size = new System.Drawing.Size(106, 16);
            this.AllAnswerText.TabIndex = 5;
            this.AllAnswerText.Text = "Всего ответов:";
            // 
            // ResultMark
            // 
            this.ResultMark.AutoSize = true;
            this.ResultMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultMark.Location = new System.Drawing.Point(200, 136);
            this.ResultMark.Name = "ResultMark";
            this.ResultMark.Size = new System.Drawing.Size(20, 24);
            this.ResultMark.TabIndex = 8;
            this.ResultMark.Text = "0";
            // 
            // MarkText
            // 
            this.MarkText.AutoSize = true;
            this.MarkText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarkText.Location = new System.Drawing.Point(22, 136);
            this.MarkText.Name = "MarkText";
            this.MarkText.Size = new System.Drawing.Size(60, 16);
            this.MarkText.TabIndex = 7;
            this.MarkText.Text = "Оценка:";
            // 
            // ResultFormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.ControlBox = false;
            this.Controls.Add(this.ResultMark);
            this.Controls.Add(this.MarkText);
            this.Controls.Add(this.AllAnswer);
            this.Controls.Add(this.AllAnswerText);
            this.Controls.Add(this.RightAnswer);
            this.Controls.Add(this.RightAnwerText);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Continue);
            this.MaximumSize = new System.Drawing.Size(300, 283);
            this.MinimumSize = new System.Drawing.Size(300, 283);
            this.Name = "ResultFormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultFormTest";
            this.Load += new System.EventHandler(this.ResultFormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label RightAnwerText;
        private System.Windows.Forms.Label RightAnswer;
        private System.Windows.Forms.Label AllAnswer;
        private System.Windows.Forms.Label AllAnswerText;
        private System.Windows.Forms.Label ResultMark;
        private System.Windows.Forms.Label MarkText;
    }
}