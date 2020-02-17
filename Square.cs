namespace battle_ship_in_the_oo_way_stare_bosmany
{
    class Square
    {
        private string occupied = " ";
        private int x, y;
        public string Occupied
        {
            get {return occupied;}
            set {
                if(value.Equals("x") || value.Equals("o") || value.Equals(" "))
                {
                    occupied = value;
                }
            }
        }

        public Square(int x, int y)
        {
            this.x = x; //do zmiennej instancyjnej mozna sie odwolac za pomoca this.
            this.y = y;
        }
    }
}