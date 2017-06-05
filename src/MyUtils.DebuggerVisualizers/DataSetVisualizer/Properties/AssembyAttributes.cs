using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using MyUtils.DebuggerVisualizers.DataSetVisualizer;
using MyUtils.DebuggerVisualizers.DataSetVisualizer.Recources;


[assembly: DebuggerVisualizer(typeof(DataSetVisualizerDialog),
        Target = typeof(DataSet),
        Description = Constants.VISUALIZER_DESCRIPTION)]
