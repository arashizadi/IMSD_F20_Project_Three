using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//A.I.

public class GameManager : MonoBehaviour
{
    //public List<List<string>> inventory = new List<List<string>>();
    public TextMesh greenBar, yellowBar, redBar, time, introInfo;
    public static int stress;
    public int cooldown;
    public GameObject stressMaterial;
    public Renderer stressRenderer1, stressRenderer2, stressRenderer3;
    byte transColor = 0;
    bool visibleStress;
    float stressOvertimeTimer, stressColorOvertimeTimer, timer = 60;

    // Start is called before the first frame update
    void Start()
    {
        stressRenderer1.material.color = new Color32(102, 00, 00, 100);
        stressRenderer2.material.color = new Color32(102, 00, 00, 100);
        stressRenderer3.material.color = new Color32(102, 00, 00, 100);
        stress = 7;
    }

    // Update is called once per frame
    void Update()
    {
        StressVisual();
        StressOvertime();
        timer -= Time.deltaTime;
        time.text = "Interview in " + ((int)timer).ToString();
        if (timer < 53)
            introInfo.gameObject.SetActive(false);
        if (timer <= 0)
        {
            SceneManager.LoadScene(2);
        }

    }

    void StressOvertime()
    {
        stressOvertimeTimer += Time.deltaTime;
        if (stressOvertimeTimer >= cooldown)
        {
            stress++;
            stressOvertimeTimer = 0;
        }
        if (stress >= 13)
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
            stressRenderer1.material.color = new Color32(102, 00, 00, transColor);
            stressRenderer2.material.color = new Color32(102, 00, 00, transColor);
            stressRenderer3.material.color = new Color32(102, 00, 00, transColor);
        }
        else
        {
            stressMaterial.SetActive(false);
        }
    }
    void StressVisual()
    {
        if (stress >= 15)
        {
            stress = 15;
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
        else
        {
            stress = 1;
            greenBar.text = "█";
            yellowBar.text = "";
            redBar.text = "";
        }
    }


}
