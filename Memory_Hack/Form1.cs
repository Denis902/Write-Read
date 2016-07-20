using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReadWriteMemory; // Memory.cs


namespace Memory_Hack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessMemory mem = new ProcessMemory("ac_client");
            if (mem.CheckProcess())
            {
                mem.StartProcess();
                int AmmoPointer = 0x109B74;
                int AmmoOffset = 0x114;
                int AmmoToFill = 100;
                mem.WriteInt(AmmoPointer + AmmoOffset, AmmoToFill);
                MessageBox.Show("Working!");
            }
            else
            {
                MessageBox.Show("Something Went Wrong!");
            }
        }
    }
}
