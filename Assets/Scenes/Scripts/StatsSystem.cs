using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    /// Our physical stats that determine our dancing stats.
    public int agility;
    public int intelligence;
    public int strength;

    // Our variables used to determine our fighting power.
    public int style;
    public int luck;
    public int rhythm;

    private void Start()
    {
        // set out agility, strength and intelligence to a random number between zero and ten.
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.
        strength = Random.Range(0, 11);
        agility = Random.Range(0, 11);
        intelligence = Random.Range(0, 11);

        // Debug out your current physical stat values (strength, agility, intelligence).

        Debug.Log("Strength = " + strength);
        Debug.Log("Agility = " + agility);
        Debug.Log("Intelligence = " + intelligence);


        // let's create some float temporary variables to hold our multiplier values.

        float agilityMultiplier = agility;
        float strengthMultiplier = strength;
        float intelligenceMultiplier = intelligence;

        // create an agility multiplier should be set to 0.5

        agilityMultiplier = 0.5f;

        // create a strength multiplier should be set to 1

        strengthMultiplier= 1;

        // create an intelligence multiplier should be set to 2.

        intelligenceMultiplier = 2;

        // Debug out our current multiplier values.

        Debug.Log("Strength multiplier value: " + strengthMultiplier);
        Debug.Log("Agility multiplier value: " + agilityMultiplier);
        Debug.Log("Intelligence multiplier value: " + intelligenceMultiplier);


        // now that we have some stats and our multiplier values let's calculate our style, luck and rhythm based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        style = (int)(strength * strengthMultiplier);

        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        luck = (int)(intelligence * intelligenceMultiplier);

        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        rhythm = (int)(agility * agilityMultiplier);         

        // Debug out our current dancing stat values (style, luck, rhythm)

        Debug.Log("Style: " + style);
        Debug.Log("Luck: " + luck);
        Debug.Log("Rhythm: " + rhythm);


        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10 / 3;

        float strengthLevel = (strength + additionalPoints);
        float agilityLevel = (agility + additionalPoints);
        float intelligenceLevel = (intelligence + additionalPoints);

        // Debug out our new physical stat values
        Debug.Log("Level up! New Strength: " + strengthLevel);
        Debug.Log("Level up! New Agility: " + agilityLevel);
        Debug.Log("Level up! New Intelligence: " + intelligenceLevel);

        // let's recalculate our style, luck and rhythm as our initial stats have changed.
        int newStyle = (int)(strengthLevel * strengthMultiplier);
        int newLuck = (int)(intelligenceLevel * intelligenceMultiplier);
        int newRhythm = (int)(agilityLevel * agilityMultiplier);

        // Debug out our new dancing stat values
        Debug.Log("Your new Style: " + newStyle);
        Debug.Log("Your new Luck: " + newLuck);
        Debug.Log("Your new: Rhythm: " + newRhythm);
    }

}
