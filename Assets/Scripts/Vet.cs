using UnityEngine;

public class Vet : MonoBehaviour
{

    public Stats Script;

    public bool freevet;

    public void healallhealth()
    {
        if(freevet == true)
        {
            Script.health = 50;
            freevet = false;
        }

        if(Script.health < 5 && Script.gold > 12)
        {
            Script.health = 50;
            Script.gold = Script.gold - 12;
        }

        if(Script.health < 15 && Script.gold > 9)
        {
            Script.health = 50;
            Script.gold = Script.gold - 9;
        }

        if(Script.health < 25 && Script.gold > 6)
        {
            Script.health = 50;
            Script.gold = Script.gold - 6;
        }

        if(Script.health < 35 && Script.gold > 4)
        {
            Script.health = 50;
            Script.gold = Script.gold - 4;
        }

        if(Script.health < 50 && Script.gold > 2)
        {
            Script.health = 50;
            Script.gold = Script.gold - 2;
        }

    }

    public void restoreallhunger()
    {
        if (freevet == true)
        {
            Script.hunger = 50;
            freevet = false;
        }

        if (Script.hunger < 5 && Script.gold > 12)
        {
            Script.hunger = 50;
            Script.gold = Script.gold - 12;
        }

        if (Script.hunger < 15 && Script.gold > 9)
        {
            Script.hunger = 50;
            Script.gold = Script.gold - 9;
        }

        if (Script.hunger < 25 && Script.gold > 6)
        {
            Script.hunger = 50;
            Script.gold = Script.gold - 6;
        }

        if (Script.hunger < 35 && Script.gold > 4)
        {
            Script.hunger = 50;
            Script.gold = Script.gold - 5;
        }

        if (Script.hunger < 50 && Script.gold > 2)
        {
            Script.hunger = 50;
            Script.gold = Script.gold - 3;
        }
    }

    public void restoreallfun()
    {

        if (freevet == true)
        {
            Script.fun = 50;
            freevet = false;
        }

        if (Script.fun < 5 && Script.gold > 12)
        {
            Script.fun = 50;
            Script.gold = Script.gold - 12;
        }

        if (Script.fun < 15 && Script.gold > 9)
        {
            Script.fun = 50;
            Script.gold = Script.gold - 9;
        }

        if (Script.fun < 25 && Script.gold > 6)
        {
            Script.fun = 50;
            Script.gold = Script.gold - 6;
        }

        if (Script.fun < 35 && Script.gold > 4)
        {
            Script.fun = 50;
            Script.gold = Script.gold - 4;
        }

        if (Script.fun < 50 && Script.gold > 2)
        {
            Script.fun = 50;
            Script.gold = Script.gold - 2;
        }
    }

}
