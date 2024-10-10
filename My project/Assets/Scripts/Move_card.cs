using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move_card : MonoBehaviour, IDragHandler {
    #region IDragHandler implementation
    public void OnDrag(PointerEventData eventData)
    {

        Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, (float)0.93));
        transform.position = p;

        Debug.Log("OnDrag");
    }


    #endregion

}
