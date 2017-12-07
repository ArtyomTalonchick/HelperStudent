namespace Проект_1._0
{
    partial class ResultForm
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
            this.TextTime = new System.Windows.Forms.Label();
            this.TextSpeed = new System.Windows.Forms.Label();
            this.TextKPD = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.KPD = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.Сontinue = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextTime
            // 
            this.TextTime.AutoSize = true;
            this.TextTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextTime.Location = new System.Drawing.Point(50, 76);
            this.TextTime.Name = "TextTime";
            this.TextTime.Size = new System.Drawing.Size(52, 16);
            this.TextTime.TabIndex = 0;
            this.TextTime.Text = "Время:";
            // 
            // TextSpeed
            // 
            this.TextSpeed.AutoSize = true;
            this.TextSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSpeed.Location = new System.Drawing.Point(50, 106);
            this.TextSpeed.Name = "TextSpeed";
            this.TextSpeed.Size = new System.Drawing.Size(72, 16);
            this.TextSpeed.TabIndex = 1;
            this.TextSpeed.Text = "Скорость:";
            // 
            // TextKPD
            // 
            this.TextKPD.AutoSize = true;
            this.TextKPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextKPD.Location = new System.Drawing.Point(50, 136);
            this.TextKPD.Name = "TextKPD";
            this.TextKPD.Size = new System.Drawing.Size(38, 16);
            this.TextKPD.TabIndex = 2;
            this.TextKPD.Text = "КПД:";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speed.Location = new System.Drawing.Point(153, 106);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(66, 24);
            this.Speed.TabIndex = 17;
            this.Speed.Text = "Speed";
            // 
            // KPD
            // 
            this.KPD.AutoSize = true;
            this.KPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KPD.Location = new System.Drawing.Point(153, 136);
            this.KPD.Name = "KPD";
            this.KPD.Size = new System.Drawing.Size(47, 24);
            this.KPD.TabIndex = 18;
            this.KPD.Text = "KPD";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark.ForeColor = System.Drawing.Color.Coral;
            this.Mark.Location = new System.Drawing.Point(57, 28);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(183, 31);
            this.Mark.TabIndex = 19;
            this.Mark.Text = "Ты монстр!!!";
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Location = new System.Drawing.Point(161, 187);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(92, 23);
            this.Menu.TabIndex = 21;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // Сontinue
            // 
            this.Сontinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сontinue.Location = new System.Drawing.Point(30, 187);
            this.Сontinue.Name = "Сontinue";
            this.Сontinue.Size = new System.Drawing.Size(92, 23);
            this.Сontinue.TabIndex = 22;
            this.Сontinue.Text = "Продолжить";
            this.Сontinue.UseVisualStyleBackColor = true;
            this.Сontinue.Click += new System.EventHandler(this.Сontinue_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(153, 76);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(55, 24);
            this.TimeLabel.TabIndex = 23;
            this.TimeLabel.Text = "00:00";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.ControlBox = false;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Сontinue);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.KPD);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.TextKPD);
            this.Controls.Add(this.TextSpeed);
            this.Controls.Add(this.TextTime);
            this.MaximumSize = new System.Drawing.Size(300, 283);
            this.MinimumSize = new System.Drawing.Size(300, 283);
            this.Name = "ResultForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resuльтат";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextTime;
        private System.Windows.Forms.Label TextSpeed;
        private System.Windows.Forms.Label TextKPD;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label KPD;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Сontinue;
        private System.Windows.Forms.Label TimeLabel;
    }
}