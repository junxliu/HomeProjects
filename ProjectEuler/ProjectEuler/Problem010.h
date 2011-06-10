#ifndef PROBLEM_010_H
#define PROBLEM_010_H

#include "Problem003.h"

long long sumPrime(int maxVal)
{
  long long sumSoFar = 2;
  for (int i = 3; i< maxVal; i += 2)
  {
    if (isPrime(i))
      sumSoFar += i;
  }
  return sumSoFar; 
}


#endif