using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteNube
{
    public partial class About : Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                foreach (var libro in cliente.ObtenerEjemplares())
                {
                    TableRow Fila = new TableRow();
                    TableCell celda = new TableCell();
                    celda.Text = libro.ejemplarid;
                    Fila.Cells.Add(celda); ;
                    celda = new TableCell();
                    celda.Text = cliente.BuscarEditorial(libro.editoraid).Nombre_Editora;
                    Fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = libro.titulo;
                    Fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = libro.FechaPublicacion;
                    Fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = libro.Costo;
                    Fila.Cells.Add(celda);
                    celda = new TableCell();
                    celda.Text = libro.PrecioVenta;
                    Fila.Cells.Add(celda);
                    TableEjemplares.Rows.Add(Fila);
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}