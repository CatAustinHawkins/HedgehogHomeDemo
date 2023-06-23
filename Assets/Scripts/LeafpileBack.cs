using System.Collections;
using UnityEngine;

public class LeafpileBack : MonoBehaviour
{
    public GameObject leafpilerummage;
    public GameObject mainscene;

    public void leafpileback()
    {
        leafpilerummage.SetActive(false);
        mainscene.SetActive(true);
    }
    
}
