/*	Travis Rowe
	9/19/16
	Data Structures and Algorithms
	This program uses vectors to demonstrate whether a sequence of numbers is a
	Jolly Jumper. That is, the absolute values of the difference between
	successive elements in the vector take on all the values 1 through n - 1,
	with n being the size of the vector.
*/

#include <iostream>
#include <fstream>
#include <vector>
#include <cmath>
#include <algorithm>
using namespace std;

int main()
{
	bool jollyJumper = true;
	int n, x;
	cin >> n; // n is the first digit of the input line
	vector<int> vals; 
	vector<int> differences;
	for (int i = 0; i < n; i++)
	{
		cin >> x; // x is the rest of the information in the input line
		vals.push_back(x);
	}
	for (int k = 0; k < n-1; k++)
	{
		differences.push_back(abs(vals[k] - vals[k + 1]));
	}
	
	sort(differences.begin(), differences.end()); 
		// sort differences for easy comparison
	
	for (int j = 1; j <= n-1; j++)
	{
		if (differences[j-1] != j) // j and the values of differences should
								   // both be 1, 2, 3, ..., n-1
			jollyJumper = false;
	}
	if (jollyJumper)
		cout << "Jolly";
	else
		cout << "Not jolly";
}