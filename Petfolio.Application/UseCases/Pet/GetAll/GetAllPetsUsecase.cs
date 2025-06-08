using Petfolio.Communication.Enums;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.GetAll;
public class GetAllPetsUsecase
{
    public ResponseAllPet Handle()
    {
        return new ResponseAllPet
        {
            Data =
            {
                new ResponseShortPet{
                    Id = 1,
                    Name = "Charlie",
                    Type = PetType.DOG
                }
            }
        };
    }
}
