using DataAccess.Repository;
using Models.Entities;

namespace apicasos.Api
{
    public class epUsuarios
    {
        public static async Task<IResult> GetUsuarios(IUsuariosRepository IUsuarios)
        {
            try
            {
                return Results.Ok(await IUsuarios.GetTUsuarios());
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }

        }

        public static async Task<IResult> GetusuariosId(Int64 id, IUsuariosRepository IUsuarios)
        {
            try
            {
                return Results.Ok(await IUsuarios.GetUsuariosId(id));
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> GetusuariosUsuario(string usuario, IUsuariosRepository IUsuarios)
        {
            try
            {
                return Results.Ok(await IUsuarios.GetUsuariosUsuario(usuario));
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> UpdateCaso(usuarios usuarios, IUsuariosRepository IUsuarios)
        {
            try
            {
                await IUsuarios.UpdateUsuarios(usuarios);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> InsertCaso(usuarios usuarios, IUsuariosRepository IUsuarios)
        {
            try
            {
                await IUsuarios.InsertUsuarios(usuarios);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> DeleteCaso(string id, IUsuariosRepository IUsuarios)
        {
            try
            {
                await IUsuarios.DeleteUsuarios(id);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> CambiarClave(usuarios usuarios, IUsuariosRepository IUsuarios)
        {
            try
            {
                await IUsuarios.CambioClave(usuarios);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }


    }
}
