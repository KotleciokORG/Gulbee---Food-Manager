using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Gulbee.Frontend.Clients;
using Gulbee.Frontend.Models;

namespace Gulbee.Frontend.Handlers;

public class GuessingHandler(ProductClient productClient){ 
    //I am not sure if it should be passed like that or from ServiceProvider
    public Product? actualProduct { get; set; }
    public bool? guessSuccess { get; set; }
    public int productCount { get; set; }
    private async Task<GuessingHandler> InitializeAsync(){
        guessSuccess = null;

        actualProduct = await PickRandomProduct();

        return this;
    } 
    public static async Task<GuessingHandler> CreateAsync(ProductClient productClient){
        var ret = new GuessingHandler(productClient);
        return await ret.InitializeAsync();
    }
    private async Task<Product> PickRandomProduct(){
        productCount = await productClient.CountProductsAsync();
        actualProduct = await productClient.GetRandomAsync();
        return actualProduct;
    }
    public async Task Submit(ProductGuess? productGuess){
        ArgumentNullException.ThrowIfNull(productGuess);
        ArgumentNullException.ThrowIfNull(actualProduct);
        ArgumentException.ThrowIfNullOrEmpty(productGuess.Name);
        ArgumentException.ThrowIfNullOrEmpty(productGuess.Name.Trim());

        if(productGuess.Name.ToLower().Trim() == actualProduct.Name.ToLower().Trim()){
           guessSuccess = true;
           await Task.Delay(500);
           actualProduct = await PickRandomProduct();
        }
        else{
            guessSuccess = false;
            await Task.Delay(500);
        }
        guessSuccess = null;
    }
}

public class ProductGuess
{
    [Required]
    [StringLength(20, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }
}