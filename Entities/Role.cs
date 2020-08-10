using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApi.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public String RoleName { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
