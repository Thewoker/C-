using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class Persona
    {
        //Datos
        private string name;
        private int age;
        private bool enActividadLaboral;
        

        //Contructor
        public Persona(string name, int age)
        {
            this.name = name;
            this.age = age;

            //Es un trabajador activo (por su edad)
            if (age >= 65)
            {
                enActividadLaboral = false;
            }
            else enActividadLaboral=true;
        }

        //Getters & Setters

        public bool EnActividadLaboral
        {
            get { return enActividadLaboral; }
        }

        public override string ToString()
        {
            return $"Cliente: {name}\nEdad: {age}\n";
        }


    }
}
