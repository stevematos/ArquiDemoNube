using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using Algoritmos;


namespace ServicioNube
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioNube : IServicioNube
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BDOrden.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public bool BorrarEjemplar(string Ejemplar)
        {
            con.Open();
            cmd = new SqlCommand("Delete from Ejemplar where EJEMPLARID=" + Ejemplar , con);
            dr = cmd.ExecuteReader();
            return true;
        }

        public Editora BuscarEditorial(string editoraid)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Editora where editoraid=" + editoraid, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            return new Editora()
            {
                editoraid = dr[0].ToString(),
                Nombre_Editora = dr[1].ToString()
            };
        }

        public Ejemplar BuscarEjemplar(string EjemplarId)
        {
            con.Open();

            cmd = new SqlCommand("Select * from Ejemplar where EJEMPLARID=" + EjemplarId ,con);

            dr = cmd.ExecuteReader();

            dr.Read();

            return new Ejemplar()
            {
                ejemplarid = dr[0].ToString(),
                editoraid = dr[1].ToString(),
                titulo = dr[2].ToString(),
                FechaPublicacion = dr[3].ToString(),
                Costo = dr[4].ToString(),
                PrecioVenta = dr[5].ToString()
            };
        }

        public string devolverMensaje()
        {
            return "holi";
        }

        public string IngresarLibro(string EjemplarId, string EditoraId, string titulo, string FechaPublicacion, string Costo, string PrecioVenta)
        {
            con.Open();
            
            string fecha;

            if(FechaPublicacion.Length>11)
                fecha = Algoritmos.Algoritmos.String_DateSql(FechaPublicacion) + "'";
            else
                fecha = Algoritmos.Algoritmos.String_DateSql(FechaPublicacion) + " 00:00:00'";

            cmd = new SqlCommand("INSERT INTO EJEMPLAR VALUES(N'"+EjemplarId+
                "', N'"+EditoraId+"', N'"+titulo+"', N'"+ fecha+", CAST("+Costo + "AS Money), CAST("+PrecioVenta +" AS Money), 0)", con);
            dr=cmd.ExecuteReader();
            con.Close();
            return "Ingreso con exito";
        }

        public bool ModificarEjemplar(string Ejemplarid, string editoraid, string titulo, string fechapublicacion, string Costo, string PrecioVenta)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Ejemplar Set " +
                                "EditoraId = '" + editoraid + "'," +
                                "Titulo = '" + titulo + "'," +
                               "Fec_Publicacion = '" + Algoritmos.Algoritmos.String_DateSql(fechapublicacion) + "'," +
                               " costo = " + Costo + "," +
                               " precio_venta = " + PrecioVenta +
                               " WHERE Ejemplarid = '" + Ejemplarid + "'", con);
            

            dr = cmd.ExecuteReader();
            con.Close();
            return true;
        }

        public List<Editora> ObtenerEditoras()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM editora", con);
            dr = cmd.ExecuteReader();
            List<Editora> lista = new List<Editora>();
            while (dr.Read())
            {
                lista.Add(new Editora()
                {
                    editoraid = dr[0].ToString(),
                    Nombre_Editora = dr[1].ToString()
                });
            }
            con.Close();
            return lista;
        }

        public List<Ejemplar> ObtenerEjemplares()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM ejemplar", con);
            dr = cmd.ExecuteReader();
            List<Ejemplar> lista = new List<Ejemplar>();
            while (dr.Read())
            {
                lista.Add(new Ejemplar() {
                    ejemplarid = dr[0].ToString(),
                    editoraid = dr[1].ToString(),
                    titulo = dr[2].ToString(),
                    FechaPublicacion = dr[3].ToString(),
                    Costo = dr[4].ToString(),
                    PrecioVenta = dr[5].ToString()
                 } );
            }
            con.Close();
            return lista;
        }
    }
}
