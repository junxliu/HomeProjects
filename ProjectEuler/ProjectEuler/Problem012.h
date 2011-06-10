#ifndef PROBLEM_012_H
#define PROBLEM_012_H

#include <cmath>

long long triangleNumber(long long n)
{
  return (1 + n) * n / 2;
}

int numDivisors(long long val)
{
  if (val == 1) return 1;
  long long upperLimit = static_cast<long long>(sqrt(static_cast<double>(val)));
  int num = 2;
  for (long long i = 2; i<= upperLimit; ++i)
    if (val % i == 0)
       num += 2;

  if (upperLimit * upperLimit == val)
    num -= 1;

  return num; 
}

long long firstTriangleNumber(int minNumDivisors)
{
  for (int i =1; ; ++i)
  {
    long long number = triangleNumber(i);
    int numDiv       = numDivisors(number);
    if (numDiv > minNumDivisors)
      return number;
  }
}

#endif