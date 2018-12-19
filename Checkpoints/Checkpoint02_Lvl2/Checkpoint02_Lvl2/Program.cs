using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Checkpoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid;
            List<Room> roomList = new List<Room>();

            do
            {
                string rooms = GetRoomsFromUser();
                roomList = CreateListOfRooms(rooms);
                isValid = RoomsAreValid(roomList);
                
                PrintLitUpRooms(roomList);
                PrintLargestRoom(roomList);
                PrintNumberOfRooms(roomList);

                Console.WriteLine();


            } while (!isValid); //eller använda oneMore här och göra en egen loop för string rooms grejen/valideringsgrejen?

        }

        private static bool RoomsAreValid(List<Room> roomList)
        {

            foreach (var room in roomList)
            {
                //Rumssarea i rätt format?
                //if (Regex.IsMatch(room.Area.ToString(), @"^[1-9]\d+$"))
                //{
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.WriteLine($"{room.Area} is in invalid format!");
                //    return false;
                //}

                if (!Regex.IsMatch(room.Name ?? "", @"^[a-zåäöA-ZÅÄÖ]*$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{room.Name} is in invalid format!");
                    return false;
                }
                else if (!Regex.IsMatch(room.LightsOnOrOff ?? "", @"^(On|Off)$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{room.LightsOnOrOff} is in invalid format!");
                    return false;
                }
                else
                    return true;
            }
            return true;

        }

        private static string GetRoomsFromUser()
        {
            Console.WriteLine("Ange namn på rum: ");
            string rooms = "Kök 20m2 On | Sovrum 8m2 Off | Badrum 5m2 On";
            //string rooms = Console.ReadLine();
            return rooms;
        }

        private static List<Room> CreateListOfRooms(string rooms)
        {
            string[] roomArray = rooms.Split('|');

            List<Room> roomList = new List<Room>();

            foreach (var room in roomArray)
            {
                string[] eachRoom = room.Trim().Split(' ');

                var r = new Room();
                r.Name = eachRoom[0].ToString();
                r.Area = int.Parse(eachRoom[1].Replace("m2", ""));
                r.LightsOnOrOff = eachRoom[2].ToString();
                roomList.Add(r);
            }
            return roomList;
        }

        private static void PrintLitUpRooms(List<Room> roomList)
        {
            var litUpRooms = roomList.Where(x => x.LightsOnOrOff == "On").ToList();

            Console.ForegroundColor = ConsoleColor.Green;
            if (litUpRooms.Count > 0)
            {
                Console.Write($"Ljuset är tänt i {string.Join(" och ", litUpRooms.Select(x => x.Name)).ToString()} ");
            }
            Console.ResetColor();
        }

        private static void PrintLargestRoom(List<Room> roomList)
        {
            var roomsOrderedBySize = roomList.OrderByDescending(x => x.Area);
            var largestRoom = roomsOrderedBySize.First();

            Console.WriteLine();
            WriteGreen($"Det största rummet är {largestRoom.Name} med {largestRoom.Area}m2");
        }

        private static void PrintNumberOfRooms(List<Room> roomList)
        {
            WriteGreen($"Lägenheten består av {roomList.Count} rum");
        }

        private static void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
