using System.ComponentModel.DataAnnotations;

namespace QLNH_API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

       
    }
}
