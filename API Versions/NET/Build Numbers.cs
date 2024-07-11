using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuildNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("data.xml");
            dataGridView1.DataSource = dataSet.Tables[0];            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }

    public class CreateContextMenu
    {
        DataGridView dataGridView1 = new DataGridView();
        public void AddContextmenu(object sender, EventArgs e)
        {
            // Create a shortcut menu.
            ContextMenu m = new ContextMenu();

            // Create MenuItem objects.
            MenuItem menuItem1 = new MenuItem();

            // Set the Text property.
            menuItem1.Text = "&Copy";

            // Add menu items to the MenuItems collection.
            m.MenuItems.Add(menuItem1);

            // Add functionality to the menu items. 
            menuItem1.Click += MenuItem1_Click;
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

    public class CreateClipboard
    {
        DataGridView dataGridView1 = new DataGridView();
    }

    public class CreateButton
    {
        public object Controls { get; private set; }

        void MyButton()
        {
            Button button1 = new Button();
            Button button2 = new Button();

            // Set Button properties  
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 25);
            button1.TabIndex = 1;
            button1.Location = new Point(20, 150);
            button1.Text = "&OK";
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Location = new System.Drawing.Point(188, 641);

            button1.Click += Button1_Click;
           
            button2.Location = new System.Drawing.Point(437, 641);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 25);
            button2.TabIndex = 2;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Create a Button object  

    }

    public class CreateGridView
    {
        public void MyGridView()
        {
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(691, 673);
            dataGridView1.TabIndex = 3;
        }
    }
}
