using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool correct = false;
    public enum degree{
        one = 0, two = 90, three = 180, four = 270, flip = 180    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown() {
        Debug.Log("pll");
        if (correct)
        {
            Debug.Log("YAY");
        }
    }
}
