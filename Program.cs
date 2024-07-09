using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Resources;

namespace BuildNumbers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {           
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            DataGridView dataGridView1 = new DataGridView();
            ContextMenu cm = new ContextMenu();
            dataGridView1.ContextMenu = cm;
            cm.MenuItems.Add("&Copy");
            cm.Popup += Cm_Popup;
        }

        private static void Cm_Popup(object sender, EventArgs e)
        {
            DataGridView dataGridView1 = new DataGridView();            
            //Clipboard clip1 = new Clipboard(dataGridView1);
            //Clipboard.GetDataObject(dataGridView1.); 
        }
    }
}
