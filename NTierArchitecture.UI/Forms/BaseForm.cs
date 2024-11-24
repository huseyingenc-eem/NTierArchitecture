﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierArchitecture.UI.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        //protected > sadece kendinden türetilen sınıflardan erişime izin verilir.
        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnList_Click(object sender, EventArgs e)
        {

        }
    }
}
