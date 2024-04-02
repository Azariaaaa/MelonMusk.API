using clickelon.api.DTO.Requests;
using FastEndpoints;
using FluentValidation;

namespace clickelon.api.Validator
{
    public class CreatePlayerValidator : Validator<CreatePlayerRequestDTO>
    {
        public CreatePlayerValidator() 
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Pseudo cannot be empty.")
                .MinimumLength(2)
                .WithMessage("Minimum 2 characters.")
                .MaximumLength(12)
                .WithMessage("Maximum 12 characters.");
        }
    }
}
