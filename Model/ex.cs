using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Model
{
    public partial class ex : SampleAdd
    {
        public ex()
        {
            InitializeComponent();


        }
        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
