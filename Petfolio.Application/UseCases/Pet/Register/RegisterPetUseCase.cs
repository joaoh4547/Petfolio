﻿using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisterPet Handle(RequestPet request)
    {
        return new ResponseRegisterPet
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
