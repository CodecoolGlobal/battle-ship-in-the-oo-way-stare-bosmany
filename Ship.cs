using System.Collections.Generic;

namespace battle_ship_in_the_oo_way_stare_bosmany
{
    class Ship
    {
        private Square[] squareArray;
        private bool vertical;
        private string shipType;
        public Ship(Square[] squareArray, string type, bool vertical = false)
        {
            this.squareArray = squareArray;
            for(int i = 0; i < squareArray.Length; i++)
            {
                squareArray[i].Occupied = "x";
            } 
            this.vertical = vertical;
            shipType = type;
        }
        public Ship(Square squareObj)
        {
            //squares = new Square[1] {squareObj}; //to samo w jednej linijce z inicjalizacja
            squareArray = new Square[1]; //uzycie konstruktora to array of squares
            squareArray[0] = squareObj;
        }
    }
}