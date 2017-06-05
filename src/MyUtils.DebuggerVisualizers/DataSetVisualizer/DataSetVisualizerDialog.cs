using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using MyUtils.DebuggerVisualizers.DataSetVisualizer.Forms;

namespace MyUtils.DebuggerVisualizers.DataSetVisualizer
{
    public class DataSetVisualizerDialog : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var entity = (DataSet)objectProvider.GetObject();

            using (var dialog = new DataSetView(entity))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                windowService.ShowDialog(dialog);
            }
        }
    }
}
