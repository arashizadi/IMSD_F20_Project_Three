using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FadeOutText : MonoBehaviour
{
    public TextMeshPro text;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
        if (timer > 4)
        {
            text.alpha -= 0.02f;
        }
        if (timer > 7)
        {
            text.text = "Now I smoke a pack a day, and it's been a hard habit to kick.";
            text.fontSize = 28;
            
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            } else
            {
              text.alpha += 0.05f;
            }
        }

        if (timer > 14)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 15)
        {
            text.text = "I have an interview today with a large corporation. \n I'm stressed out.";

            text.fontSize = 32;

            if (text.alpha >= 1)
            {
                text.alpha = 1;
            }
            else
            {
                text.alpha += 0.05f;
            }
        }
        if (timer > 19)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 21)
        {
            text.text = "I want to smoke before this interview.";
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            }
            else
            {
                text.alpha += 0.05f;
            }
        }
        if (timer > 26)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 29)
        {
            text.text = "But, I NEED to get this job.";
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            }
            else
            {
                text.alpha += 0.05f;
            }
        }
        if (timer > 32)
        {
            SceneManager.LoadScene(1);
        }
    }
}
