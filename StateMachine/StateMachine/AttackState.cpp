#include "AttackState.h"
#include "StateManager.h"
#include "JumpState.h"
#include "IdleState.h"

#include <Windows.h>

#include <iostream>

using namespace std;

int AttackState::ammo = 100;

AttackState::AttackState(StateManager* manager) : State(manager)
{
}

void AttackState::update()
{
	runChance = rand() % 2;
	cout << "Ammo remaining = " << ammo << endl;
	if(ammo <= 0)
	{
		cout << "Out of ammo, changing state to jump..." << endl;
		Sleep(1000);
		manager->setState(new JumpState(manager));
	}
	else
	{
		if (runChance == 0)
		{
			cout << "Didn't find an enemy, changing state to idle..." << endl;
			Sleep(1000);
			manager->setState(new IdleState(manager));
		}
		else
		{
			cout << "Shoot" << endl;
			Sleep(250);
			ammo--;
		}
		if (ammo % 10 == 0) {
			cout << "Ammo Count: " << ammo << endl;
		}
	}
}