﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MediaShare.Authorization.Roles;
using MediaShare.Authorization.Users;
using MediaShare.MultiTenancy;
using MediaShare.Media;

namespace MediaShare.EntityFrameworkCore
{
    public class MediaShareDbContext : AbpZeroDbContext<Tenant, Role, User, MediaShareDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Video> Videos { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Setting> MSettings { get; set; }

        public DbSet<VideoFavRelation> VideoFavRelations { get; set; }

        public DbSet<ResDir> ResDirs { get; set; }

        public DbSet<ViewRecord> ViewRecord { get; set; }


        public MediaShareDbContext(DbContextOptions<MediaShareDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Filter("PersonFilter", (IHasPerson entity, int personId) => entity.PersonId == personId, 0);
        }
    }
}
