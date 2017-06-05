using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using MyUtils.DebuggerVisualizers.CollectionVisualizer.Recources;
using MyUtils.DebuggerVisualizers.Properties;

namespace MyUtils.DebuggerVisualizers.KeyValueVisualizer.Forms
{
    public partial class KeyValueView : Form
    {

        // データソース
        private DataTable _entities;
        public KeyValueView()
        {
            InitializeComponent();
        }

        public KeyValueView(DataTable entities) : this()
        {
            _entities = entities;
        }

        private void CollectionView_Load(object sender, EventArgs e)
        {
            TypeNameTextBox.Text = _entities.TableName;
            EntityGridView.Rows.Clear();
            EntityGridView.DataSource = _entities;
            if (EntityGridView.Columns.Count > 0)
            {
                EntityGridView.Columns[EntityGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                foreach (DataGridViewColumn c in EntityGridView.Columns)
                {
                    c.SortMode = DataGridViewColumnSortMode.NotSortable;

                    switch (c.Name)
                    {
                        case "Key":
                            c.HeaderText = Resources.KeyValueVisualizerKeyColumnHeader;
                            break;
                        case "Value":
                            c.HeaderText = Resources.KeyValueVisualizerValueColumnHeader;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
   }
}
