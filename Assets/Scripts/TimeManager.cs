using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public GameObject Daytime;
    public GameObject Nightime;
    public GameObject Daytime2;
    public GameObject Nightime2;

    public GameObject hedgehognight;
    public GameObject hedgehogday;

    public GameObject Clock1;
    public GameObject Clock2;
    public GameObject Clock3;
    public GameObject Clock4;

    public GameObject daytimeaudio;
    public GameObject nighttimeaudio;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        daytimeaudio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;

        if(timer > 0)
        {
            nighttimeaudio.SetActive(true);
            Clock1.SetActive(true);
            Clock4.SetActive(false);
        }

        if(timer > 45)
        {
            nighttimeaudio.SetActive(false);
            Clock2.SetActive(true);
            Clock1.SetActive(false);
        }

        if(timer > 90)
        {
            daytimeaudio.SetActive(true);
            Daytime.SetActive(true);
            Nightime.SetActive(false);
            Daytime2.SetActive(true);
            Nightime2.SetActive(false);
            hedgehogday.transform.position = hedgehognight.transform.position;
            Clock3.SetActive(true);
            Clock2.SetActive(false);
        }

        if(timer > 135)
        {
            daytimeaudio.SetActive(false);
            Clock4.SetActive(true);
            Clock3.SetActive(false);
        }

        if(timer > 180)
        {
            Daytime.SetActive(false);
            Nightime.SetActive(true);
            Daytime2.SetActive(false);
            Nightime2.SetActive(true);
            timer = 0;
        }
    }
}
