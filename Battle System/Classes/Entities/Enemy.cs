using Battle_System.Classes.Entities;
using Battle_System.Classes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_System.Classes.Entities
{
    internal class Enemy : Entity
    {
        public Enemy(string name) : base(name)
        {

        }
    }
    internal class Skeleton : Enemy
    {
        public Skeleton() : base("Skeleton")
        {
            strength = 1;
            EquipItem(new Weapon("Skeletal Hand", "hand from a skeleton", 1));
        }
    }
    internal class Goblin : Enemy
    {
        public Goblin() : base("Goblin")
        {
            strength = 2;
            EquipItem(new Weapon("copper dagger", "decaying copper dagger", 1));
        }
    }
    internal class JhonWarhammer : Enemy
    {
        public JhonWarhammer() : base("Jhon Warhammer")
        {
            strength = 40000;
            EquipItem(new Weapon("40000 WARHAMMERS!!", "Holy shit its the 40000 warhammers that jhon warhammer collected", 1));
        }
    }
}

