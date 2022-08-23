using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomiekatalog
{
    class Planet
    {
        private long idPlanet;
        private int anzahl_monde_satelliten;
        private string planet_name;
        private string planet_typ;
        private float umlauf_tage;
        private float planet_masse;
        private float planet_durchmesser;
        private float periphel_aphel;
        private float planet_druck;
        private float planet_temperatur;

        public long GetIdPlanet()
        {
            return idPlanet;
        }

        public Planet(long idPlanet, int anzahl_monde_satelliten, string planet_name, string planet_typ, float umlauf_tage, float planet_masse,
                      float planet_durchmesser, float periphel_aphel, float planet_druck, float planet_temperatur)
        {
            this.idPlanet = idPlanet;
            this.anzahl_monde_satelliten = anzahl_monde_satelliten;
            this.planet_name = planet_name;
            this.planet_typ = planet_typ;
            this.umlauf_tage = umlauf_tage;
            this.planet_masse = planet_masse;
            this.planet_durchmesser = planet_durchmesser;
            this.periphel_aphel = periphel_aphel;
            this.planet_druck = planet_druck;
            this.planet_temperatur = planet_temperatur;
        }
        public override string ToString()
        {
            return anzahl_monde_satelliten + "Trabanten/Satelliten/Monde" + planet_name + "||||" + planet_typ+ "||||" + umlauf_tage + "tage" + planet_masse + "||||" +
                   planet_durchmesser + "||||" + periphel_aphel + "AE" + planet_druck +"bar" + "||||" + planet_temperatur + "K";
        }
    }
}
