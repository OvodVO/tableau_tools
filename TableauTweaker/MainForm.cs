using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace WashU.BatemanLab.MassSpec.TableauTweaker
{
    public partial class MainForm : Form
    {
        TableauWorkbook _tableauWorkbook;

        public MainForm()
        {
            InitializeComponent();
            this.Text = AssemblyProduct;
            this._tableauWorkbook = new TableauWorkbook();
        }

        private void OpenTableauWorkbook()
        {
            OpenFileDialog _openDlg = new OpenFileDialog();
            _openDlg.Filter = "Tableau workbook |*.twb; *.twbx";
            _openDlg.Multiselect = false;

            if (_openDlg.ShowDialog() == DialogResult.OK)
            {
                _tableauWorkbook.OpenFile(_openDlg.FileName);
            }
        }
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenTableauWorkbook();
            _tableauWorkbook.CleanWorkbook();
        }
    }
}
