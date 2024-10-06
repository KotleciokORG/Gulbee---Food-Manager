using Gulbee.Api.Dto;
using Gulbee.Api.Entities;

namespace Gulbee.Api.Mapping;

public static class ProductMapping{
    public static ProductGetDto ToGetDto(this Product product){
        return new ProductGetDto(
            product.Id,
            product.Name,
            product.Kcal,
            product.Nutri is null ? null : product.Nutri.Fat,
            product.Nutri is null ? null : product.Nutri.Carbo,
            product.Nutri is null ? null : product.Nutri.Sugar,
            product.Nutri is null ? null : product.Nutri.Proteins,
            product.Nutri is null ? null : product.Nutri.Salt,
            product.Nutri is null ? null : product.Nutri.Fiber,
            product.CategoryId,
            product.Category is null ? null : product.Category.Name //may be null!
        );
    }
    public static Nutri GetNutri(this ProductPostDto productPostDto){
        return new Nutri(){
            Fat = productPostDto.Fat,
            Carbo = productPostDto.Carbo,
            Sugar = productPostDto.Sugar,
            Proteins = productPostDto.Proteins,
            Salt = productPostDto.Salt,
            Fiber = productPostDto.Fiber,
        };
    }
    public static Nutri GetNutri(this ProductUpdateDto productPostDto){
        return new Nutri(){
            Fat = productPostDto.Fat,
            Carbo = productPostDto.Carbo,
            Sugar = productPostDto.Sugar,
            Proteins = productPostDto.Proteins,
            Salt = productPostDto.Salt,
            Fiber = productPostDto.Fiber,
        };
    }
    public static Product ToEntity(this ProductPostDto productPostDto){
        return new Product(){
            Name = productPostDto.Name,
            Kcal = productPostDto.Kcal,
            CategoryId = productPostDto.CategoryId
        };
    }
    public static Product ToEntity(this ProductUpdateDto productPostDto,int id){
        return new Product(){
            Id = id,
            Name = productPostDto.Name,
            Kcal = productPostDto.Kcal,
            CategoryId = productPostDto.CategoryId
        };
    }
}