#include "IdleState.h"
#include "JumpState.h"
#include "AttackState.h"
#include "StateManager.h"

#include <Windows.h>

#include <iostream>

using namespace std;

IdleState::IdleState(StateManager* manager) : State(manager)
{
	randChoice = rand() % 100;
}

void IdleState::update()
{
	cout << "Ai is Idle" << endl;
	Sleep(3000);

	//choose between rnadomly shooting and jumping
	if (randChoice <= 50)
	{
		cout << "Ai has encountered an obstacle, changing state to jump..." << endl;
		Sleep(1000);
		manager->setState(new JumpState(manager));
	}
	else
	{
		cout << "Ai is searching for an enemy, changing state to attack..." << endl;
		Sleep(1000);
		manager->setState(new AttackState(manager));
	}
}