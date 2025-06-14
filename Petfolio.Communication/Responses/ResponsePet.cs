﻿using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class ResponsePet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly BirthDay { get; set; }
    public PetType Type { get; set; }
}
