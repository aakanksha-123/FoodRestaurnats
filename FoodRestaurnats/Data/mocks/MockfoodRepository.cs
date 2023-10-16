using FoodRestaurnats.Data.interfaces;
using FoodRestaurnats.Data.Models;

namespace FoodRestaurnats.Data.mocks
{
    public class MockfoodRepository : IfoodRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        //public IEnumerable<food> foods { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<food> foods => new List<food>
                {
                    new food {
                        Name = "Puranpoli",
                        Price = 50, ShortDescription = "The most popular dish",
                        LongDescription = "pavbhaji is the world's most poupular dish, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://recipes.timesofindia.com/thumb/55045560.cms?imgsize=252832&width=800&height=800",
                        InStock = true,
                        IsPreferredfood = true,
                        ImageThumbnailUrl = "https://recipes.timesofindia.com/thumb/55045560.cms?imgsize=252832&width=800&height=800"
                    },
                    new food {
                        Name = "pavbhaji",
                        Price = 60, ShortDescription = "pavbjhaji made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.thestatesman.com/wp-content/uploads/2019/07/pav-bhaji.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.thestatesman.com/wp-content/uploads/2019/07/pav-bhaji.jpg"
                    },
                    new food {
                        Name = "vegthali",
                        Price = 12.95M, ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://i.pinimg.com/originals/a2/bb/d5/a2bbd55e26b31e5157b770d5e5292c0d.jpg",
                        InStock = true,
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://i.pinimg.com/originals/a2/bb/d5/a2bbd55e26b31e5157b770d5e5292c0d.jpg"
                    },
                    new food
                    {
                        Name = "Chole bature ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl ="https://www.yumcurry.com/wp-content/uploads/2021/08/chole-bhature.jpg",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://www.yumcurry.com/wp-content/uploads/2021/08/chole-bhature.jpg"
                    },
                     new food
                    {
                        Name = "Dal tadka ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl ="https://foodiewish.com/wp-content/uploads/2020/07/Yellow-Dal-Tadka-Recipe.jpg",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://foodiewish.com/wp-content/uploads/2020/07/Yellow-Dal-Tadka-Recipe.jpg"
                    },
                      new food
                    {
                        Name = "Veg biryani ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl ="https://th.bing.com/th/id/OIP.Wiw3y-pnb0KqoPH3rngKnAHaGd?pid=ImgDet&rs=1",
                        IsPreferredfood = false,
                        ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.Wiw3y-pnb0KqoPH3rngKnAHaGd?pid=ImgDet&rs=1"
                    }
                };
        public IEnumerable<food>? Preferredfood { get; }

        //public IEnumerable<food> Preferredfood => throw new NotImplementedException();

        //IEnumerable<food> IfoodRepository.Preferredfood { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        public food GetfoodById(int foodId)
        {
            throw new NotImplementedException();
        }
    }

}
