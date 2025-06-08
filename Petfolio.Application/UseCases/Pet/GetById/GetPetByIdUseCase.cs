using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetPetByIdUseCase
{

    public ResponsePet Handle(int id)
    {
        return new ResponsePet
        {
            Id = id,
            Name = "Pipoquinha",
            Type = PetType.CAT,
            BirthDay = new DateOnly(year: 2020, month: 01, day: 15)
        };
    }
}
