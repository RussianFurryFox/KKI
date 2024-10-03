using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public CardBase cardbase;
    void Start()
    {
        Debug.Log(cardbase.CardName[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
