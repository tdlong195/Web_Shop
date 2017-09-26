using System;

namespace Shop.Data.Interface
{
    //giao tiep de khoi tao cac doi tuong entity
    public interface IDbFactory : IDisposable
    {
        ShopDBContext Init();
    }
}