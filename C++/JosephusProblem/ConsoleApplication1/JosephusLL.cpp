/*	Travis Rowe
	9/9/2016
	CMPS 3013-101 Data Structures and Algorithms
	This program will solve the Josephus Problem: In a group of 12 men, every third man is
	killed until there is only one left. Where should Josephus stand to survive?
	The program has a complexity of O(n). However many men are in the circle initially,
	that is how many times the program will run.

	I have written the entire program as turned in and have not copied this code, or parts
	of this code from the internet or another student.
															Signature__Travis Rowe_______
*/ 


#include "JosephusLL.h"
#include <iostream>
using namespace std;
int main()
{
	int nodesleft;
	CirLinkList C;
	C.Build(12);
	C.Dump();
	C.Advance(7);
	while (C.Kill() != 1)
		C.Advance(3);
	C.Dump();
	cout << "Remaining node is " << C.GetStart() << endl;
	return 0;
}

CirLinkList::CirLinkList()
{
}


CirLinkList::~CirLinkList()
{
}

//Creates the inital lineup and sets pointers appropriately, including the start
void CirLinkList::Build(int ct)
{
	Node *nptr, *prev;

	if (ct > 0)
	{
		start = prev = nptr = new Node(1, 0, 0);
		for (int i = 2; i <= ct; i++)
		{
			nptr = new Node(i, prev, 0);
			prev->next = nptr;
			prev = nptr;
		}
		//connect all the ends 
		nptr->next = start;
		start->back = nptr;
		nodect = ct;
	}
	else
	{
		cout << "What..!" << endl;
	}
}

// Prints the linked list going forward and backward
void CirLinkList::Dump()
{
	Node * ptr = start;
	cout << "List going forward has " << nodect << " nodes and they are: ";
	cout << ptr->val << " ";

	while ((ptr = ptr->next) != start)
	{
		cout << ptr->val << " ";
	}
	cout << "\nList going backwards is ";
	

	while ((ptr = ptr->back) != start)
	{
		cout << ptr->val << " ";
	}
	cout << ptr->val << " " << endl;
}

// Moves the start point ahead k steps
void CirLinkList::Advance(int k)
{
	for (int z = 1; z <= k; z++)
	{
		start = start->next;
	}
}
// Deletes the start point and moves it one step ahead.
int CirLinkList::Kill()
{
	Node *tempPtr = start; // stores the location of the killed man
	start = start->next; // moves the start pointer to the next man in line
	start->back = tempPtr->back; // Fixes the pointers to exclude the killed man
	start->back->next = start;
	delete tempPtr;
	nodect--; // corrects the size of the Linked List
	//Dump();
	return nodect;
}

// Returns the value of the node that start points at
int CirLinkList::GetStart()
{
	return start->val;
}