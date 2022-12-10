namespace Logger
{
    using Players;
    public interface ILogger
    {
        void PrintStart();
        void PrintWrongNumber();
        void PrintNumberPlayers();
        void PrintTour(int numberTour);
        void PrintEnd(IPlayer winner);
        void PrintVersus(IPlayer firstPlayer, IPlayer secondPlayer);
        void PrintAttack(IPlayer playerAttack, IPlayer playerDefend);
        void PrintUltimate(IPlayer playerAttack, IPlayer playerDefend, int randomUlt);
        void PrintEffect(IPlayer player);
        void PrintDefeat(IPlayer loser);
    }
}
