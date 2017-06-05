using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms
{
    public partial class InitializedGridViewContainer : UserControl
    {
        public InitializedGridViewContainer()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
    }
}
