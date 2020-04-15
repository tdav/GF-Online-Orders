using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using UniPos.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace UniPos.Core
{
    public class UserService : Repository<tbUser>, IRepository<tbUser>
    {
        private MyDbContext db;
        private IConfiguration config;

        public UserService(MyDbContext dbContext, IConfiguration Configuration) : base(dbContext) 
        {
            db = dbContext; 
            config = Configuration;
        }


        public viUser Authenticate(string username, string password)
        {
            viUser usr = new viUser();
 

            var res = db.tbUser.Include(x => x.Role)
                               .SingleOrDefault(x => x.Username == username && x.Password == password);

            if (res == null)  return null;
                      
             
            var SecretStr = config.GetSection("JwtToken:SecretKey").Value;
            var key = Encoding.ASCII.GetBytes(SecretStr);
             
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, res.Id.ToString()),
                new Claim(ClaimTypes.Role, res.Role.UserAccess)
            };

            JwtSecurityToken token = new JwtSecurityToken(
                //issuer: issuer,
                //audience: issuer,
                claims: authClaims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();   
            
            usr.Token = handler.WriteToken(token);
            usr.FirstName = res.FirstName;
            usr.LastName = res.LastName;
            usr.Username = res.Username;
            usr.Access = res.Role.UserAccess;
            usr.Id = res.Id;

            return usr;
        }

        public IEnumerable<tbUser> GetAllUsers()
        {
            return db.tbUser.WithoutPasswords();
        }
    }
}
