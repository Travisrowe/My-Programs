/* Travis Rowe
 * 12/9/16
 * 3013- DS and Algorithms
 * Coalesced Hashing
 * This program implements a hash table that uses a cellar to deal with collisions.
 * It studies the effect the size of the cellar has in proportion to the size of
 * the rest of the table.
 * I have written the entire program as turned in and have not copied this code, 
 * or parts of this code from the internet or another student.  
 *														Signature____________________
*/


#include "Hash.h"
#include <iostream>
#include "time.h"
using namespace std;

void main()
{
	int newVal;
	int size;
	float beta;
	srand(time(NULL));

	size = 10000;
	for (beta = .35; beta <= 1; beta += .025)
	{
		Hash table = Hash(size, beta);
		for (int i = 0; i < size; i++)
		{
			newVal = rand();
			table.Insert(newVal);
		}
		cout << "beta: " << beta<< ":\t" << table.getAvgProbeCount() << endl;
	}
}