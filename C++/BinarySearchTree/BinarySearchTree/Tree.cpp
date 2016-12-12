//Tree.cpp
#include "Tree.h"
//constructor
Tree::Tree(void)
{
	root = 0;
}

// This is the destructor.  When does it get called.
// There are several places of interest
Tree::~Tree(void)
{
	RemoveTree(root);
}

// Note the & .  Why is it needed
void Tree::RemoveTree(Node *& r){//Inorder deletion of entire tree;
	if (r==0)return;
	else{
	   RemoveTree(r->left);
	   RemoveTree(r->right);
	   delete r;
	   r=0;
	}
}

// Note the &.  Why is it needed here as well 
void Tree::AuxInsert(Node *& r, int v){
	if (r==0){//insert node here
        r = new Node(v);
	}
	else {
		if (v <= r->val) AuxInsert(r->left, v);
		else AuxInsert(r->right, v);
	}
}

//Public method to insert a node into the tree
void Tree::Insert(int v)
{
	AuxInsert(root,v);
}

// Private recursive method to print the tree
void Tree::AuxPrint(Node * r){//Inorder
	if (r==0)return;
	else{
	   AuxPrint(r->left);
	   cout << r->val<<" ";
	   AuxPrint(r->right);
	}
}

//Public print method
void Tree::Print(){
	AuxPrint(root);
	cout<<endl<<endl;
}

//Public Delete method
void Tree::Delete(int val)
{
	AuxDelete(root, val);
}


//The recursive successor delete for the public Delete() method
void Tree::AuxDelete(Node *&r, int v)
{
	if (r == NULL) return;
	else {// lets keep looking
		if (v>r->val) { 
			AuxDelete(r->right, v);
		}
		else if (v<r->val) {
			AuxDelete(r->left, v);
		}
		else {// We have found the node to delete
			if (r->left == NULL && r->right == NULL) {// r has no children
				delete r;// just delete it
				r = NULL;
				return;
			}
			else {//found the node with at least one child
				Node * ptr;
				if (r->left == NULL)// no left child but a right exists
				{
					Node* temp = r->right;
					delete r;
					r = temp;
					return;
				}
				else if (r->right == NULL)// left child but no right child.
				{// 
					Node* temp = r->left;
					delete r;
					r = temp;
					return;
				}
				else { // we have 2 children. Will replace with successor node
					Node * follower;
					ptr = r->right;// go right 1 node
					follower = ptr;
					if (ptr->left == NULL) {//splice out ptr
						r->right = ptr->right;
						r->val = ptr->val;
						delete ptr;
						return;
					}
					// we have a left node so
					while (ptr->left != 0) {// and then go left as far as you can go
						//follower = ptr;
						ptr = ptr->left;
					}
					// Ptr points to successor. 
					// Move contents of successor to the root of the subtree
					// being examined and delete the successor node.
					r->val = ptr->val;
					// does this successor have a right node
					if (ptr->right != NULL) {
						follower->left = ptr->right;
						delete ptr; // delete sucessor
					}
					else {
						follower->left = NULL;
						delete ptr; // delete sucessor
					}
				}

			}
		}
	}
	return;
}

int Tree::Sum()
{
	return auxSum(root);
}


int Tree::auxSum(Node * r)
{
	if (r == 0)return 0;
	return r->val + auxSum(r->left) + auxSum(r->right);
}

double Tree::IPL()
{
	double x = 0;
	auxIPL(root, x, 0);
	return x;
}

void Tree::auxIPL(Node *&r, double &sumDepth, int curDepth = 0)
{
	sumDepth += curDepth;
	if (r->left != 0)
	{
		auxIPL(r->left, sumDepth, curDepth + 1);
		
	}
	if (r->right != 0)
	{
		auxIPL(r->right, sumDepth, curDepth + 1);
		
	}
}

int Tree::SimpsonIPL(void)
{
	return SimsponAuxIPL(root, 0);
}

int Tree::SimsponAuxIPL(Node *r, int depth)
{
	if (r == 0) return 0;
	return depth + SimsponAuxIPL(r->left, depth + 1) + SimsponAuxIPL(r->right, depth + 1);
}