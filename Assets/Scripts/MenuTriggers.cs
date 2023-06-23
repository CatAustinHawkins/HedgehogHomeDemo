using UnityEngine;

public class MenuTriggers : MonoBehaviour
{

    public GameObject feedmenu;

    public bool isfeedmenuopen;

    public GameObject playmenu;

    public bool isplaymenuopen;

    public GameObject workmenu;

    public bool isworkmenuopen;

    public GameObject vetmenu;

    public bool isvetmenuopen;

    public GameObject decoratemenu;

    public bool isdecoratemenuopen;

    public void feedmenuopen()
    {
        if (isfeedmenuopen == false)
        {
            feedmenu.SetActive(true);

            playmenu.SetActive(false);
            isplaymenuopen = false;

            decoratemenu.SetActive(false);
            isdecoratemenuopen = false;

            workmenu.SetActive(false);
            isworkmenuopen = false;

            vetmenu.SetActive(false);
            isvetmenuopen = false;

            isfeedmenuopen = true;
        }
        else
        {
            feedmenu.SetActive(false);
            isfeedmenuopen = false;
        }
    }

    public void playmenuopen()
    {
        if (isplaymenuopen == false)
        {
            playmenu.SetActive(true);

            workmenu.SetActive(false);
            isworkmenuopen = false;

            decoratemenu.SetActive(false);
            isdecoratemenuopen = false;
            
            feedmenu.SetActive(false);
            isfeedmenuopen = false;
            
            vetmenu.SetActive(false);
            isvetmenuopen = false;

            isplaymenuopen = true;
        }
        else
        {
            playmenu.SetActive(false);
            isplaymenuopen = false;
        }
    }

    public void workmenuopen()
    {
        if (isworkmenuopen == false)
        {
            workmenu.SetActive(true);

            playmenu.SetActive(false);
            isplaymenuopen = false;

            decoratemenu.SetActive(false);
            isdecoratemenuopen = false;
            
            feedmenu.SetActive(false);
            isfeedmenuopen = false;

            vetmenu.SetActive(false);
            isvetmenuopen = false;

            isworkmenuopen = true;
        }
        else
        {
            workmenu.SetActive(false);
            isworkmenuopen = false;
        }
    }

    public void vetmenuopen()
    {
        if (isvetmenuopen == false)
        {
            vetmenu.SetActive(true);

            playmenu.SetActive(false);
            isplaymenuopen = false;

            decoratemenu.SetActive(false);
            isdecoratemenuopen = false;

            feedmenu.SetActive(false);
            isfeedmenuopen = false;

            workmenu.SetActive(false);
            isworkmenuopen = false;

            isvetmenuopen = true;
        }
        else
        {
            vetmenu.SetActive(false);
            isvetmenuopen = false;
        }
    }

    public void decoratemenuopen()
    {
        if(isdecoratemenuopen == false)
        {
            decoratemenu.SetActive(true);

            playmenu.SetActive(false);
            isplaymenuopen = false;

            vetmenu.SetActive(false);
            isvetmenuopen = false;
            
            feedmenu.SetActive(false);
            isfeedmenuopen = false;
            
            workmenu.SetActive(false);
            isworkmenuopen = false;

            isdecoratemenuopen = true;
        }
        else
        {
            decoratemenu.SetActive(false);
            isdecoratemenuopen = false;
        }
        
    }
}
