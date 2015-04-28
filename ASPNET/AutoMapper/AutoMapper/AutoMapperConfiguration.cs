using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using AutoMapper;
using Nib.Sales.HttpServer.Dtos;
using Nib.Sales.Interface.Dtos.Responses;

namespace Nib.Sales.HttpServer
{
    /// <summary>
    /// Configures automapper for the sales service
    /// </summary>
    internal static class AutoMapperConfiguration
    {
        /// <summary>
        /// Initialises all of the various mappings handled by AutoMapper
        /// </summary>
        public static void ConfigureMappings()
        {
            // Policies
            //Mapper.CreateProfile("GetDetails").RecognizePrefixes("Policy");

            Mapper.Initialize(cfg => 
                {
                    cfg.RecognizePrefixes("Policy");

                    cfg.CreateMap<GetDetailsResponse, PersonDetailsDto>().IgnoreAllNonExisting();


                    cfg.CreateMap<GetDetailsResponse, PolicyResponseDto>()
                        .ForMember(dest => dest.Owner, opt => opt.MapFrom(o => Mapper.Map<GetDetailsResponse, PersonDetailsDto> (o)))
                        .IgnoreAllNonExisting()
                    //    .ForMember(dest => dest.Owner.Title, opt => opt.MapFrom(src => new PersonDetailsDto { Title = src.OwnerTitle }))
                        
                        ;
                });

            //Mapper.Configuration.RecognizePrefixes("Policy");

            //Mapper.CreateMap<GetDetailsResponse, PolicyResponseDto>()
            //    .WithProfile("GetDetails")

                //.ForMember(dest => dest.Owner.Title, opt => opt.MapFrom(src => new PersonDetailsDto { Title = src.OwnerTitle }))
                //.ForMember(dest => dest.Owner.FirstName, opt => opt.MapFrom(src => new PersonDetailsDto { FirstName = src.OwnerFirstName}))
                //.ForMember(dest => dest.Owner.Surname, opt => opt.MapFrom(src => new PersonDetailsDto { Surname = src.OwnerLastName}))
                //.ForMember(dest => dest.Owner.DateOfBirth, opt => opt.MapFrom(src => new PersonDetailsDto { DateOfBirth = DateTime.ParseExact( src.OwnerBirthDate, "dd-mm-yyyy", CultureInfo.InvariantCulture) }));

                
                ;
        }
    }

    static class Extensions
    {
        public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>
                                            (this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            var destinationType = typeof(TDestination);
            var existingMaps = Mapper.GetAllTypeMaps().First(x => x.SourceType.Equals(sourceType) && x.DestinationType.Equals(destinationType));

            foreach (var property in existingMaps.GetUnmappedPropertyNames())
            {
                expression.ForMember(property, opt => opt.Ignore());
            }
            return expression;
        }
    }
}
