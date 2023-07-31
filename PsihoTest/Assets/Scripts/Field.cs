using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    private int numOfChildren = 4;
    private int randNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    delegate void OnTileClick();


    private void Reset()
    {
        for(int i = 0; i < numOfChildren; i++)
        {
            transform.GetChild(i).GetComponent<Tile>().correct =  i == randNum ? true : false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
