using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windformtasks;

namespace windformtask2
{
    public partial class TestForm : Form
    {
        List<RegistrationDetails> regList;
        public TestForm(List<RegistrationDetails> regDetailsList )
        {
            InitializeComponent();
            regList = regDetailsList;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
