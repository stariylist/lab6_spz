using System;

namespace SPZ_Lab6.Model
{
    class Guest
    {
        public string GuestLastName { get; set; }
        public string GuestFirstName { get; set; }
        public int Days { get; set; }
        private static string[] lastNamesArray = new string[] { "Коваленко", "Коваль", "Токарь", "Гончар", "Гончаренко",
                                                                 "Притула", "Осадчих", "Зборовських", "Чепурных", "Писаренко",
                                                                  "Лоленко", "Приколенко", "Дваченко", "Русских", "Путин", "Порошенко"};
        private static string[] firstNamesArray = new string[] { "Виктор","Владислав", "Джейс", "Винсент", "Сергей", "Артур",
                                                                 "Александр", "Ксения","Виолетта", "Ольга", "Мария","Вероника",
                                                                  "Екатерина", "Джонатан", "Джозеф", "Джотаро", "Дио",
                                                                  "Аанг", "Наруто", "Рамен", "Дариус", "Зевс", "Виктория"};
        static Random random = new Random();
        public Guest()
        {
            GuestLastName = lastNamesArray[random.Next(0, lastNamesArray.Length)];
            GuestFirstName = firstNamesArray[random.Next(0, firstNamesArray.Length)];
            Days = random.Next(1, 5);
        }
        public Guest(string lastName, string firstName, int days)
        {
            GuestLastName = lastName;
            GuestFirstName = firstName;
            Days = days;
        }
    }
}
