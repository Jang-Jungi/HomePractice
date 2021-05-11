using System;

namespace _5번
{
    class MainApp
    {
        static void Main(string[] args)
        {
            IAnimal dog = new 강아지();
            
            dog.Sleep("개");
            dog.Sound("개");
            dog.Eat("개");
            
            강아지 dog1 = new();
            dog1.Age = 123412;
            dog1.color = "White";
            
            IAnimal Cat = new 고양이();

            Cat.Sleep("고양이");
            Cat.Sound("고양이");
            Cat.Eat("고양이");

            IAnimal horse = new 말();

            horse.Sleep("말");
            horse.Sound("말");
            horse.Eat("말");
        }
    }
}
