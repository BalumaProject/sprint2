
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;
using BalumaProjectGenNHibernate.Enumerated.BalumaProject;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/

        /*
         * Inicializaci�n de datos previos a la demo.
         * La creaci�n de algunas entidades son necesarias antes de poder proceder
         * con la ejecuci�n del programa.
         * */
        AdministradorCEN admin = new AdministradorCEN ();

        admin.CrearAdministrador ("admin", "admin", "admin", "admin", "admin");
        CategoriaCEN categoria = new CategoriaCEN ();
        categoria.CrearCategoria ("cuadra", "vela");
        categoria.CrearCategoria ("latina", "vela");
        categoria.CrearCategoria ("de cuchillo", "vela");

        ClienteCEN cliente = new ClienteCEN ();
        cliente.CrearCliente ("a a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a");
        cliente.CrearCliente ("cliente1 cliente1", "cliente1", "cliente1", "cliente1",
                "cliente1", "cliente1", "cliente1", "cliente1",
                "cliente1", "cliente1", "cliente1");
        cliente.CrearCliente ("cliente2 cliente2", "cliente2", "cliente2", "cliente2",
                "cliente2", "cliente2", "cliente2", "cliente2",
                "cliente2", "cliente2", "cliente2");
        cliente.CrearCliente ("cliente3 cliente3", "cliente3", "cliente3", "cliente3",
                "cliente3", "cliente3", "cliente3", "cliente3",
                "cliente3", "cliente3", "cliente3");
        cliente.CrearCliente ("Manuel Manuel", "Manuel", "Manuel", "Manuel",
                "Manuel", "Manuel", "Manuel", "Manuel",
                "Manuel", "Manuel", "Manuel");

        var pedido = new PedidoCEN ();
        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.en_curso, TipoPagoEnum.paypal, "admin", "cliente1");
        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.cancelado, TipoPagoEnum.visa, "admin", "cliente1");
        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.entregado, TipoPagoEnum.paypal, "admin", "cliente1");

        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.en_curso, TipoPagoEnum.paypal, "admin", "Manuel");
        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.cancelado, TipoPagoEnum.visa, "admin", "Manuel");
        pedido.CrearPedido (DateTime.Now, EstadoPedidoEnum.entregado, TipoPagoEnum.paypal, "admin", "Manuel");


        ProductoCEN prod = new ProductoCEN ();
        ProductoCEN prod2 = new ProductoCEN ();
        prod.CrearProducto (1, 300f, "admin", "latina", "latina clasica", 1);
        prod2.CrearProducto (2, 200f, "admin", "latina", "latina regata", 1);
        prod2.CrearProducto (3, 200f, "admin", "cuadra", "cuadra competicion", 1);
        prod2.CrearProducto (4, 200f, "admin", "de cuchillo", "cuchillo clasica", 1);

        /*   IList<ProductoEN> productos = new List<ProductoEN>();
         * productos = prod.DameTodosLosProductos(0, 100);
         * carrito.AnyadirProducto(1, productos);*/



        try
        {
                /*List<BalumaProjectGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<BalumaProjectGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * BalumaProjectGenNHibernate.EN.Mediaplayer.UserEN userEN = new BalumaProjectGenNHibernate.EN.Mediaplayer.UserEN();
                 * BalumaProjectGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new BalumaProjectGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * BalumaProjectGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new BalumaProjectGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * BalumaProjectGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new BalumaProjectGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * BalumaProjectGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new BalumaProjectGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * BalumaProjectGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new BalumaProjectGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * BalumaProjectGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new BalumaProjectGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //BalumaProjectGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new BalumaProjectGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
