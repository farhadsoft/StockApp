using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Model;

namespace Application.Services
{
    public class UploadService : IUploadService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UploadService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task AddAsync(IEnumerable<ProductAddDto> products)
        {
            unitOfWork.ProductRepository.Delete();
            await unitOfWork.SaveAsync();

            var productList = mapper.Map<IEnumerable<Product>>(products);
            await unitOfWork.ProductRepository.AddAsync(productList);
            await unitOfWork.SaveAsync();
        }
    }
}
