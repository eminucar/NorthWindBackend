using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception
    {
        public virtual void OnBefore()
        {
            int a = 0;
        }

        public virtual void OnAfter()
        {

        }

    }
}
