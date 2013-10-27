namespace FileToBase64.DStyle
{
    using System;
    using System.Windows.Forms;	

    /// <summary>
    /// Пользовательский контрол, реализующий включение двойной буферизации для текстового поля
    /// </summary>
    class DRichTextBox : RichTextBox
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DRichTextBox()
        {
            // Активация двойной буферизации
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~DRichTextBox()
        {
            GC.Collect(0);
        }
    }
}
