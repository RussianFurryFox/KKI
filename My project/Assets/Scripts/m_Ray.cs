using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_Ray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        coll=GetComponent<Collider>();
    }

    public Material Red;
    public Material Blue;
    Material m_Material;
    Collider coll;

    // Update is called once per frame
    void Update()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (coll.Raycast(ray,out hit,Mathf.Infinity))
        {
            m_Material.color = Red.color;

        }
        else
        {
            m_Material.color = Blue.color;
        }
    }
}
