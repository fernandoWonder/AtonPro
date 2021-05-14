using Domain.Domain.Entities.Temp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appplication.Statics
{
    public static class TurnoCurrent
    {
        static Turno turnoCurrent;
        public static void initialize(Turno turno)
        {
            turnoCurrent = turno;
        }

        public static Turno getTurnoCurrent()
        {
            return turnoCurrent;
        }
    }
}
