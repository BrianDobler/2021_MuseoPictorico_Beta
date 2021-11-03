namespace MuseoPictoricoG11.LogicaDeNegocio
{
    public interface ISujetoOcupacionSede
    {
        void desuscribir(IObservadorOcupacionSede observador);
        void suscribir(IObservadorOcupacionSede observador);
        void notificar();
    }
}
