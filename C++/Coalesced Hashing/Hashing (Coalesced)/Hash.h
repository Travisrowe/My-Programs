#pragma once
#include <vector>
#include <iostream>
using namespace std;

class Hash
{
	struct item
	{
		int value = -1;
		int next = -1;
	};
	vector<struct item> table;
	int tableSize;
	int probeCount;
	int addressSize;
	int nextAvail;
public:
	Hash();
	Hash(int, float);
	~Hash();
	void Dump();
	void Insert(int);
	int HashFunc(int);
	float getAvgProbeCount();


};

