using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Threading;

namespace Jint {
    public class CachedTypeResolver : ITypeResolver {
        static Dictionary<string, Type> _Cache = new Dictionary<string, Type>();
        static ReaderWriterLock rwl = new ReaderWriterLock();

        public Type ResolveType(string fullname) {
            rwl.AcquireReaderLock(Timeout.Infinite);

            try {
                if (_Cache.ContainsKey(fullname)) {
                    return _Cache[fullname];
                }
            }
            finally {
                rwl.ReleaseReaderLock();
            }

            Type type = null;
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies()) {
                type = a.GetType(fullname, false, false);

                if (type != null) {
                    break;
                }
            }

            rwl.AcquireWriterLock(Timeout.Infinite);

            try {
                _Cache.Add(fullname, type);
                return type;
            }
            finally {
                rwl.ReleaseWriterLock();
            }
        }
    }
}
