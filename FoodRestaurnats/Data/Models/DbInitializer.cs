namespace FoodRestaurnats.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(WebApplication app)
        {
            //AppDbContext context =
            //    applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            using var scope = app.Services.CreateScope();
            AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
                context.SaveChanges();
            }

            if (!context.foods.Any())
            {
                context.AddRange
                (
                    new food
                    {
                        Name = "Puranpoli",
                        Price = 50,
                        ShortDescription = "Puran Poli, also known as Puran Puri or Holige",
                        LongDescription = "Puran Poli is an Indian delicacy made by stuffing soft whole wheat dough with soft-cooked yellow lentils, jaggery/brown sugar, cardamom, nutmeg, and saffron. It is then rolled thin and cooked on a pan with lots of ghee to make it into a crisp golden brown, flavorful, and aromatic flatbread.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://recipes.timesofindia.com/thumb/55045560.cms?imgsize=252832&width=800&height=800",
                        InStock = true,
                        IsPreferredfood = true,
                        ImageThumbnailUrl = "https://recipes.timesofindia.com/thumb/55045560.cms?imgsize=252832&width=800&height=800"
                    },
                    new food
                    {
                        Name = "pavbhaji",
                        Price = 60,
                        ShortDescription = "Pav Bhaji is a popular and flavorful Indian street food dish ",
                        LongDescription = "Pav Bhaji is a fast food dish from Mumbai (Bombay), India, consisting of a vegetable curry (bhaji) cooked in tomato gravy and served with a soft bread roll (pav). While Bhaji is a traditional Indian name for a vegetable dish, the Pav or Pao was the Portuguese word for bread, which was introduced by them during their brief presence in Mumbai around the mid-1500s.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://www.thestatesman.com/wp-content/uploads/2019/07/pav-bhaji.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.thestatesman.com/wp-content/uploads/2019/07/pav-bhaji.jpg"
                    },
                    new food
                    {
                        Name = "vegthali",
                        Price = 70,
                        ShortDescription = "Multi vegi dish.",
                        LongDescription = "Maharashtrian cuisine is a mix of Vegetarian and non-vegetarian cuisine.  Malvani and Konkani cuisine is a famous non-vegetarian cuisine. As Maharashtra is on the coastal side, seafood and rice are staples and are more famous for this cuisine.",
                        Category = Categories["Veg"],

                        ImageUrl = "https://i.pinimg.com/originals/a2/bb/d5/a2bbd55e26b31e5157b770d5e5292c0d.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://i.pinimg.com/originals/a2/bb/d5/a2bbd55e26b31e5157b770d5e5292c0d.jpg"
                    },
                    new food
                    {
                        Name = "Chole bature ",
                        Price = 50,
                        ShortDescription = "North indian dish",
                        LongDescription = "Chole Bhature is a popular North Indian dish known for its combination of spicy chickpea curry (chole) and deep-fried bread (bhature). It is a beloved dish in India and is often enjoyed as a hearty breakfast or a filling meal for lunch or dinner. ",
                        Category = Categories["Veg"],
                        ImageUrl = "https://www.yumcurry.com/wp-content/uploads/2021/08/chole-bhature.jpg",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.yumcurry.com/wp-content/uploads/2021/08/chole-bhature.jpg"
                    },
                    new food
                    {
                        Name = "Dal tadka ",
                        Price = 100,
                        ShortDescription = "Tadka Dal",
                        LongDescription = "Dal Tadka, also known as Tadka Dal is a popular Indian vegetarian dish made from lentils. It is a staple in Indian cuisine and is enjoyed throughout the country. ",
                        Category = Categories["Veg"],
                        ImageUrl = "https://foodiewish.com/wp-content/uploads/2020/07/Yellow-Dal-Tadka-Recipe.jpg",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://foodiewish.com/wp-content/uploads/2020/07/Yellow-Dal-Tadka-Recipe.jpg",
                    },
                    new food
                    {
                        Name = "Veg biryani ",
                        Price = 120,
                        ShortDescription = "Veg Biryani is a popular dish .",
                        LongDescription = "Veg Biryani is a popular and aromatic rice dish made with mixed vegetables, basmati rice, and a blend of spices. It is a vegetarian version of the traditional biryani, which is typically made with meat. This dish is beloved by vegetarians and non-vegetarians alike for its rich flavors and delightful aroma.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://th.bing.com/th/id/OIP.Wiw3y-pnb0KqoPH3rngKnAHaGd?pid=ImgDet&rs=1",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.Wiw3y-pnb0KqoPH3rngKnAHaGd?pid=ImgDet&rs=1",
                    },
                    new food
                    {
                        Name = "Dal Khichdi",
                        Price = 70,
                        ShortDescription = "Dal Khichdi is a popular and comforting one-pot dish in Indian cuisine ",
                        LongDescription = "Dal Khichdi is not only nutritious but also versatile and can be customized to suit your taste preferences. It's a staple in many Indian households and is known for its simplicity and ease of preparation.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://www.vegrecipesofindia.com/wp-content/uploads/2021/02/khichdi-recipe-1.jpg",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.vegrecipesofindia.com/wp-content/uploads/2021/02/khichdi-recipe-1.jpg",
                    },
                    new food
                    {
                        Name = "pulav",
                        Price = 50,
                        ShortDescription = "Pulav (also spelled pilaf or pilau) is a popular and versatile rice dish",
                        LongDescription = "Pulav is a versatile dish, and its variations are endless. The choice of ingredients and spices can vary based on regional and personal preferences. It can be served as a standalone dish or as a side to other main courses.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://4.bp.blogspot.com/-qWzc-7lpAXk/WIEb8Z55zmI/AAAAAAAACdE/iewzgRqTP2Q-TdRenIB3zLueuE9rW2nIQCLcB/s1600/vegetable%2Bpulao.JPG",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://4.bp.blogspot.com/-qWzc-7lpAXk/WIEb8Z55zmI/AAAAAAAACdE/iewzgRqTP2Q-TdRenIB3zLueuE9rW2nIQCLcB/s1600/vegetable%2Bpulao.JPG",
                    },
                    new food
                    {
                        Name = "Paneer Masala ",
                        Price = 150,
                        ShortDescription = "Popular and flavorful North Indian vegetarian dish .",
                        LongDescription = "Paneer Masala, also known as Paneer Tikka Masala, is a popular and flavorful North Indian vegetarian dish that features paneer, which is Indian cottage cheese, in a rich and creamy tomato-based gravy.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://bing.com/th?id=OSK.36ef5c22ffde4107d3a85c5dd223627b",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://bing.com/th?id=OSK.36ef5c22ffde4107d3a85c5dd223627b",
                    },
                    new food
                    {
                        Name = "Dosa",
                        Price = 40,
                        ShortDescription = "Dosa is a popular South Indian dish",
                        LongDescription = "Dosa is loved for its thin, crispy texture, fermented flavor, and the ability to be customized with different fillings and accompaniments. It's a staple of South Indian cuisine and a cherished food in Indian culinary traditions.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://bing.com/th?id=OSK.f4c5fed555a42cc4618cbdb7fcfcdd95",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://bing.com/th?id=OSK.f4c5fed555a42cc4618cbdb7fcfcdd95",
                    },
                    new food
                    {
                        Name = "Moong Dal Halwa",
                        Price = 40,
                        ShortDescription = "Moong Dal Halwa is a delicious and rich dessert",
                        LongDescription = "Moong Dal Halwa is typically served hot and is a favorite dessert during festivals, special occasions, and celebrations in India. It is enjoyed for its creamy, rich, and nutty taste. It can be served as a standalone dessert or paired with a scoop of vanilla ice cream for a delightful combination of hot and cold.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://bing.com/th?id=OSK.d1386d8ffa0a30ce54385b2d8a54b688",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://bing.com/th?id=OSK.d1386d8ffa0a30ce54385b2d8a54b688",
                    },
                    new food
                    {
                        Name = "Aloo Mutter",
                        Price = 60,
                        ShortDescription = "Classic North Indian vegetarian dish",
                        LongDescription = "Aloo Mutter is typically served hot and can be paired with various Indian bread like roti, naan, or paratha, or it can be served with steamed rice. It's a hearty and comforting dish enjoyed in North India and is a favorite among both vegetarians and non-vegetarians..",
                        Category = Categories["Veg"],
                        ImageUrl = "https://www.cubesnjuliennes.com/wp-content/uploads/2020/07/Punjabi-Aloo-Matar.jpg",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.cubesnjuliennes.com/wp-content/uploads/2020/07/Punjabi-Aloo-Matar.jpg",
                    },
                    new food
                    {
                        Name = "Paneer Tikka",
                        Price = 100,
                        ShortDescription = "Popular Indian appetizer",
                        LongDescription = "Paneer Tikka is typically served as a starter or appetizer. It's a beloved snack at parties, celebrations, and in Indian restaurants. The smoky and spicy flavors make it a popular choice for those who enjoy Indian cuisine.",
                        Category = Categories["Veg"],
                        ImageUrl = "https://bing.com/th?id=OSK.264dc5309c6402fd341bc77e3041dd95",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://bing.com/th?id=OSK.264dc5309c6402fd341bc77e3041dd95",
                    },
                    new food
                    {
                        Name = "Chana Masala",
                        Price = 80,
                        ShortDescription = "Popular North Indian and Punjabi dish.",
                        LongDescription = "Chana Masala is typically served hot and can be paired with various Indian bread like roti, naan, or paratha, or with steamed rice. It's a hearty and satisfying dish, loved by vegetarians and non-vegetarians alike",
                        Category = Categories["Veg"],
                        ImageUrl = "https://th.bing.com/th/id/OIP.d5yUgcF3drOgAQ_fDFP_qgHaFq?pid=ImgDet&rs=1",
                        InStock = false,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.d5yUgcF3drOgAQ_fDFP_qgHaFq?pid=ImgDet&rs=1",
                    },
                    new food
                    {
                        Name = "Tandoori Chicken ",
                        Price = 120,
                        ShortDescription = "Classic and well-loved Indian dish.",
                        LongDescription = "Tandoori Chicken is a classic and well-loved Indian dish known for its smoky and flavorful taste. It is made by marinating chicken pieces in a mixture of yogurt and spices, and then cooking it in a tandoor, a traditional clay oven.",
                        Category = Categories["Non-Veg"],
                        ImageUrl = "https://www.licious.in/blog/wp-content/uploads/2020/12/Tandoori-Chicken.jpg",
                        InStock = true,
                        IsPreferredfood = true,
                        ImageThumbnailUrl = "https://www.licious.in/blog/wp-content/uploads/2020/12/Tandoori-Chicken.jpg",
                    },
                    new food
                    {
                        Name = "Mutton Biryani ",
                        Price = 100,
                        ShortDescription = " Popular South Asian dish ",
                        LongDescription = "Mutton Biryani is a delicious and aromatic South Asian dish known for its flavorful combination of rice, tender mutton (goat or lamb), and a blend of spices. It's a popular and much-loved one-pot meal that's often served at special occasions, gatherings, and celebrations.",
                        Category = Categories["Non-Veg"],
                        ImageUrl = "https://1.bp.blogspot.com/-6O14eb7OjZA/V3ywHpi1koI/AAAAAAAAACg/dJAZ35Hjz1k_PuwNl8-oswTkCyAd86powCLcB/s1600/Mutton-Biriyani-Non-Vegetarian-Recipe.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://1.bp.blogspot.com/-6O14eb7OjZA/V3ywHpi1koI/AAAAAAAAACg/dJAZ35Hjz1k_PuwNl8-oswTkCyAd86powCLcB/s1600/Mutton-Biriyani-Non-Vegetarian-Recipe.jpg",
                    },
                    new food
                    {
                        Name = "Chicken Kabab ",
                        Price = 150,
                        ShortDescription = " Chicken Kebabs are commonly served as an appetizer",
                        LongDescription = "Chicken Kebab, also known as Chicken Kabab, is a popular dish made from marinated pieces of chicken that are skewered and grilled or roasted. It's a favorite appetizer and snack in many cuisines around the world, with various regional variations",
                        Category = Categories["Non-Veg"],
                        ImageUrl = "https://th.bing.com/th/id/OIP.zjvXrozyBc2Nhe5uWvhM9AHaHF?pid=ImgDet&rs=1",
                        InStock = true,
                        IsPreferredfood = true,
                        ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.zjvXrozyBc2Nhe5uWvhM9AHaHF?pid=ImgDet&rs=1",
                    },
                    new food
                    {
                        Name = "Fish Tacos",
                        Price = 150,
                        ShortDescription = "Fish Tacos are typically served as a main dish",
                        LongDescription = "Fish Tacos are a popular and delicious dish with Mexican origins that has become widely enjoyed around the world. They typically consist of battered or grilled fish fillets served in tortillas with various toppings and condiments. ",
                        Category = Categories["Non-Veg"],
                        ImageUrl = "https://tatyanaseverydayfood.com/wp-content/uploads/2017/07/Fish-Tacos-with-Mango-Salsa-3.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://tatyanaseverydayfood.com/wp-content/uploads/2017/07/Fish-Tacos-with-Mango-Salsa-3.jpg",
                    },
                    new food
                    {
                        Name = "Butter Chicken ",
                        Price = 130,
                        ShortDescription = "Murgh Makhani",
                        LongDescription = "Butter Chicken is typically served hot and is often accompanied by naan bread, roti, or steamed rice. It's garnished with fresh coriander leaves and served with a side of raita (yogurt with herbs and spices) and pickle",
                        Category = Categories["Non-Veg"],
                        ImageUrl = "https://i1.wp.com/carameltintedlife.com/wp-content/uploads/2020/05/The-best-butter-chicken-recipe-1-of-1-6-scaled.jpg?fit=1537%2C2048&ssl=1",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://i1.wp.com/carameltintedlife.com/wp-content/uploads/2020/05/The-best-butter-chicken-recipe-1-of-1-6-scaled.jpg?fit=1537%2C2048&ssl=1",
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, category>? categories;
        public static Dictionary<string, category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new category[]
                    {
                        new category { CategoryName = "Veg", Description="All Veg dishes" },
                        new category { CategoryName = "Non-Veg", Description="All non-veg dishes" }
                    };

                    categories = new Dictionary<string, category>();

                    foreach (category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}

