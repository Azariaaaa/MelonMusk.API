using clickelon.api.DTO.Requests;
using clickelon.api.DTO.Responses;
using clickelon.api.Model;
using FastEndpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickelon.api.EndPoints
{
    public class CreateGameEndPoint : Endpoint<CreateGameRequestDTO, CreateGameResponseDTO>
    {
        public override void Configure()
        {
            Post("/AddScore");
            AllowAnonymous();
        }
        public override async Task HandleAsync(CreateGameRequestDTO request, CancellationToken ct)
        {
            Game.Create(request.Score, request.PlayerId);

            //await SendAsync(new()
            //{   
            //    Id = 1
            //});
        }
    }
}
