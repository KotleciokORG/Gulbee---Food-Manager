using Gulbee.Frontend.Models;

namespace Gulbee.Frontend.Clients;

public class ProductClient(HttpClient httpClient)
{
    public async Task<Product[]> GetProductAsync(){
        return await httpClient.GetFromJsonAsync<Product[]>("products") 
        ?? [];
    }
    public async Task<Product> GetProductAsync(int id){
        return await httpClient.GetFromJsonAsync<Product>($"products/{id}") 
        ?? throw new Exception("Item not found");
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