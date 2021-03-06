
using System;

namespace BalumaProjectGenNHibernate.EN.BalumaProject
{
public partial class ClienteEN                  :                           BalumaProjectGenNHibernate.EN.BalumaProject.UsuarioEN


{
/**
 *
 */

private string localidad;

/**
 *
 */

private string codigoPostal;

/**
 *
 */

private string numCuentaBancaria;

/**
 *
 */

private string telefono;

/**
 *
 */

private System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedidos;

/**
 *
 */

private string email;

/**
 *
 */

private string url_foto;





public virtual string Localidad {
        get { return localidad; } set { localidad = value;  }
}


public virtual string CodigoPostal {
        get { return codigoPostal; } set { codigoPostal = value;  }
}


public virtual string NumCuentaBancaria {
        get { return numCuentaBancaria; } set { numCuentaBancaria = value;  }
}


public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> Pedidos {
        get { return pedidos; } set { pedidos = value;  }
}


public virtual string Email {
        get { return email; } set { email = value;  }
}


public virtual string Url_foto {
        get { return url_foto; } set { url_foto = value;  }
}





public ClienteEN() : base ()
{
        pedidos = new System.Collections.Generic.List<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN>();
}



public ClienteEN(string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedidos, string email, string url_foto, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.init (nIF, localidad, codigoPostal, numCuentaBancaria, telefono, pedidos, email, url_foto, apellidos, password, username, validar, nombre);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (cliente.NIF, cliente.Localidad, cliente.CodigoPostal, cliente.NumCuentaBancaria, cliente.Telefono, cliente.Pedidos, cliente.Email, cliente.Url_foto, cliente.Apellidos, cliente.Password, cliente.Username, cliente.Validar, cliente.Nombre);
}

private void init (string nIF, string localidad, string codigoPostal, string numCuentaBancaria, string telefono, System.Collections.Generic.IList<BalumaProjectGenNHibernate.EN.BalumaProject.PedidoEN> pedidos, string email, string url_foto, string apellidos, string password, string username, BalumaProjectGenNHibernate.EN.BalumaProject.ValidarEN validar, string nombre)
{
        this.NIF = NIF;


        this.Localidad = localidad;

        this.CodigoPostal = codigoPostal;

        this.NumCuentaBancaria = numCuentaBancaria;

        this.Telefono = telefono;

        this.Pedidos = pedidos;

        this.Email = email;

        this.Url_foto = url_foto;

        this.Apellidos = apellidos;

        this.Password = password;

        this.Username = username;

        this.Validar = validar;

        this.Nombre = nombre;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (NIF.Equals (t.NIF))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NIF.GetHashCode ();
        return hash;
}
}
}
