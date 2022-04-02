namespace BattleRoomLib.Models
{
    public abstract class HeroSpecialization
    {
        public string Name { get; protected set; }

        public int Damage { get; set; }
    }
}
