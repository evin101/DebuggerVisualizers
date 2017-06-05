namespace MyUtils.DebuggerVisualizers.Internal
{
    public interface IProxyObjectFactory
    {
        object CreateProxy(object target);
    }
}
