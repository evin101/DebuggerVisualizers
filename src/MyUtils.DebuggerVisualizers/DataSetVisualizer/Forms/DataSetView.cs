using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms
{
    public partial class DataSetView : Form
    {

        // データソース
        private DataSet _dataSet;
        public DataSetView()
        {
            InitializeComponent();
        }

        public DataSetView(DataSet dataSet) : this()
        {
            _dataSet = dataSet;
        }

        private void DataSetView_Load(object sender, EventArgs e)
        {

            DataSetNameTextBox.Text = _dataSet.DataSetName;

            var firstContainer = GetGridContainer(DataTableTabControl);
            if (firstContainer != null && string.IsNullOrEmpty(firstContainer.Name))
            {
                firstContainer.Name = "defaultContainer";
            }
            var gridContainerName = firstContainer.Name;

            while (_dataSet.Tables.Count > DataTableTabControl.TabPages.Count)
            {
                var page = new TabPage();
                page.Controls.Add(new InitializedGridViewContainer() { Name = gridContainerName });
                DataTableTabControl.TabPages.Add(page);
            }


            for (var i = 0; i < _dataSet.Tables.Count; i++)
            {
                DataTableTabControl.TabPages[i].Text = _dataSet.Tables[i].TableName;
                var gridContainer = (InitializedGridViewContainer)DataTableTabControl.TabPages[i].Controls.Find(gridContainerName, true).FirstOrDefault();
                if (gridContainer != null)
                {
                    gridContainer.DataRowGridView.DataSource = _dataSet.Tables[i];
                }
            }
        }

        private InitializedGridViewContainer GetGridContainer(TabControl tabControl)
        {
            if (tabControl.TabPages.Count == 0)
            {
                return null;
            }
            return tabControl.TabPages[0].Controls.OfType<InitializedGridViewContainer>().FirstOrDefault();

        }
    }
}
