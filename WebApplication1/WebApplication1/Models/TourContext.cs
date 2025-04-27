using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models

{
    public class TourContext : DbContext
    {
        public TourContext(DbContextOptions<TourContext> options) : base(options) { }

        public DbSet<Traveler> Traveler { get; set; }
        public DbSet<Trip> Trip { get; set; }

        public DbSet<UserLogin> UserLogin { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip { TripId = "J", Name = "Jerusalem", Date = DateTime.Parse("2023-08-02 07:00"),Price="600$",Remaining_Seats=2},
                new Trip { TripId = "B", Name = "Bethlehem", Date = DateTime.Parse("2023-07-02 02:00"), Price = "500$", Remaining_Seats =10},
                new Trip { TripId = "C", Name = "Jericho", Date = DateTime.Parse("2023-07-15 05:00"), Price = "800$", Remaining_Seats = 7}
            );
            modelBuilder.Entity<Traveler>().HasData(
                new Traveler {TravelerId= 1,Name = "Ahmad Yahya", Age = 20,Email="Ahmad@gmail.com",Seats=2,TripId="B"},
                new Traveler {TravelerId = 2,Name = "Mujahed Eleyat", Age = 27,Email = "Mujahed@gmail.com",Seats = 1,TripId="J"},
                new Traveler {TravelerId = 3,Name = "Dunia Abdeljabbar", Age = 23,Email = "Dunia@gmail.com", Seats = 3, TripId = "C"}
            );
            modelBuilder.Entity<UserLogin>().HasData(
                new UserLogin {UserLoginId=1,Email="Ahmad@gmail.com",Password="123"},
                new UserLogin {UserLoginId=2,Email="Dunia@gmail.com",Password = "123"}
            );

        }
    }
}
