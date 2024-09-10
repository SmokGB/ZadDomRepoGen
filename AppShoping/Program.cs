using AppShoping.Data;
using AppShoping.Entities;
using AppShoping.Repositories;

var foodRepository = new SqlRepository<Food>(new ShopAppDbContext());
AddFoods(foodRepository);
AddBioFoods(foodRepository);
WriteAllToConsole(foodRepository);

static void AddFoods(IRepository<Food> myFoodRepository)
{
    myFoodRepository.Add(new Food { ProductName = "Banan" });
    myFoodRepository.Add(new Food { ProductName = "Pomidor" });
    myFoodRepository.Add(new Food { ProductName = "Ser żółty" });
    myFoodRepository.Save();

}

static void AddBioFoods(IWriteRepository<BioFood> myFoodRepository)
{
    myFoodRepository.Add(new BioFood { ProductName = "Cytryna" });
    myFoodRepository.Add(new BioFood { ProductName = "Truskawki" });
    myFoodRepository.Save();
}



static void WriteAllToConsole(IReadRepository<IEntity> allFoods)
{
    var items = allFoods.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }

}
