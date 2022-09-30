using DataAccess.Repository;
using Models.Entities;

namespace apicasos.Api
{
    public class epCasos
    {

        public static async Task<IResult> GetCasos(ICasosRepository casos)
        {
            try
            {
                return Results.Ok(await casos.GetCaso());
            }
            catch(Exception e)
            {
                return Results.Problem(e.Message);
            }

        }

        public static async Task<IResult> GetCasoUsuario(string pUsuario, ICasosRepository casos)
        {
            try
            {
                return Results.Ok(await casos.GetCasoUsuario(pUsuario));
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }

        }

        public static async Task<IResult> GetCasoId(int id_caso,ICasosRepository iCasos)
        {
            try
            {
                return Results.Ok(await iCasos.GetCasoId(id_caso));
            }
            catch(Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> UpdateCaso(casos casos, ICasosRepository iCasos)
        {
            try
            {
                await iCasos.UpdateCaso(casos);
                return Results.Ok();
            }
            catch(Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> InsertCaso(casos casos, ICasosRepository iCasos)
        {
            try
            {
                await iCasos.InsertCaso(casos);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> DeleteCaso(int id, ICasosRepository iCasos)
        {
            try
            {
                await iCasos.DeleteCaso(id);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

    }
}
