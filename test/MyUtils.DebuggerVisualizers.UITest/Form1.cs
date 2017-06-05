using Microsoft.VisualStudio.DebuggerVisualizers;
using MyUtils.DebuggerVisualizers.CollectionVisualizer;
using MyUtils.DebuggerVisualizers.DataSetVisualizer;
using MyUtils.DebuggerVisualizers.KeyValueVisualizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyUtils.DebuggerVisualizers.UITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CollectionVisualizerDialogButton_Click(object sender, EventArgs e)
        {

            var lst = new[]
            {
                new { Text = "First", No = 1 },
                new { Text = "Seccond", No = 2 },
            }.ToList();

            var lst2 = new[]
{
                1,2,3,4,5
            }.ToList();


            var lst3 = new List<object>
            {
                new object()
            };

            Utils.ShowVisualizer<CollectionVisualizerDialog, CollectionVisualizerObjectSource>(lst);
            Utils.ShowVisualizer<CollectionVisualizerDialog, CollectionVisualizerObjectSource>(lst2);
            Utils.ShowVisualizer<CollectionVisualizerDialog, CollectionVisualizerObjectSource>(lst3);
        }

        private void DataSetVisualizerDialogButton_Click(object sender, EventArgs e)
        {
            var ds = new DataSet("MyDataSet");

            var tables = Enumerable.Range(1, 5).Select(i => new DataTable("DataTable" + i.ToString())).ToArray();


            foreach (var t in tables)
            {
                if (t.Columns.Count == 0)
                {
                    t.Columns.Add(t.GetHashCode().ToString() + "A");
                    t.Columns.Add(t.GetHashCode().ToString() + "B");
                    t.Columns.Add(t.GetHashCode().ToString() + "C");
                }

                for (var i = 0; i < 10; i++)
                {
                    t.Rows.Add(t.NewRow());
                    t.Rows[t.Rows.Count - 1].SetField(0, "aa");
                    t.Rows[t.Rows.Count - 1].SetField(1, "bb");
                    t.Rows[t.Rows.Count - 1].SetField(2, "cc");
                }

            }
            ds.Tables.AddRange(tables);
            Utils.ShowVisualizer<DataSetVisualizerDialog, VisualizerObjectSource>(ds);

        }

        private void KeyValueVisualizerDialogButton_Click(object sender, EventArgs e)
        {
            var obj = new Dictionary<string, object>()
            {
                {"1","Foo" },
                {"2","Bar" },
                {"3","12345" },
            };

            Utils.ShowVisualizer<KeyValueVisualizerDialog, KeyValueVisualizerObjectSource>(obj);
        }
    }
}
