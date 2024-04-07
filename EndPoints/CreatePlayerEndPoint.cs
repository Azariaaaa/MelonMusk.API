using clickelon.api.DTO.Requests;
using clickelon.api.DTO.Responses;
using clickelon.api.Model;
using FastEndpoints;
using System.Numerics;

namespace clickelon.api.EndPoints
{
    public class CreatePlayerEndPoint : Endpoint<CreatePlayerRequestDTO, CreatePlayerReponseDTO>
    {
        public override void Configure()
        {
            Post("/AddNewPlayer");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CreatePlayerRequestDTO request, CancellationToken ct)
        {
            int idToReturn = Player.CreateAPlayerByName(request.Name);

            await SendAsync( new()
            {
                Id = idToReturn
            });
        }
    }
}
