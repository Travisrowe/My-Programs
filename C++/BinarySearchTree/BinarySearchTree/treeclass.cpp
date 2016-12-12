/*	Modified by Travis Rowe
	10/13/16
	This code finds the average internal path length for two trees, one with
	128 nodes, and one with 256 nodes. It will use incrementing numbers
	of insertion/deletion pairs (increment = 1/3 * 1000, up to 100,000) for data
	points. For each increment of I/D pairs, the code will run 100 times to find
	the average IPL. I will then put the data on a graph, using the number
	of I/D pairs as the x-axis, and the average IPL as the y-axis for the graph.

	*/

// treeclass.cpp : This the main program to test the treeclass
// Written by Richard P. Simpson
#include "Tree.h"
#include <iostream>
using namespace std;
#include <vector>
//the following is required for the sort() below
#include <algorithm>
#include <time.h>

int main()
{
	Tree T;
	int key, val, index, runNum;
	double IPLratio = 0, expIPL;
	int n; //number of randomly chosen keys

	n = 128; //the number of Nodes
	int IDpairs = 0; 
	srand(time(NULL));

	expIPL = 1.386 * n * log2(n) - 2.846 * n;
	//According to Jeffery Eppinger, the expected IPL of a tree with n nodes
	//is approximately equal to 1.386n * ln(n) - 2.846n.


	while (IDpairs <= 50000) //increment num of I/D pairs by 1000
	{
		IPLratio = 0; // reset IPLratio for each increment
		for (runNum = 1; runNum <= 100; runNum++)
		{
			vector<int> Values; //reset the vector
			for (int i = 0; i < n; i++) //build tree and vector with matcing values
			{
				key = rand() % 1000;// returns a random number from 0 to 999
				T.Insert(key);
				Values.push_back(key);
			}

			for (int i = 0; i < IDpairs; i++) //IDpairs is the x axis of the graph
			{
				index = rand() % n; // chooses a number between 0 and the number of
				// Nodes in the tree
				val = Values[index]; // selects the value from that index to delete
				T.Delete(Values[index]);
				Values.erase(Values.begin() + index);
				// removes val from both the tree and the vector
				key = rand() % 1000;// returns a random number from 0 to 999
				T.Insert(key);	// Inserts a new random number into the tree
				Values.push_back(key);	// and into the vector

			}
			IPLratio += T.SimpsonIPL() / expIPL; 
				//stores the measured IPL over the calculated IPL
			T.~Tree();
		}
		cout << IPLratio / runNum << endl;

		IDpairs += 1000;

	}
}

