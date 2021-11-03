using CapaPersistencia;
using MuseoPictoricoG11.Modelos;
using NHibernate;
using System;
using System.Collections.Generic;

namespace MuseoPictoricoG11.Repositorio
{
    public abstract class NhRepositorio<TEntidad> where TEntidad : Entidad
    {
        public ISession Session;

        protected NhRepositorio()
        {
            Session = FachadaPersistencia.getSession();
        }

        public TEntidad ConsultarPorId(int id)
        {
            return Session.QueryOver<TEntidad>().Where(x => x.Id == id).SingleOrDefault<TEntidad>();
        }

        public TEntidad Guardar(TEntidad entidad)
        {
            //if (!Session.IsOpen) Session = sesionFactory.OpenSession();

            using (ITransaction tx = Session.BeginTransaction())
            {
                try
                {
                    Session.SaveOrUpdate(entidad);
                    tx.Commit();
                    tx.Dispose();
                }
                catch (Exception exception)
                {
                    string innerExcepcionMesage = "";
                    if (exception.InnerException != null)
                        innerExcepcionMesage = exception.InnerException.Message;

                    tx.Rollback();
                    tx.Dispose();
                }
                return entidad;
            }

        }

        public IList<TEntidad> ConsultarTodos()
        {
            return Session.QueryOver<TEntidad>().List<TEntidad>();
        }

        public void Eliminar(TEntidad entidad)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                try
                {
                    Session.Delete(entidad);
                    tx.Commit();
                    tx.Dispose();
                }
                catch (Exception exception)
                {
                    string innerExcepcionMesage = "";
                    if (exception.InnerException != null)
                        innerExcepcionMesage = exception.InnerException.Message;

                    tx.Rollback();
                    tx.Dispose();
                }
            }
        }
    }
}
