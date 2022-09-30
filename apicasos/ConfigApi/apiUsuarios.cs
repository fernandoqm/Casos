using apicasos.Api;

namespace apicasos.ConfigApi
{
    public static class apiUsuarios
    {
        public static void ConfigureApiUsuarios(this WebApplication app)
        {
            app.MapGet("/GetUsuarios", epUsuarios.GetUsuarios);
            app.MapGet("/GetUsuariosId/{id}", epUsuarios.GetusuariosId);
            app.MapGet("/GetUsuariosUsuario/{usuario}",epUsuarios.GetusuariosUsuario);
            app.MapPost("/InsertUsuario", epUsuarios.InsertCaso);
            app.MapPut("/UpdateUsuario", epUsuarios.UpdateCaso);
            app.MapDelete("/DeleteUsuario", epUsuarios.DeleteCaso);

        }
    }
}
