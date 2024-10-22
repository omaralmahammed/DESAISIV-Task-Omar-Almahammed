using Microsoft.EntityFrameworkCore;


namespace DESAISIV_Task_Omar_Almahammed.models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }


    }
}
