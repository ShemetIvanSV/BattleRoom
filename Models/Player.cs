namespace BattleRoomLib.Models
{
    public class Player
    {
        public string Name { get; set; }

        public HeroSpecialization Specialization { get; set; }

        public Player(string name)
        {
            Specialization = new Mage();
            Name = name;
        }

        public int Attack()
        {
            return Specialization.Damage;
        }
    }
}
