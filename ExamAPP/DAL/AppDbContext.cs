using ExamAPP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ExamAPP.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
    }
}
