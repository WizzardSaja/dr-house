using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;
namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Soldier soldier = new Soldier("Soldier made7a ", 70, new Position(8, 4, 1));
            Officer officer = new Officer("Officer Saja ", 80, new Position(10, 5, 3));
            Character[] characters = { soldier, officer };

          //  foreach (var character in characters){character.DisplayInfo();}
            

            for (int i = 0;i< characters.Length;i++){
                characters[i].DisplayInfo();
            }
            Debug.Log("Soldier Health before attack"+ soldier.Health);
            officer.Attack(30, soldier, "shooting");
            Debug.Log("Soldier Health after attack"+ soldier.Health);
        }

    }
}

