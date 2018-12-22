using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServicioNube
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioNube
    {
        [OperationContract]
        List<Ejemplar> ObtenerEjemplares();

        [OperationContract]
        String devolverMensaje();

        [OperationContract]
        String IngresarLibro(String EjemplarId,String EditoraId,
            String titulo,String FechaPublicacion,String Costo,
            String PrecioVenta);

        [OperationContract]
        Ejemplar BuscarEjemplar(String EjemplarId);

        [OperationContract]
        bool BorrarEjemplar(String Ejemplar);

        [OperationContract]
        bool ModificarEjemplar(String Ejemplarid, String editoraid
            , String titulo, String fechapublicacion, String Costo,
            String PrecioVenta);

        [OperationContract]
        Editora BuscarEditorial(String editoraid);

        [OperationContract]
        List<Editora> ObtenerEditoras();
        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class Ejemplar
    {
        [DataMember]
        public String ejemplarid { get; set; }

        [DataMember]
        public String editoraid { get; set; }

        [DataMember]
        public String titulo { get; set; }

        [DataMember]
        public String FechaPublicacion { get; set; }

        [DataMember]
        public String Costo { get; set; }

        [DataMember]
        public String PrecioVenta { get; set; }

    }

    public class Editora
    {
        [DataMember]
        public String editoraid { get; set; }

        [DataMember]
        public String Nombre_Editora { get; set; }
    }
   
}
