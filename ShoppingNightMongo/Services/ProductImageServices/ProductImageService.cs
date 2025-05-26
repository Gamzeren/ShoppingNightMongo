using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.ProductImageDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<ProductImage> _productImageCollection;
        private readonly IMongoCollection<Product> _productCollection;

        public ProductImageService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client=new MongoClient(_databaseSettings.ConnectionString);
            var database=client.GetDatabase(_databaseSettings.DatabaseName);
            _productImageCollection=database.GetCollection<ProductImage>(_databaseSettings.ProductImageCollectionName);
            _productCollection=database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper=mapper;
        }

        public async Task CreateProductImageAsync(CreateProductImageDto createProductImageDto)
        {
            var productImage=_mapper.Map<ProductImage>(createProductImageDto);
            await _productImageCollection.InsertOneAsync(productImage);
        }

        public async Task DeleteProductImageAsync(string id)
        {
            await _productImageCollection.DeleteOneAsync(x=>x.ProductImageId==id);
        }

        public async Task<List<ResultProductImageDto>> GetAllProductImageAsync()
        {
            var productImages=await _productImageCollection.Find(x=>true).ToListAsync();
            var products = await _productCollection.Find(x => true).ToListAsync();

            var result = productImages.Select(img =>
            {
                var dto = _mapper.Map<ResultProductImageDto>(img);
                var product = products.FirstOrDefault(p => p.ProductId == img.ProductId);
                dto.ProductName = product?.ProductName;
                return dto;
            }).ToList();
            return result;
        }

        public async Task<GetProductImageDto> GetProductImageByIdAsync(string id)
        {
            var value=await _productImageCollection.Find(x=>x.ProductImageId==id).FirstOrDefaultAsync();
            var dto=_mapper.Map<GetProductImageDto>(value);

            var values = await _productCollection.Find(x => x.ProductId == value.ProductId).FirstOrDefaultAsync();
            dto.ProductName = values?.ProductName;

            return dto;
        }

        public async Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
        {
            var value = _mapper.Map<ProductImage>(updateProductImageDto);
            await _productImageCollection.FindOneAndReplaceAsync(x=>x.ProductImageId==updateProductImageDto.ProductImageId, value);
        }
    }
}
