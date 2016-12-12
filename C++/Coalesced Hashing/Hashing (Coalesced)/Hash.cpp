#include "Hash.h"



Hash::Hash()
{
}

Hash::Hash(int tsize, float beta)
{
	table.resize(tsize);
	tableSize = tsize;
	addressSize = (int)(tsize * beta);
	nextAvail = tsize - 1;
}

Hash::~Hash()
{
}

void Hash::Dump()
{
	cout << "Table dump\n";
	for (int i = 0; i < addressSize; i++)
	{
		cout << i << ": " << table[i].value << " " << table[i].next << endl;
	}
	cout << "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n";
	for (int i = addressSize; i < tableSize; i++)
	{
		cout << i << ": " << table[i].value << " " << table[i].next << endl;
	}
}

void Hash::Insert(int val)
{
	int slotNum = HashFunc(val);
	if (table[slotNum].value == -1)
	{
		table[slotNum].value = val;
		table[slotNum].next = -2;
	}
	else //we have a collision
	{
		while (table[slotNum].next != -2)
		{
			slotNum = table[slotNum].next;
			probeCount++;
		}
		//points nextAvail to the last empty space in the table
		while (table[nextAvail].value != -1) 
		{
			nextAvail--;
			probeCount++;
		}
		table[nextAvail].value = val;
		table[nextAvail].next = -2;
		table[slotNum].next = nextAvail;
	}
}

//returns the ideal key for the value.
//We are using a simple hash since the values are random
int Hash::HashFunc(int v)
{
	return v % addressSize;
}

float Hash::getAvgProbeCount()
{
	//note that, in main, I only add addressSize number of values
	return (float)probeCount / (float)tableSize; 
}
