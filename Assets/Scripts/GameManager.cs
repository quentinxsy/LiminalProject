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

    public EventManager[] eventManager;

    public Material[] skyboxMaterials;


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

        /*foreach (EventManager @event in eventManager)
        {
            @event.TimeElapsedEvents.Invoke();
        }*/

        Invoke("FirstEvent", eventManager[0].eventTimeStart);
        Invoke("SecondEvent", eventManager[1].eventTimeStart);
        Invoke("ThirdEvent", eventManager[2].eventTimeStart);
        Invoke("FourthEvent", eventManager[3].eventTimeStart);

    }


    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        Debug.Log(elapsedTime);

        if(elapsedTime > 0 && elapsedTime < 60)
        {
            currentGamePhase = GamePhases.Start;
            
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
                RenderSettings.skybox = skyboxMaterials[0];               
                break;
                        
            case GamePhases.Middle:
                RenderSettings.skybox = skyboxMaterials[1];
                break;

            case GamePhases.End:
                RenderSettings.skybox = skyboxMaterials[2];
                break;
        }
    }

    public void FirstEvent()
    {
        eventManager[0].TimeElapsedEvents.Invoke();
    }
    public void SecondEvent()
    {
        eventManager[1].TimeElapsedEvents.Invoke();
    }
    public void ThirdEvent()
    {
        eventManager[2].TimeElapsedEvents.Invoke();
    }
    public void FourthEvent()
    {
        eventManager[3].TimeElapsedEvents.Invoke();
    }
}

[System.Serializable]
public class EventManager
{
    [Tooltip("Time you would like the event to occur.")]
    public float eventTimeStart;

    [Tooltip("Array of events that will occur based on the time set above")]
    public UnityEvent TimeElapsedEvents;

}


