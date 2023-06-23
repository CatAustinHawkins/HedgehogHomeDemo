using UnityEngine;

public class DecorateMenu : MonoBehaviour
{

    public LeafpileManager script;

    //text
    public GameObject slot2text;
    public GameObject slot3text;
    public GameObject slot4text;
    public GameObject slot5text;
    public GameObject slot6text;
    public GameObject slot7text;
    public GameObject slot8text;
    public GameObject slot9text;
    public GameObject slot10text;
    public GameObject slot11text;
    public GameObject slot12text;
    public GameObject slot13text;
    public GameObject slot14text;
    public GameObject slot15text;
    public GameObject slot16text;

    //images
    public GameObject slot2image;
    public GameObject slot3image;
    public GameObject slot4image;
    public GameObject slot5image;
    public GameObject slot6image;
    public GameObject slot7image;
    public GameObject slot8image;
    public GameObject slot9image;
    public GameObject slot10image;
    public GameObject slot11image;
    public GameObject slot12image;
    public GameObject slot13image;
    public GameObject slot14image;
    public GameObject slot15image;
    public GameObject slot16image;

    //check if slot is active before place item
    public bool slot1active;
    public bool slot2active;
    public bool slot3active;
    public bool slot4active;
    public bool slot5active;
    public bool slot6active;
    public bool slot7active;
    public bool slot8active;
    public bool slot9active;
    public bool slot10active;
    public bool slot11active;
    public bool slot12active;
    public bool slot13active;
    public bool slot14active;
    public bool slot15active;
    public bool slot16active;

    //decoration
    public GameObject slot1fence;
    public GameObject slot2pond;
    public GameObject slot3pondpebbles;
    public GameObject slot4pondplantsset1;
    public GameObject slot5hedgebackground;
    public GameObject slot6hedgehoghouse;
    public GameObject slot7snail;
    public GameObject slot8backgroundfairylights;
    public GameObject slot9treebackground;
    public GameObject slot10birdbath;
    public GameObject slot11birdfoodtable;
    public GameObject slot12flowerbed;
    public GameObject slot13flowerset1;
    public GameObject slot14flowerset2;
    public GameObject slot15pondplantsset2;
    public GameObject slot16bees;

    private void Start()
    {
        slot1active = true;
    }

    public void Update()
    {
        if(script.reward6 == true)
        {
            slot2text.SetActive(false);
            slot2image.SetActive(true);
        }
        if (script.reward7 == true)
        {
            slot3text.SetActive(false);
            slot3image.SetActive(true);
        }
        if (script.reward8 == true)
        {
            slot4text.SetActive(false);
            slot4image.SetActive(true);
        }
        if (script.reward9 == true)
        {
            slot5text.SetActive(false);
            slot5image.SetActive(true);
        }
        if (script.reward10 == true)
        {
            slot6text.SetActive(false);
            slot6image.SetActive(true);
        }
        if (script.reward11 == true)
        {
            slot7text.SetActive(false);
            slot7image.SetActive(true);
        }
        if (script.reward12 == true)
        {
            slot8text.SetActive(false);
            slot8image.SetActive(true);
        }
        if (script.reward13 == true)
        {
            slot9text.SetActive(false);
            slot9image.SetActive(true);
        }
        if (script.reward14 == true)
        {
            slot10text.SetActive(false);
            slot10image.SetActive(true);
        }
        if (script.reward15 == true)
        {
            slot11text.SetActive(false);
            slot11image.SetActive(true);
        }
        if (script.reward16 == true)
        {
            slot12text.SetActive(false);
            slot12image.SetActive(true);
        }
        if (script.reward17 == true)
        {
            slot13text.SetActive(false);
            slot13image.SetActive(true);
        }
        if (script.reward18 == true)
        {
            slot14text.SetActive(false);
            slot14image.SetActive(true);
        }
        if (script.reward19 == true)
        {
            slot15text.SetActive(false);
            slot15image.SetActive(true);
        }
        if (script.reward20 == true)
        {
            slot16text.SetActive(false);
            slot16image.SetActive(true);
        }
    }

    public void slot1()//FENCE
    {
        if(slot1active == false)
        {
            slot1fence.SetActive(true);
            slot1active = true;
            slot5hedgebackground.SetActive(false);
            slot5active = false;
            slot9treebackground.SetActive(false);
            slot9active = false;
        }
    }

    public void slot2()//POND
    {
        if (slot2active == true)
        {
            slot2pond.SetActive(false);
            slot2active = false;
        }
        else
        {
            slot2pond.SetActive(true);
            slot2active = true;
        }
    }

    public void slot3()//POND PEBBLES
    {
        if (slot3active == true && slot2active == true)
        {
            slot3pondpebbles.SetActive(false);
            slot3active = false;
        }
        else
        {
            slot3pondpebbles.SetActive(true);
            slot3active = true;
        }
    }

    public void slot4()//POND PLANT SET 1
    {
        if (slot4active == true)
        {
            slot4pondplantsset1.SetActive(false);
            slot4active = false;
        }
        else
        {
            slot4pondplantsset1.SetActive(true);
            slot4active = true;
        }
    }

    public void slot5()//HEDGE BACKGROUND
    {
        if (slot5active == true)
        {
            slot5hedgebackground.SetActive(false);
            slot5active = false;
            slot1fence.SetActive(true);
            slot1active = true;
        }

        if (slot5active == false)
        {
            slot5hedgebackground.SetActive(true);
            slot5active = true;
            slot1fence.SetActive(false);
            slot1active = false;
            slot9treebackground.SetActive(false);
            slot9active = false;
        }
    }

    public void slot6()//HEDGEHOG HOUSE
    {
        if (slot6active == true)
        {
            slot6hedgehoghouse.SetActive(false);
            slot6active = false;
        }
        else
        {
            slot6hedgehoghouse.SetActive(true);
            slot6active = true;
        }
    }

    public void slot7()//SNAIL
    {
        if (slot7active == true)
        {
            slot7snail.SetActive(false);
            slot7active = false;
        }
        else
        {
            slot7snail.SetActive(true);
            slot7active = true;
        }
    }

    public void slot8()//FAIRY LIGHTS
    {
        if (slot8active == true)
        {
            slot8backgroundfairylights.SetActive(false);
            slot8active = false;
        }
        else
        {
            slot8backgroundfairylights.SetActive(true);
            slot8active = true;
        }
    }

    public void slot9()//TREE BACKGROUND
    {
        //if fence = true

        if (slot9active == true)
        {
            slot9treebackground.SetActive(false);
            slot9active = false;
            slot1fence.SetActive(true);
            slot1active = true;
            slot5hedgebackground.SetActive(false);
            slot5active = false;
        }

        if (slot9active == false)
        {
            slot5hedgebackground.SetActive(false);
            slot5active = false;
            slot9treebackground.SetActive(true);
            slot9active = true;
            slot1fence.SetActive(false);
            slot1active = false;
        }

    }

    public void slot10()//BIRD BATH
    {
        if (slot10active == true)
        {
            slot10birdbath.SetActive(false);
            slot10active = false;
        }
        else
        {
            slot10birdbath.SetActive(true);
            slot10active = true;
        }
    }
    public void slot11()//BIRD FOOD TABLE
    {
        if (slot11active == true)
        {
            slot11birdfoodtable.SetActive(false);
            slot11active = false;
        }
        else
        {
            slot11birdfoodtable.SetActive(true);
            slot11active = true;
        }
    }

    public void slot12()//FLOWER BED
    {
        if (slot12active == true)
        {
            slot12flowerbed.SetActive(false);
            slot12active = false;
        }
        else
        {
            slot12flowerbed.SetActive(true);
            slot12active = true;
        }
    }

    public void slot13()//FLOWER SET 1 
    {
        if (slot13active == true)
        {
            slot13flowerset1.SetActive(false);
            slot13active = false;
        }
        else
        {
            slot13flowerset1.SetActive(true);
            slot13active = true;
        }
    }

    public void slot14()//FLOWER SET 2
    {
        if (slot14active == true)
        {
            slot14flowerset2.SetActive(false);
            slot14active = false;
        }
        else
        {
            slot14flowerset2.SetActive(true);
            slot14active = true;
        }
    }

    public void slot15()//POND PLANTS 2
    {
        if (slot15active == true)
        {
            slot15pondplantsset2.SetActive(false);
            slot15active = false;
        }
        else
        {
            slot15pondplantsset2.SetActive(true);
            slot15active = true;
        }
    }

    public void slot16()//BEES
    {
        if (slot16active == true)
        {
            slot16bees.SetActive(false);
            slot16active = false;
        }
        else
        {
            slot16bees.SetActive(true);
            slot16active = true;
        }
    }
}
