using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using MyUtils.DebuggerVisualizers.CollectionVisualizer.Forms;

namespace MyUtils.DebuggerVisualizers.CollectionVisualizer
{
    public class CollectionVisualizerDialog : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var entity = (DataTable)objectProvider.GetObject();

            using (var dialog = new CollectionView(entity))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                windowService.ShowDialog(dialog);
            }
        }
    }
}
