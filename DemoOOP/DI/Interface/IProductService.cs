using DemoOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP.DI.Interface
{
    public interface IProductService
    {
        void Create(string Name, string Manufacture, string CreatedBy, bool Active, string Description);
        List<Product> GetAll();
    }
}
