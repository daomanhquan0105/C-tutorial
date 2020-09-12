#include<stdio.h>
#include <string>
#include<iostream>
#include<conio.h>

void main()
{
	/*int a[] = { 121,454,898,745,465,456654,22,4 };
	int tong=0;
	printf("cac so doi xung la: \n");
	for (int i = 0; i < 10; i++) 
	{
		for (int k = a[i]; k != 0; k = k / 10) 
		{
			tong = tong * 10 + k % 10;
		}
		if (tong == a[i])
		{
			printf("%d \n", a[i]);	
		}
		tong = 0;
	}*/
	int a[] = {3,7,13,24,31,43,53,61,84,93,86,73,44,57,35 };
	/*for (int i = 0; i < 12; i++)
	{
		printf("%d ", a[i]);
	}*/
	int n = 15;
	int gio[100] = { 0 };
	/*for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (a[i] > a[j])
			{
				int c = a[i];
				a[i] = a[j];
				a[j] = a[c];
			}
		}
	}
	printf("mang da dk sap xe la:\n ");
	for (int i = 0; i < n; i++) {
		printf("%d ", a[i]);
	}*/
	for (int i = 0; i < n; i++)
	{
		gio[a[i]]++;
	}
	for (int i = 0; i < 100; i++)
	{
		if (gio[i] > 0)
		{
			for (int j = 0; j < gio[i]; j++)
			{
				printf("%d ", i);
			}
		}
	}
	//int  y=1,x=17;
	/*for (int i = 0; i < n; i++)
	{
		for (int k = 2; k < a[i] / 2; k++)
		{
			if (a[i] % k == 0)
			{
				y = 0;
				break;
			}
		}
		if (y == 1)
		{
			printf("%d ", a[i]);
		}
		y = 1;
	}*/
}
