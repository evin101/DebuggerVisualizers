using System;
using System.IO;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace MyUtils.DebuggerVisualizers.Internal
{
    public class VisualizerObjectSourceBase : VisualizerObjectSource
    {
        protected IProxyObjectFactory Factory { get; private set; }

        protected VisualizerObjectSourceBase(IProxyObjectFactory factory)
        {
            Factory = factory;
        }

        public override void GetData(object target, Stream outgoingData)
        {
            Serialize(outgoingData, Factory.CreateProxy(target));
        }
    }
}
