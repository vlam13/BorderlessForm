﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorderlessApp
{
    public partial class TitleBar : UserControl
    {
        Form _ownerForm;
        CloseButton _closeButton;
        MaximizeButton _maximizeButton;
        MinimizeButton _minimizeButton;
        FlowLayoutPanel _buttonsPannel;

        public TitleBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);

            _buttonsPannel = new FlowLayoutPanel();
            _buttonsPannel.Size = Size.Empty;
            _buttonsPannel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _buttonsPannel.AutoSize = true;
            _buttonsPannel.BackColor = Color.LightGray;
            _buttonsPannel.Padding = new Padding(1,0,1,1);

            _closeButton = new CloseButton();
            _closeButton.Click += CloseButtonClick;
            _closeButton.Visible = true;
            _closeButton.Margin = Padding.Empty;

            _maximizeButton = new MaximizeButton();
            _maximizeButton.Click += MaximizeButtonClick;
            _maximizeButton.Visible = true;
            _maximizeButton.Margin = new Padding(0,0,1,0);

            _minimizeButton = new MinimizeButton();
            _minimizeButton.Click += MinimizeButtonClick;
            _minimizeButton.Visible = true;
            _minimizeButton.Margin = new Padding(0, 0, 1, 0);

            _buttonsPannel.Controls.Add(_minimizeButton);
            _buttonsPannel.Controls.Add(_maximizeButton);
            _buttonsPannel.Controls.Add(_closeButton);

            this.Controls.Add(_buttonsPannel);
        }

        public TitleBar(Form owner)
            : this()
        {
            _ownerForm = owner;
        }

        #region Properties

        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        public override bool Focused
        {
            get
            {
                return false;
            }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            bool handled = false;

            switch(m.Msg)
            {
                case (int)WinApi.WM_LBUTTONDBLCLK:
                    {
                        WinApi.SendMessage(_ownerForm.Handle, (int)WinApi.WM_NCLBUTTONDBLCLK, WinApi.HT_CAPTION, 0);
                        handled = true;
                        break;
                    }
                case (int)WinApi.WM_LBUTTONDOWN:
                    {
                        WinApi.SendMessage(_ownerForm.Handle, (int)WinApi.WM_NCLBUTTONDOWN, WinApi.HT_CAPTION, 0);
                        handled = true;
                        break;
                    }
                case (int)WinApi.WM_RBUTTONDOWN:
                    {
                        WinApi.SendMessage(_ownerForm.Handle, (int)WinApi.WM_NCRBUTTONDOWN, WinApi.HT_CAPTION, 0);
                        handled = true;
                        break;
                    }
                case (int)WinApi.WM_RBUTTONUP:
                    {
                        WinApi.SendMessage(_ownerForm.Handle, (int)WinApi.WM_NCRBUTTONUP, WinApi.HT_CAPTION, 0);
                        handled = true;
                        break;
                    }
                case (int)WinApi.WM_ACTIVATE:
                    {
                        WinApi.SendMessage(_ownerForm.Handle, (int)WinApi.WM_NCACTIVATE, WinApi.HT_CAPTION, 0);
                        handled = true;
                        break;
                    }
            }

            if(!handled)
                base.WndProc(ref m);
        }

        #region Button handlers
        private void MaximizeButtonClick(object sender, EventArgs e)
        {
            if (_ownerForm.WindowState != FormWindowState.Maximized)
                _ownerForm.WindowState = FormWindowState.Maximized;
            else
                _ownerForm.WindowState = FormWindowState.Normal;
        }

        private void MinimizeButtonClick(object sender, EventArgs e)
        {
            //int flags = ((int)WinApi.ActivateWindowFlags.AW_HIDE | (int)WinApi.ActivateWindowFlags.AW_BLEND |
            //             (int)WinApi.ActivateWindowFlags.AW_VER_POSITIVE | (int)WinApi.ActivateWindowFlags.AW_HOR_NEGATIVE | (int)WinApi.ActivateWindowFlags.AW_HOR_POSITIVE);

            //bool result = WinApi.AnimateWindow(_ownerForm.Handle, 200, flags);

            WinApi.ShowWindow((int)_ownerForm.Handle, WinApi.SW_MINIMIZE);
         }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            //if (_ownerForm.WindowState != FormWindowState.Maximized)
            //{
            //    while (_ownerForm.Size.Width > 2 && _ownerForm.Size.Height > 2)
            //    {
            //        _ownerForm.Location = new Point(_ownerForm.Location.X + 1, _ownerForm.Location.Y + 1);
            //        _ownerForm.Size = new Size(_ownerForm.Size.Width - 2, _ownerForm.Size.Height - 2);
            //    }
            //}
            _ownerForm.Close();
        }

        #endregion

        #region Form events

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            _buttonsPannel.Location = new Point(Right - _buttonsPannel.Width, 0);
        }

        #endregion
    }
}
