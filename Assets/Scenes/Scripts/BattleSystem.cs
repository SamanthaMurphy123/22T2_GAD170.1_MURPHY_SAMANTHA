using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = 0;
        playerOneStyle = Random.Range(1,11);

        // luck should be random between 0-4
        int playerOneLuck = 0;
        playerOneLuck = Random.Range(0,5);

        // rhythm should be random between 1-6
        int playerOneRhythm = 0;
        playerOneRhythm = Random.Range(1,7);

        // style should be random between 1-10
        int playerTwoStyle = 0;
        playerTwoStyle = Random.Range(1,11);

        // luck should be random between 0-4
        int playerTwoLuck = 0;
        playerTwoLuck = Random.Range(0,5);

        // rhythm should be random between 1-6
        int playerTwoRhythm = 0;
        playerTwoRhythm = Random.Range(1,7);

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = 0;
        playerOnePowerLevel = (playerOneLuck + playerOneStyle + playerOneRhythm);

        int playerTwoPowerLevel = 0;
        playerTwoPowerLevel = (playerTwoLuck + playerTwoStyle + playerTwoRhythm);

        // Debug out the two players' power levels.
        Debug.Log("Player 1 power level: " + playerOnePowerLevel);
        Debug.Log("Player 2 power level: " + playerTwoPowerLevel);

        // calculate the percentage chance of winning the fight for each character.
        // to do this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        float playerOnePercent;       //Player One's percent of winning
        float playerTwoPercent;       //Player Two's percent of winning

        int totalPower = (playerOnePowerLevel + playerTwoPowerLevel);

        playerOnePercent = (playerOnePowerLevel / totalPower);
        playerTwoPercent = (playerTwoPowerLevel / totalPower);


        int playerOneChanceToWin = (int)(playerOnePercent * 100);
        int playerTwoChanceToWin = (int)(playerTwoPercent * 100);

        // Debug out the chance of each character to win.
        Debug.Log("Player One chance to win: " + playerOneChanceToWin + "%");
        Debug.Log("Player Two chance to win: " + playerTwoChanceToWin + "%");

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.
        // Debug out which character has won, which has lost, or if it's a draw. 
        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
        if (playerOnePowerLevel >= playerTwoPowerLevel)
        {
            Debug.Log("Player One has Won!");
            playerOnePowerLevel++;
        }
        else if (playerOnePowerLevel <= playerTwoPowerLevel)
        {
            Debug.Log("Player Two has won!");
            playerTwoPowerLevel++;
        }
        else if (playerOnePowerLevel == playerTwoPowerLevel)
        {
            Debug.Log("It's a draw!");
            playerOnePowerLevel++;
            playerTwoPowerLevel++;
        }     
    }
}
