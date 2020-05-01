namespace SheepRace
{
    public static class Factory
    {
        // Decides which class to instantiate
        public static Punter GetAPunter(int id)
        {
            switch (id)
            {
                case 0: return new Satpreet();
                case 1: return new Dilpreet();
                case 2: return new Shelly();
                default: return null;
            }
        }

    }
}
