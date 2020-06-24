using Core.Utilities.Interceptors;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect: MethodInterception
    {
        public override void OnAfter()
        {
            base.OnAfter();
        }
    }
}
