﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartographer_Launcher
{
    public partial class richTextBox_transparent : RichTextBox
    {
        public richTextBox_transparent()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor |
            //                 //ControlStyles.OptimizedDoubleBuffer |
            //                 ControlStyles.AllPaintingInWmPaint |
            //                 ControlStyles.ResizeRedraw |
            //                 ControlStyles.UserPaint, true);
            //BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                //This makes the control's background transparent
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }
        //private void redrawText()
        //{
        //    using (Graphics graphics = this.CreateGraphics())
        //    using (SolidBrush brush = new SolidBrush(this.ForeColor))
        //        graphics.DrawString(this.Text, this.Font, brush, 0, 0); //play around with how you draw string more to suit your original
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    redrawText();
        //}
    }
}