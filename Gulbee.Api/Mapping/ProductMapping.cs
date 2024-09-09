using Gulbee.Api.Dto;
using Gulbee.Api.Entities;

namespace Gulbee.Api.Mapping;

public static class ProductMapping{
    public static ProductGetDto ToGetDto(this Product product){
        return new ProductGetDto(){
            Name = product.Name,
            Kcal = product.Kcal,
            Fat = product.Fat,
            Carbo = product.Carbo,
            Sugar = product.Sugar,
            Proteins = product.Proteins,
            Salt = product.Salt,
            Category = product.Category!.Name //may be null!
        };
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