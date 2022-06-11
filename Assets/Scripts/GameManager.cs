using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject[] coins;
    // Start is called before the first frame update
    void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin");
        foreach (GameObject co in coins)
        {
            co.transform.Rotate(0, 1, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
