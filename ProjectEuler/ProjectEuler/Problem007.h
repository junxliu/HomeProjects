#ifndef PROBLEM_007_H
#define PROBLEM_007_H

#include "Problem003.h"

int nthPrime (int n)
{
	if (n == 1) return 2;
	int nth = 2;
	int prime = 3;
	
	for (int val = prime+2; nth != n; val +=2)
	{
		if (isPrime(val))
		{
			++ nth;
			prime = val;
		}
	}
	return prime;
}

#endif