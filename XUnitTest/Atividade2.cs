using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public static class Atividade2
    {

        public static bool ValidarEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
