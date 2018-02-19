using CityLuxProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityLuxProject.Models;

namespace CityLuxProject
{
    public partial class ProductList : System.Web.UI.Page
    {
        private CItyLuxDbContext dbContext = new CItyLuxDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGridView();
            }
        }

        private void BindGridView()
        {
            var data = this.dbContext
                .Product
                .ToList()
                .Select(x => new ProductListGridViewModel()
                {
                    ProductName = x.Name,
                    MerchandiseGroup = x.MerchandiseGroup.Name,
                    Price = this.CalculatePrice(x)
                }).ToList();

            this.ProductsGrid.DataSource = data;
            this.ProductsGrid.DataBind();
        }

        private double CalculatePrice(Product product)
        {
            double price = 0;
            var productComponents = dbContext.Recipe.Where(x => x.ProductId == product.Id)
                .Select(x=>x.ComponentId).ToList();

            var components = this.dbContext.Component.Where(x => productComponents.Contains(x.Id)).ToList();
            foreach (var item in components)
            {
                price += item.Price;
            }

            return price;
        }
    }

    public class ProductListGridViewModel
    {
        public string ProductName { get; set; }
        public string MerchandiseGroup { get; set; }
        public double Price { get; set; }
    }
}