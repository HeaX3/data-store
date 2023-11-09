using System.Collections.Generic;

namespace DataStores
{
    public abstract class DataStore
    {
        protected abstract IEnumerable<DataModule> modules { get; }

        public void Initialize()
        {
            foreach(var module in modules) module.Initialize();
        }
    }
}
