using RiaPlus.Domain.Entities;
using System.Data.Entity;

namespace RiaPlus.Domain.Concrete
{
    //DbContext автоматичне буде визначати властивість для кожної таблиці в базі даних
    public class EFDbContext : DbContext
    {
        //          Модель     Таблиця
        public DbSet<Product> Products { get; set; }

        // web.config conn string
    }
}
