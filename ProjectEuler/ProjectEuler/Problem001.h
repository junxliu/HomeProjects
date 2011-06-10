#ifndef PROBLEM_001_H
#define PROBLEM_001_H

bool isMultiple3(int val)
{
	return val % 3 == 0; 
}

bool isMultiple5 (int val)
{
	return val % 5 == 0;
}

int sumMultiple35(int maxVal)
{
	int sum  = 0;
	for (int i= 1; i< maxVal; ++i)
		if (isMultiple3(i) || isMultiple5(i))
			sum += i;
	return sum;
}

#endif