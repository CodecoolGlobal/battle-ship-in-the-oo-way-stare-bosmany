namespace battle_ship_in_the_oo_way_stare_bosmany
{
    class Ocean
    {
        private string name;
        private Square[,] array2d;
        private Ship[] shipArray = new Ship[5];
        private int totalShips = 0;
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
            if(totalShips == shipArray.Length)
            {
                return false;
            }

            int shipLength = GetShipLength(type);
            //bool spaceOk = CheckSpace(x, y, shipLength)
            //if(~spaceOk || shipLength == 0)
            //  return false

            //stworz pod tablice Square dla statku
            //stworz tablice Squre o odpowiednim rozmiarze
            if(vertical)
            {
                
            }

            //shipArray[totalShips] = new Ship(new , type, vertical);
            totalShips++;
            return true;
        }
        
    }
}