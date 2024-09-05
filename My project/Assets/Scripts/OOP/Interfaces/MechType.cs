using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechType : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public MechType(){

    }

    public MechType(int init_health){
        health = init_health;
    }

    public void AttackWithMelee(int amount){
        Debug.Log("Melee Attack");
        attackDamage = amount;
    }

    public void TakeDamage(int amount){
        health -= amount;
    }
}