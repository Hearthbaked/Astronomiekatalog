using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomiekatalog
{
    class Sternsystem
    {
        private long idSternsystem;
        private int anzahl_sterne;
        private string sternsystem_name;
        private string sternsystem_typ;
        private string asteroidenfelder;
        private string sternsystem_stern;
        private string spektralklasse;
        private float sternsystem_alter;
        private float sternsystem_masse;
        private float sternsystem_absolute_helligkeit;

        public long GetIdSternsystem()
        {
            return idSternsystem;
        }

        public Sternsystem(long idSternsystem, int anzahl_sterne, string sternsystem_name, string sternsystem_typ, string asteroidenfelder,
                           string sternsystem_stern, string spektralklasse, float sternsystem_alter, float sternsystem_masse, 
                           float sternsystem_absolute_helligkeit)
        {
            this.idSternsystem = idSternsystem;
            this.anzahl_sterne = anzahl_sterne;
            this.sternsystem_name = sternsystem_name;
            this.sternsystem_typ = sternsystem_typ;
            this.asteroidenfelder = asteroidenfelder;
            this.sternsystem_stern = sternsystem_stern;
            this.spektralklasse = spektralklasse;
            this.sternsystem_alter = sternsystem_alter;
            this.sternsystem_masse = sternsystem_masse;
            this.sternsystem_absolute_helligkeit = sternsystem_absolute_helligkeit;
        }

        public override string ToString()
        {
            return anzahl_sterne + "Sterne" + "||||" + sternsystem_name + "||||" + sternsystem_typ + "||||" + asteroidenfelder + "||||" + sternsystem_stern + "||||" + spektralklasse +
                  "||||" + sternsystem_alter + "Milliarden Jahre" + "||||" + sternsystem_masse + "Sonnenmassen" + "||||" + sternsystem_absolute_helligkeit + "mag(Magnitude)";
        }
    }
}
