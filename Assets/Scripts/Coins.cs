using UnityEngine;


public class Coins : MonoBehaviour
{

    public GameObject stats;

    public GameObject HedgehogEat;

    public GameObject wormhunt;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        stats.GetComponent<Stats>().coincollected();
        HedgehogEat.GetComponent<HedgehogEatTrigger>().CoinCollected();
        gameObject.SetActive(false);
        wormhunt.GetComponent<WormHunt>().goldtextupdate();
    }
}
