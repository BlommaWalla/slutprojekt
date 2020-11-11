using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace slutprojekt {
    class Program {
        static int RoomOverflowFix(int room, int roomLength) {
            int n;

            if (room > roomLength) {
                room = 0;
            } else if (room < 0) {
                room = roomLength;
            }
            n = room;

            return n;
        }




        static Array NextRoom(int currentRoom, int roomLength, int roomAmount) {
            List<int> n = new List<int>();
            int[] m = new int[roomAmount + 1];

            int lmao;
            Random random = new Random();
            n.Add(currentRoom);

            while (n.Count < roomAmount + 1) {
                lmao = random.Next(0, roomLength);

                if (!n.Contains(lmao)) {
                    n.Add(lmao);
                    Console.WriteLine(lmao);
                }

            }
            Console.WriteLine();
            m = n.ToArray();

            return m;
        }



        static int RoomParse(string ans) {
            int n = 0;
            bool parseLoop = true;

            while (parseLoop) {
                bool success = int.TryParse(ans, out n);


                if (success) {
                    parseLoop = false;
                    Console.WriteLine(n);

                } else {
                    Console.WriteLine("pls skriv ett nummer. (1 - 3)");
                    ans = Console.ReadLine();

                }
            }

            return n;
        }




        static void Main(string[] args) {
            string[,] rooms = {{"Korridoren, vilken kool plats", "Korridoren, den är trång, varm och luktar civil-elev. "},
                {"Nördarnas myshörna, 508", "När man tittar in genom glasdörren ser man origami, figurines, bilden på det svarta hålet och mer. Man ser också Japanska, över allt. Delvis för att Yoko finns där men också för att alla i rummet är weebs."},
                {"Karwans Kontor", "Vissa säger att om du går in kommer du inte ut igen. Jag kännde en grabb som tog mod till sig och gick in dit för att prata om matkortet. Jag har inte sett honom sen dess men efter att han gick in dök 2 stycken McDonalds upp på matkortet. Coincidence? I THINK NOT!"},
                {"room 4", "the fourth room"},
                {"room 5", "the fifth room"},
                {"room 6", "owo? A sixth room‽!?"}};

            bool gotKey = false;
            bool gameLoop = true;
            int newRooms = 3;
            int currentRoom = 0;
            int[] givenRooms = new int[newRooms + 1];
            string ans;
            int chosenRoom;


            Console.WriteLine("Välkommen till NTI, just nu är du i " + rooms[0, 0]);
            Console.WriteLine(rooms[0, 1] + "Men oroa dig inte. Du kan nämligen gå till:");
            Console.WriteLine();




            while (gameLoop) {

                //givenRooms = NextRoom(currentRoom, rooms.Length, 3);
                for (int i = 0; i < 4; i++) {
                    Console.WriteLine(NextRoom(currentRoom, rooms.Length, 3));
                }

                Console.WriteLine("Vart vill du gå? (1 - 3)");
                ans = Console.ReadLine();
                chosenRoom = RoomParse(ans);


                while (chosenRoom > 3 || chosenRoom < 1) {
                    if (chosenRoom > 3 || chosenRoom < 1) {
                        Console.WriteLine("Inget annat än 1 - 3 pls");
                        ans = Console.ReadLine();
                        RoomParse(ans);

                    }
                }

                //Console.WriteLine("ait så basically walla " + givenRooms[chosenRoom]);







                //currentRoom = roomOverflowFix(currentRoom, rooms.GetLength(0));
                //Console.WriteLine("walla" + rooms.GetLength(0));

                //for (int i = 0; i < nextRoom(currentRoom, rooms.GetLength(0), newRooms).Count; i++) {
                //    Console.Write(nextRoom(currentRoom, rooms.GetLength(0), newRooms)[i]);
                //}


                //Console.WriteLine("Välkommen till NTI, just nu är du i " + rooms[0, 0]);
                //Console.WriteLine(rooms[0, 1] + "Men oroa dig inte. Du kan nämligen gå till:");
                //Console.WriteLine();


                //for (int i = 0; i < nextRoom(currentRoom, rooms.GetLength(0), newRooms).Count; i++) {
                //    Console.WriteLine(rooms[nextRoom(currentRoom, rooms.GetLength(0), newRooms)[i], 0]);

                //}




                Console.ReadLine();
            }


        }
    }
}
