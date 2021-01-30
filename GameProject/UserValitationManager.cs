using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValitationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Birthdate == 1985 && gamer.FirstName == "Hilal" && gamer.LastName ==" Günay" && gamer.IdentityNumber == 1234)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
