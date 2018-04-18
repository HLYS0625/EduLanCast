using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduLanCast.Views
{
    public partial class TeaChooseScreenForm : Form
    {
        private readonly Form _form;
        public TeaChooseScreenForm(Form form)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _form = form;
        }

        private void TeaChooseScreenForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
           
            _form.Hide();
            Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
