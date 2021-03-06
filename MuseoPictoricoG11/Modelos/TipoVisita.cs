///////////////////////////////////////////////////////////
//  TipoVisita.cs
//  Implementation of the Class TipoVisita
//  Generated by Enterprise Architect
//  Created on:      26-jun.-2021 19:14:33
///////////////////////////////////////////////////////////

namespace MuseoPictoricoG11.Modelos
{


    public class TipoVisita : Entidad
    {
        private int id;
        private string nombre;

        public TipoVisita()
        {

        }

        ~TipoVisita()
        {

        }

        public virtual string Nombre { get => nombre; set => nombre = value; }

        public virtual string getNombre()
        {

            return this.nombre;
        }

        public virtual void setId(int id)
        {
            this.id = id;
        }

        public virtual int getId()
        {
            return this.id;
        }
    }
}//end TipoVisita