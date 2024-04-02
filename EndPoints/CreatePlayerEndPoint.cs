using clickelon.api.DTO.Requests;
using clickelon.api.DTO.Responses;
using clickelon.api.Model;
using FastEndpoints;

namespace clickelon.api.EndPoints
{
    public class CreatePlayerEndPoint : Endpoint<CreatePlayerRequestDTO>
    {
        public override void Configure()
        {
            Post("/AddPlayer");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CreatePlayerRequestDTO request, CancellationToken ct)
        {
            Player.CreateAPlayerByName(request.Name);
        }
    }
}
