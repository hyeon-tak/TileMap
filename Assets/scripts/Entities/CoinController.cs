using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Coin);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
