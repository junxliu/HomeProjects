#ifndef PROBLEM_004_H
#define PROBLEM_004_H

int reverseNumber(int val)
{
	int rv = 0;
	do 
	{
		rv *= 10; 
		rv += val % 10;
		val /= 10;
	} while (val);
	return rv;
}

bool isPalindromic(int val)
{
	return val == reverseNumber(val);
}

int largestPalindromic(int numDigits)
{
	int largestSoFar = 0; 
	int maxVal = int (pow(10.0, numDigits) - 1); 
	int minVal = int (pow (10.0, numDigits - 1)); 
	for (int val1 = maxVal; val1>=minVal; -- val1)
	{
		for (int val2 = val1; val2 >= minVal; --val2)
		{
			int product = val1 * val2; 
			if (isPalindromic(product) && product > largestSoFar)
				largestSoFar = product;
		}
	}
	return largestSoFar; 
}


#endif