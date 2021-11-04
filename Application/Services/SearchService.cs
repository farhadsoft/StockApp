using Application.DTOs;
using Application.Interfaces;
using AutoMapper;

namespace Application.Services
{
    public class SearchService : ISearchService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public SearchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductNameDto>> GetAllNames()
        {
            var result = await unitOfWork.ProductRepository.GetNamesAsync();
            return mapper.Map<IEnumerable<ProductNameDto>>(result.DistinctBy(x => x.Name));
        }

        public async Task<IEnumerable<ProductSearchDto>> GetByNameAsync(string name)
        {
            var result = await unitOfWork.ProductRepository.GetByNameAsync(name);
            return mapper.Map<IEnumerable<ProductSearchDto>>(result);
        }
    }
}
