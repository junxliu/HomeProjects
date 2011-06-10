#ifndef PROBLEM_005_H
#define PROBLEM_005_H

#include <vector>
#include <numeric>

long long smallestDivisible(int n)
{ 
	std::vector<int>		selectedVal;
	long long product = 1; 
	for (int i=2; i<=n; ++i)
	{
		if (product % i != 0)
		{
			bool hasDiv = false;

			for (std::vector<int>::iterator iter = selectedVal.begin(); iter!= selectedVal.end(); ++iter)
			{
				if (i % (*iter) == 0)
				{
					*iter = i;
					hasDiv = true;
					break;
				}
			}

			if (!hasDiv)
			{
				selectedVal.push_back(i);
			}

			product = std::accumulate(selectedVal.begin(), selectedVal.end(), 1, std::multiplies<int>());
		}
	}

	return product; 
}

#endif