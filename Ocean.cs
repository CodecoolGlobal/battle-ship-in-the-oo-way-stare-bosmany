namespace battle_ship_in_the_oo_way_stare_bosmany
{
    class Ocean
    {
        private string name;
        private Square[,] array2d;
        private Ship[] shipArray = new Ship[5];
        private int shipCounter = 0; //licznik statkow
        private string[] shipTypes = {"Carrier", "Battleship", "Cruiser", "Submarine", "Destroyer"};

        
        public Ocean(int size, string name) // constructor
        {
            this.name = name;

            array2d = new Square[size, size];
            for(int row = 0; row < size; row++)
            {
                for(int col = 0; col < size; col++)
                {
                    array2d[row, col] = new Square(row, col);
                }
            }

        }
        private int GetShipLength(string type)
        {
            int shipLength = 0;
        
            if(type.Equals(shipTypes[0]))
            {
                shipLength = 5;
            } 
            else if(type.Equals(shipTypes[1]))
            {
                shipLength = 4;
            }
            else if(type.Equals(shipTypes[2]) || type.Equals(shipTypes[3]))
            {
                shipLength = 3;
            }
            else if(type.Equals(shipTypes[4]))
            {
                shipLength = 2;
            }
            return shipLength;
        }

        public bool CreateShip(int x, int y, string type, bool vertical = false)
        {
            //shipArray pelna - zakoncz dzialanie i zwroc false
            if(shipCounter == shipArray.Length)
            {
                return false;
            }

            int shipLength = GetShipLength(type);
            //bool spaceOk = CheckSpace(x, y, shipLength)
            //if(~spaceOk || shipLength == 0)
            //  return false


            //stworz pod tablice Square dla statku
            //stworz tablice Squre o odpowiednim rozmiarze
            Square[] tempSquareArray = new Square[shipLength];
            if(vertical)
            {
                for(int i = 0; i < shipLength; i++)
                {
                    tempSquareArray[i] = array2d[x + i, y];
                }
            }
            else
            {
                for(int i = 0; i < shipLength; i++)
                {
                    tempSquareArray[i] = array2d[x, y + i];
                }
            }

            shipArray[shipCounter] = new Ship(tempSquareArray, type, vertical);
            shipCounter++;
            
            return true;
        }

        public string GetSquareStatus(int x, int y)
        {
            return array2d[x, y].Occupied;
        }
        
    }
}