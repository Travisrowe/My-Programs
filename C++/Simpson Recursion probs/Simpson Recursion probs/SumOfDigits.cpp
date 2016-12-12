/*	Travis Rowe
	9/12/16
	Data Structures and Algorithms
	These functions will take a number and return the sum of that numbers digits.
	For example, an input of the number 12345 would return 15.

	I have written the entire program as turned in and have not copied this code, 
	or parts of this code from the internet or another student.
	
													Signature____________________
*/

#include <iostream>
using namespace std;

int SumOfDigits(int n)
{
	if (n < 0)
		n *= -1; // make n positive
	if (n / 10 == 0)	// base case
		return n;
	return(n % 10 + SumOfDigits(n / 10)); // adds the last digit of the integer to the sum
}

int main()
{
	int n = 1234;
	cout << "SumOfDigits(" << n << ") = " << SumOfDigits(n) << endl;
	return 0;
}

//SumOfDigits(65987835) = 51
//SumOfDigits(1234) = 10
