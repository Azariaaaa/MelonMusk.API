using clickelon.api.DTO.Requests;
using clickelon.api.Model;
using FastEndpoints;

namespace clickelon.api.EndPoints
{
    public class GetTwentyBestGamesEndPoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("/GetTwentyBestGames");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            var twentyBestGames = Game.GetTwentyBestGames();
            await SendAsync(twentyBestGames);
        }
    }
}
