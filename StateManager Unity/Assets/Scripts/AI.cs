using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateControl;

public class AI : MonoBehaviour {

    //timer to switch state variables
    public bool switchState = false;
    public float gameTimer;
    public int seconds = 0;

    public StateMachine<AI> stateMachine { get; set; }

    private void Start()
    {
        stateMachine = new StateMachine<AI>(this);
        stateMachine.ChangeState(IdleState.Instance);
        gameTimer = Time.time;

    }

    private void Update()
    {
        //timer to switch states from idle to attack
        if (Time.time > gameTimer + 1)
        {
            gameTimer = Time.time;
            seconds++;
            Debug.Log(seconds);
        }

        if (seconds == 5)
        {
            seconds = 0;
            switchState = !switchState;
        }

        //call the update function of the state
        stateMachine.Update();

    }
}
