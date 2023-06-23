using UnityEngine;

public class Worm : MonoBehaviour
{

    public GameObject hedgehogeat;

    public GameObject stats;

    public GameObject wormhunt;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        stats.GetComponent<Stats>().wormcollected();
        wormhunt.GetComponent<WormHunt>().wormtextupdate();
        hedgehogeat.GetComponent<HedgehogEatTrigger>().hedgehogeatstart();

        Debug.Log("Worm Collected");

        gameObject.SetActive(false);
    }
}
