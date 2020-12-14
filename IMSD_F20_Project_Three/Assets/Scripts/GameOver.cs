using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Boo.Lang;
//A.I.
public class GameOver : MonoBehaviour
{
    GameManager GameManager;
    public GameObject bubbleBoss, bubblePlayer, GNO, GO;
    public TextMeshPro dialogue;
    public string goodEndingBossOne, goodEndingPlayerOne, goodEndingBossTwo, goodEndingPlayerTwo, goodEndingBossThree, goodEndingPlayerThree,
        goodEndingBossFour, goodEndingPlayerFour, badEndingBossOne, badEndingPlayerOne, badEndingBossTwo, badEndingPlayerTwo, badEndingBossThree,
        badEndingPlayerThree, badEndingBossFour, badEndingPlayerFour;
    string endingBossOne, endingPlayerOne, endingBossTwo, endingPlayerTwo, endingBossThree, endingPlayerThree, endingBossFour, endingPlayerFour;
    int textCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.stress > 10)
        {
            endingBossOne = badEndingBossOne;
            endingPlayerOne = badEndingPlayerOne;
            endingBossTwo = badEndingBossTwo;
            endingPlayerTwo = badEndingPlayerTwo;
            endingBossThree = badEndingBossThree;
            endingPlayerThree = badEndingPlayerThree;
            endingBossFour = badEndingBossFour;
            endingPlayerFour = badEndingPlayerFour;
        }
        else
        {
            endingBossOne = goodEndingBossOne;
            endingPlayerOne = goodEndingPlayerOne;
            endingBossTwo = goodEndingBossTwo;
            endingPlayerTwo = goodEndingPlayerTwo;
            endingBossThree = goodEndingBossThree;
            endingPlayerThree = goodEndingPlayerThree;
            endingBossFour = goodEndingBossFour;
            endingPlayerFour = goodEndingPlayerFour;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
            textCounter++;

        switch (textCounter)
        {
            case 0:

                if (endingBossOne != "")
                {
                    dialogue.text = endingBossOne;
                    bubbleBoss.SetActive(true);
                    bubblePlayer.SetActive(false);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 1:

                if (endingPlayerOne != "")
                {
                    dialogue.text = endingPlayerOne;
                    bubbleBoss.SetActive(false);
                    bubblePlayer.SetActive(true);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 2:

                if (endingBossTwo != "")
                {
                    dialogue.text = endingBossTwo;
                    bubbleBoss.SetActive(true);
                    bubblePlayer.SetActive(false);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 3:

                if (endingPlayerTwo != "")
                {
                    dialogue.text = endingPlayerTwo;
                    bubbleBoss.SetActive(false);
                    bubblePlayer.SetActive(true);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 4:

                if (endingBossThree != "")
                {
                    dialogue.text = endingBossThree;
                    bubbleBoss.SetActive(true);
                    bubblePlayer.SetActive(false);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 5:

                if (endingPlayerThree != "")
                {
                    dialogue.text = endingPlayerThree;
                    bubbleBoss.SetActive(false);
                    bubblePlayer.SetActive(true);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 6:

                if (endingBossFour != "")
                {
                    dialogue.text = endingBossFour;
                    bubbleBoss.SetActive(true);
                    bubblePlayer.SetActive(false);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 7:

                if (endingPlayerFour != "")
                {
                    dialogue.text = endingPlayerFour;
                    bubbleBoss.SetActive(false);
                    bubblePlayer.SetActive(true);
                    break;
                }
                else
                {
                    GG();
                    break;
                }

            case 8:
                GG();
                break;
        }
    }
    void GG()
    {
        GNO.SetActive(false);
        GO.SetActive(true);
    }
}
