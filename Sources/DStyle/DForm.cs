namespace FileToBase64.DStyle {
    using System;
    using System.Windows.Forms;
    using System.Drawing;

    public class DForm : Form
    {
        private Panel _panelFrontBox;
        private Panel _panelTop;
        private Panel _panelInternalBox;
        private Panel _panelOutBorder;
        private Panel _panelReSize;

        private Label _lTitleApplication;
        private Label _lDk;

        // Для перемещения формы

        /// <summary>
        /// Объекта Point. Объект будет использоваться в качестве переменной при вычислении способа перемещения формы.
        /// </summary>
        private System.Drawing.Point _mouseOffset;

        /// <summary>
        /// sMouseDown позволяет отслеживать, удерживает ли пользователь кнопку мыши. Форма должна перемещаться только тогда, когда кнопка мыши удерживается нажатой.
        /// </summary>
        private bool _isMouseDown;
        private Timer _timerOpacity;
        private System.ComponentModel.IContainer components;
        private Label ButtonClose;
        private Label ButtonMinimumSizeForm;
        private Label ButtonMaximumSizeForm;
        
        private bool _flagIsDown;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DForm()
        {
            InitializeComponent();

            // Активация двойной буферизации
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //this.ButtonExitApplication.Location = new System.Drawing.Point(this.panelTop.Width - this.ButtonExitApplication.Width, this.ButtonExitApplication.Location.Y);
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~DForm()
        {
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DForm));
            this._panelFrontBox = new System.Windows.Forms.Panel();
            this._panelReSize = new System.Windows.Forms.Panel();
            this._panelInternalBox = new System.Windows.Forms.Panel();
            this._panelTop = new System.Windows.Forms.Panel();
            this.ButtonMinimumSizeForm = new System.Windows.Forms.Label();
            this.ButtonMaximumSizeForm = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Label();
            this._lDk = new System.Windows.Forms.Label();
            this._lTitleApplication = new System.Windows.Forms.Label();
            this._timerOpacity = new System.Windows.Forms.Timer(this.components);
            this._panelOutBorder = new System.Windows.Forms.Panel();
            this._panelFrontBox.SuspendLayout();
            this._panelInternalBox.SuspendLayout();
            this._panelTop.SuspendLayout();
            this._panelOutBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelFrontBox
            // 
            this._panelFrontBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelFrontBox.BackColor = System.Drawing.Color.White;
            this._panelFrontBox.Controls.Add(this._panelReSize);
            this._panelFrontBox.Controls.Add(this._panelInternalBox);
            this._panelFrontBox.Cursor = System.Windows.Forms.Cursors.Default;
            this._panelFrontBox.Location = new System.Drawing.Point(1, 1);
            this._panelFrontBox.Margin = new System.Windows.Forms.Padding(10);
            this._panelFrontBox.Name = "_panelFrontBox";
            this._panelFrontBox.Padding = new System.Windows.Forms.Padding(5);
            this._panelFrontBox.Size = new System.Drawing.Size(698, 148);
            this._panelFrontBox.TabIndex = 0;
            // 
            // _panelReSize
            // 
            this._panelReSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._panelReSize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._panelReSize.Location = new System.Drawing.Point(688, 137);
            this._panelReSize.Name = "_panelReSize";
            this._panelReSize.Size = new System.Drawing.Size(10, 10);
            this._panelReSize.TabIndex = 1;
            this._panelReSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this._panelReSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this._panelReSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // _panelInternalBox
            // 
            this._panelInternalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._panelInternalBox.BackColor = System.Drawing.Color.White;
            this._panelInternalBox.Controls.Add(this._panelTop);
            this._panelInternalBox.Location = new System.Drawing.Point(10, 0);
            this._panelInternalBox.Margin = new System.Windows.Forms.Padding(10, 1, 10, 10);
            this._panelInternalBox.Name = "_panelInternalBox";
            this._panelInternalBox.Size = new System.Drawing.Size(679, 138);
            this._panelInternalBox.TabIndex = 0;
            // 
            // _panelTop
            // 
            this._panelTop.BackColor = System.Drawing.Color.White;
            this._panelTop.Controls.Add(this.ButtonMinimumSizeForm);
            this._panelTop.Controls.Add(this.ButtonMaximumSizeForm);
            this._panelTop.Controls.Add(this.ButtonClose);
            this._panelTop.Controls.Add(this._lDk);
            this._panelTop.Controls.Add(this._lTitleApplication);
            this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelTop.Location = new System.Drawing.Point(0, 0);
            this._panelTop.Margin = new System.Windows.Forms.Padding(10, 1, 10, 0);
            this._panelTop.Name = "_panelTop";
            this._panelTop.Size = new System.Drawing.Size(679, 34);
            this._panelTop.TabIndex = 0;
            this._panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            this._panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this._panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this._panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // ButtonMinimumSizeForm
            // 
            this.ButtonMinimumSizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimumSizeForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimumSizeForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinimumSizeForm.ForeColor = System.Drawing.Color.White;
            this.ButtonMinimumSizeForm.Image = global::FileToBase64.Properties.Resources.minimum_size_form;
            this.ButtonMinimumSizeForm.Location = new System.Drawing.Point(575, 0);
            this.ButtonMinimumSizeForm.Name = "ButtonMinimumSizeForm";
            this.ButtonMinimumSizeForm.Size = new System.Drawing.Size(34, 29);
            this.ButtonMinimumSizeForm.TabIndex = 36;
            this.ButtonMinimumSizeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonMinimumSizeForm.Click += new System.EventHandler(this.ButtonMinimumSizeForm_Click_1);
            this.ButtonMinimumSizeForm.MouseEnter += new System.EventHandler(this.ButtonMinimumSizeForm_MouseEnter);
            this.ButtonMinimumSizeForm.MouseLeave += new System.EventHandler(this.ButtonMinimumSizeForm_MouseLeave);
            // 
            // ButtonMaximumSizeForm
            // 
            this.ButtonMaximumSizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximumSizeForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMaximumSizeForm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMaximumSizeForm.ForeColor = System.Drawing.Color.White;
            this.ButtonMaximumSizeForm.Image = global::FileToBase64.Properties.Resources.maximum_size_form;
            this.ButtonMaximumSizeForm.Location = new System.Drawing.Point(610, 0);
            this.ButtonMaximumSizeForm.Name = "ButtonMaximumSizeForm";
            this.ButtonMaximumSizeForm.Size = new System.Drawing.Size(34, 29);
            this.ButtonMaximumSizeForm.TabIndex = 36;
            this.ButtonMaximumSizeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonMaximumSizeForm.Click += new System.EventHandler(this.ButtonMaximumSizeForm_Click_1);
            this.ButtonMaximumSizeForm.MouseEnter += new System.EventHandler(this.ButtonMaximumSizeForm_MouseEnter);
            this.ButtonMaximumSizeForm.MouseLeave += new System.EventHandler(this.ButtonMaximumSizeForm_MouseLeave);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonClose.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(645, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 29);
            this.ButtonClose.TabIndex = 36;
            this.ButtonClose.Text = "x";
            this.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // _lDk
            // 
            this._lDk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(195)))), ((int)(((byte)(46)))));
            this._lDk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lDk.ForeColor = System.Drawing.Color.White;
            this._lDk.Location = new System.Drawing.Point(1, 0);
            this._lDk.Name = "_lDk";
            this._lDk.Size = new System.Drawing.Size(34, 34);
            this._lDk.TabIndex = 36;
            this._lDk.Text = "DK";
            this._lDk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lTitleApplication
            // 
            this._lTitleApplication.AutoSize = true;
            this._lTitleApplication.Location = new System.Drawing.Point(37, 4);
            this._lTitleApplication.Name = "_lTitleApplication";
            this._lTitleApplication.Size = new System.Drawing.Size(133, 26);
            this._lTitleApplication.TabIndex = 0;
            this._lTitleApplication.Text = "Создание Base64 строки\r\nВерсия 0.0.0.4 2013";
            // 
            // _timerOpacity
            // 
            this._timerOpacity.Interval = 400;
            this._timerOpacity.Tick += new System.EventHandler(this.timerOpacity_Tick);
            // 
            // _panelOutBorder
            // 
            this._panelOutBorder.BackColor = System.Drawing.Color.DarkGray;
            this._panelOutBorder.Controls.Add(this._panelFrontBox);
            this._panelOutBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelOutBorder.Location = new System.Drawing.Point(0, 0);
            this._panelOutBorder.Name = "_panelOutBorder";
            this._panelOutBorder.Size = new System.Drawing.Size(700, 150);
            this._panelOutBorder.TabIndex = 0;
            // 
            // DForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(700, 150);
            this.ControlBox = false;
            this.Controls.Add(this._panelOutBorder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DForm";
            this.Activated += new System.EventHandler(this.DForm_Activated);
            this.Resize += new System.EventHandler(this.DForm_Resize);
            this._panelFrontBox.ResumeLayout(false);
            this._panelInternalBox.ResumeLayout(false);
            this._panelTop.ResumeLayout(false);
            this._panelTop.PerformLayout();
            this._panelOutBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region ПЕРЕМЕЩЕНИЕ ФОРМЫ

        /// <summary>
        /// Обработчик событий для события MouseDown формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            int xOffset = -e.X - 11/*- SystemInformation.FrameBorderSize.Width*/;
            int yOffset = -e.Y - 1/*- SystemInformation.FrameBorderSize.Height*/;
            _mouseOffset = new Point(xOffset, yOffset);
            _isMouseDown = true;

            this.Opacity = 0.80;
            this._timerOpacity.Start();
        }

        /// <summary>
        /// Обработчик событий для события MouseMove формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown) return;

            Point mousePos = Control.MousePosition;
            mousePos.Offset(_mouseOffset.X, _mouseOffset.Y);
            Location = mousePos;
        }

        /// <summary>
        /// Обработчик событий для события MouseUp формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button != MouseButtons.Left) return;

            _isMouseDown = false;

            this._timerOpacity.Stop();
            this.Opacity = 1;//0.999;
        }

        #endregion

        #region ИЗМЕНЕНИЕ РАЗМЕРА ФОРМЫ

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._flagIsDown != true) return;

            Width = MousePosition.X - Location.X;
            Height = MousePosition.Y - Location.Y;

            this.Refresh();
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            
            this._flagIsDown = true;
            //this.Opacity = 1.0;
            //this.Refresh();            
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
   
            this._flagIsDown = false;
            //this.Opacity = 0.999;
            //this.Refresh();
        }

        #endregion

        #region ОБРАБОТЧИКИ СОБЫТИЙ ДЛЯ КНОПОК ЗАГОЛОВКА ФОРМЫ

        /// <summary>
        /// Обработчик событий двойного клика по загаловку формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTop_DoubleClick(object sender, EventArgs e)
        {
            this.WindowStateForm();
        }

        /// <summary>
        /// Обработчик выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

            dialogResult = MessageBox.Show(@"Выйти из программы?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {

                // Closes the parent form.

                Application.Exit();

            }//if
        }

        /// <summary>
        /// Обработчик событий максимального/нормального размера окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMaximumSizeForm_Click(object sender, EventArgs e)
        {
            this.WindowStateForm();
        }

        /// <summary>
        /// Состояние вида размера формы окна
        /// </summary>
        private void WindowStateForm()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                //this.ButtonMaximumSizeForm.BackgroundImage = global::FileToBase64.Properties.Resources.maximum_size_form;
                this.Refresh();
                return;
            }//if

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                //this.ButtonMaximumSizeForm.BackgroundImage = global::FileToBase64.Properties.Resources.normal_size_form;
                this.Refresh();
                return;
            }//if
        }

        /// <summary>
        /// Обработчик событий минимального размера окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinimumSizeForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void DForm_Activated(object sender, EventArgs e)
        {
            //this.ButtonMaximumSizeForm.BackgroundImage = global::FileToBase64.Properties.Resources.maximum_size_form;
        }

        private void DForm_Resize(object sender, EventArgs e)
        {    
            this.Refresh();
        }

        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0.80;
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(224, 67, 67);  
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(199, 80, 80);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                String.Format("Приложение будет закрыто. Подтверждаете действие?"),
                String.Format("{0}: {1}", Application.ProductName, Application.CompanyName),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes) return;

            Application.Exit();
        }

        private void ButtonMaximumSizeForm_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonMaximumSizeForm.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);

            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    this.ButtonMaximumSizeForm.Image = global::FileToBase64.Properties.Resources.normal_size_form_active;
                    break;

                case FormWindowState.Normal:
                    this.ButtonMaximumSizeForm.Image = global::FileToBase64.Properties.Resources.maximum_size_form_active;
                    break;
            }
        }

        private void ButtonMaximumSizeForm_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMaximumSizeForm.BackColor = System.Drawing.Color.Transparent;

            switch (WindowState)
            {
                case FormWindowState.Maximized:
                    this.ButtonMaximumSizeForm.Image = global::FileToBase64.Properties.Resources.normal_size_form;
                    break;

                case FormWindowState.Normal:
                    this.ButtonMaximumSizeForm.Image = global::FileToBase64.Properties.Resources.maximum_size_form;
                    break;
            }
        }

        private void ButtonMaximumSizeForm_Click_1(object sender, EventArgs e)
        {
            WindowStateForm();
        }

        private void ButtonMinimumSizeForm_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonMinimumSizeForm.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
            this.ButtonMinimumSizeForm.Image = global::FileToBase64.Properties.Resources.minimum_size_form_active;
        }

        private void ButtonMinimumSizeForm_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMinimumSizeForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimumSizeForm.Image = global::FileToBase64.Properties.Resources.minimum_size_form;
        }

        private void ButtonMinimumSizeForm_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
