using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class LeafpileManager : MonoBehaviour
{

    //when the player wins an item, start void on decoratemenu that enables its button so player can turn on the decoration

    public Stats script;//get the value of gold
    public Vet script2;
    public HedgehogWormHunt script3;

    public Text goldamount;

    public int random;
    public float timer;

    public bool timerbegin;

    public bool reward1; //increase worm hunt timer
    public bool reward2; //hunger decys slower
    public bool reward3; //fun decays slower
    public bool reward4; //free vet visit
    public bool reward5; //3 gold
    public bool reward6; //item - Pond
    public bool reward7; //item - Pond Pebbles
    public bool reward8; //item - Pond Plants Set 1
    public bool reward9; //item - Hedge Background
    public bool reward10; //item - Hedgehog House
    public bool reward11; //item - Snails
    public bool reward12; //item - Hedge/Fence Fairy Lights
    public bool reward13; //item - Tree Background
    public bool reward14; //item - Bird Bath
    public bool reward15; //item - Bird Food Table
    public bool reward16; //item - Flower Bed
    public bool reward17; //item - Flower Set 1
    public bool reward18; //item - Flower Set 2
    public bool reward19; //item - Pond Plants Set 2
    public bool reward20; //item - Bees

    public GameObject leafrustle;


    public TextMeshProUGUI reward;

    public GameObject decorate;

    private void Update()
    {
        goldamount.text = script.gold.ToString();

        if(timerbegin == true)
        {
            timer = timer + 1 * Time.deltaTime;
        }

        if(timer > 1)
        {
            timer = 0;
            leafrustle.SetActive(false);
            reward.text = "...";

            timerbegin = false;
        }
    }

    public void leafpile()
    {
        leafrustle.SetActive(true);

        if(script.gold > 0 && timerbegin == false)
        {
            random = UnityEngine.Random.Range(1, 21);
            timerbegin = true;
            script.gold = script.gold - 1;

            //REWARD 1 - Increase Worm Hunt Timer
            if (random == 1 && reward1 == true)
            {
                reward.text = "Nothing :(";
            }
            if (random == 1 && reward1 == false)
            {
                script3.speed += 1f;
                reward.text = "Speed increase in Worm Hunt!";
                reward1 = true;
            }


            //REWARD 2 - Hunger Decays Slower
            if (random == 2 && reward2 == true)
            {
                script.gold = script.gold + 2;
                reward.text = "2 Gold!";
            }
            if (random == 2 && reward2 == false)
            {
                script.hungertimerlonger = true;
                reward.text = "Hunger Decays Slower!";
                reward2 = true;
            }


            //REWARD 3 - Fun Decays Slower
            if (random == 3 && reward3 == true)
            {
                reward.text = "... Nothing";
            }
            if (random == 3 && reward3 == false)
            {
                reward.text = "Fun Decays Slower!";
                script.funtimerlonger = true;
                reward3 = true;
            }


            //REWARD 4 - Free Vet Visit
            if (random == 4 && reward4 == true)
            {
                script2.freevet = true;
                reward.text = "Free Vet Visit!";
            }
            if (random == 4 && reward4 == false)
            {
                script2.freevet = true;
                reward.text = "Free Vet Visit!";
                reward4 = true;
            }


            //REWARD 5 - 3 Gold
            if (random == 5 && reward5 == true)
            {
                reward.text = "Nothing, try again!";
            }
            if (random == 5 && reward5 == false)
            {
                reward.text = "3 Gold";
                script.gold = script.gold + 3;
                reward5 = true;
            }


            //REWARD 6 - Pond
            if (random == 6 && reward6 == true)
            {
                reward.text = "1 Gold";
                script.gold = script.gold + 1;
            }
            if (random == 6 && reward6 == false)
            {
                reward.text = "Pond Decoration";
                reward6 = true;
            }


            //REWARD 7 - Pond Pebbles
            if (random == 7 && reward7 == true)
            {
                reward.text = "2 Gold";
                script.gold = script.gold + 1;
            }
            if (random == 7 && reward7 == false)
            {
                reward.text = "Pond Pebbles Decoration";
                reward7 = true;
            }


            //REWARD 8 - Pond Plants Set 1
            if (random == 8 && reward8 == true)
            {
                reward.text = "Nothing";
            }
            if (random == 8 && reward8 == false)
            {
                reward.text = "Pond Plants Set 1 Decoration";
                reward8 = true;
            }


            //REWARD 9 - Hedge Background
            if (random == 9 && reward9 == true)
            {
                reward.text = "Nothing, D:";
            }
            if (random == 9 && reward9 == false)
            {
                reward.text = "Hedge Background Decoration";
                reward9 = true;
            }


            //REWARD 10 - Hedgehog House
            if (random == 10 && reward10 == true)
            {
                reward.text = "Nothing";
            }
            if (random == 10 && reward10 == false)
            {
                reward.text = "Hedgehog House Decoration";
                reward10 = true;
            }


            //REWARD 11 - Snail
            if (random == 11 && reward11 == true)
            {
                reward.text = "2 gold";
                script.gold += 2;
            }
            if (random == 11 && reward11 == false)
            {
                reward.text = "Snail Decoration";
                reward11 = true;
            }


            //REWARD 12 - Background Fairy lights
            if (random == 12 && reward12 == true)
            {
                reward.text = "3 gold";
                script.gold += 3;
            }
            if (random == 12 && reward12 == false)
            {
                reward.text = "Fairy Lights Decoration";
                reward12 = true;
            }


            //REWARD 13 - Tree Background
            if (random == 13 && reward13 == true)
            {
                reward.text = "Nothing";
            }
            if (random == 13 && reward13 == false)
            {
                reward.text = "Tree Background Decoration";
                reward13 = true;
            }


            //REWARD 14 - Bird Bath
            if (random == 14 && reward14 == true)
            {
                reward.text = "Nothing, oh no D:";
            }
            if (random == 14 && reward14 == false)
            {
                reward.text = "Bird Bath Decoration";
                reward14 = true;
            }


            //REWARD 15 - Bird Food Table
            if (random == 15 && reward15 == true)
            {
                reward.text = "Nothing, better luck next time!";
            }
            if (random == 15 && reward15 == false)
            {
                reward.text = "Bird Food Table Decoration";
                reward15 = true;
            }


            //REWARD 16 - Flower Bed
            if (random == 16 && reward16 == true)
            {
                reward.text = "Nothing, oh no D:";
            }
            if (random == 16 && reward16 == false)
            {
                reward.text = "Flower Bed Decoration";
                reward16 = true;
            }


            //REWARD 17 - Flower Set 1
            if (random == 17 && reward17 == true)
            {

            }
            if (random == 17 && reward17 == false)
            {
                reward.text = "Flower Set 1 Decoration";
                reward17 = true;
            }


            //REWARD 18 - Flower Set 2
            if (random == 18 && reward18 == true)
            {

            }
            if (random == 18 && reward18 == false)
            {
                reward.text = "Flower Set 2 Decoration";
                reward18 = true;
            }


            //REWARD 19 - Pond Plants Set 2
            if (random == 19 && reward19 == true)
            {
                reward.text = "";
            }
            if (random == 19 && reward19 == false)
            {
                reward.text = "Pond Plants Set 2 Decoration";
                reward19 = true;
            }


            //REWARD 20 - Bees
            if (random == 20 && reward20 == true)
            {
                reward.text = "5 Gold!";
                script.gold = +5;

            }
            if (random == 20 && reward20 == false)
            {
                reward.text = "Bees Decorations";
                reward20 = true;
            }
        }
    }
}
