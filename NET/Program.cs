using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Resources;

namespace BuildNumbers
{
    public class Program
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

            MyContextMenu m1 = new MyContextMenu();
            m1.AddContextmenu();
        }       
    }

    public class MyContextMenu
    {
        DataGridView dataGridView1 = new DataGridView();
        public void AddContextmenu()
        {
            // Create a shortcut menu.
            ContextMenu m = new ContextMenu();

            // Create MenuItem objects.
            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();

            // Set the Text property.
            menuItem1.Text = "&Copy";
            menuItem2.Text = "&Paste";

            // Add menu items to the MenuItems collection.
            m.MenuItems.Add(menuItem1);
            m.MenuItems.Add(menuItem2);           

            // Add functionality to the menu items. 
            menuItem1.Click += MenuItem1_Click;
            menuItem2.Click += MenuItem2_Click;
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(this.dataGridView1.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    //this.dataGridView1.m
                    //The Clipboard could not be accessed. Please try again;
                }
            };
        }
    }
}
