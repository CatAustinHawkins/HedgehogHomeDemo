using UnityEngine;

public class WormHuntBegin : MonoBehaviour
{
    public GameObject wormhuntitems;
    public GameObject maincamera;
    public GameObject mainsceneitems;

    public GameObject hedgehog;

    public GameObject backgroundmusic;

    //SLUGS, COINS, WORMS
    public GameObject Slug1;
    public GameObject Slug2;
    public GameObject Slug3;
    public GameObject Slug4;
    public GameObject Slug5;
    public GameObject Slug6;

    public GameObject Coin1;
    public GameObject Coin2;
    public GameObject Coin3;
    public GameObject Coin4;
    public GameObject Coin5;
    public GameObject Coin6;
    public GameObject Coin7;
    public GameObject Coin8;

    public GameObject Worm1;
    public GameObject Worm2;
    public GameObject Worm3;
    public GameObject Worm4;
    public GameObject Worm5;
    public GameObject Worm6;
    public GameObject Worm7;
    public GameObject Worm8;
    public GameObject Worm9;
    public GameObject Worm10;
    public GameObject Worm11;
    public GameObject Worm12;
    public GameObject Worm13;
    public GameObject Worm14;
    public GameObject Worm15;


    public void wormhuntbegin()
    {
        backgroundmusic.SetActive(false);

        wormhuntitems.SetActive(true);
        mainsceneitems.SetActive(false);
        maincamera.SetActive(false);
        hedgehog.transform.position = new Vector3(0, 0, 0);

        Slug1.SetActive(true);
        Slug2.SetActive(true);
        Slug3.SetActive(true);
        Slug4.SetActive(true);
        Slug5.SetActive(true);
        Slug6.SetActive(true);

        Coin1.SetActive(true);
        Coin2.SetActive(true);
        Coin3.SetActive(true);
        Coin4.SetActive(true);
        Coin5.SetActive(true);
        Coin6.SetActive(true);
        Coin7.SetActive(true);
        Coin8.SetActive(true);

        Worm1.SetActive(true);
        Worm2.SetActive(true);
        Worm3.SetActive(true);
        Worm4.SetActive(true);
        Worm5.SetActive(true);
        Worm6.SetActive(true);
        Worm7.SetActive(true);
        Worm8.SetActive(true);
        Worm9.SetActive(true);
        Worm10.SetActive(true);
        Worm11.SetActive(true);
        Worm12.SetActive(true);
        Worm13.SetActive(true);
        Worm14.SetActive(true);
        Worm15.SetActive(true);

        Slug1.transform.position = UnityEngine.Random.insideUnitCircle * 20;
        Slug2.transform.position = UnityEngine.Random.insideUnitCircle * 20;
        Slug3.transform.position = UnityEngine.Random.insideUnitCircle * 20;
        Slug4.transform.position = UnityEngine.Random.insideUnitCircle * 20;
        Slug5.transform.position = UnityEngine.Random.insideUnitCircle * 20;
        Slug6.transform.position = UnityEngine.Random.insideUnitCircle * 20;

        Coin1.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin2.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin3.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin4.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin5.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin6.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin7.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Coin8.transform.position = UnityEngine.Random.insideUnitCircle * 23;

        Worm1.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm2.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm3.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm4.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm5.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm6.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm7.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm8.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm9.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm10.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm11.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm12.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm13.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm14.transform.position = UnityEngine.Random.insideUnitCircle * 23;
        Worm15.transform.position = UnityEngine.Random.insideUnitCircle * 23;
    }
}
