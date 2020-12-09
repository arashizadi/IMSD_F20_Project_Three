using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//A.I.

public class GameManager : MonoBehaviour
{
    //public List<List<string>> inventory = new List<List<string>>();
    public TextMeshPro greenBar, yellowBar, redBar;
    public static int stress;
    // Start is called before the first frame update
    void Start()
    {
        stress = 15;
        PickObject();
    }

    // Update is called once per frame
    void Update()
    {
        StressVisual();

    }

    void PickObject()
    {
        //inventory.Add(new List<string>());

    }
    void StressVisual()
    {
        if (stress == 15)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "█████";
        }
        else if (stress == 14)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "████";
        }        
        else if (stress == 13)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "███";
        }
        else if (stress == 12)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "██";
        }
        else if (stress == 11)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "█";
        }
        else if (stress == 10)
        {
            greenBar.text = "█████";
            yellowBar.text = "█████";
            redBar.text = "";
        }
        else if (stress == 9)
        {
            greenBar.text = "█████";
            yellowBar.text = "████";
            redBar.text = "";
        }
        else if (stress == 8)
        {
            greenBar.text = "█████";
            yellowBar.text = "███";
            redBar.text = "";
        }
        else if (stress == 7)
        {
            greenBar.text = "█████";
            yellowBar.text = "██";
            redBar.text = "";
        }
        else if (stress == 6)
        {
            greenBar.text = "█████";
            yellowBar.text = "█";
            redBar.text = "";
        }
        else if (stress == 5)
        {
            greenBar.text = "█████";
            yellowBar.text = "";
            redBar.text = "";
        }
        else if (stress == 4)
        {
            greenBar.text = "████";
            yellowBar.text = "";
            redBar.text = "";
        }
        else if (stress == 3)
        {
            greenBar.text = "███";
            yellowBar.text = "";
            redBar.text = "";
        }
        else if (stress == 2)
        {
            greenBar.text = "██";
            yellowBar.text = "";
            redBar.text = "";
        }
        else if (stress == 1)
        {
            greenBar.text = "█";
            yellowBar.text = "";
            redBar.text = "";
        }
        else
        {
            Debug.LogError("Unknown amount of stress");
        }

    }


}
