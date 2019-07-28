namespace OurProject._0
{
    partial class Typing_ResultStoryForm
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
            this.CloseButtom = new System.Windows.Forms.Button();
            this.ResultStoryBox = new System.Windows.Forms.ListBox();
            this.ClearAllResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Languages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButtom
            // 
            this.CloseButtom.Location = new System.Drawing.Point(21, 253);
            this.CloseButtom.Name = "CloseButtom";
            this.CloseButtom.Size = new System.Drawing.Size(75, 23);
            this.CloseButtom.TabIndex = 0;
            this.CloseButtom.Text = "Закрыть";
            this.CloseButtom.UseVisualStyleBackColor = true;
            this.CloseButtom.Click += new System.EventHandler(this.CloseButtom_Click);
            // 
            // ResultStoryBox
            // 
            this.ResultStoryBox.FormattingEnabled = true;
            this.ResultStoryBox.Items.AddRange(new object[] {
            "4 декабря 2017 г.\t\t3\t\t80",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.ResultStoryBox.Location = new System.Drawing.Point(12, 38);
            this.ResultStoryBox.Name = "ResultStoryBox";
            this.ResultStoryBox.Size = new System.Drawing.Size(301, 199);
            this.ResultStoryBox.TabIndex = 2;
            // 
            // ClearAllResult
            // 
            this.ClearAllResult.Location = new System.Drawing.Point(117, 253);
            this.ClearAllResult.Name = "ClearAllResult";
            this.ClearAllResult.Size = new System.Drawing.Size(75, 23);
            this.ClearAllResult.TabIndex = 3;
            this.ClearAllResult.Text = "Очистить";
            this.ClearAllResult.UseVisualStyleBackColor = true;
            this.ClearAllResult.Click += new System.EventHandler(this.ClearAllResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время набора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость";
            // 
            // Languages
            // 
            this.Languages.Location = new System.Drawing.Point(213, 253);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(75, 23);
            this.Languages.TabIndex = 7;
            this.Languages.Text = "Английский";
            this.Languages.UseVisualStyleBackColor = true;
            this.Languages.Click += new System.EventHandler(this.Languages_Click);
            // 
            // ResultStoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 295);
            this.ControlBox = false;
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAllResult);
            this.Controls.Add(this.ResultStoryBox);
            this.Controls.Add(this.CloseButtom);
            this.Name = "ResultStoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultStoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButtom;
        private System.Windows.Forms.ListBox ResultStoryBox;
        private System.Windows.Forms.Button ClearAllResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Languages;
    }
}