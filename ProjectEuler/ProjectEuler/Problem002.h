#ifndef PROBLEM_002_H
#define PROBLEM_002_H

int sumEvenFibonacci(int maxVal)
{
	int prev = 1;
	int curr = 2;
	int sum =  0;
	while (curr < maxVal)
	{
		if (curr % 2 == 0)
			sum += curr;
		int next = prev + curr;
		prev = curr;
		curr = next; 
	}
	return sum;
}

#endif