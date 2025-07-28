﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Identity.Models
{
    public class AppIdentityDBContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDBContext(DbContextOptions<AppIdentityDBContext> options) :base(options)
        {
                
        }
    }
}
