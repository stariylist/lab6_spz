using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SPZ_Lab6.Model
{
    static class Hotel
    {
        static public int CountRooms = 100;
        static public Dictionary<int, Guest> HotelDictionary;
        [DataMember]
        static public List<Room> Rooms;
        static public decimal Income { get; set; } = 0;
        static Random rand = new Random();
        static Hotel()//заполняем отель рандомными значениями
        {
            HotelDictionary = new Dictionary<int, Guest>();
            Rooms = new List<Room>();
            for (int i = 1; i <= CountRooms; i++)
            {
                HotelDictionary.Add(i, null);
                Rooms.Add(new Room(i));
            }
        }
        static public void Generate()//кол-во занятых комнат
        {
            int numberOccupiedRooms = rand.Next(30, 60);
            Filling(numberOccupiedRooms);
        }
        static public int OccupiedRooms()=> HotelDictionary.Where(item => item.Value != null).Count();
        static void Filling(int numberOccupiedRooms)//заполнение
        { 
            for (int i = 1; i <= numberOccupiedRooms; i++)
            {
                int number = rand.Next(1, CountRooms + 1);
                if (HotelDictionary[number] == null)
                {
                    Rooms[number - 1].Settling();
                    HotelDictionary[number] = new Guest();
                    Income += HotelDictionary[number].Days * Rooms[number - 1].Price;
                    Form1.Occupied++;
                }
            }
        }
        static public void FillingWithTourists()
        {
            while(Form1.Occupied < 100)
            {
            Filling(CountRooms); 
            } 
        }
    }
}
