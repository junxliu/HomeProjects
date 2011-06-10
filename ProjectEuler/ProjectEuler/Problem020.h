#ifndef PROBLEM_020_H
#define PROBLEM_020_H

#include "Problem013.h"

BigInteger factorial (int n)
{
  BigInteger result(1);
  for (int i = 2; i<=n; ++i)
    result = result * BigInteger(i);
  return result;
}


int problem20(int n)
{
  BigInteger fact = factorial(n);
  return fact.sumDigits();
}

#endif