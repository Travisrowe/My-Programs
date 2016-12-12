#pragma once
class CirLinkList
{
	struct Node {
		int val;
		int size;
		Node * next;
		Node * back;
		//Here is a constructor that works with a struct as we discussed.
		Node(int v, Node * b, Node * n) { val = v; next = n; back = b; } // Node constructor!
	};
	Node* start;//Node we start at. This can change
	int nodect;// store node ct as well
public:
	CirLinkList();
	~CirLinkList();
	void Build(int ct);
	void Dump();
	int Kill();
	void Advance(int k);
	int GetStart();
};

