namespace Logger
{
    using Players;
    using Effects;
    public class GameLogger : ILogger
    {
        public void PrintStart()
        {
            Console.WriteLine("\nДобро пожаловать в RPG SAGA!");
        }
        public void PrintWrongNumber()
        {
            Console.WriteLine("Неправильное число!");
        }
        public void PrintNumberPlayers()
        {
            Console.WriteLine("Выберите число игроков:");
        }

        public void PrintTour(int numberTour)
        {
            Console.WriteLine($"Кон {numberTour}.\n");

        }

        public void PrintVersus(IPlayer firstPlayer, IPlayer secondPlayer)
        {
            Console.WriteLine($"({firstPlayer.ClassName}) {firstPlayer.Name} vs ({secondPlayer.ClassName}) {secondPlayer.Name}");
        }

        public void PrintAttack(IPlayer playerAttack, IPlayer playerDefend)
        {
            Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
        }

        public void PrintUltimate(IPlayer playerAttack, IPlayer playerDefend, int randomUlt)
        {
            if (playerAttack.ClassName == "Маг")
            {
                Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
            }
            else if (playerAttack.ClassName == "Рыцарь")
            {
                Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
            } else if (playerAttack.ClassName == "Лучник")
            {
                Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и поджигает противника ({playerDefend.ClassName}) {playerDefend.Name}");
            } else if (playerAttack.ClassName == "Огненный маг")
            {
                if (playerAttack.Abilities[randomUlt].AbilityName == "Заморозка")
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
                else
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
                }
            }
            else if (playerAttack.ClassName == "Воин")
            {
                if (playerAttack.Abilities[randomUlt].AbilityName == "Удар возмездия")
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и наносит урон {playerAttack.Strength} противнику ({playerDefend.ClassName}) {playerDefend.Name}");
                }
                else
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
            }
            else if (playerAttack.ClassName == "Оборотень"|| playerAttack.ClassName == "Волколак")
            {
                if (playerAttack.Abilities[randomUlt].AbilityName == "Кровотечение")
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и ранит противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
            }
            else if (playerAttack.ClassName == "Вор" || playerAttack.ClassName == "Разбойник")
            {
                if (playerAttack.Abilities[randomUlt].AbilityName == "Удар со спины")
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
            }
            else if (playerAttack.ClassName == "Стрелок")
            {
                if (playerAttack.Abilities[randomUlt].AbilityName == "Огненные стрелы")
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) и поджигает противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
                else
                {
                    Console.WriteLine($"({playerAttack.ClassName}) {playerAttack.Name} использует ({playerAttack.Abilities[randomUlt].AbilityName}) на противника ({playerDefend.ClassName}) {playerDefend.Name}");
                }
            }
        }

        public void PrintEffect(IPlayer player)
        {
            foreach (var effect in player.MyEffects)
            {
                if (effect is Stun)
                {
                    Console.WriteLine($"({player.ClassName}) {player.Name} пропускает ход!");
                }

                if (effect is LongDamage longDamage)
                {
                    Console.WriteLine($"({player.ClassName}) {player.Name} получает урон {longDamage.Factor}");
                }
            }

        }

        public void PrintDefeat(IPlayer loser)
        {
            Console.WriteLine($"({loser.ClassName}) {loser.Name} погибает! \n\n");
        }

        public void PrintEnd(IPlayer winner)
        {
            Console.WriteLine($"({winner.ClassName}) {winner.Name} побеждает! \nThe END...");
        }
    }
}
