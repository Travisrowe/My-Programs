//Tree.h
#pragma once
#include <iostream>
#include <math.h> // for natural log
using namespace std;
class Tree
{
	// PRIVATE vars
	struct Node{
       int val;
	   Node * left;
	   Node * right;
	 
	   //Here is a constructor that works with a struct as we discussed.
	   Node(int v) { val = v; left = right = 0; } // Node constructor!
	};
	Node * root;
	void AuxInsert(Node *&,int);
	void AuxDelete(Node *& , int );
	void AuxPrint(Node *);
	void RemoveTree(Node *& r);
	int  auxSum(Node * r);
	void auxIPL(Node *&, double &, int);
	int SimsponAuxIPL(Node *r, int depth);

	// We now go public
	public:
	Tree(void);//Constructor
	~Tree(void);//Desructor
	void Insert(int v);//Insert v into the tree
	void Delete(int val);//Delete val from the tree
	int Sum();//Return the sum of the values in the tree.
	void Print();//Can you change this to have a parameter
				 // Print(PREORDER), Print(INORDER) and Print(Postorder) ?
				 // PREORDER etc enums
	double IPL(); // recursive function to find the actual IPL of the tree
	int SimpsonIPL(void);
};

