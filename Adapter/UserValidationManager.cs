using System;
using TCKimlikNoDogrulama.Core;

namespace GameSimulation
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            
            if (new TCKimlikNoDogrulamaCORE(gamer.IdNo, gamer.FirstName, gamer.LastName, gamer.DateYear).KisiVarMi())
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

