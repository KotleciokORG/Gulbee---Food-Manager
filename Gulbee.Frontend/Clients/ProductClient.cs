using Gulbee.Frontend.Models;

namespace Gulbee.Frontend.Clients;

public class ProductClient(HttpClient httpClient)
{
    public async Task<int> CountProductsAsync(){
        return await httpClient.GetFromJsonAsync<int>("products/count");
    }
    public async Task<Product[]> GetProductsAsync(){
        return await httpClient.GetFromJsonAsync<Product[]>("products/get") 
        ?? [];
    }
    public async Task<Product> GetProductAsync(int id){
        return await httpClient.GetFromJsonAsync<Product>($"products/get/{id}") 
        ?? throw new Exception("Item not found");
    }
    public async Task<Product> GetRandomAsync(){
        return await httpClient.GetFromJsonAsync<Product>($"products/random") 
        ?? throw new Exception("Unhandled problem with Random");
    }
    
    public async Task AddProductAsync(Product product){
        await httpClient.PostAsJsonAsync("products/",product);
    }
    public async Task UpdateProductAsync(int id, Product product){
        await httpClient.PutAsJsonAsync($"products/{id}",product);
    }
    public async Task DeleteProductAsync(int id){
        await httpClient.DeleteAsync($"products/{id}");
    }
}