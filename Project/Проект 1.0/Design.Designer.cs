namespace OurProject._0
{
    partial class DesignForm
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
            this.SaveDesignButton = new System.Windows.Forms.Button();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.ButtonCollorLabel = new System.Windows.Forms.Label();
            this.BackColorComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonCollorComboBox = new System.Windows.Forms.ComboBox();
            this.TextOfButtonColorComboBox = new System.Windows.Forms.ComboBox();
            this.LabelColorComboBox = new System.Windows.Forms.ComboBox();
            this.TextOfButtonColorLabel = new System.Windows.Forms.Label();
            this.LabelColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveDesignButton
            // 
            this.SaveDesignButton.Location = new System.Drawing.Point(260, 257);
            this.SaveDesignButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveDesignButton.Name = "SaveDesignButton";
            this.SaveDesignButton.Size = new System.Drawing.Size(138, 39);
            this.SaveDesignButton.TabIndex = 0;
            this.SaveDesignButton.Text = "Сохранить";
            this.SaveDesignButton.UseVisualStyleBackColor = true;
            this.SaveDesignButton.Click += new System.EventHandler(this.SaveDesignButton_Click);
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackgroundColorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(47, 30);
            this.BackgroundColorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(114, 24);
            this.BackgroundColorLabel.TabIndex = 1;
            this.BackgroundColorLabel.Text = "Цвет фона";
            // 
            // ButtonCollorLabel
            // 
            this.ButtonCollorLabel.AutoSize = true;
            this.ButtonCollorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCollorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonCollorLabel.Location = new System.Drawing.Point(47, 87);
            this.ButtonCollorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ButtonCollorLabel.Name = "ButtonCollorLabel";
            this.ButtonCollorLabel.Size = new System.Drawing.Size(132, 24);
            this.ButtonCollorLabel.TabIndex = 2;
            this.ButtonCollorLabel.Text = "Цвет кнопок";
            // 
            // BackColorComboBox
            // 
            this.BackColorComboBox.FormattingEnabled = true;
            this.BackColorComboBox.Items.AddRange(new object[] {
            "Серый",
            "Черный",
            "Белый",
            "Красный",
            "Коралловый",
            "Розовый",
            "Оранжевый",
            "Желтый",
            "Золотой",
            "Зеленый",
            "Салатовый",
            "Бирюзовый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.BackColorComboBox.Location = new System.Drawing.Point(362, 24);
            this.BackColorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.BackColorComboBox.Name = "BackColorComboBox";
            this.BackColorComboBox.Size = new System.Drawing.Size(218, 30);
            this.BackColorComboBox.TabIndex = 3;
            this.BackColorComboBox.SelectedIndexChanged += new System.EventHandler(this.BackColorComboBox_SelectedIndexChanged);
            // 
            // ButtonCollorComboBox
            // 
            this.ButtonCollorComboBox.FormattingEnabled = true;
            this.ButtonCollorComboBox.Items.AddRange(new object[] {
            "Серый",
            "Черный",
            "Белый",
            "Красный",
            "Коралловый",
            "Розовый",
            "Оранжевый",
            "Желтый",
            "Золотой",
            "Зеленый",
            "Салатовый",
            "Бирюзовый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.ButtonCollorComboBox.Location = new System.Drawing.Point(362, 81);
            this.ButtonCollorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonCollorComboBox.Name = "ButtonCollorComboBox";
            this.ButtonCollorComboBox.Size = new System.Drawing.Size(218, 30);
            this.ButtonCollorComboBox.TabIndex = 4;
            this.ButtonCollorComboBox.SelectedIndexChanged += new System.EventHandler(this.ButtonCollorComboBox_SelectedIndexChanged);
            // 
            // TextOfButtonColorComboBox
            // 
            this.TextOfButtonColorComboBox.FormattingEnabled = true;
            this.TextOfButtonColorComboBox.Items.AddRange(new object[] {
            "Серый",
            "Черный",
            "Белый",
            "Красный",
            "Коралловый",
            "Розовый",
            "Оранжевый",
            "Желтый",
            "Золотой",
            "Зеленый",
            "Салатовый",
            "Бирюзовый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.TextOfButtonColorComboBox.Location = new System.Drawing.Point(362, 137);
            this.TextOfButtonColorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.TextOfButtonColorComboBox.Name = "TextOfButtonColorComboBox";
            this.TextOfButtonColorComboBox.Size = new System.Drawing.Size(218, 30);
            this.TextOfButtonColorComboBox.TabIndex = 5;
            this.TextOfButtonColorComboBox.SelectedIndexChanged += new System.EventHandler(this.TextOfButtonColorComboBox_SelectedIndexChanged);
            // 
            // LabelColorComboBox
            // 
            this.LabelColorComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelColorComboBox.FormattingEnabled = true;
            this.LabelColorComboBox.Items.AddRange(new object[] {
            "Серый",
            "Черный",
            "Белый",
            "Красный",
            "Коралловый",
            "Розовый",
            "Оранжевый",
            "Желтый",
            "Золотой",
            "Зеленый",
            "Салатовый",
            "Бирюзовый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.LabelColorComboBox.Location = new System.Drawing.Point(362, 193);
            this.LabelColorComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.LabelColorComboBox.Name = "LabelColorComboBox";
            this.LabelColorComboBox.Size = new System.Drawing.Size(218, 30);
            this.LabelColorComboBox.TabIndex = 6;
            this.LabelColorComboBox.SelectedIndexChanged += new System.EventHandler(this.LabelColorComboBox_SelectedIndexChanged);
            // 
            // TextOfButtonColorLabel
            // 
            this.TextOfButtonColorLabel.AutoSize = true;
            this.TextOfButtonColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOfButtonColorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextOfButtonColorLabel.Location = new System.Drawing.Point(47, 143);
            this.TextOfButtonColorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextOfButtonColorLabel.Name = "TextOfButtonColorLabel";
            this.TextOfButtonColorLabel.Size = new System.Drawing.Size(272, 24);
            this.TextOfButtonColorLabel.TabIndex = 7;
            this.TextOfButtonColorLabel.Text = "Цвет надписей на кнопках";
            // 
            // LabelColorLabel
            // 
            this.LabelColorLabel.AutoSize = true;
            this.LabelColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelColorLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LabelColorLabel.Location = new System.Drawing.Point(47, 196);
            this.LabelColorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelColorLabel.Name = "LabelColorLabel";
            this.LabelColorLabel.Size = new System.Drawing.Size(270, 24);
            this.LabelColorLabel.TabIndex = 8;
            this.LabelColorLabel.Text = "Цвет остальных надписей";
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 321);
            this.Controls.Add(this.LabelColorLabel);
            this.Controls.Add(this.TextOfButtonColorLabel);
            this.Controls.Add(this.LabelColorComboBox);
            this.Controls.Add(this.TextOfButtonColorComboBox);
            this.Controls.Add(this.ButtonCollorComboBox);
            this.Controls.Add(this.BackColorComboBox);
            this.Controls.Add(this.ButtonCollorLabel);
            this.Controls.Add(this.BackgroundColorLabel);
            this.Controls.Add(this.SaveDesignButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DesignForm";
            this.Text = "Дизайн интерфейса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveDesignButton;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.Label ButtonCollorLabel;
        private System.Windows.Forms.ComboBox BackColorComboBox;
        private System.Windows.Forms.ComboBox ButtonCollorComboBox;
        private System.Windows.Forms.ComboBox TextOfButtonColorComboBox;
        private System.Windows.Forms.ComboBox LabelColorComboBox;
        private System.Windows.Forms.Label TextOfButtonColorLabel;
        private System.Windows.Forms.Label LabelColorLabel;
    }
}