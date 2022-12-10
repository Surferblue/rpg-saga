namespace Selector
{
    using Logger;
    public class Selector
    {
        private int ChoiceNewHero { get; set; }
        private ILogger Logger { get; set; }
        private List<bool> NewClasses { get; set; } = new List<bool>();

        public Selector(ILogger logger)
        {
            Logger = logger;
            NewClasses.Add(false);
            NewClasses.Add(false);
            NewClasses.Add(false);
            NewClasses.Add(false);
            NewClasses.Add(false);
        }
        public List<bool> SelectCustomClass()
        {
            return NewClasses;
        }

        public int SelectNumbPlayers()
        {
            int playersNumbers;

            while (true)
            {
                Logger.PrintNumberPlayers();

                string? numberOfPlayers = Console.ReadLine();

                if (int.TryParse(numberOfPlayers, out int i) && (i % 2 == 0))
                {
                    playersNumbers = i;
                    break;
                }
                else
                {
                    Logger.PrintWrongNumber();
                }
            }
            return playersNumbers;
        }
    }
}
