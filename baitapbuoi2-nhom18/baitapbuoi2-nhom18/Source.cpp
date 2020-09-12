#include<stdio.h>
#include<math.h>
#include <conio.h>
#include<stdlib.h>
#include <string.h>


void viduA1()
{
	int N[] = { 4,5,7,9,2,3,14,15,17,11,13 };
	int n = 11;
	for (int i = 0; i < n; i+=2)
	{
		printf("%d\n", N[i]);
	}
}
void viduA2()
{
	int N[] = { 4,5,7,9,2,3,14,15,17,11,13 };
	int n = 11;
	int tong = 0;
	for (int i = 1; i < n; i+=2)
	{
		tong += N[i];
		//printf("%d\n", N[i]);
	}
	printf("tong cac phan o vi tri le trong mang la: %d", tong);
}
void viduA3()
{
	int N[] = { 4,5,7,9,2,3,14,15,17,11,13 };
	int n = 11;
	int min =N[0], max=N[0];
	for (int i = 1; i < n; i ++)
	{
		if (min > N[i])
		{
			min = N[i];
		}
		if (max < N[i])
		{
			max = N[i];
		}

	}
	printf("gia tri nho nhat cua mang la: %d\n gia tri lon nhat cua mang la : %d ", min, max);
}
void viduA4()
{
	int N[] = { 4, 5, 7, 9, 2, 3, 14, 15,17,11,13 };
	int n = 11;
	int i, j;
	for (i = 0; i < n - 1; i++)
	{
		for (j = i + 1; j < n; j++)
		{
			if (N[i] > N[j])
			{
				int c = N[i];
				N[i] = N[j];
				N[j] = c;
			}
		}
	}
	for (i = 0; i < n; i++)
	{
		printf("%d ", N[i]);
	}
}
void viduA5()
{
	
	int N[] = { 2,2,3,4,5,7,9,2,3,14,15,2,4,11,17,11,13,20,19,14,14,15,17,17,15,87,88,74,14,23 };
	int n = 27;
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (N[i] > N[j])
			{
				int c = N[i];
				N[i] = N[j];
				N[j] = c;
			}
		}
	}
	for (int i = 0; i < n; i++)
	{
		printf("%d ", N[i]);
	}
	printf("\n");
	int dem = 0;
	for (int i = 0; i < n; i++)
	{
		if (N[i] != N[i + 1])
		{
			printf("%d xuat hien %d\n", N[i], (i - dem + 1));
			dem = i + 1;
		}
	}
	
}
void viduA6()
{
	char N[] = { 'a','b','c','d','e','a','c','a','a' };
	int n = 9;
	int cout = 0;
	for (int i = 0; i < n; i++)
	{

	}

}
void viduA7()
{
	double N[] = { 1,4,5,6,10,8,9,11,13,14,16,18,20,21 };
	int ktra = 0;

	for (int i = 0; i <14 ; i++)
	{
		if (N[i] <= N[i + 1]) ktra = 1;
		else
		{
			ktra = 3; 
			break;
		}
	}
	if (ktra == 1)
	{
		printf("day la day so tang");
	}
	else 
	{
		for (int i = 0; i < 14; i++)
		{
			if (N[i] >= N[i + 1]) ktra = 2;
			else
			{
				ktra = 4;
				break;
			}
		}
		if (ktra == 2)
		{
			printf("day la day so giam");
		}
		else printf("day la day hon don");
	}
}
void viduA8()
{
	int N[] = { 1,4,5,6,10,8,9,6,1,14,16,18,20,21 };
	int n = 14;
	int ktra = 0;
	int tong = 0;
	for (int i = 0; i < n; i++)
	{
		if (N[i] != 1)
		{
			for (int j = 1; j <= N[i] / 2; j++)
			{
				if (N[i] % j == 0)
				{
					tong += j;
				}
			}
			if (tong == N[i])
			{
				ktra += N[i];
			}
		}
		tong = 0;
	}
	printf("tong cua cac so hanh phuc la: %d", ktra);
}
void viduA9()
{
	int A[] = { 1,4,5,6,10,8,9,6,1,10,21 };
	int B[] = { 1,4,5,6,10,8,9,6,1,10,21 };
	int n = 10;
	int x = 0;
	for (int i = 0; i < n; i++)
	{
		for (int j = A[i]; j != 0; j /= 10)
		{
			x = x * 10 + j % 10;
		}

		A[i] = x;
		x = 0;
		for (int j = B[i]; j != 0; j /= 10)
		{
			x = x * 10 + j % 10;
		}
		B[i] = x;
		x = 0;
	}
	printf("gia tri tong cua 2 mang la: \n");
	for (int i = 0; i < n; i++)
	{
		printf("%d\n",(A[i]+B[i]));
	}
}
void viduA10()
{
	float a[] = { 4,5.12,7.13,9.9,2.0,3,14,15,2,4,11,17,11,13 };
	int n = 14, x=0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] > 0 && a[i] == (int)a[i])
		{
			printf("%0.0f  ", a[i]);
			x++;
		}
	}
	printf("\n");
	for (int i = 0; i < n; i++)
	{
		if (a[i] > 0 && a[i] == (int)a[i] && (int)a[i] % 3 == 0)
		{
				printf("%0.2f ", a[i]);
		}
	}
	//chen
	float sum = 0;
	for (int i = 1; i < n; i += 2)
	{
		sum += i;
	}
	printf("tong cac phan tu le la %0.2f\n", sum);
	if ((n-1) % 2 == 0)
	{
		a[n / 2] = sum;
	}
	if ((n-1) % 2 != 0)
	{
		a[(n) / 2] = sum;
	}
	for (int i = 0; i < n; i++)
	{
		printf("%0.0f  ", a[i]);
	}
}
void viduB1(int** a, int n, int m);
void viduB2(int n)
{
	int tong=0;
	for (int i = 1; i <= n; i++)
	{
		tong += i;
	}
	printf("%d ", tong);
}
void viduB3(int n)
{
	if (n % 2 == 0)
		printf("%d la so chan",n);
	else printf("%d la so le",n);
}
void viduB4(double a, double b)
{
	int c = a;
	a = b;
	b = c;
	printf("cac so sau khi hoan vi la: %0.0f  %0.0f", a, b);
}
void viduB5_kiemtrasoCP(int n)
{
	if (sqrt(n) == (int)sqrt(n))
	{
		printf("%d la so chinh phuong", n);
	}
}
int viduB6_tinhdientichHCN(int a, int b)
{
	int S = a * b;
	return S;
}
void viduB7_tinhtong(int a, int b)
{
	int i = 0,tong=0;
	if (a % 2 == 0)
	{
		for (i = a + 1; i < b; i += 2)
			tong += i;
	}
	else
	{
		for (i = a + 2; i < b; i += 2)
			tong += i;
	}
	printf("tong cac so trong khoang tu %d den %d la: %d", a, b, tong);
}
void viduB8(int*a,int n)
{
	int min = a[0], max = a[0];
	for (int i = 1; i < n; i++)
	{
		if (min > a[i])
			min = a[i];
		if (max < a[i])
			max = a[i];
	}
	printf("min=%d\nmax=%d\n", min, max);
}
void viduB9(int* a, int n)
{
	int i, j;
	for (i = 0; i < n - 1; i++)
	{
		for (j = i + 1; j < n; j++)
		{
			if (a[i] > a[j])
			{
				int c = a[i];
				a[i] = a[j];
				a[j] = c;
			}
		}
	}
	for (i = 0; i < n; i++)
	{
		printf("%d ", a[i]);
	}
	printf("\nba so nho nhat cua day la: %d %d %d ", a[0], a[1], a[2]);
}
void viduB10(int* a, int n)
{
	for (int i = 0; i < n; i++)
		printf("%d  ", a[i]);
}
void viduB11()
{
	int x;
	scanf_s("%d", &x);
	if (x % 2 == 0)
	{
		printf("%d la so chan", x);
	}
	else
	{
		printf("%d la so le", x);
	}
}
//void viduB12()
//{
//	char a = printf("hello word");
//	char b = printf("hello word!!");
//	char c[] = { a,b };
//	int min = strlen(a);
//	for (int i = 1; i > 2; i++)
//	{
//		if (min > strlen(b));
//		min = strlen(b);
//	}
//
//	printf("%c", min);
//}
void viduB15()
{

	int n;
	scanf_s("%d", &n);
	if (n == 0)
	{
		printf("%d khong phai so nguyen am cung khong phai nguyen duong", n);
	}
	if (n > 0 && n == (int)n)
	{
		printf("%d la so nguyen duong", n);
	}
	if (n < 0 && n == (int)n) {
		printf("%d la so nguyen am", n);

	}
}

void viduB16(int n)
{
	int sum = 1;
	for (int i = 2; i <= n; i++)
	{
		sum *= i;
	}
	printf("%d!=%d", n,sum);
}
void viduB17(int a[][100],int n,int m)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("a[%d][%d]=  ", i, j);
			scanf_s("%d", &a[i][j]);
		}
		printf("\n");
	}
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("a[%d][%d]=%d\t ",i,j, a[i][j]);
		}
		printf("\n");
	}
}
void viduB18(int *a,int n)
{
	
	for (int i = 0; i < n; i++)
	{
		if (i > 0 && i % 5 == 0)
			printf("\n\n");
			printf("a[%d]=%d\t\t", i, a[i]);
	}
}

void main()
{
	int dem = 1;
	int demMoi = 0;
	int so = 0;
	int N[] = { 2,2,3,4,5,7,9,9,9,9,9,9,9,9,2,3,14,15,2,4,11,17,11,13,20,19,14,14,15,17,17,15,87,88,74,14,23 };
	int n = 27;
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (N[i] == N[j])
				dem+=1;
		}
		if (demMoi < dem)
		{
			demMoi = dem;
			so = N[i];
		}
		dem = 1;
	}
	printf("%d co so %d xuat hien ",so,demMoi);
	
}