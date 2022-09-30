using apicasos.Api;

namespace apicasos.ConfigApi
{
    public static class ApiCasos
    {

        public static void ConfigureApiCasos(this WebApplication app)
        {
            app.MapGet("/GetCasos", epCasos.GetCasos);
            app.MapGet("/GetCasosId/{id_caso}", epCasos.GetCasoId);
            app.MapGet("/GetCasoUsuario/{pUsuario}", epCasos.GetCasoUsuario);
            app.MapPost("/InsertCasos", epCasos.InsertCaso);
            app.MapPut("/UpdateCasos", epCasos.UpdateCaso);
            app.MapDelete("/DeleteCasos", epCasos.DeleteCaso);
        }

    }
}
