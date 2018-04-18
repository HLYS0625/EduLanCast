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
    public partial class TeaMainForm : Form
    {
        public TeaMainForm()
        {
            InitializeComponent();
        }

        private void TeaMainForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
           
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void BtnStartCast_Click(object sender, EventArgs e)
        {
            var teachoosescreenform=new TeaChooseScreenForm(this);
            teachoosescreenform.Show();
            
        }
    }
}
