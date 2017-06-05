using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using MyUtils.DebuggerVisualizers.CollectionVisualizer;
using MyUtils.DebuggerVisualizers.CollectionVisualizer.Recources;


[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(List<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(LinkedList<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(LinkedList<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(ISet<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(SortedSet<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(HashSet<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(IList<>),
        Description = Constants.VISUALIZER_DESCRIPTION)]

[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
        typeof(CollectionVisualizerObjectSource),
        Target = typeof(DataTable),
        Description = Constants.VISUALIZER_DESCRIPTION)]

#if !NET40
//[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
//        typeof(CollectionVisualizerObjectSource),
//        Target = typeof(IReadOnlyList<>),
//        Description = "エンティティ ビジュアライザ")]

//[assembly: DebuggerVisualizer(typeof(CollectionVisualizerDialog),
//        typeof(CollectionVisualizerObjectSource),
//        Target = typeof(IReadOnlyCollection<>),
//        Description = "エンティティ ビジュアライザ")]
#endif