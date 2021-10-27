using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLrentas
{
    public class seguridadBL
    {
        public bool Autorizar(string usuarios, string contrasenas)
        {
            if (usuarios =="admin" && contrasenas =="123")
            {
                return true;
            }
            else
            {
                if (usuarios == "user" && contrasenas == "456")
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
