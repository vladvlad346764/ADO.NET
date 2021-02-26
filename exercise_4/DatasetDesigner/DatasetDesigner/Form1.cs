using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            ApressFinancial1DataSet adventureWorks2019DataSet1 = new ApressFinancial1DataSet();
            ApressFinancial1DataSetTableAdapters.PersonTableAdapter personTableAdapter1 = new ApressFinancial1DataSetTableAdapters.PersonTableAdapter();
            personTableAdapter1.Fill(adventureWorks2019DataSet1.Person);
            foreach (ApressFinancial1DataSet.PersonRow NWCustomer in adventureWorks2019DataSet1.Person.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.FirstName);
            }
        }
    }
}
