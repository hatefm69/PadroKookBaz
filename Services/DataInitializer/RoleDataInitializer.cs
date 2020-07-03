//using Data.Repositories;
//using Entities.User;
//using System.Linq;

//namespace Services.DataInitializer
//{
//    public class RoleDataInitializer : IDataInitializer
//    {
//        private readonly IRepository<Role> repository;

//        public RoleDataInitializer(IRepository<Role> repository)
//        {
//            this.repository = repository;
//        }

//        public void InitializeData()
//        {
//            if (!repository.TableNoTracking.Any())
//            {
//                repository.Add(new Role { Name = "User" ,Description="کاربر عادی"}, false);
//                repository.Add(new Role { Name = "Admin",Description="مدیران سایت" });
//            }
//        }
//    }
//}
