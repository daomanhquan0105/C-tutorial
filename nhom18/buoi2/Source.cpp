#include<stdio.h>

void main()
{
	int a[] = {121,454,898,745,465};
	int b = 0;
	for (int i = 0; i < 5; i++) {
		for(int j=a[i]; j!=0;j/10)
		{
			b = b * 10 + j % 10;
		}
		if (b == a[i]) {
			printf("%d", a[i]);
		}
	}
}