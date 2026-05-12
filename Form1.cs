using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laptrinhwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//<<<<<<< HEAD
        
//=======
        private void button1_Click(object sender, EventArgs e)
        {
            nhanhvien nvv = new nhanhvien();
            nvv.Show(); 
         }
//>>>>>>> ab7850fe5df507b7a2a57d21598dc4b4f463cec3
    }
}
