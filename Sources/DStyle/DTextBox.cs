namespace FileToBase64.DStyle
{
    using System;
    using System.Windows.Forms;	

    /// <summary>
    /// Пользовательский контрол, реализующий включение двойной буферизации для текстового поля
    /// </summary>
    class DTextBox : TextBox
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DTextBox()
        {
            // Активация двойной буферизации
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~DTextBox()
        {
            GC.Collect(0);
        }
    }
}
