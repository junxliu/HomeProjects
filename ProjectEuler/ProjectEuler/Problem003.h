#ifndef PROBLEM_003_H
#define PROBLEM_003_H
#include <cmath>


bool isPrime(int val)
{
	if (val == 2)	  return true;
	if (val % 2 == 0) return false;

	int upper = (int)sqrt(double(val));
	
	for (int i=3; i <= upper; i+= 2)
	{
		if (val % i ==0)
			return false;
	}

	return true;
}


int largestPrimeFactor (long long val)
{
	int largestPrime = 1; 
	while (val % 2 == 0)
	{
		largestPrime = 2;
		val /= 2;
	}

	for (int i = 3; i <= val; i += 2)
	{
		if (isPrime(i))
		{
			while (val % i == 0)
			{
				val /= i;
			}
			largestPrime = i; 
		}
	}

	return largestPrime;

}


#endif