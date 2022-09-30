using apicasos.Api;

namespace apicasos.ConfigApi
{
    public static class ApiTegnologia
    {
        public static void ConfigureApiTegnologia(this WebApplication app)
        {
            app.MapGet("/GetTegnologia", epTegnologia.GetTegnologia);
            app.MapGet("/GetTegnologiaId/{id}", epTegnologia.GetTegnologiaId);
            app.MapPost("/InsertTegnologia", epTegnologia.InsertTegnologia);
            app.MapPut("/UpdateTegnologia", epTegnologia.UpdateTegnologia);
            app.MapDelete("/DeleteTegnologia", epTegnologia.DeleteTegnologia);

        }

    }
}
