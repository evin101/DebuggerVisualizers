using MyUtils.DebuggerVisualizers.CollectionVisualizer.Recources;
using MyUtils.DebuggerVisualizers.KeyValueVisualizer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: DebuggerVisualizer(typeof(KeyValueVisualizerDialog),
        typeof(KeyValueVisualizerObjectSource),
        Target = typeof(Dictionary<,>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(KeyValueVisualizerDialog),
        typeof(KeyValueVisualizerObjectSource),
        Target = typeof(SortedDictionary<,>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(KeyValueVisualizerDialog),
        typeof(KeyValueVisualizerObjectSource),
        Target = typeof(NameValueCollection),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(KeyValueVisualizerDialog),
        typeof(KeyValueVisualizerObjectSource),
        Target = typeof(Hashtable),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(KeyValueVisualizerDialog),
        typeof(KeyValueVisualizerObjectSource),
        Target = typeof(IDictionary<,>),
        Description = Constants.VISUALIZER_DESCRIPTION)]
