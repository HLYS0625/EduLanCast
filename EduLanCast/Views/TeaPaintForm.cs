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
    public partial class TeaPaintForm : Form
    {
        private readonly Form _form;
        public TeaPaintForm(Form form)
        {
            InitializeComponent();
            _form = form;
        }

        private void TeaScreenCastForm_Load(object sender, EventArgs e)
        {

        }
    }
}
