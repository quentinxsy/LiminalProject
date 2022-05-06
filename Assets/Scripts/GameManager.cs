using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GamePhases {Start, Middle, End};
    public GamePhases currentGamePhase;
    float experienceTime;

    public GameObject wormHole;
    public bool spawnedWormHole = false;
    
    // Update is called once per frame
    void Update()
    {
        experienceTime += Time.deltaTime;
        Debug.Log(experienceTime);

        if(experienceTime > 0 && experienceTime < 60)
        {
            currentGamePhase = GamePhases.Start;
            if(experienceTime >= 5f && experienceTime <= 6f && spawnedWormHole == false)
            {
                Instantiate(wormHole);
                spawnedWormHole = true;
                Debug.Log("Spawn Wormhole");
            }
        }

        if (experienceTime > 60 && experienceTime < 180)
        {
            currentGamePhase = GamePhases.Middle;
            
        }

        if (experienceTime > 180 && experienceTime < 240)
        {
            currentGamePhase = GamePhases.End;
            
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
