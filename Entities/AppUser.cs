using System.Reflection;
using System.Reflection.Metadata;
using System.Security.AccessControl;
namespace API.Entities
{
    public class AppUser
    {
       public int Id { get; set; }

       public string UserName { get; set; }              
    }
}