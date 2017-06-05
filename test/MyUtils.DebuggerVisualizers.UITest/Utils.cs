using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUtils.DebuggerVisualizers.UITest
{
    public class Utils
    {
        public static void ShowVisualizer<TVisualizer, TObjectSource>(object target) where TVisualizer : DialogDebuggerVisualizer
        {
            VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(target, typeof(TVisualizer), typeof(TObjectSource));
            visualizerHost.ShowVisualizer();
        }
    }
}
