using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesLeoK
{
    public partial class frmChocolateBoxesLeoK : Form
    {
        public frmChocolateBoxesLeoK()
        {
            InitializeComponent();
        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            //Set the user input to boxesOfChoc
            int boxesOfChoc;
            boxesOfChoc = Convert.ToInt32(nudBoxesSold.Value);

            if (boxesOfChoc > 20)
            {
                this.lblPrize.Text = " A Prize!";
            }
            else
            {
                if (boxesOfChoc < 10)
                {
                    this.lblPrize.Text = " An Honorable Mention";
                }
                else
                {
                    this.lblPrize.Text = " A Small Prize";
                }
            }
        }
    }
}
