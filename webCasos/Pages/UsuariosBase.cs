using Microsoft.AspNetCore.Components;
using Models.Entities;
using webCasos.Services;
using webCasos.Services.Contracts;

namespace webCasos.Pages
{
    public class UsuariosBase:ComponentBase
    {

        [Inject]
        public IUsuariosServices UsuariosServices { get; set; }
        public IEnumerable<usuarios>? lstUsuarios { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lstUsuarios = await UsuariosServices.getUsuarios();
        }

        protected IOrderedEnumerable<IGrouping<int, usuarios>> GetTipoCasos()
        {
            return (IOrderedEnumerable<IGrouping<int, usuarios>>)(from usuarios in lstUsuarios
                                                                  group usuarios by usuarios.ubicacion_activa);
        }

        protected string GetNombreTipo(IGrouping<int, usuarios> AgrupaUbicacion)
        {
            return "Otros";

            if (AgrupaUbicacion.FirstOrDefault(pg => pg.ubicacion_activa == AgrupaUbicacion.Key).ubicacion_activa == 1)
            {
                return "Administración";
            }

            if (AgrupaUbicacion.FirstOrDefault(pg => pg.ubicacion_activa == AgrupaUbicacion.Key).ubicacion_activa == 2)
            {
                return "Develop";
            }

            if (AgrupaUbicacion.FirstOrDefault(pg => pg.ubicacion_activa == AgrupaUbicacion.Key).ubicacion_activa == 3)
            {
                return "QA";
            }

        }

    }
}
