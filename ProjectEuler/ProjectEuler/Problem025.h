#ifndef PROBLEM_025_H
#define PROBLEM_025_H

#include "Problem013.h"

int problem25(int numDigits)
{
  int nthTerm = 2;
  BigInteger previous (1);
  BigInteger current  (1);
  while(current.getNumDigits() != numDigits)
  {
    BigInteger sum = previous + current;
    previous = current;
    current = sum;
    ++ nthTerm;
  }
  return nthTerm;
}

#endif