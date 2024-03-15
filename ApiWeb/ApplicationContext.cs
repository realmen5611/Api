using ApiWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiWeb
{
    public class ApplicationContext : DbContext
    {
        private const string Password = "admin";
        private const string DbName = "mydb";
        private const int Port = 3306;
        private const string Server = "127.0.0.1";
        private const string UserName = "root";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"Server={Server};database={DbName};Port={Port};User id={UserName};Password={Password}", new MySqlServerVersion(new Version(8, 0, 35)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersEntity>().HasOne(x => x.Role).WithMany().HasForeignKey(x => x.idRole).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<RoleEntity> Role { get; set; }
        public DbSet<DolshnostEntity> Dolshnost { get; set; }
        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<NarusheniaEmpEntity> NarusheniaEmp { get; set; }
        public DbSet<NarusheteliEntity> Narusheteli { get; set; }
        public DbSet<PolEntity> Pol { get; set; }
        public DbSet<PrestupleniaEntity> Prestuplenia { get; set; }
        public DbSet<SanctionEntity> Sanction { get; set; }
        public DbSet<VidPrestupleniaEntity> VidPrestuplenia { get; set; }
        public DbSet<ListAllNarusheniEntity> ListAllNarusheni { get; set; }
    }
}
