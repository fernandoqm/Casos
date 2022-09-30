using Microsoft.AspNetCore.Components;
using Models.Entities;
using webCasos.Services.Contracts;

namespace webCasos.Pages
{
    public class CasosDetailsBase: ComponentBase
    {

        [Parameter]
        public int id_caso { get; set; }

        [Inject]
        public ICasosService casosServices { get; set; }
        public casos objCasos { get; set; }
        public string ErrorMensage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                objCasos = await casosServices.getItems(id_caso);
            }
            catch (Exception ex)
            {
                ErrorMensage = ex.Message;
            }
        }

    }
}
