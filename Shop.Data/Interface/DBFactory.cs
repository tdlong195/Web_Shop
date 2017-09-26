namespace Shop.Data.Interface
{
    public class DBFactory : Disposable, IDbFactory
    {
        private ShopDBContext dbContext;

        public ShopDBContext Init()
        {
            return dbContext ?? (dbContext = new ShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}