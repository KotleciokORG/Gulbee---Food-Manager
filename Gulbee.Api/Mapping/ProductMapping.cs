using Gulbee.Api.Dto;
using Gulbee.Api.Entities;

namespace Gulbee.Api.Mapping;

public static class ProductMapping{
    public static ProductGetDto ToGetDto(this Product product){
        return new ProductGetDto(
            product.Id,
            product.Name,
            product.Kcal,
            product.Fat,
            product.Carbo,
            product.Sugar,
            product.Proteins,
            product.Salt,
            product.Category!.Name //may be null!
        );
    }

    public static Product ToEntity(this ProductPostDto productPostDto){
        return new Product(){
            Name = productPostDto.Name,
            Kcal = productPostDto.Kcal,
            Fat = productPostDto.Fat,
            Carbo = productPostDto.Carbo,
            Sugar = productPostDto.Sugar,
            Proteins = productPostDto.Proteins,
            Salt = productPostDto.Salt,
            CategoryId = productPostDto.CategoryId
        };
    }
    public static Product ToEntity(this ProductUpdateDto productPostDto,int id){
        return new Product(){
            Id = id,
            Name = productPostDto.Name,
            Kcal = productPostDto.Kcal,
            Fat = productPostDto.Fat,
            Carbo = productPostDto.Carbo,
            Sugar = productPostDto.Sugar,
            Proteins = productPostDto.Proteins,
            Salt = productPostDto.Salt,
            CategoryId = productPostDto.CategoryId
        };
    }
}