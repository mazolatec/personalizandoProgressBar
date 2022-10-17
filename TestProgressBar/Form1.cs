using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

       
        //Thread dt = new Thread(funcaoFor);
        //dt.Start();
      
public void funcaoFor()
        {
            vProgressBar.Value = 0;
            for (int i = 0; i < 1000000; i++)
            {
               // Thread.Sleep(200);
                vProgressBar.Value += i; ;
            }
        }

        private void btnControleVarial_Click(object sender, EventArgs e)
        {   vProgressBar.Value = 0;
            progressBar1.Value = 0;
            //vProgressBar.Minimum = int.Parse(txtBoxValueMin.Text);
            vProgressBar.Maximum = 100;
            progressBar1.Maximum = 100;
            for (int i = 0; i <= int.Parse(txtBoxValueMax.Text); i++)
            {
                vProgressBar.Value = i;
                Thread.Sleep(200);
                vProgressBar.Update();
                lblStatusI.Text = "Var i do for: " + i.ToString();
                lblStatusI.Refresh();
            }
            lblStatusI.Text = "Var i do for:  0" ;
            for (int i = 0; i <= int.Parse(txtBoxValueMax.Text); i++)
            {
                //progressBar1.Update();
                lblStatusI.Text = "Var i do for: " + i.ToString();
                progressBar1.Value = i;
                Thread.Sleep(200);
                progressBar1.Update();
                lblStatusI.Refresh();
            }
           // lblStatusI.Text = "Var i do for:  0";
        }
    }
}
