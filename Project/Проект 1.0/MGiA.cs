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
        public const string mgiaFileName = @"Libraries\MGiAFunctions.dll";
        public delegate IntPtr DelTableKeli(int residuesClassModule);
        public delegate IntPtr Del1(string number1, string number2);

        // Метод для получения таблицы Кели
        public void TableKeli(DelTableKeli function)
        {
            MGiaTextBox.Clear();
            try
            {
                int residuesClassModule = Convert.ToInt32(ResiduesClassModuleTextBox.Text);             // Читаем класс вычетов
                var result = Marshal.PtrToStringAnsi(function(residuesClassModule));                    // Получаем результат преобразования
                String[] substrings = result.Split('\n');
                foreach (String element in substrings)
                    MGiaTextBox.AppendText(element + Environment.NewLine);                              // Выводим результат
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }

        // Метод для получения НОД или НОК
        public void MathFunctionBetweenTwoNumbers(Del1 function)
        {
            MGiaTextBox.Clear();
            try
            {
                string number1 = Number1TextBox.Text;
                string number2 = Number2TextBox.Text;
                var result = Marshal.PtrToStringAnsi(function(number1, number2));
                MGiaTextBox.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }


        [DllImport(mgiaFileName, CharSet = CharSet.Auto, EntryPoint = "_TableKeliForSum", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TableKeliForSum(int residuesClassModule);
       
        // Нахождение таблицы Кели для суммы для заданного модуля классов вычетов при нажатии на кнопку
        private void TableKeliForSumButton_Click(object sender, EventArgs e)
        {
            DelTableKeli tableKeliForSum = new DelTableKeli(TableKeliForSum);
            TableKeli(tableKeliForSum);
        }


        [DllImport(mgiaFileName, CharSet = CharSet.Auto, EntryPoint = "_TableKeliForMultiplication", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr TableKeliForMultiplication(int residuesClassModule);
        
        // Нахождение таблицы Кели для произведения для заданного модуля классов вычетов при нажатии на кнопку
        private void TableKeliForMultiplicationButton_Click(object sender, EventArgs e)
        {
            DelTableKeli tableKeliForMultiplication = new DelTableKeli(TableKeliForMultiplication);
            TableKeli(tableKeliForMultiplication);
        }


        [DllImport(mgiaFileName, CharSet = CharSet.Ansi, EntryPoint = "_lcm", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr LCM(string number1, string number2);

        // Нахождение НОД двух чисел при нажатии на кнопку 
        private void LCMButton_Click(object sender, EventArgs e)
        {
            Del1 lcm = new Del1(LCM);
            MathFunctionBetweenTwoNumbers(lcm);
        }


        [DllImport(mgiaFileName, CharSet = CharSet.Ansi, EntryPoint = "_gcd", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GCD(string number1, string number2);

        // Нахождение НОК двух чисел при нажатии на кнопку 
        private void GCDButton_Click(object sender, EventArgs e)
        {
            Del1 gcd = new Del1(GCD);
            MathFunctionBetweenTwoNumbers(gcd);
        }


        [DllImport(mgiaFileName, CharSet = CharSet.Ansi, EntryPoint = "_primeRow", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr PrimeRow(int number1, int number2);

        // Нахождение всех простых чисел на отрезке при нажатии на кнопку 
        private void PrimeRowButton_Click(object sender, EventArgs e)
        {
            MGiaTextBox.Clear();
            try
            {
                int left = Convert.ToInt32(Number1TextBox.Text);
                int right = Convert.ToInt32(Number2TextBox.Text);
                var result = Marshal.PtrToStringAnsi(PrimeRow(left, right));
                MGiaTextBox.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода!");
            }
        }
    }
}