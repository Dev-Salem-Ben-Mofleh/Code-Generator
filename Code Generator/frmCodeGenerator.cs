using Bussinse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;

namespace Code_Generator
{
    public partial class frmCodeGenerator : Form
    {
        private clsBussiness _bussiness;
        private string _selectedTable = "";

        public frmCodeGenerator()
        {
            InitializeComponent();
        }
        private bool HandleAll()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void _FillDataBaseName()
        {
            DataTable data= clsBussiness.GetAll();

            foreach (DataRow row in data.Rows)
            {
                cbDatabaseNAme.Items.Add(row["DatabaseName"].ToString());
            }
             _bussiness = new clsBussiness();

            
        }
        private void _Reset()
        {
            _bussiness=new clsBussiness();
            cbDatabaseNAme.Items.Clear();
            lvCDA.Items.Clear();
            lvTables.Items.Clear();
            txtCode.Text = "";
            lblcolumnRecord.Text = "0";
            lbltablerecord.Text = "0";
            txtPathAccessLayer.Text = "";
            txtAppconfig.Text = "";
            txtBussinessLayer.Text = "";
            _selectedTable = "";
            _FillDataBaseName();
        }
        private void _GetAllTables()
        {
            lvTables.Items.Clear();
            foreach(string Tables in _bussiness.Tables)
            {
                ListViewItem Item = new ListViewItem(Tables);
                lvTables.Items.Add(Item);

            }

            lbltablerecord.Text= _bussiness.Tables.Count.ToString();
        }
        private void _ColumnsOfTables()
        {
            lvCDA.Items.Clear();

            int Counter = 1;

                    foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
                    {
                            ListViewItem Item = new ListViewItem(Parametrs.Key);
                            List<string>DatatypeAndNull= Parametrs.Value.Split(',').ToList();
                            Item.SubItems.Add( DatatypeAndNull[0]);
                            Item.SubItems.Add(DatatypeAndNull[1]) ;
                            lvCDA.Items.Add(Item);
                Counter++;
                    }
                   
            lblcolumnRecord.Text = lvCDA.Items.Count.ToString();
        }
        private void btnGenerateDataAccessSetting_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateAcesssSetting().ToString();

        }

        private void frmCodeGenerator_Load(object sender, EventArgs e)
        {
            _FillDataBaseName();
        }

        private void cbDatabaseNAme_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bussiness.DatabaseName = cbDatabaseNAme.Text;
            _bussiness.FillTablesOfDataBase(cbDatabaseNAme.Text);
            _selectedTable = "";
            _GetAllTables();
        }

        private void lvTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTables.SelectedItems[0];
                _selectedTable = selectedItem.Text;
                _bussiness.FillParamtersOfDataBase(cbDatabaseNAme.Text, _selectedTable);
                _ColumnsOfTables();

            }
            else
            {
                return;
            }
        }

        private void btnGenerateDataAccessLayer_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            MessageBox.Show("Please ensure your have added all the necessary helper class to your data access layer to prevent complatoin error.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCode.Text = "";
          txtCode.Text=_bussiness.GenerateDataAcesss(_selectedTable).ToString();
        }

        [STAThread]
        private void bntCopy_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
                return;

            Clipboard.SetText(txtCode.Text);
        }

        private void btnGenerateBussinessLayer_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateBussinessLayer(_selectedTable).ToString();
        }

        private void btnGenerateStoredProcedure_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateStoredProcedure(_selectedTable).ToString();
        }

        private void btnGenerateErrorLogger_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateErrorLogger().ToString();
        }

        private void btnGenerateDataAccessHelper_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateDataAcesssHelper().ToString();
        }

        private void btnGenerateLogHandler_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            txtCode.Text = "";
            txtCode.Text = _bussiness.GenerateLogHandler().ToString();
        }

        private void cbDatabaseNAme_Validating(object sender, CancelEventArgs e)
        {
            if (cbDatabaseNAme.Text=="")
            {
                e.Cancel = true;
                cbDatabaseNAme.Focus();
                errorProvider1.SetError(cbDatabaseNAme, "Choose Database");
            }
            else
            {
                errorProvider1.SetError(cbDatabaseNAme, null);
            }
        }

        private void lvTables_Validating(object sender, CancelEventArgs e)
        {
            if (_selectedTable == "")
            {
                e.Cancel = true;
                cbDatabaseNAme.Focus();
                errorProvider1.SetError(lvTables, "Select Table");
            }
            else
            {
                errorProvider1.SetError(lvTables, null);
            }
        }

        private void btnReset_Click(object sender, EventArgs e) => _Reset();
        private void btnGenerateAccessLayer_Click(object sender, EventArgs e)
        {
            if (cbDatabaseNAme.Text == "")
            {
                
                MessageBox.Show("Select Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPathAccessLayer.Text == "")
            {
                MessageBox.Show("Fill Tha Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            if (MessageBox.Show("Are you sure you want to generate data_access calsses into this path", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
            {
                List<string> NameSapceDataAceess = txtPathAccessLayer.Text.Split('\\').ToList();
                _bussiness.NameSpaceDataAccess = NameSapceDataAceess[NameSapceDataAceess.Count - 1];
                _bussiness.GenerateAllFilesOfDataAccessLayerAndHelper(txtPathAccessLayer.Text, cbDatabaseNAme.Text);

                MessageBox.Show("Data Sccess Classes Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void btnBussinessLayer_Click(object sender, EventArgs e)
        {
            if (txtBussinessLayer.Text == "")
            {
                MessageBox.Show("Fill Tha Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (MessageBox.Show("Are you sure you want to generate bussiness calsses into this path", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<string> NameSpaceBussiness = txtBussinessLayer.Text.Split('\\').ToList();
                _bussiness.NameSpaceBussiness = NameSpaceBussiness[NameSpaceBussiness.Count - 1];
                _bussiness.GenerateAllFilesOfBussinessLayer(txtBussinessLayer.Text, cbDatabaseNAme.Text);
                
                MessageBox.Show("Bussiness Classes Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
                return;

            }
        }

        private void btnAppconfig_Click(object sender, EventArgs e)
        {
            if (txtAppconfig.Text == "")
            {
                MessageBox.Show("Fill Tha Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (MessageBox.Show("Are you sure you want to generate App.config file into this path", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bussiness.GenerateAppConfig(txtAppconfig.Text, cbDatabaseNAme.Text);
                MessageBox.Show("App.config Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                return;
            }
        }

        private void btnGeneratetotheSelectedTable_Click(object sender, EventArgs e)
        {
            if (!HandleAll())
                return;

            if (MessageBox.Show("Are you sure you want to generate stored procedures  for this table", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bussiness.ExcuteStoredProcedureDircteInSql(_selectedTable,cbDatabaseNAme.Text);
                MessageBox.Show("Stored Procedures Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                return;
            }
        }

        private void btnGeneratetoAllTable_Click(object sender, EventArgs e)
        {
            if (cbDatabaseNAme.Text == "")
            {
                MessageBox.Show("Select Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to generate stored procedures  for all table", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _bussiness.GenerateAllFilesOfStoredProcedure(cbDatabaseNAme.Text);
                MessageBox.Show("Stored Procedures Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        
    }
}