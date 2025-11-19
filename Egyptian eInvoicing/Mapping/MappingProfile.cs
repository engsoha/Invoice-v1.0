using AutoMapper;
using Egyptian_eInvoicing.ViewModels;
using Egyptian_eInvoicing.Models;
using Egyptian_eInvoicing.Models.Lines;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<InvoiceCreationViewModel, Document>()
            .ForMember(dest => dest.InvoiceLines, opt => opt.MapFrom(src => src.Lines.Select(l => l.LineData))) // خاصية مهمة جداً لربط القوائم
            .ReverseMap(); 

        CreateMap<InvoiceLineViewModel, InvoiceLine>()
            .ForMember(dest => dest.TaxableItems, opt => opt.MapFrom(src => src.TaxItems))
            .ReverseMap();

        
    }
}