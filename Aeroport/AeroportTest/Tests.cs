using System;
using Aeroport;
using NUnit.Framework;

namespace AeroportTest
{
    [TestFixture]
    public class Tests//модульное тестирование-провереям работспомсобность проекта-в данному случае один тест проверка имени-добавления пользовтаеля
    {
        private UserManager userManager = new UserManager("Server=127.0.0.1;Database=aeroport;UID=root;PWD=Plm19941967", "User");

        [SetUp]
        public void Setup()
        {
            userManager.DeleteAll();//очищает данные перед каждым тестом
        }
        

        [Test]
        public void TestCreateUser()
        {
            userManager.Create("Andrei1954", "Zaur14", "IVAN", "Andreev", 25, 10);
            Buyer b = userManager.Get("Andrei1954");
            Assert.AreEqual("IVAN",b.Name);//будем плли равен b.name=ivan
        }
    }
}