using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechMaker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MechType mechType = new MechType(20);
        MechType secondMechType = new MechType(30);
        
        mechType.AttackWithMelee(10);
        secondMechType.AttackWithMelee(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
