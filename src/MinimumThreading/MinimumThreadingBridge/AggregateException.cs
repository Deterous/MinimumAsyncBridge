#if NET40_OR_GREATER
using System;
using System.Runtime.CompilerServices;
using System.Threading;
[assembly: TypeForwardedTo(typeof(AggregateException))]
#else
using System.Collections.ObjectModel;
using System.Linq;

namespace System
{
    public class AggregateException : Exception
    {
        public ReadOnlyCollection<Exception> InnerExceptions { get; }

        public AggregateException(params Exception[] exceptions) : base("", exceptions.FirstOrDefault())
        {
            InnerExceptions = new ReadOnlyCollection<Exception>(exceptions);
        }
    }
}
#endif
