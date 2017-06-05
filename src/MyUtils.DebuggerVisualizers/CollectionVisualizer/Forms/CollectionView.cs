using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using MyUtils.DebuggerVisualizers.CollectionVisualizer.Recources;

namespace MyUtils.DebuggerVisualizers.CollectionVisualizer.Forms
{
    public partial class CollectionView : Form
    {

        // データソース
        private DataTable _entities;
        public CollectionView()
        {
            InitializeComponent();
        }

        public CollectionView(DataTable entities) : this()
        {
            _entities = entities;
        }

        private void CollectionView_Load(object sender, EventArgs e)
        {
            TypeNameTextBox.Text = _entities.TableName;
            EntityGridView.DataSource = _entities;
            if (EntityGridView.Columns.Count > 0)
            {
                EntityGridView.Columns[EntityGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (DataGridViewColumn c in EntityGridView.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                if (EntityGridView.Columns.Count == 1 && EntityGridView.Columns[0].DataPropertyName == Constants.ALTERNATE_PROPERTY_NAME)
                {
                    EntityGridView.Columns[0].HeaderText = Properties.Resources.CollectionVisualizerDefaultColumnHeaderName;
                }

            }
        }

   }
}
