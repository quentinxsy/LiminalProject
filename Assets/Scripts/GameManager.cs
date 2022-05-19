using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public static GameManager _instance;

    public enum GamePhases {Start, Middle, End};
    public GamePhases currentGamePhase;
    float elapsedTime;

    public GameObject wormHole;
    public bool spawnedWormHole = false;

    [SerializeField] UnityEvent[] TimeElapsedEvents;


    private void Start()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        

    }


    // Update is called once per frame
    void Update()
    {
        
        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);

        if(elapsedTime > 0 && elapsedTime < 60)
        {
            currentGamePhase = GamePhases.Start;
            if(elapsedTime >= 5f && elapsedTime <= 6f && spawnedWormHole == false)
            {
                Instantiate(wormHole);
                spawnedWormHole = true;
                Debug.Log("Spawn Wormhole");
            }
        }

        if (elapsedTime > 60 && elapsedTime < 180)
        {
            currentGamePhase = GamePhases.Middle;            
        }
            
        if (elapsedTime > 180 && elapsedTime < 240)
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

    IEnumerator Event1()
    {
        yield return new WaitForSeconds(15f);
    }


    public void EventOne()
    {

    }
}


