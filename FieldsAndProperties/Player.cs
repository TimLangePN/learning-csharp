namespace FieldsAndProperties
{
    class Player
    {
        //Field
        private int _lives = 100;

        //Computed Property
        public int Lives { 
            get 
            {
                return _lives;
            }
            set 
            {
                if (value <= 0 || value >= 1000)
                {
                    Console.WriteLine("Incorrect value");
                    return;
                }

                _lives = value;
            }
        }

    }
}
