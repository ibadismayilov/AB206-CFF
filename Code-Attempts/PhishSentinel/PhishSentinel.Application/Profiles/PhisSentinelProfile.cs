using AutoMapper;
using PhishSentinel.Application.DTOs.Auth;
using PhishSentinel.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhishSentinel.Application.Profiles;
public class PhisSentinelProfile : Profile
{
    public PhisSentinelProfile()
    {
        CreateMap<Login,LoginGetDTO>();
        CreateMap<Register, RegisterGetDTO>();
    }
}
