#ifndef ATTACKSTATE_H
#define ATTACKSTATE_H

#include "State.h"

class AttackState : public State
{
private:
	static int ammo;
	int runChance;

public:
	AttackState(StateManager* manager);
	void update();

};

#endif