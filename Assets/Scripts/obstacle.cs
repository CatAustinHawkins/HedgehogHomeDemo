using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Stats stats;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        stats.health = stats.health - 5;
        gameObject.SetActive(false);

    }
}
