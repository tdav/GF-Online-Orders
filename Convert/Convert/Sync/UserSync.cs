using System;
using UniPos.Models;

namespace Convert
{

    public class UserSync
    {
        public static void Run(Apteka.SqlServer.AptekaSqlServerDbContext sqlDb, MyDbContext pgDb)
        {

            var sr = new spRole()
            {
                Name = "admin",
                UserAccess = "999;1;2;3",
                CreateDate = DateTime.Now,
                CreateUser = 1,
                Status = 1
            };

            var sl = new spAccessList()
            {
                Id = 999,
                Name = "admin",
                CreateDate = DateTime.Now,
                CreateUser = 1,
                Status = 1
            };

            pgDb.tbUser.Add
                (
                    new tbUser()
                    {
                        FirstName = "admin",
                        LastName = "admin",
                        Role = sr,
                        Status = 1,
                        CreateDate = DateTime.Now,
                        CreateUser = 1,
                        Username = "admin",
                        Password = "2010"
                    }
                );

            pgDb.ChangeTracker.DetectChanges();
            pgDb.SaveChanges();
        }
    }
}