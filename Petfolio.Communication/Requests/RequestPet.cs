using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;

public class RequestPet
{
    public string Name { get; set; }
    public DateOnly BirthDay { get; set; }

    public PetType Type { get; set; }

}
