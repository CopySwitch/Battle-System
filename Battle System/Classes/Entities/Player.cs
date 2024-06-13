using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    public class Player : Entity
    {
        protected string ClassName;
        public Player(string name) : base(name)
        {
            GiveItem(new Item("food", "some food"));
            GiveItem(new Item("torch", "a torch"));
            GiveItem(new Item("map", "a map"));
            ClassName = "None";
        }
        internal void GiveItem(Item item)
        {
            
        }
        public string GetClassName()
        {
            return ClassName;
        }
    }
    public class Fighter : Player
    {
        public Fighter(string name) : base(name) 
        {
            strength = 5;
            ClassName = "Fighter";
            EquipItem(new Weapon("sword", "a basic sword", 1));
        }
    }
    public class Mage : Player
    {
        public Mage(string name) : base(name)
        {
            strength = 3;
            ClassName = "Mage";
            EquipItem(new Weapon("Grimore", "A basic Grimore given to magic scollars", 1));
        }
    }
    public class Ranger : Player
    {
        public Ranger(string name) : base(name)
        {
            strength = 4;
            ClassName = "Ranger";
            EquipItem(new Weapon("Wooden Bow", "a basic bow", 1));
        }
        public override int Attack()
        {
            Console.WriteLine("Arrow ");
            return 1000;
        }
    }
}
