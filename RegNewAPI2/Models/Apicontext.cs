using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace RegNewAPI2.Models
{
    public class Apicontext : DbContext
    {

        public Apicontext(DbContextOptions<Apicontext> options) : base(options)
        {

        }
        public DbSet<ApiModel> MVCDemo9 { get; set; }

    }

}