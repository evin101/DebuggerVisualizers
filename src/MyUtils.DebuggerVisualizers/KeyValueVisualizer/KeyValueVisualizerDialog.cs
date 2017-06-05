using Microsoft.VisualStudio.DebuggerVisualizers;
using MyUtils.DebuggerVisualizers.KeyValueVisualizer.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtils.DebuggerVisualizers.KeyValueVisualizer
{
    public class KeyValueVisualizerDialog : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var entity = (DataTable)objectProvider.GetObject();

            using (var dialog = new KeyValueView(entity))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                windowService.ShowDialog(dialog);
            }
        }
    }
}
