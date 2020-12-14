using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//A.I.
public class GameOver : MonoBehaviour
{
    GameManager GameManager;
    public string goodEndingBossOne, goodEndingPlayerOne, goodEndingBossTwo, goodEndingPlayerTwo, goodEndingBossThree, goodEndingPlayerThree, 
        goodEndingBossFour, goodEndingPlayerFour, badEndingBossOne, badEndingPlayerOne, badEndingBossTwo, badEndingPlayerTwo, badEndingBossThree, 
        badEndingPlayerThree, badEndingBossFour, badEndingPlayerFour;
    string endingBossOne, endingPlayerOne, endingBossTwo, endingPlayerTwo, endingBossThree, endingPlayerThree, endingBossFour, endingPlayerFour;
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
        
    }
}
