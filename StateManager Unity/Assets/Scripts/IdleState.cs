using UnityEngine;
using StateControl;

public class IdleState : State<AI>
{
    private static IdleState _instance;

    //constructor
    private IdleState()
    {
        //if state already exists then return
        if(_instance != null)
        {
            return;
        }

        //if not set instance to this
        _instance = this;
    }

    public static IdleState Instance
    {
        get
        {
            //if state doens't exist, create state
            if (_instance == null)
            {
                new IdleState();
            }

            return _instance;
        }
    }

    //Enter State function
    public override void EnterState(AI _owner)
    {
        Debug.Log("Entering Idle State");
    }

    //Exit State Function
    public override void ExitState(AI _owner)
    {
        Debug.Log("Exiting Idle State");
    }

    //Function for what happens in this state
    public override void UpdateState(AI _owner)
    {
        if (_owner.switchState)
        {
            _owner.stateMachine.ChangeState(AttackState.Instance); //switch to attack state
        }
    }
}
