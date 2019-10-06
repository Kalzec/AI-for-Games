using UnityEngine;
using StateControl;

public class AttackState : State<AI>
{
    private static AttackState _instance;

    //constructor
    private AttackState()
    {
        //if state already exists then return
        if (_instance != null)
        {
            return;
        }

        //if not set instance to this
        _instance = this;
    }

    public static AttackState Instance
    {
        get
        {
            //if state doens't exist, create state
            if (_instance == null)
            {
                new AttackState();
            }

            return _instance;
        }
    }

    //Enter State function
    public override void EnterState(AI _owner)
    {
        Debug.Log("Entering Attack State");
    }

    //Exit State Function
    public override void ExitState(AI _owner)
    {
        Debug.Log("Exiting Attack State");
    }

    //Function for what happens in this state
    public override void UpdateState(AI _owner)
    {
        
        if (!_owner.switchState)
        {
            _owner.stateMachine.ChangeState(IdleState.Instance); //switch to idle state
        }
    }
}
