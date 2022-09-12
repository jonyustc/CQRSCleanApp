using Domain;

namespace Infrastructure.Data
{
    public static class SeedData
    {
        public static void SeedProductCategoryAndUnitData(DataContext context)
        {
            if(!context.ProductCategories.Any())
            {
                var categoryList = new List<ProductCategory>
                {
                    new ProductCategory { CategoryName = "Laptop",Description ="Laptop Description" },
                    new ProductCategory { CategoryName = "Accessories",Description ="Accessories Description" },
                    new ProductCategory { CategoryName = "Fruits",Description ="Fruits Description" },
                    new ProductCategory { CategoryName = "Juice",Description ="Juice Description" },
                    new ProductCategory { CategoryName = "Rolling Bar",Description ="Rolling Bar Description" }
                };

                context.ProductCategories.AddRange(categoryList);

                context.SaveChanges();
            }

            if(!context.ProductUnits.Any())
            {
                var unitList = new List<ProductUnit>
                {
                    new ProductUnit { UnitName = "Pcs" },
                    new ProductUnit { UnitName = "Kg" },
                    new ProductUnit { UnitName = "Ltr"},
                    new ProductUnit { UnitName = "MT"}
                };

                context.ProductUnits.AddRange(unitList);

                context.SaveChanges();
            }
        }
    }
}