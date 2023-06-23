using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainmenuitems;
    public GameObject aboutmenu;
    public GameObject controlsandsettingsmenu;
    public GameObject mainscene;
    public GameObject gameplay;

    public void StartGame()
    {
        mainmenuitems.SetActive(false);
        mainscene.SetActive(true);
        gameplay.SetActive(true);
    }

    public void AboutMenu()
    {
        mainmenuitems.SetActive(false);
        aboutmenu.SetActive(true);
    }

    public void ControlMenu()
    {
        controlsandsettingsmenu.SetActive(true);
        mainmenuitems.SetActive(false);
    }

    public void backtomain()
    {
        mainmenuitems.SetActive(true);
        aboutmenu.SetActive(false);
        controlsandsettingsmenu.SetActive(false);
    }


}
