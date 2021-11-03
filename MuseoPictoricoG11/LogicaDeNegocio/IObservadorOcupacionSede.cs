using System;

namespace MuseoPictoricoG11.LogicaDeNegocio
{
    public interface IObservadorOcupacionSede
    {
        void actualizarCantidadVisitantes(DateTime fechaHoraActualizacion, int cantVisitantes, int capacidadSede);
    }
}
