///////////////////////////////////////////////////////////
//  TipoDeEntrada.cs
//  Implementation of the Class TipoDeEntrada
//  Generated by Enterprise Architect
//  Created on:      26-jun.-2021 19:14:20
///////////////////////////////////////////////////////////

namespace MuseoPictoricoG11.Modelos
{

    public class TipoDeEntrada : Entidad
    {
        private int id;
        private string nombre;

        public TipoDeEntrada()
        {

        }

        ~TipoDeEntrada()
        {

        }

        public virtual string Nombre { get => nombre; set => nombre = value; }

        public virtual string getNombre()
        {

            return this.nombre;
        }

        /// 
        /// <param name="nombre"></param>
        public virtual void setNombre(string nombre)
        {

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
}//end TipoDeEntrada