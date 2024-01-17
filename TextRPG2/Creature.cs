using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG2
{
    public enum CreatureType
    {
        None = 0,
        Player = 1,
        Monster = 2
    }

    class Creature
    {
        protected CreatureType _type;
        protected int _hp = 0;
        protected int _attack = 0;

        protected Creature(CreatureType type)
        {
            this._type = type;
        }

        public void SetInfo(int hp, int attack)
        {
            this._hp = hp;
            this._attack = attack;
        }

        public int GetHp() { return this._hp; }
        public int GetAttack() { return this._attack; }
        public bool IsDead() { return this._hp <= 0; }
        public void OnDamaged(int damage)
        {
            this._hp -= damage;
            if (this._hp < 0) { this._hp = 0; }
        }
    }
}
