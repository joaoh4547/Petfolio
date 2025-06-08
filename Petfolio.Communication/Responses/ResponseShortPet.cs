using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class ResponseShortPet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
}
