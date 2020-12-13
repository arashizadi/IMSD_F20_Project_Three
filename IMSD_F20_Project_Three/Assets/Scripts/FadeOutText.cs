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
            text.text = "Now I smoke a pack a day.";
            
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            } else
            {
              text.alpha += 0.05f;
            }
        }

        if (timer > 11)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 14)
        {
            text.text = "sentence 3.";
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            }
            else
            {
                text.alpha += 0.05f;
            }
        }
        if (timer > 18)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 21)
        {
            text.text = "sentence 4.";
            if (text.alpha >= 1)
            {
                text.alpha = 1;
            }
            else
            {
                text.alpha += 0.05f;
            }
        }
        if (timer > 25)
        {
            text.alpha -= 0.05f;
        }
        if (timer > 28)
        {
            text.text = "sentence 5.";
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
