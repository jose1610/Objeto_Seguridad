using CapaModeloSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorSeguridad
{
    public class ClsBitacora
    {

        Bitacora b = new Bitacora();

        public void usuario(int usuario)
        {
            b.UserSystem = usuario;
            //usuario = b.UserSystem;
        }

        public void acciones(int aplicacion, String accion)
        {
            b.nombreAplicacion = aplicacion;
            b.accion = accion;

            b.Insertar();
        }



    }
}
