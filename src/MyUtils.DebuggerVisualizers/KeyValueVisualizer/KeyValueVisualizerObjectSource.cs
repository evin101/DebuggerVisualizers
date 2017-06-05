using MyUtils.DebuggerVisualizers.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtils.DebuggerVisualizers.KeyValueVisualizer
{
    public class KeyValueVisualizerObjectSource : VisualizerObjectSourceBase
    {

        public KeyValueVisualizerObjectSource() : base(new KeyValueProxyFactory())
        {
        }
    }
}
