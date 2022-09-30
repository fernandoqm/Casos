using Microsoft.AspNetCore.Components;
using Models.Entities;
using webCasos.Services.Contracts;


namespace webCasos.Pages
{
    public class CasosBase:ComponentBase
    {
        [Inject]
        public ICasosService? casosService { get; set; }

        public IEnumerable<casos>? lstCasos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lstCasos = await casosService.getItems();
        }

        protected IOrderedEnumerable<IGrouping<int,casos>>GetTipoCasos()
        {
            return (IOrderedEnumerable<IGrouping<int, casos>>)(from casos in lstCasos
                   group casos by casos.tipo_caso);
        }

        protected string GetNombreTipo(IGrouping<int, casos>AgrupaTipoCaso)
        {
            return "Sin asignar";

            if (AgrupaTipoCaso.FirstOrDefault(pg => pg.tipo_caso == AgrupaTipoCaso.Key).tipo_caso == 1)
            {
                return "Hotfix";
            }

            if (AgrupaTipoCaso.FirstOrDefault(pg => pg.tipo_caso == AgrupaTipoCaso.Key).tipo_caso == 2)
            {
                return "Bugfix";
            }

            if (AgrupaTipoCaso.FirstOrDefault(pg => pg.tipo_caso == AgrupaTipoCaso.Key).tipo_caso == 3)
            {
                return "Feature";
            }

        }


    }
}
