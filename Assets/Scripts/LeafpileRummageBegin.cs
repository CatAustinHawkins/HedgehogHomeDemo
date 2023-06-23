using UnityEngine;

public class LeafpileRummageBegin : MonoBehaviour
{
    public GameObject leafpile;
    public GameObject mainscene;

    public void leafpilebegin()
    {
        leafpile.SetActive(true);
        mainscene.SetActive(false);
    }

    public void leafpileend()
    {
        leafpile.SetActive(false);
        mainscene.SetActive(true);
    }
}
