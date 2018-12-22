using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteNube
{
    public partial class Update : System.Web.UI.Page
    {
       protected override void OnInit(EventArgs e)
       {
            base.OnInit(e);
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                ComboBoxLibros.Items.Clear();
                var libros = cliente.ObtenerEjemplares();
                foreach (var libro in libros)
                    ComboBoxLibros.Items.Add(libro.ejemplarid);
            }
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                ComboBoxEditoraId.Items.Clear();
                foreach (var Editora in cliente.ObtenerEditoras())
                    ComboBoxEditoraId.Items.Add(Editora.Nombre_Editora + " ID:" + Editora.editoraid);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                var libro = cliente.BuscarEjemplar(ComboBoxLibros.Text);

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                var libro = cliente.BuscarEjemplar(ComboBoxLibros.Text);
                TextEjemplarId.Text = libro.ejemplarid;
                TextTitulo.Text = libro.titulo;
                TextFechaPublicacion.Text = libro.FechaPublicacion;
                TextCosto.Text = libro.Costo;
                TextPrecioVenta.Text = libro.PrecioVenta;
            }
         }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                cliente.ModificarEjemplar(TextEjemplarId.Text, Regex.Split(ComboBoxEditoraId.Text, " ID:")[1]
                    , TextTitulo.Text, TextFechaPublicacion.Text, TextCosto.Text
                    , TextPrecioVenta.Text);
            }
            TextEjemplarId.Text = "";
            TextTitulo.Text = "";
            TextFechaPublicacion.Text = "";
            TextCosto.Text = "";
            TextPrecioVenta.Text = "";
        }
        
    }
}