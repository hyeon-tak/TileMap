using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoFStair : MonoBehaviour
{

    public GameObject FirstFloor;
    public GameObject SecondFloor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("asd");
            FirstFloor.SetActive(true);
            SecondFloor.SetActive(false);
        }

    }

}