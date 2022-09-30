using Microsoft.AspNetCore.Components;
using Models.Entities;

namespace webCasos.Pages
{
    public class DisplayCasoBase: ComponentBase
    {
        [Parameter]
        public IEnumerable<casos> lstCasos { get; set; }



    }
}
