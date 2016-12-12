/*	Travis Rowe
	9/12/16
	Data Structures and Algorithms
	This will take a positive integer n and reverse its digits. For example,
	the number 12345 will be reversed and printed as 54321.

	I have written the entire program as turned in and have not copied this code,
	or parts of this code from the internet or another student.

													Signature____________________
*/

#include <iostream>
using namespace std;

int ReverseDigits(int n, int revN = 0)	// revN will store the reverse num
{
	if (n < 0)	// ensure n is positive
		n *= -1;
	if (n / 10 == 0)	// if there is only one digit left in n, add that digit.
		return revN + n;
	revN += (n % 10);	// add the last digit of n to revN
	revN *= 10;	// multiply revN by 10 to make room for the next digit
	return ReverseDigits(n / 10, revN);
}

int main()
{
	int n = 1234;
	cout << "ReverseDigits(" << n << ") = " << ReverseDigits(n) << endl;
	return 0;
}

//ReverseDigits(65987835) = 53878956
//ReverseDigits(1234) = 4321