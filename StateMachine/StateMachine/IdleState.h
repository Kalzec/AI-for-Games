#ifndef IDLESTATE_H
#define IDLESTATE_H

#include "State.h"

class IdleState : public State
{
private:
	int randChoice;

public:
	IdleState(StateManager* manager);
	void update();

};

#endif
