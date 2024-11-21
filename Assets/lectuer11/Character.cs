using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Assignment18
{
    public class Character : MonoBehaviour
    {
        public string name;
        private int health;
        protected Position Position;
        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

        public Character(string name, int health, Position Position)
        {
            this.name = name;
            Health = health;
            this.Position = Position;
        }
        public Character()
        {
            this.name = "no name";
            this.health = 100;
            this.Position = new Position(0, 0, 0);
            // this("No name", 100, new Position(0, 0, 0))
        }
        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + name);
            Debug.Log("Health: " + Health);
            Position.printPosition();
            //Debug.Log($"Name: {Name}, Health: {Health}");

        }
        public void Attack(int damage, Character target)
        {
            target.Health = target.Health - damage;
            Debug.Log($"{name} attacked {target.name} causing {damage} damage.");

        }
        public void Attack(int damage, Character target, string attackType)
        {
            Debug.Log($"{name} attacked {target.name} using {attackType} causing {damage} damage.");
            Attack(damage, target);
        }


    }


}
