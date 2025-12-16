using Repositories.Abstraction;
using Services.Features.ProductCategory.Create.Contracts;
using Services.Features.ProductCategory.Create.Contracts.DTOs;
using Services.Features.ProductCategory.Create.Rules;

namespace Services.Features.ProductCategory.Create.Implementation;

public class CreateProductCategoryFeature : ICreateProductCategoryFeature
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    private readonly ProductCategoryRules _productCategoryRules;

    public CreateProductCategoryFeature(IProductCategoryRepository productCategoryRepository, ProductCategoryRules productCategoryRules)
    {
        _productCategoryRepository = productCategoryRepository;
        _productCategoryRules = productCategoryRules;
    }
    
    public async Task CreateAsync(ProductCategoryDTO productCategory)
    {
        await _productCategoryRules.EnsureProductCategoryNameIsNotNullOrEmpty(productCategory.CategoryName);
        await _productCategoryRules.EnsureProductCategoryNameIsNotDuplicate(productCategory.CategoryName);

        await _productCategoryRepository.AddNewProductCategoryAsync(new BusinessObjects.Entities.ProductCategory()
        {
            Id = Guid.NewGuid(),
            CategoryName = productCategory.CategoryName,
            Notes = productCategory.Notes
        });
    }
}