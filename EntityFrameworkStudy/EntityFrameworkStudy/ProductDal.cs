using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entry() metodu: Bu yöntem çağrıldığında, Entity Framework, belirtilen nesneyi izlemeye alır
//ve bu nesnenin durumunu takip eder. Bu durum, nesnenin eklenmiş, güncellenmiş veya silinmiş olduğunu belirler.
//Bu sayede, SaveChanges() metodunu çağırdığınızda, Entity Framework değişiklikleri algılar
//ve ilgili SQL işlemlerini veritabanına uygular.

// Yani, context.Entry(product) ifadesi, belirli bir nesnenin izlenmesi için Entity Framework'e bir yol sağlar
// ve bu nesnenin durumunun veritabanı işlemleri için uygun şekilde ayarlanmasını sağlar.

namespace EntityFrameworkStudy
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key) // Bu şekilde direk veri tabanı sorgulanır. 
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price) 
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.FirstOrDefault(p => p.Id == id);
                return result;

                // Çıktıda tek bir sonuç oluşacağı için ToList yazılmasına gerek yoktur. 
                // Onun yerine FirstOrDefault metodu yazılır. Sonuç varsa ise sonucu verir.
                // Eğer sonuç yok ise null döndürür.

                //SingleOrDefault, birden fazla varsa hata verir.
                //FirstOrDefault, birden fazla varsa ilk olanı verir. 
            }
        }


        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // context.Products.Add(product);
                var entity = context.Entry(product); 
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); //Girilen product'ı veri tabınındaki product ile ilişkilendiriyor(eşitliyor).
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }

   
    

}
