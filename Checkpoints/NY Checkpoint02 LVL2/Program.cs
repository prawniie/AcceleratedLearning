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
            string rooms;

            while (true)
            {
                try
                {
                    rooms = GetRoomsFromUser();

                    if (rooms.ToLower() == "exit")
                    {
                        break;
                    }

                    IEnumerable<Room> roomList = CreateListOfRooms(rooms);
                    //PrintRooms(roomList);
                    PrintLargestRoom(roomList);
                    PrintLitUpRooms(roomList);
                    PrintNumberOfRooms(roomList);

                }
                catch (ArgumentException ex)
                {
                    ErrorMessage(ex.Message);
                }
            }
        }

        private static string GetRoomsFromUser()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write("Enter rooms (write \"exit\" to exit): ");
            string rooms = Console.ReadLine();

            if (rooms.Length == 0 || string.IsNullOrWhiteSpace(rooms))
            {
                throw new ArgumentException("Invalid input data");
            }

            //string rooms = "Kitchen 8m2 On | Bathroom 4m2 On | Bedroom 10m2 Off";
            return rooms;
        }

        private static List<Room> CreateListOfRooms(string rooms)
        {
            string[] roomsArray = rooms.Split('|');

            List<Room> roomList = new List<Room>();

            foreach (var room in roomsArray)
            {
                string[] eachRoom = room.Trim().Split(' ');
                var r = new Room();

                //Validating name
                string name = eachRoom[0];
                if (Regex.IsMatch(name, @"^[a-zåäö]*$", RegexOptions.IgnoreCase))
                {
                    r.Name = name;
                }
                else
                    throw new ArgumentException("Invalid input data!");

                //Validating area
                int area = int.Parse(eachRoom[1].Replace("m2", ""));
                if (area > 0 && area < 250)
                {
                    r.Area = area;
                }
                else
                    throw new ArgumentException("Invalid input data");

                //Validating lights on or off
                string lights = eachRoom[2];
                if (Regex.IsMatch(lights, @"^(On|Off)$", RegexOptions.IgnoreCase))
                {
                    r.LightsOnOrOff = lights;
                }
                else
                    throw new ArgumentException("Invalid input data");

                roomList.Add(r);
            }

            return roomList;
        }

        private static void PrintRooms(IEnumerable<Room> roomList)
        {
            var print = roomList.Select(x => $"Room name: {x.Name}");
            WriteGreen(string.Join("\n", print));
        }

        private static void PrintLargestRoom(IEnumerable<Room> roomList)
        {
            var largestRoom = roomList.OrderByDescending(x => x.Area).First();

            WriteGreen($"\nThe largest room is: {largestRoom.Name} with {largestRoom.Area}m2");
        }

        private static void PrintLitUpRooms(IEnumerable<Room> roomList)
        {
            var litUpRooms = roomList.Where(x => x.LightsOnOrOff.ToLower() == "on");

            if (litUpRooms.Any())
            {
                WriteGreen($"The lights are on in {string.Join(" and ", litUpRooms.Select(x => x.Name)).ToString()}");
            }
        }

        private static void PrintNumberOfRooms(IEnumerable<Room> roomList)
        {
            WriteGreen($"There are {roomList.ToList().Count} rooms in the apartment\n");
        }

        private static void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
