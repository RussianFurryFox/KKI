using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GMscript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool turn;

    public TextMesh Txt;
    public TextMesh eTxt;
    string text;
    int startTime = 16;
    int curTime=16;


    public CardBase cardbase;
    public GameObject Card_1;
    public GameObject Card_2;
    int[,] cell = new int[,]
    {
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 0, 0 }


    };
    int[,] ecell = new int[,]
   {
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 0, 0 },
        {0, 0, 0, 0 }


   };

    void Start()
    {
        turn = (Random.value > 0.5);
        deal();
        deal2();
        if (turn) StartCoroutine(Timer());
        else StartCoroutine(eTimer());
        Debug.Log(cardbase.CardName[0]);
    }

    IEnumerator Timer()
    {
        tChange();
        yield return new WaitForSecondsRealtime (1);
        if (curTime > 0 && turn)
        {
            StartCoroutine(Timer());
        }
        else
        {
            Txt.text = "";
            curTime = 16;
            if (Move_card.dragged==true)
            {
                Move_card.comeback();
            }
            turn=false;
            StartCoroutine(eTimer());
        }
       
    }
    IEnumerator eTimer()
    {
        etChange();
        yield return new WaitForSecondsRealtime(1);
        if (curTime > 0 && !turn)
        {
            StartCoroutine(eTimer());
        }
        else
        {
            eTxt.text = "";
            curTime = 16;
            if (Move_card.dragged == true)
            {
                Move_card.comeback();
            }
            turn = true;
            StartCoroutine(Timer());
        }

    }
    void tChange()
    {
        --curTime;
        text=curTime.ToString();
        Txt.text = text;
        
    }
    void etChange()
    {
        --curTime;
        text = curTime.ToString();
        eTxt.text = text;

    }

    void deal()
    {
        GameObject[] card = new GameObject[] { Card_1, Card_2 };
        for (int i = 0; i < 4; i++)
        {
            if (cell [i, 0] == 0)
            {
                int number = Random.Range(0, 2);
                GameObject go = Instantiate(card[number]) as GameObject;
                go.transform.parent = GameObject.Find("c"+i.ToString()+"0").transform;
                go.transform.localPosition = Vector3.zero;
                go.layer = 9;
                cell[i, 0] = 1;
            }
        }
    }
    void deal2()
    {
        GameObject[] card = new GameObject[] { Card_1, Card_2 };
        for (int i = 0; i < 4; i++)
        {
            if (ecell[i, 0] == 0)
            {
                int number = Random.Range(0, 2);
                GameObject go = Instantiate(card[number]) as GameObject;
                go.transform.parent = GameObject.Find("e" + i.ToString() + "0").transform;
                go.transform.localPosition = Vector3.zero;
                go.layer = 10;
                ecell[i, 0] = 1;
            }
        }
    }
}
