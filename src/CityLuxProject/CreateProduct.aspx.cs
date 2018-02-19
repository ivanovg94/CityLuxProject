using CityLuxProject.Data;
using CityLuxProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CityLuxProject
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        private CItyLuxDbContext dbContext = new CItyLuxDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindProductTypes();
                this.BindComponents();
            }
        }

        private void BindComponents()
        {
            var components = this.dbContext.Component.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                ComponentType = x.ComponentType,
                Price = x.Price
            })
            .ToList()
            .Select(x => new
            {
                Id = x.Id,
                Name = $"{x.Name} ({x.ComponentType.Name} - {x.Price}лв.)"
            });

            this.ComponentsList.DataSource = components;
            this.ComponentsList.DataBind();
        }

        private void BindProductTypes()
        {
            var productTypes = this.dbContext.MerchandiseGroup
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();


            this.ProductTypeDropDown.DataSource = productTypes;
            this.ProductTypeDropDown.DataBind();
        }

        protected void CreateProductBtn_Click(object sender, EventArgs e)
        {
            var productName = this.CreateProductTextBox.Text.ToString();
            var merchandiseGroup = this.ProductTypeDropDown.SelectedValue.ToString();

            var componentsIds = this.ComponentsList.Items.Cast<ListItem>().Where(i => i.Selected).Select(x => x.Value).ToList();

            var recipies = new List<Recipe>();
            var productId = Guid.NewGuid().ToString();
            foreach (var componentid in componentsIds)
            {
                var component = this.dbContext.Component.FirstOrDefault(x => x.Id == componentid);

                recipies.Add(new Recipe()
                {
                    Component = component,
                    ProductId = productId
                });
            }

            var product = new Product()
            {
                Id = productId,
                Name = productName,
                MerchandiseGroupId = merchandiseGroup,
                Recipes = recipies
            };

            dbContext.Product.Add(product);
            dbContext.SaveChanges();
        }
    }
}