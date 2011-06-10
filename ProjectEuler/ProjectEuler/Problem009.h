#ifndef PROBLEM_009_H
#define PROBLEM_009_H

bool isPythagorean(int a, int b, int c)
{
  return (a*a + b*b) == (c*c);
}

int productOfPythagoreanTriplets(int sum)
{
  for (int a = 1; a <= sum; ++ a)
    for (int b = a; b <= sum; ++b)
    {
      int c = sum - a - b;
      if (isPythagorean(a, b, c))
        return a * b * c; 
    }
    return 0; 
}



#endif