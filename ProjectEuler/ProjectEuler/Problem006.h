#ifndef PROBLEM_006_H
#define PROBLEM_006_H

int squareOfSum(int n)
{
	int sum = (1 + n) * n / 2;
	return sum * sum;
}

int sumOfSquare(int n)
{
	return n * (n+1) * (2 * n + 1) / 6;
}

int diffSS(int n)
{
	return squareOfSum(n) - sumOfSquare(n);
}

#endif