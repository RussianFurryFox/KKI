using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject target;
    public int Dmg;


    private void OnMouseDown()
    {
        Health TargetHealt = target.GetComponent<Health>();
        TargetHealt.TakeDmg(Dmg);
    }




}
