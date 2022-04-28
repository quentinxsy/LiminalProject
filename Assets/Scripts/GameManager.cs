using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GamePhases {Start, Middle, End};
    public GamePhases currentGamePhase;
    float experienceTime;
    
    // Update is called once per frame
    void Update()
    {
        experienceTime += Time.deltaTime;
        Debug.Log(experienceTime);

        if(experienceTime > 0 && experienceTime < 60)
        {
            currentGamePhase = GamePhases.Start;
            Debug.Log(currentGamePhase);
        }

        if (experienceTime > 60 && experienceTime < 180)
        {
            currentGamePhase = GamePhases.Middle;
            Debug.Log("Middle Phase");
        }

        if (experienceTime > 180 && experienceTime < 240)
        {
            currentGamePhase = GamePhases.End;
            Debug.Log("End Phase");
        }

        switch (currentGamePhase)
        {
            case GamePhases.Start:
                break;

            case GamePhases.Middle:
                break;

            case GamePhases.End:
                break;
        }


    }
}
