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
    public int cooldown = 30;
    public GameObject stressMaterial;
    public Renderer stressRenderer;
    byte transColor = 0;
    bool visibleStress;
    float stressOvertimeTimer, stressColorOvertimeTimer;

    // Start is called before the first frame update
    void Start()
    {
        stressRenderer.material.color = new Color32(102, 00, 00, 100);
        stress = 11;
    }

    // Update is called once per frame
    void Update()
    {
        StressVisual();
        StressOvertime();
    }

    void StressOvertime()
    {
        stressOvertimeTimer += Time.deltaTime;
        if (stressOvertimeTimer >= cooldown)
        {
            stress++;
            stressOvertimeTimer = 0;
        }
        if (stress >= 11)
        {
            stressMaterial.SetActive(true);
            stressColorOvertimeTimer += Time.deltaTime;
            if (stressColorOvertimeTimer >= 0.4f && !visibleStress)
            {
                transColor++;
                if (stressColorOvertimeTimer >= 0.4f)
                {
                    visibleStress = true;
                    stressColorOvertimeTimer = 0;
                }
            }
            else
            {
                transColor--;
                if (stressColorOvertimeTimer >= 0.10f)
                {
                    visibleStress = false;
                    stressColorOvertimeTimer = 0;
                }
            }
            stressRenderer.material.color = new Color32(102, 00, 00, transColor);
        }
        else
        {
            stressMaterial.SetActive(false);
        }
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
