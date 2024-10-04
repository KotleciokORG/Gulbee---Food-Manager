using Gulbee.Frontend.Models;

namespace Gulbee.Frontend.Clients;

public class CategoryClient(HttpClient httpClient)
{
    public async Task<Category[]> GetCategoriesAsync(){
        return await httpClient.GetFromJsonAsync<Category[]>("category/") 
        ?? [];
    }
}