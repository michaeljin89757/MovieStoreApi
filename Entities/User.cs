using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public String Email { get; set; }
        public String HashedPassword { get; set; }
        public String Salt { get; set; }
        public DateTime CreateDate { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
