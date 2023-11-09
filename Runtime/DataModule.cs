namespace DataStores
{
    public abstract class DataModule : IDataModule
    {
        public void Initialize()
        {
            OnInitialize();
        }

        protected virtual void OnInitialize()
        {
            
        }
    }
    
    public abstract class DataModule<T> : DataModule where T : DataStore
    {
        public T store { get; private set; }
        
        public DataModule(T store)
        {
            this.store = store;
        }
    }
}