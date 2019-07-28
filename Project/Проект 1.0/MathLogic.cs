using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OurProject._0
{
    public partial class Helper
    {
        public const string mathLogicFileName = @"Libraries\MathLogicFunctions.dll";                
        public delegate IntPtr Del(int numberOfFunction, int numberOfArguments);

        // Метод, исполняющий нужное преобразования из матлогики
        public void MathLogicFunction(Del function) 
        {
            MathLogicResultTextBox.Clear();                                                             
            try
            {
                int numberOfFunction = Convert.ToInt32(InputFunctTextBox.Text);                         // Номер функции
                int numberOfArguments = Convert.ToInt32(NumberOfArgumentsTextBox.Text);                 // Количество аргументов
                var result = Marshal.PtrToStringAnsi(function(numberOfFunction, numberOfArguments));    // Преобразование
                MathLogicResultTextBox.Text = result;                                                   // Вывод результатов
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }


        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_TruthTable", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TruthTable(int numberOfFunction, int numberOfArguments);

        // Отображение таблицы истинности при нажатии на кнопку
        private void TruthTableButton_Click(object sender, EventArgs e)
        {
            MathLogicResultTextBox.Clear();
            try
            {
                int numberOfFunction = Convert.ToInt32(InputFunctTextBox.Text);                         // Номер функции
                int numberOfArguments = Convert.ToInt32(NumberOfArgumentsTextBox.Text);                 // Количество аргументов
                var result = Marshal.PtrToStringAnsi(TruthTable(numberOfFunction, numberOfArguments));  // Преобразование
                String[] substrings = result.Split('\n');                                               // Деление на строки
                foreach (String element in substrings)
                    MathLogicResultTextBox.AppendText(element + Environment.NewLine);                   // Отображение каждой строки
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_Zhegalkin", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Zhegalkin(int numberOfFunction, int numberOfArguments);

        // Отображение плинома Жегалкина при нажатии на кнопку
        private void ZhegalkinButton_Click(object sender, EventArgs e)
        {
            Del zhegalkin = new Del(Zhegalkin);
            MathLogicFunction(zhegalkin);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_Linear", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Linear(int numberOfFunction, int numberOfArguments);

        // Проверка функции на линейность при нажатии на кнопку
        private void CheckLinearButton_Click(object sender, EventArgs e)
        {
            Del linear = new Del(Linear);
            MathLogicFunction(linear);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_BuildSKNF", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr BuildSKNF(int numberOfFunction, int numberOfArguments);

        // Перевод функции в СКНФ при нажатии на кнопку
        private void BuildSKNFButton_Click(object sender, EventArgs e)
        {
            Del buildSKNF = new Del(BuildSKNF);
            MathLogicFunction(buildSKNF);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_BuildSDNF", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr BuildSDNF(int numberOfFunction, int numberOfArguments);

        // Перевод функции в СДНФ при нажатии на кнопку
        private void BuildSDNFButton_Click(object sender, EventArgs e)
        {
            Del buildSDNF = new Del(BuildSDNF);
            MathLogicFunction(buildSDNF);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_CheckFunctionMonotone", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CheckFunctionMonotone(int numberOfFunction, int numberOfArguments);

        // Проверка функции на монотонность при нажатии на кнопку
        private void CheckMonotoneButton_Click(object sender, EventArgs e)
        {
            Del checkFunctionMonotone = new Del(CheckFunctionMonotone);
            MathLogicFunction(checkFunctionMonotone);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_CheckFunctionSavesZero", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CheckFunctionSavesZero(int numberOfFunction, int numberOfArguments);

        // Проверка функции на сохранения 0 при нажатии на кнопку
        private void CheckSavesZeroButton_Click(object sender, EventArgs e)
        {
            Del checkFunctionSavesZero = new Del(CheckFunctionSavesZero);
            MathLogicFunction(checkFunctionSavesZero);
        }

        [DllImport(mathLogicFileName, CharSet = CharSet.Auto, EntryPoint = "_CheckFunctionSavesOne", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr CheckFunctionSavesOne(int numberOfFunction, int numberOfArguments);

        // Проверка функции на сохранения 1 при нажатии на кнопку
        private void CheckSavesOneButton_Click(object sender, EventArgs e)
        {
            Del checkFunctionSavesOne = new Del(CheckFunctionSavesOne);
            MathLogicFunction(checkFunctionSavesOne);
        }
    }
}