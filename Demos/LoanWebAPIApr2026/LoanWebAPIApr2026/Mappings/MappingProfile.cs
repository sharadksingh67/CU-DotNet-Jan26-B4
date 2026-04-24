using AutoMapper;
using LoanWebAPIApr2026.DTOs;
using LoanWebAPIApr2026.Models;

namespace LoanWebAPIApr2026.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Fluent Validations Automatically called here

            CreateMap<LoanRequestDto, LoanApplication>();
            CreateMap<LoanApplication, LoanResponseDto>();
        }
    }

}
