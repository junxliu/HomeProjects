#ifndef PROBLEM_015_H
#define PROBLEM_015_H

long long combination(int n, int k)
{
  long long numerator   = 1;
  long long denominator = 1; 
  for (int i=k; i>=1; --i)
  {
    numerator   *= (n - i + 1);
    if (numerator % i == 0)
      numerator /= i;
    else
      denominator *= i; 
  }
  return numerator / denominator; 
}

#endif