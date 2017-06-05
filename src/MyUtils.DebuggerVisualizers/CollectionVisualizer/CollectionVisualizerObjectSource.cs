using System;
using System.Collections.Generic;
using System.Linq;
using MyUtils.DebuggerVisualizers.Internal;
using System.Diagnostics;

namespace MyUtils.DebuggerVisualizers.CollectionVisualizer
{
    public class CollectionVisualizerObjectSource : VisualizerObjectSourceBase
    {
        public CollectionVisualizerObjectSource(): base(new CollectionProxyFactory())
        {
        }
    }
}
