

using System;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Criterion;
using NHibernate.Tool.hbm2ddl;
using Environment = System.Environment;



// @generated
namespace CapaPersistencia
{

    public enum SessionAction { Begin, Continue, End, BeginAndEnd }

    public class FachadaPersistencia
    {
        private static FachadaPersistencia estaSesion;
        private static ISessionFactory sesionFactory;

        private ISession m_Session;
        private String idiomaSqlServer;

        public static ISession getSession()
        {
            if (estaSesion == null)
            {
                estaSesion = new FachadaPersistencia();
                var configuration = new Configuration();
                configuration.DataBaseIntegration(db =>
                {
                    db.ConnectionProvider<DriverConnectionProvider>();
                    db.Dialect<MsSql2012Dialect>();
                    db.Driver<SqlClientDriver>();
                    db.ConnectionString = @"Server=localhost\sqlexpress;Database=MuseoPictorico;Integrated Security=True;";
                    db.BatchSize = 30;
                    db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                    db.Timeout = 20;
                    db.LogFormattedSql = true;
                    db.LogSqlInConsole = true;
                    db.HqlToSqlSubstitutions = "true 1, false 0, yes 'Y', no 'N'";
                });

                //var mapper = new ConventionModelMapper();
                var mapper = new ConventionModelMapper();
                var mappings = new[]
                    {
                            typeof(DetalleExposicionMap),
                            typeof(EmpleadoMap),
                            typeof(EntradaMap),
                            typeof(ExposicionMap),
                            typeof(ObraMap),
                            typeof(ReservaVisitaMap),
                            typeof(SedeMap),
                            typeof(SesionMap),
                            typeof(TarifaMap),
                            typeof(TipoDeEntradaMap),
                            typeof(TipoVisitaMap),
                            typeof(UsuarioMap)
                        };

                mapper.AddMappings(mappings);
                configuration.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

                //UpdateSchema(configuration);

                //el schemaExport es para construir la base de datos y BORRA todos los datos de la misma.
                new SchemaExport(configuration).Drop(false, true);
                new SchemaExport(configuration).Execute(false, true, false);

                //try
                {
                    sesionFactory = configuration.BuildSessionFactory();
                    estaSesion.m_Session = sesionFactory.OpenSession();
                }
                estaSesion.idiomaSqlServer = estaSesion.obtenerIdiomaDeSqlServer();
                //catch (Exception exception)
                //{
                //    string innerExcepcionMesage = "";
                //    if (exception.InnerException != null)
                //        innerExcepcionMesage = exception.InnerException.Message;

                //    MensajeBox.mensajeError("No se puede iniciar la aplicación por el siguiente error: \n" + exception.Message + " \n\n " + innerExcepcionMesage, true);
                //    //Application.Exit();
                //}
            }
            return estaSesion.m_Session;
        }

        private static void UpdateSchema(Configuration config)
        {
            string appPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            Action<string> updateExport = x => {
                using (var file = new System.IO.FileStream(appPath + @"\update.sql", System.IO.FileMode.Create, System.IO.FileAccess.Write))
                using (var sw = new System.IO.StreamWriter(file))
                {
                    sw.Write(x);
                    sw.Close();
                }
            };
            SchemaUpdate SchemaUpdater = new SchemaUpdate(config);
            SchemaUpdater.Execute(updateExport, true);

            //new SchemaUpdate(config).Execute(true, true);
        }
        public FachadaPersistencia nuevaSesion()
        {
            FachadaPersistencia nuevaFachada = new FachadaPersistencia();
            nuevaFachada.idiomaSqlServer = idiomaSqlServer;
            nuevaFachada.m_Session = sesionFactory.OpenSession();
            nuevaFachada.m_Session.Close();
            return nuevaFachada;
        }

        public String obtenerIdiomaDeSqlServer()
        {
            String sql = "select @@language as idioma";
            if (!m_Session.IsOpen) m_Session = sesionFactory.OpenSession();

            IQuery query = m_Session.CreateSQLQuery(sql);
            String result = (String)query.UniqueResult();

            return result;
        }


        public bool estadoConexion()
        {
            return m_Session.IsOpen;
        }

    }
}
