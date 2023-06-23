using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedgehogEatTrigger : MonoBehaviour
{
    public float timer1;
    public bool timer1go;
    public GameObject hedgehogeat;

    public float timer2;
    public bool timer2go;
    public GameObject coincollected;

     private void Update()
     {
         if (timer1go == true)
         {
             timer1 = timer1 + 1 * Time.deltaTime;
         }
         if (timer1 > 2f)
        {
             hedgehogeat.SetActive(false);
            timer1go = false;
             timer1 = 0;
        }

        if (timer2go == true)
        {
            timer2 = timer2 + 1 * Time.deltaTime;
        }
        if (timer2 > 2f)
        {
            coincollected.SetActive(false);
            timer2go = false;
            timer2 = 0;
        }
    }


    public void hedgehogeatstart()
    {
         hedgehogeat.SetActive(true);
         timer1go = true;
    }

    public void CoinCollected()
    {
        coincollected.SetActive(true);
        timer2go = true;
    }
}
