using Microsoft.EntityFrameworkCore;

namespace Gulbee.Api.Entities;
public class Nutri{
    public int Id { get; set; }
    public double Fat { get; set; }
    public double Carbo { get; set; }
    public double Sugar { get; set; }
    public double Proteins { get; set; }
    public double Salt { get; set; }
    public double Fiber { get; set; }
    
}