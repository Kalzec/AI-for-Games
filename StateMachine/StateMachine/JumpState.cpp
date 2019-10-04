#include "JumpState.h"
#include "IdleState.h"
#include "StateManager.h"

#include <Windows.h>

#include <iostream>

using namespace std;

JumpState::JumpState(StateManager* manager) : State(manager)
{

}

void JumpState::update()
{
	cout << "Jump update" << endl;
	Sleep(250);
	cout << "Ai has jumped, changing state to Idle..." << endl;
	Sleep(1000);
	manager->setState(new IdleState(manager));
}