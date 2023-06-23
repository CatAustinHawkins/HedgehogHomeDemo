using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Stats : MonoBehaviour
{
    public Slider healthslider;

    public Slider hungerslider;

    public Slider funslider;

    public TextMeshProUGUI goldtext;

    public GameObject hedgehogeat;

    public float health;

    public int hunger;

    public int fun;

    public int gold;

    public float funtime;

    public float hungertime;

    public bool hungertimerlonger;
    public bool funtimerlonger;

    public float timer1;
    public bool timer1go;

    public TimeManager timescript;

    private void Start()
    {
        funtime = 0;
        hungertime = 0;

        hunger = 46;
        fun = 40;
        gold = 5;

        Debug.Log("Start");
    }

    private void Awake()
    {
        healthslider.value = health;
        hungerslider.value = hunger;
    }

    void Update()
    {
        healthslider.value = health;
        hungerslider.value = hunger;
        funslider.value = fun;
        goldtext.text = gold.ToString();

        funtime = funtime + 1 * Time.deltaTime;
        hungertime = hungertime + 1 * Time.deltaTime;

        if(hunger > 50)
        {
            hunger = 50;
        }

        if(fun > 50)
        {
            fun = 50;
        }

        if(health > 50)
        {
            health = 50;
        }

        if(hungertime > 2.5f && hungertimerlonger == false && hunger > 0 && timescript.timer < 90)
        {
            hunger = hunger - 1;
            hungertime = 0;
        }

        if (hungertime > 5f && hungertimerlonger == true && hunger > 0 && timescript.timer < 90)
        {
            hunger = hunger - 1;
            hungertime = 0;
        }

        if (funtime > 3.5f && funtimerlonger == false && fun > 0 && timescript.timer < 90)
        {
            fun = fun - 1;
            funtime = 0;
        }

        if (funtime > 7.5f && funtimerlonger == true && fun > 0 && timescript.timer < 90)
        {
            fun = fun - 1;
            funtime = 0;
        }

        if (hungertime > 7.5f && hungertimerlonger == false && hunger > 0 && timescript.timer > 90)
        {
            hunger = hunger - 1;
            hungertime = 0;
        }

        if (hungertime > 12.5f && hungertimerlonger == true && hunger > 0 && timescript.timer > 90)
        {
            hunger = hunger - 1;
            hungertime = 0;
        }

        if (funtime > 10f && funtimerlonger == false && fun > 0 && timescript.timer > 90)
        {
            fun = fun - 1;
            funtime = 0;
        }

        if (funtime > 15f && funtimerlonger == true && fun > 0 && timescript.timer > 90)
        {
            fun = fun - 1;
            funtime = 0;
        }

        if (hunger < 1)
        {
            health = health - 0.005f;
        }

        if(health < 0)
        {
            SceneManager.LoadScene("HedgehogLeft");
        }

        if(fun == 0)
        {
            health = health - 0.0005f;
        }

        if(timer1go == true)
        {
            timer1 = timer1 + 1 * Time.deltaTime;
        }
        if(timer1 > 2f)
        {
            hedgehogeat.SetActive(false);
            timer1go = false;
            timer1 = 0;
        }
    }

    public void slug()
    { 
        if(gold >= 1 && hunger <= 50)
        {
            gold = gold - 1;
            hunger = hunger + 2;
            hedgehogeat.SetActive(true);
            timer1go = true;
        }
    }

    public void insect()
    {
        if (gold >= 3 && hunger <= 50)
        {
            gold = gold - 3;
            hunger = hunger + 8;
            hedgehogeat.SetActive(true);
            timer1go = true;
        }
    }
    public void egg()
    {
        if (gold >= 5 && hunger <= 50)
        {
            gold = gold - 5;
            hunger = hunger + 15;
            hedgehogeat.SetActive(true);
            timer1go = true;
        }
    }

    public void wetfood()
    {
        if (gold >= 7 && hunger <= 50)
        {
            gold = gold - 7;
            hunger = hunger + 25;
            hedgehogeat.SetActive(true);
            timer1go = true;
        }
    }

    public void wormcollected()
    {
        if(hunger <= 50)
        {
            hunger = hunger + 2;
        }

    }

    public void coincollected()
    {
        gold = gold + 1;
    }

    public void wormhuntover()
    {
        if(fun < 50)
        {
            fun = fun + 20;
        }
    }

    public void questioncorrect()
    {
        gold = gold + 2;
        
    }

    public void questionincorrect()
    {
        //gold = gold - 1;
    }

    public void leafpile()
    {
        gold = gold - 1;
    }
}
