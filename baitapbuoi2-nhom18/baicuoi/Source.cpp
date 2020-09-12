#include<stdio.h>
#include<math.h>

int timMin(int a, int b)
{
	if (a > b) return b;
	if (a < b) return a;
}
int timMin3So(int a, int b, int c)
{
	int x = timMin(timMin(a, b), c);
	return x;
}
int kTraFibo(int a)
{
	int i = 0;
	int so1 = 1;
	int so2 = 1, so3 = 0;
	while (i < a)
	{
		so3 = so1 + so2;

		if (so3 == a)
		{
			return a;
		}
		else
		{
			so1 = so2;
			so2 = so3;
		}
		i++;
	}
	//if (so3 == a) return a;
	if (so3 != a) return 0;
}
int ktraMu3(int a)
{
	if (pow(a, (1 / 3)) == (int)pow(a, (1 / 3)))
		return a;
	return 0;
}



void main()
{
	int x = timMin3So(18, 8, 15);
	printf("so nho nhat la: %d\n", x);
	if (kTraFibo(x) != 0) printf("%d thuoc trong day fibonacci ", x);
	if (kTraFibo(x) == 0)
	{
		printf("%d khong thuoc trong day so fibonacci", x);
	}
