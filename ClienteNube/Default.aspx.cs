using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteNube
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ServicioNube.ServicioNubeClient cliente = new ServicioNube.ServicioNubeClient())
            {
                Label1.Text = cliente.devolverMensaje();
            }
        }
    }
}