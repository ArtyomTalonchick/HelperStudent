namespace Проект_1._0
{
    partial class Helper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Сycle = new System.Windows.Forms.Timer(this.components);
            this.Тренажёр = new System.Windows.Forms.TabPage();
            this.KeyboardButton = new System.Windows.Forms.Button();
            this.TrainingSelect = new System.Windows.Forms.MenuStrip();
            this.English = new System.Windows.Forms.ToolStripMenuItem();
            this.English1 = new System.Windows.Forms.ToolStripMenuItem();
            this.English2 = new System.Windows.Forms.ToolStripMenuItem();
            this.English3 = new System.Windows.Forms.ToolStripMenuItem();
            this.English4 = new System.Windows.Forms.ToolStripMenuItem();
            this.English5 = new System.Windows.Forms.ToolStripMenuItem();
            this.English6 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG2 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG3 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG4 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG5 = new System.Windows.Forms.ToolStripMenuItem();
            this.IKG6 = new System.Windows.Forms.ToolStripMenuItem();
            this.History = new System.Windows.Forms.ToolStripMenuItem();
            this.History1 = new System.Windows.Forms.ToolStripMenuItem();
            this.History2 = new System.Windows.Forms.ToolStripMenuItem();
            this.History3 = new System.Windows.Forms.ToolStripMenuItem();
            this.History4 = new System.Windows.Forms.ToolStripMenuItem();
            this.History5 = new System.Windows.Forms.ToolStripMenuItem();
            this.History6 = new System.Windows.Forms.ToolStripMenuItem();
            this.History7 = new System.Windows.Forms.ToolStripMenuItem();
            this.History8 = new System.Windows.Forms.ToolStripMenuItem();
            this.History9 = new System.Windows.Forms.ToolStripMenuItem();
            this.History10 = new System.Windows.Forms.ToolStripMenuItem();
            this.мГиАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.оАиПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.политологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.философияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.NewText = new System.Windows.Forms.TextBox();
            this.OldText = new System.Windows.Forms.TextBox();
            this.WriteBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FinishButton = new System.Windows.Forms.Button();
            this.QuestionText = new System.Windows.Forms.Label();
            this.RightAnswerText = new System.Windows.Forms.Label();
            this.IncorrectAnswer = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.TestSelect = new System.Windows.Forms.MenuStrip();
            this.QuestionEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish2 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish3 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish4 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish5 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionEnglish6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.Answer2 = new System.Windows.Forms.CheckBox();
            this.Answer3 = new System.Windows.Forms.CheckBox();
            this.Answer4 = new System.Windows.Forms.CheckBox();
            this.Answer1 = new System.Windows.Forms.CheckBox();
            this.Cycle1Sek = new System.Windows.Forms.Timer(this.components);
            this.CycleTest = new System.Windows.Forms.Timer(this.components);
            this.Тренажёр.SuspendLayout();
            this.TrainingSelect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.TestSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Сycle
            // 
            this.Сycle.Enabled = true;
            this.Сycle.Interval = 1;
            this.Сycle.Tick += new System.EventHandler(this.Сycle_Tick);
            // 
            // Тренажёр
            // 
            this.Тренажёр.Controls.Add(this.KeyboardButton);
            this.Тренажёр.Controls.Add(this.TrainingSelect);
            this.Тренажёр.Controls.Add(this.Stop);
            this.Тренажёр.Controls.Add(this.TimeLabel);
            this.Тренажёр.Controls.Add(this.NewText);
            this.Тренажёр.Controls.Add(this.OldText);
            this.Тренажёр.Controls.Add(this.WriteBox);
            this.Тренажёр.Location = new System.Drawing.Point(4, 22);
            this.Тренажёр.Name = "Тренажёр";
            this.Тренажёр.Padding = new System.Windows.Forms.Padding(3);
            this.Тренажёр.Size = new System.Drawing.Size(1280, 325);
            this.Тренажёр.TabIndex = 0;
            this.Тренажёр.Text = "Тренажёр";
            this.Тренажёр.UseVisualStyleBackColor = true;
            // 
            // KeyboardButton
            // 
            this.KeyboardButton.Location = new System.Drawing.Point(1169, 293);
            this.KeyboardButton.Name = "KeyboardButton";
            this.KeyboardButton.Size = new System.Drawing.Size(94, 23);
            this.KeyboardButton.TabIndex = 37;
            this.KeyboardButton.Text = "Клавиатура";
            this.KeyboardButton.UseVisualStyleBackColor = true;
            this.KeyboardButton.Click += new System.EventHandler(this.KeyboardButton_Click);
            // 
            // TrainingSelect
            // 
            this.TrainingSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English,
            this.IKG,
            this.History,
            this.мГиАToolStripMenuItem,
            this.SelectSubject,
            this.оАиПToolStripMenuItem,
            this.политологияToolStripMenuItem,
            this.философияToolStripMenuItem});
            this.TrainingSelect.Location = new System.Drawing.Point(3, 3);
            this.TrainingSelect.Name = "TrainingSelect";
            this.TrainingSelect.Size = new System.Drawing.Size(1274, 24);
            this.TrainingSelect.TabIndex = 34;
            this.TrainingSelect.Text = "menuStrip1";
            // 
            // English
            // 
            this.English.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English1,
            this.English2,
            this.English3,
            this.English4,
            this.English5,
            this.English6});
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(86, 20);
            this.English.Text = "Английский";
            // 
            // English1
            // 
            this.English1.Name = "English1";
            this.English1.Size = new System.Drawing.Size(198, 22);
            this.English1.Text = "Student\'s profile";
            this.English1.Click += new System.EventHandler(this.English1_Click);
            // 
            // English2
            // 
            this.English2.Name = "English2";
            this.English2.Size = new System.Drawing.Size(198, 22);
            this.English2.Text = "The BSUIR";
            this.English2.Click += new System.EventHandler(this.English2_Click);
            // 
            // English3
            // 
            this.English3.Name = "English3";
            this.English3.Size = new System.Drawing.Size(198, 22);
            this.English3.Text = "The Republic of Belarus";
            this.English3.Click += new System.EventHandler(this.English3_Click);
            // 
            // English4
            // 
            this.English4.Name = "English4";
            this.English4.Size = new System.Drawing.Size(198, 22);
            this.English4.Text = "Great Britain";
            this.English4.Click += new System.EventHandler(this.English4_Click);
            // 
            // English5
            // 
            this.English5.Name = "English5";
            this.English5.Size = new System.Drawing.Size(198, 22);
            this.English5.Text = "Environmental issues";
            this.English5.Click += new System.EventHandler(this.English5_Click);
            // 
            // English6
            // 
            this.English6.Name = "English6";
            this.English6.Size = new System.Drawing.Size(198, 22);
            this.English6.Text = "My future profession";
            this.English6.Click += new System.EventHandler(this.English6_Click);
            // 
            // IKG
            // 
            this.IKG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IKG1,
            this.IKG2,
            this.IKG3,
            this.IKG4,
            this.IKG5,
            this.IKG6});
            this.IKG.Name = "IKG";
            this.IKG.Size = new System.Drawing.Size(41, 20);
            this.IKG.Text = "ИКГ";
            // 
            // IKG1
            // 
            this.IKG1.Name = "IKG1";
            this.IKG1.Size = new System.Drawing.Size(330, 22);
            this.IKG1.Text = "Способы проецирования";
            this.IKG1.Click += new System.EventHandler(this.IKG1_Click);
            // 
            // IKG2
            // 
            this.IKG2.Name = "IKG2";
            this.IKG2.Size = new System.Drawing.Size(330, 22);
            this.IKG2.Text = "Комплексный чертеж точки";
            this.IKG2.Click += new System.EventHandler(this.IKG2_Click);
            // 
            // IKG3
            // 
            this.IKG3.Name = "IKG3";
            this.IKG3.Size = new System.Drawing.Size(330, 22);
            this.IKG3.Text = "Прямые и плоскости частного положения";
            this.IKG3.Click += new System.EventHandler(this.IKG3_Click);
            // 
            // IKG4
            // 
            this.IKG4.Name = "IKG4";
            this.IKG4.Size = new System.Drawing.Size(330, 22);
            this.IKG4.Text = "Основные позиционные задачи";
            this.IKG4.Click += new System.EventHandler(this.IKG4_Click);
            // 
            // IKG5
            // 
            this.IKG5.Name = "IKG5";
            this.IKG5.Size = new System.Drawing.Size(330, 22);
            this.IKG5.Text = "Взаимное расположения прямой и плоскости";
            this.IKG5.Click += new System.EventHandler(this.IKG5_Click);
            // 
            // IKG6
            // 
            this.IKG6.Name = "IKG6";
            this.IKG6.Size = new System.Drawing.Size(330, 22);
            this.IKG6.Text = "Взаимное расположение двух плоскостей";
            this.IKG6.Click += new System.EventHandler(this.IKG6_Click);
            // 
            // History
            // 
            this.History.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.History1,
            this.History2,
            this.History3,
            this.History4,
            this.History5,
            this.History6,
            this.History7,
            this.History8,
            this.History9,
            this.History10});
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(66, 20);
            this.History.Text = "История";
            // 
            // History1
            // 
            this.History1.Name = "History1";
            this.History1.Size = new System.Drawing.Size(324, 22);
            this.History1.Text = "Первобытные люди на территории Беларуси";
            this.History1.Click += new System.EventHandler(this.History1_Click);
            // 
            // History2
            // 
            this.History2.Name = "History2";
            this.History2.Size = new System.Drawing.Size(324, 22);
            this.History2.Text = "2";
            // 
            // History3
            // 
            this.History3.Name = "History3";
            this.History3.Size = new System.Drawing.Size(324, 22);
            this.History3.Text = "3";
            // 
            // History4
            // 
            this.History4.Name = "History4";
            this.History4.Size = new System.Drawing.Size(324, 22);
            this.History4.Text = "4";
            // 
            // History5
            // 
            this.History5.Name = "History5";
            this.History5.Size = new System.Drawing.Size(324, 22);
            this.History5.Text = "5";
            // 
            // History6
            // 
            this.History6.Name = "History6";
            this.History6.Size = new System.Drawing.Size(324, 22);
            this.History6.Text = "6";
            // 
            // History7
            // 
            this.History7.Name = "History7";
            this.History7.Size = new System.Drawing.Size(324, 22);
            this.History7.Text = "7";
            // 
            // History8
            // 
            this.History8.Name = "History8";
            this.History8.Size = new System.Drawing.Size(324, 22);
            this.History8.Text = "8";
            // 
            // History9
            // 
            this.History9.Name = "History9";
            this.History9.Size = new System.Drawing.Size(324, 22);
            this.History9.Text = "9";
            // 
            // History10
            // 
            this.History10.Name = "History10";
            this.History10.Size = new System.Drawing.Size(324, 22);
            this.History10.Text = "10";
            // 
            // мГиАToolStripMenuItem
            // 
            this.мГиАToolStripMenuItem.Name = "мГиАToolStripMenuItem";
            this.мГиАToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.мГиАToolStripMenuItem.Text = "МГиА";
            // 
            // SelectSubject
            // 
            this.SelectSubject.Name = "SelectSubject";
            this.SelectSubject.Size = new System.Drawing.Size(49, 20);
            this.SelectSubject.Text = "ММА";
            this.SelectSubject.Click += new System.EventHandler(this.SelectSubject_Click);
            // 
            // оАиПToolStripMenuItem
            // 
            this.оАиПToolStripMenuItem.Name = "оАиПToolStripMenuItem";
            this.оАиПToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.оАиПToolStripMenuItem.Text = "ОАиП";
            // 
            // политологияToolStripMenuItem
            // 
            this.политологияToolStripMenuItem.Name = "политологияToolStripMenuItem";
            this.политологияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.политологияToolStripMenuItem.Text = "Политология";
            // 
            // философияToolStripMenuItem
            // 
            this.философияToolStripMenuItem.Name = "философияToolStripMenuItem";
            this.философияToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.философияToolStripMenuItem.Text = "Философия";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(592, 237);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 36;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(587, 100);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(71, 25);
            this.TimeLabel.TabIndex = 35;
            this.TimeLabel.Text = "00:00";
            // 
            // NewText
            // 
            this.NewText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewText.Enabled = false;
            this.NewText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewText.ForeColor = System.Drawing.Color.Black;
            this.NewText.Location = new System.Drawing.Point(620, 161);
            this.NewText.Name = "NewText";
            this.NewText.ReadOnly = true;
            this.NewText.Size = new System.Drawing.Size(544, 42);
            this.NewText.TabIndex = 32;
            this.NewText.Text = "печатать?";
            // 
            // OldText
            // 
            this.OldText.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OldText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldText.CausesValidation = false;
            this.OldText.Enabled = false;
            this.OldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldText.Location = new System.Drawing.Point(76, 161);
            this.OldText.Name = "OldText";
            this.OldText.ReadOnly = true;
            this.OldText.Size = new System.Drawing.Size(544, 42);
            this.OldText.TabIndex = 31;
            this.OldText.Text = "Начинаем ";
            this.OldText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WriteBox
            // 
            this.WriteBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WriteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteBox.Location = new System.Drawing.Point(632, 174);
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(100, 29);
            this.WriteBox.TabIndex = 33;
            this.WriteBox.TextChanged += new System.EventHandler(this.WriteBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Тренажёр);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 351);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Меню";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.FinishButton);
            this.tabPage3.Controls.Add(this.QuestionText);
            this.tabPage3.Controls.Add(this.RightAnswerText);
            this.tabPage3.Controls.Add(this.IncorrectAnswer);
            this.tabPage3.Controls.Add(this.Mark);
            this.tabPage3.Controls.Add(this.AnswerButton);
            this.tabPage3.Controls.Add(this.TestSelect);
            this.tabPage3.Controls.Add(this.Answer2);
            this.tabPage3.Controls.Add(this.Answer3);
            this.tabPage3.Controls.Add(this.Answer4);
            this.tabPage3.Controls.Add(this.Answer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1280, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Тестики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FinishButton
            // 
            this.FinishButton.Enabled = false;
            this.FinishButton.Location = new System.Drawing.Point(680, 248);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(88, 23);
            this.FinishButton.TabIndex = 46;
            this.FinishButton.Text = "Завершить";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSize = true;
            this.QuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionText.Location = new System.Drawing.Point(148, 60);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(100, 24);
            this.QuestionText.TabIndex = 45;
            this.QuestionText.Text = " Question";
            // 
            // RightAnswerText
            // 
            this.RightAnswerText.AutoSize = true;
            this.RightAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAnswerText.ForeColor = System.Drawing.Color.Lime;
            this.RightAnswerText.Location = new System.Drawing.Point(828, 79);
            this.RightAnswerText.Name = "RightAnswerText";
            this.RightAnswerText.Size = new System.Drawing.Size(141, 153);
            this.RightAnswerText.TabIndex = 44;
            this.RightAnswerText.Text = "0";
            // 
            // IncorrectAnswer
            // 
            this.IncorrectAnswer.AutoSize = true;
            this.IncorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncorrectAnswer.ForeColor = System.Drawing.Color.Red;
            this.IncorrectAnswer.Location = new System.Drawing.Point(975, 79);
            this.IncorrectAnswer.Name = "IncorrectAnswer";
            this.IncorrectAnswer.Size = new System.Drawing.Size(141, 153);
            this.IncorrectAnswer.TabIndex = 43;
            this.IncorrectAnswer.Text = "0";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mark.Location = new System.Drawing.Point(482, 136);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(0, 39);
            this.Mark.TabIndex = 42;
            // 
            // AnswerButton
            // 
            this.AnswerButton.Location = new System.Drawing.Point(554, 248);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(75, 23);
            this.AnswerButton.TabIndex = 40;
            this.AnswerButton.Text = "Ок";
            this.AnswerButton.UseVisualStyleBackColor = true;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // TestSelect
            // 
            this.TestSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionEnglish,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.TestSelect.Location = new System.Drawing.Point(3, 3);
            this.TestSelect.Name = "TestSelect";
            this.TestSelect.Size = new System.Drawing.Size(1274, 24);
            this.TestSelect.TabIndex = 35;
            this.TestSelect.Text = "menuStrip1";
            // 
            // QuestionEnglish
            // 
            this.QuestionEnglish.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuestionEnglish1,
            this.QuestionEnglish2,
            this.QuestionEnglish3,
            this.QuestionEnglish4,
            this.QuestionEnglish5,
            this.QuestionEnglish6});
            this.QuestionEnglish.Name = "QuestionEnglish";
            this.QuestionEnglish.Size = new System.Drawing.Size(86, 20);
            this.QuestionEnglish.Text = "Английский";
            // 
            // QuestionEnglish1
            // 
            this.QuestionEnglish1.Name = "QuestionEnglish1";
            this.QuestionEnglish1.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish1.Text = "Student\'s profile";
            this.QuestionEnglish1.Click += new System.EventHandler(this.QuestionEnglish1_Click);
            // 
            // QuestionEnglish2
            // 
            this.QuestionEnglish2.Name = "QuestionEnglish2";
            this.QuestionEnglish2.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish2.Text = "The BSUIR";
            // 
            // QuestionEnglish3
            // 
            this.QuestionEnglish3.Name = "QuestionEnglish3";
            this.QuestionEnglish3.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish3.Text = "The Republic of Belarus";
            // 
            // QuestionEnglish4
            // 
            this.QuestionEnglish4.Name = "QuestionEnglish4";
            this.QuestionEnglish4.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish4.Text = "Great Britain";
            // 
            // QuestionEnglish5
            // 
            this.QuestionEnglish5.Name = "QuestionEnglish5";
            this.QuestionEnglish5.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish5.Text = "Environmental issues";
            // 
            // QuestionEnglish6
            // 
            this.QuestionEnglish6.Name = "QuestionEnglish6";
            this.QuestionEnglish6.Size = new System.Drawing.Size(198, 22);
            this.QuestionEnglish6.Text = "My future profession";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem9.Text = "ИКГ";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem10.Text = "История";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem11.Text = "МГиА";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem12.Text = "ММА";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem13.Text = "ОАиП";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem14.Text = "Политология";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem15.Text = "Философия";
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Enabled = false;
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2.Location = new System.Drawing.Point(152, 168);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(97, 24);
            this.Answer2.TabIndex = 39;
            this.Answer2.Text = "Answer2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.CheckedChanged += new System.EventHandler(this.Answer2_CheckedChanged);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Enabled = false;
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3.Location = new System.Drawing.Point(152, 208);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(97, 24);
            this.Answer3.TabIndex = 38;
            this.Answer3.Text = "Answer3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.CheckedChanged += new System.EventHandler(this.Answer3_CheckedChanged);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Enabled = false;
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer4.Location = new System.Drawing.Point(152, 248);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(97, 24);
            this.Answer4.TabIndex = 37;
            this.Answer4.Text = "Answer4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.CheckedChanged += new System.EventHandler(this.Answer4_CheckedChanged);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Enabled = false;
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1.Location = new System.Drawing.Point(152, 128);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(97, 24);
            this.Answer1.TabIndex = 36;
            this.Answer1.Text = "Answer1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.CheckedChanged += new System.EventHandler(this.Answer1_CheckedChanged);
            // 
            // Cycle1Sek
            // 
            this.Cycle1Sek.Enabled = true;
            this.Cycle1Sek.Interval = 1000;
            this.Cycle1Sek.Tick += new System.EventHandler(this.Cycle1Sek_Tick);
            // 
            // CycleTest
            // 
            this.CycleTest.Enabled = true;
            this.CycleTest.Interval = 1;
            this.CycleTest.Tick += new System.EventHandler(this.CycleTest_Tick);
            // 
            // Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 351);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(1290, 390);
            this.MinimumSize = new System.Drawing.Size(1290, 390);
            this.Name = "Helper";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helper первокурсника";
            this.Load += new System.EventHandler(this.Helper_Load);
            this.Тренажёр.ResumeLayout(false);
            this.Тренажёр.PerformLayout();
            this.TrainingSelect.ResumeLayout(false);
            this.TrainingSelect.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.TestSelect.ResumeLayout(false);
            this.TestSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer Сycle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabPage Тренажёр;
        private System.Windows.Forms.MenuStrip TrainingSelect;
        private System.Windows.Forms.ToolStripMenuItem English;
        private System.Windows.Forms.ToolStripMenuItem English1;
        private System.Windows.Forms.ToolStripMenuItem English2;
        private System.Windows.Forms.ToolStripMenuItem English3;
        private System.Windows.Forms.ToolStripMenuItem English4;
        private System.Windows.Forms.ToolStripMenuItem English5;
        private System.Windows.Forms.ToolStripMenuItem English6;
        private System.Windows.Forms.ToolStripMenuItem IKG;
        private System.Windows.Forms.ToolStripMenuItem History;
        private System.Windows.Forms.ToolStripMenuItem мГиАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectSubject;
        private System.Windows.Forms.ToolStripMenuItem оАиПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem политологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem философияToolStripMenuItem;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox NewText;
        private System.Windows.Forms.TextBox OldText;
        private System.Windows.Forms.TextBox WriteBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Timer Cycle1Sek;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox Answer2;
        private System.Windows.Forms.CheckBox Answer3;
        private System.Windows.Forms.CheckBox Answer4;
        private System.Windows.Forms.CheckBox Answer1;
        private System.Windows.Forms.MenuStrip TestSelect;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.Button AnswerButton;
        private System.Windows.Forms.Button KeyboardButton;
        private System.Windows.Forms.ToolStripMenuItem IKG1;
        private System.Windows.Forms.ToolStripMenuItem IKG2;
        private System.Windows.Forms.ToolStripMenuItem IKG3;
        private System.Windows.Forms.ToolStripMenuItem IKG4;
        private System.Windows.Forms.ToolStripMenuItem IKG5;
        private System.Windows.Forms.ToolStripMenuItem IKG6;
        private System.Windows.Forms.ToolStripMenuItem History1;
        private System.Windows.Forms.ToolStripMenuItem History2;
        private System.Windows.Forms.ToolStripMenuItem History3;
        private System.Windows.Forms.ToolStripMenuItem History4;
        private System.Windows.Forms.ToolStripMenuItem History5;
        private System.Windows.Forms.ToolStripMenuItem History6;
        private System.Windows.Forms.ToolStripMenuItem History7;
        private System.Windows.Forms.ToolStripMenuItem History8;
        private System.Windows.Forms.ToolStripMenuItem History9;
        private System.Windows.Forms.ToolStripMenuItem History10;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish2;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish3;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish4;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish5;
        private System.Windows.Forms.ToolStripMenuItem QuestionEnglish6;
        private System.Windows.Forms.Timer CycleTest;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label IncorrectAnswer;
        private System.Windows.Forms.Label RightAnswerText;
        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button FinishButton;
    }
}

