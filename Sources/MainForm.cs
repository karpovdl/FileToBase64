/*
Date of creation: 11.11.2012 
Date of change: 18.12.2012
The latest version: 0.0.0.2
*/

namespace FileToBase64
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.ComponentModel;
    using System.Globalization;

    public partial class MainForm : DStyle.DForm
    {
        private string FileName { get; set; }
        private byte[] FileNameBytes { get; set; }
        private bool IsStopThread { get; set; }
        private const int MINIMAL_SIZE = 0; /*0 bytes*/
        private const int MAXIMUM_SIZE = 50000000; /*50 Mbytes*/

        private readonly String _emptyString;

        public MainForm()
        {
            InitializeComponent();

            FileName = String.Empty;
            _emptyString = String.Empty;            
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            try
            {
                const string filter = "All files|*.*";

                var openFileDialog = new OpenFileDialog
                {
                    Filter = filter,
                    ReadOnlyChecked = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ClearHistory();

                    FileName = openFileDialog.FileName;

                    _fullFileName.Text = FileName;

                    FileNameBytes = File.ReadAllBytes(FileName);

                    if (FileNameBytes.Length > Int32.MaxValue)
                    {
                        MessageBox.Show(
                            String.Format(
                                CultureInfo.InvariantCulture,
                                "Файла {0} превышает допустимый размер в {1} байт",
                                FileName, Int32.MaxValue),
                            GetTitleApplication(),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return;
                    }

                    _fileSize.Text = Convert.ToString(FileNameBytes.Length);

                    _lengthBase64String.Text = _emptyString;
                }
            } //try

            catch (Exception ex)
            {
                _stringBase64.Text = GetException(ref ex);
            } //catch 
        }

        private void ButtonConvertToBase64_Click(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            try
            {
                if (File.Exists(FileName))
                {
                    if (FileNameBytes.Length > MINIMAL_SIZE)
                    {
                        IsStopThread = false;
                        backgroundWorker.RunWorkerAsync(FileNameBytes);
                    } //if
                } //if

                else
                {
                    _stringBase64.Text = String.Format(
                        CultureInfo.InvariantCulture,
                        "[Необходимо выбрать файл]{0}",
                        _emptyString);
                }
            } //try

            catch (Exception ex)
            {
                _stringBase64.Text = GetException(ref ex);
            } //catch
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            try
            {
                string text = _stringBase64.Text;
                if (String.IsNullOrEmpty(text) == false)
                {
                    Clipboard.SetText(text);
                }
            } //try

            catch (Exception ex)
            {
                _stringBase64.Text = GetException(ref ex);
            } //catch 
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            try
            {
                const string filter = "All files|*.*";

                var saveFileDialog = new SaveFileDialog
                                         {
                                             Filter = filter
                                         };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String fileName = saveFileDialog.FileName;

                    File.WriteAllText(fileName, _stringBase64.Text);

                    MessageBox.Show(
                        String.Format(
                            CultureInfo.InvariantCulture,
                            "Файл {0} сохранен",
                            fileName),
                        GetTitleApplication(),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                } //if
            } //try

            catch (Exception ex)
            {
                _stringBase64.Text = GetException(ref ex);
            } //catch 
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            ClearHistory();
        }

        private void ButtonTextWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (IsBusyThread) return;

            _stringBase64.WordWrap = ButtonTextWrap.Checked;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            // Принудительно завершаем запущенный поток
            if (backgroundWorker != null && backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
                RunWorkerCompletedEventArgs canceled = new RunWorkerCompletedEventArgs(null, null, true);
                backgroundWorker_RunWorkerCompleted(null, canceled);
            }//if
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RichTextBox stringBase64 = new RichTextBox();

            try
            {
                //Convert a Word document's base64 representation

                if (IsStopThread) return;
                backgroundWorker.ReportProgress(0, "<start>");
                byte[] bytes = (byte[])e.Argument;

                if (bytes.Length <= MAXIMUM_SIZE)
                {
                    if (IsStopThread) return;
                    backgroundWorker.ReportProgress(1, "<progress:1>");
                    string base64 = Convert.ToBase64String(bytes, 0, bytes.Length, Base64FormattingOptions.InsertLineBreaks);
                    
                    if (IsStopThread) return;
                    backgroundWorker.ReportProgress(2, "<progress:2>");
                    stringBase64.AppendText(base64);

                    if (IsStopThread) return;
                    backgroundWorker.ReportProgress(3, "<finish>");
                }

                if (bytes.Length > MAXIMUM_SIZE)
                {
                    backgroundWorker.ReportProgress(2, "<progress:bigtext>");
                }

                e.Result = stringBase64.Text;
                
                // Позиция в блоке данных
                //int position = 0;
                //const int blockSize = 81920;

                //while (position < bytes.Length)
                //{
                //    int sizeCBuffer;
                //    if (bytes.Length - (position + blockSize) > 0)
                //        sizeCBuffer = blockSize;
                //    else
                //        sizeCBuffer = bytes.Length - position;

                //    // Блок данных - сообщение от сервера
                //    byte[] msg = new byte[sizeCBuffer];

                //    base64 += Convert.ToBase64String(msg, 0, msg.Length);
                    

                //    if (IsStopThread) return;
                    
                //    position += sizeCBuffer;
                //    double progress = 100.0 * (Convert.ToDouble(position)/Convert.ToDouble(bytes.Length));

                //    backgroundWorker.ReportProgress(2, 
                //        String.Format(
                //            CultureInfo.InvariantCulture, 
                //            "{0} byte {1}%",
                //            base64.Length, (int)progress));
                //} //while
            } //try

            catch (Exception ex)
            {
                e.Result = ex.Message;
            } //catch
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string endl = "\r\n";
            switch (e.UserState.ToString())
            {
                case "<start>":
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "Progress 25% .{0}" + endl, _emptyString);
                    ButtonStop.Visible = true;
                    break;

                case "<progress:1>":
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "Progress 50% ..{0}" + endl, _emptyString);
                    break;

                case "<progress:2>":
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "Progress 75% ...{0}" + endl, _emptyString);
                    break;

                case "<finish>":
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "Progress 100% ....{0}" + endl, _emptyString);                    
                    break;

                case "<progress:bigtext>":
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "[Размер файла, который может быть конвертирован, превысил допустимый размер в {0} байт]", MAXIMUM_SIZE);
                    break;

                default:
                    _stringBase64.Text = String.Format(CultureInfo.InvariantCulture, "{0}", e.UserState);
                    break;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    _stringBase64.Text = String.Format(
                        CultureInfo.InvariantCulture,
                        "[Получение строки в формате base64 прервано пользователем]{0}",
                        _emptyString);

                    IsStopThread = true;
                }

                else if (e.Error != null)
                {
                    _stringBase64.Text = String.Format(
                        CultureInfo.InvariantCulture,
                        "[Worker exception: {0}]",
                        e.Error);
                }

                else
                {
                    if (IsStopThread) return;

                    if (FileNameBytes.Length <= MAXIMUM_SIZE)
                    {
                        _stringBase64.Text = e.Result.ToString();                    
                        _lengthBase64String.Text = e.Result.ToString().Length.ToString(CultureInfo.InvariantCulture);
                    }
                }
            } //try

            finally
            {
                ButtonStop.Visible = false;
            } //finally
        }

        private void ClearHistory()
        {
            _stringBase64.Clear();

            FileName = _emptyString;
            _fileSize.Text = _emptyString;
            _fullFileName.Text = _emptyString;
            _lengthBase64String.Text = _emptyString;
        }

        private string GetTitleApplication()
        {
            return Application.ProductName + " " + Application.ProductVersion;
        }

        private string GetException(ref Exception ex)
        {
            return String.Format(
                CultureInfo.InvariantCulture,
                "[Exception: {0}]",
                ex.Message);
        }

        private bool IsBusyThread
        {
            get
            {
                bool isBusy = false;
                if (backgroundWorker != null)
                {
                    isBusy = backgroundWorker.IsBusy;

                    if (isBusy)
                    {
                        MessageBox.Show(
                            String.Format(
                                CultureInfo.InvariantCulture,
                                "Процесс преобразования не закончен. Подождите и попробуйте еще раз позднее{0}",
                                _emptyString),
                            GetTitleApplication(),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    } //if
                } //if

                return isBusy;
            } //get
        }
    }
}
