using DataAccess.Repository;
using Models.Entities;

namespace apicasos.Api
{
    public class epTegnologia
    {
        public static async Task<IResult> GetTegnologia(ITegnologiaRepository tegnologia)
        {
            try
            {
                return Results.Ok(await tegnologia.GetTegnologia());
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }

        }

        public static async Task<IResult> GetTegnologiaId(string id, ITegnologiaRepository tegnologia)
        {
            try
            {
                return Results.Ok(await tegnologia.GetTegnologiaId(id));
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> UpdateTegnologia(tegnologia tegnologia, ITegnologiaRepository itegnologia)
        {
            try
            {
                await itegnologia.UpdateTegnologia(tegnologia);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> InsertTegnologia(tegnologia tegnologia, ITegnologiaRepository itegnologia)
        {
            try
            {
                await itegnologia.InsertTegnologia(tegnologia);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }

        public static async Task<IResult> DeleteTegnologia(string id, ITegnologiaRepository itegnologia)
        {
            try
            {
                await itegnologia.DeleteTegnologia(id);
                return Results.Ok();
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }
    }
}
