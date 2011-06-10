#ifndef PROBLEM_016_H
#define PROBLEM_016_H

#include "Problem013.h"

BigInteger powerBigInteger(int singleDigitNumber, int exponent)
{
  BigInteger result (singleDigitNumber); 
  for (int i = 1; i< exponent; ++i)
    result.multiplyBySingleDigitNumber(singleDigitNumber);
  return result;
}

int sumPower(int singleDigitNumber, int exponent)
{
  BigInteger result = powerBigInteger(singleDigitNumber, exponent);
  return result.sumDigits();
}

#endif

