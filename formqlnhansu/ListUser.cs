using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formqlnhansu
{
    public class ListUser
    {
        private static ListUser instance; 

        private List<User> listAccountUser;

        public List<User> ListAccountUser { get => listAccountUser; set => listAccountUser = value;  }

        public static ListUser Instance
        {
            get
            {
                if(instance == null)
                    instance = new ListUser();
                return instance;
            }
        }

        private ListUser ()
        {
            listAccountUser = new List<User> ();
            listAccountUser.Add(new User("thuan","123"));
            listAccountUser.Add(new User("quocthai", "123456789"));
        }
    }
}
