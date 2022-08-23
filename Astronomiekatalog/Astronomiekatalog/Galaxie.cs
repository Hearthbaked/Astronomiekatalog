using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomiekatalog
{
    class Galaxie
    {
        private long idGalaxie;
        private int anzahl_sterne;
        private string galaxie_name;
        private string galaxie_typ;
        private string galaktischer_kern_schwarzes_loch;
        private float galaxie_absolute_helligkeit;
        private float galaxie_alter;
        private float galaxie_geschwindigkeit;
        private float masse_inkl_dunkle_materie;
        private float galaxie_dicke;
        private float galaxie_durchmesser;

        public long GetIdGalaxie()
        {
            return idGalaxie;
        }
        public Galaxie(long idGalaxie, int anzahl_sterne, string galaxie_name, string galaxie_typ, string galaktischer_kern_schwarzes_loch, float galaxie_absolute_helligkeit, float galaxie_alter, 
                       float galaxie_geschwindigkeit, float masse_inkl_dunkle_materie, float galaxie_dicke, float galaxie_durchmesser)
        {
            this.idGalaxie = idGalaxie;
            this.anzahl_sterne = anzahl_sterne;
            this.galaxie_name = galaxie_name;
            this.galaxie_typ = galaxie_typ;
            this.galaktischer_kern_schwarzes_loch = galaktischer_kern_schwarzes_loch;
            this.galaxie_absolute_helligkeit = galaxie_absolute_helligkeit;
            this.galaxie_alter = galaxie_alter;
            this.galaxie_geschwindigkeit = galaxie_geschwindigkeit;
            this.masse_inkl_dunkle_materie = masse_inkl_dunkle_materie;
            this.galaxie_dicke = galaxie_dicke;
            this.galaxie_durchmesser = galaxie_durchmesser;
        }
        public override string ToString()
        {
            return galaxie_name + "||||" + galaxie_typ + "||||" + galaktischer_kern_schwarzes_loch + "||||" + anzahl_sterne +"Milliarden"+ galaxie_absolute_helligkeit + "mag(Magnitude)" + "||||" + galaxie_alter + "Billionen Jahre" + "||||" + galaxie_geschwindigkeit +
                   "km/s" + "||||" + masse_inkl_dunkle_materie + "Billionen Sonnenmassen" + "||||" + galaxie_dicke + "Lichtjahre" + "||||" + galaxie_durchmesser + "Lichtjahre";
        }
    }
}
