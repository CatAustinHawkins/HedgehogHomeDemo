using UnityEngine;
using UnityEngine.UI;

public class WormHunt : MonoBehaviour
{

    public int worms;
    public int gold;

    public Text wormtext;
    public Text goldtext;

    public float timer = 30.0f;

    public Text timertext;

    public GameObject backgroundmusic;

    public GameObject wormhuntitems;
    public GameObject maincamera;
    public GameObject mainsceneitems;

    public Stats stats;

    public Slider healthslider;

    public Slider hungerslider;

    public void Awake()
    {
        timer = 30.0f;
        healthslider.value = stats.health;
        hungerslider.value = stats.hunger;
    }

    void Update()
    {
        healthslider.value = stats.health;
        hungerslider.value = stats.hunger;

        goldtext.text = gold.ToString();
        wormtext.text = worms.ToString();

        timer -= Time.deltaTime;
        timertext.text = timer.ToString();

        if(timer < 0)
        {
            wormhuntitems.SetActive(false);
            mainsceneitems.SetActive(true);
            maincamera.SetActive(true);
            worms = 0;
            gold = 0;
            backgroundmusic.SetActive(true);
            stats.GetComponent<Stats>().wormhuntover();
            timer = 30.0f;
        }
    }

    public void wormtextupdate()
    {
        worms = worms + 1;
        wormtext.text = worms.ToString();
    }

    public void goldtextupdate()
    {
        gold = gold + 1;
        goldtext.text = gold.ToString();
    }
}
