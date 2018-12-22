using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteNube
{
    public partial class Contact : Page
    {

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
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
                cliente.IngresarLibro(TextEjemplarId.Text, 
                Regex.Split(ComboBoxEditoraId.Text," ID:")[1] 
                  ,TextTitulo.Text, TextFechaPublicacion.Text, TextCosto.Text, TextPrecioVenta.Text);
            }
            TextEjemplarId.Text = "";
            TextTitulo.Text = "";
            TextFechaPublicacion.Text = "";
            TextCosto.Text = "";
            TextPrecioVenta.Text = "";
        }
    }
}