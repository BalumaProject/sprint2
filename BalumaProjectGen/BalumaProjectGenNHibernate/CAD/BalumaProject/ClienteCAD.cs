
using System;
using System.Text;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.Exceptions;

namespace BalumaProjectGenNHibernate.CAD.BalumaProject
{
public partial class ClienteCAD : BasicCAD, IClienteCAD
{
public ClienteCAD() : base ()
{
}

public ClienteCAD(ISession sessionAux) : base (sessionAux)
{
}



public ClienteEN ReadOIDDefault (string NIF)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), NIF);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}


public string CrearCliente (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (cliente);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cliente.NIF;
}

public void ModificarCliente (ClienteEN cliente)
{
        try
        {
                SessionInitializeTransaction ();
                ClienteEN clienteEN = (ClienteEN)session.Load (typeof(ClienteEN), cliente.NIF);

                clienteEN.Apellidos = cliente.Apellidos;


                clienteEN.Password = cliente.Password;


                clienteEN.Username = cliente.Username;


                clienteEN.Nombre = cliente.Nombre;


                clienteEN.Localidad = cliente.Localidad;


                clienteEN.CodigoPostal = cliente.CodigoPostal;


                clienteEN.NumCuentaBancaria = cliente.NumCuentaBancaria;


                clienteEN.Telefono = cliente.Telefono;


                clienteEN.Email = cliente.Email;


                clienteEN.Url_foto = cliente.Url_foto;

                session.Update (clienteEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ClienteEN> ObtenerTodos (int first, int size)
{
        System.Collections.Generic.IList<ClienteEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ClienteEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ClienteEN>();
                else
                        result = session.CreateCriteria (typeof(ClienteEN)).List<ClienteEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ClienteEN Obtener (string NIF)
{
        ClienteEN clienteEN = null;

        try
        {
                SessionInitializeTransaction ();
                clienteEN = (ClienteEN)session.Get (typeof(ClienteEN), NIF);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BalumaProjectGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BalumaProjectGenNHibernate.Exceptions.DataLayerException ("Error in ClienteCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return clienteEN;
}
}
}
