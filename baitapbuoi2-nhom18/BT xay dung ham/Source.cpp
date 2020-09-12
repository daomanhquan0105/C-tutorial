#include<stdio.h>
#include<math.h>
#include <conio.h>
#include<stdlib.h>
#include <string.h>
double tinhTich(double a, double b)
{
	return  a * b;
}
void nhapXuatMang(int* a,int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("a[%d]=", i);
		scanf_s("%d", &a[i]);
	}
	for (int i = 0; i < n; i++)
	{
		printf("a[%d]=%d\t", i, a[i]);
	}
}
void veTamgiacVuong(int n)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < i; j++)
		{
			printf("* ");
		}
		printf("\n");
	}
}
void ktraSoCP(int n)
{
	if (sqrt(n) == (int)sqrt(n))
		printf("%d la so chinh phuong", n);
	else printf("%d ko phai so chinh phuong", n);
}
void tinhCan(int n, int x)
{
	double S = pow(x, (1.0/n));
	printf("%0.4f", S);
}
void inBangCuuchuong(int n)
{
	for (int i = 1; i < n; i++)
	{
		for (int j = 1; j < n; j++)
			printf("%d*%d=%d\t", j, i, (j* i));
		printf("\n");
	}
}
void tinhTongGiaiThua(int n)
{
	double sum = 0, so = 1;
	for (int i = 1; i <= n; i++)
	{
		for (int j = i; j>0; j--)
		{
			so *= j;
		}
		sum+= 1 / so;
		so = 1;
	}
	printf("%0.4f", sum);
}
double timDieuKienMang(double* a, int n)
{
	for (int i = 0; i < n; i++)
	{
		if (i == 0 || i==1)
		{
			if (a[i] == a[i + 1] * a[i + 2])
			{
				return 1;
				break;
			}
			return -1;
		}
		if (i > 2)
		{
			if (a[i] == a[i - 1] * a[i - 2] || a[i] == a[i + 1] * a[i + 2])
			{
				return 1;
				break;
			}
			else
			{
				return -1;
			}
		}
	}
}
int ktraSoNguyenTo(int n)
{
	if (n == 1) return 0;
	else
	{
		if (n == 2 || n == 3 || n == 5)
			return 1;
		else
		{
			if (n % 2 == 0) return 0;
			else
			{
				for (int i = 3; i < sqrt(n); i++)
				{
					if (n % i == 0) 
						return 0;
				}
				return 1;
			}
		}
	}
}
void timViTriMang(int* a, int n)
{
	int x;
	printf("nhap x: ");
	scanf_s("%d", &x);
	int vitri = 0;
	for (int i = 0; i < n; i++)
	{
		if (a[i] == x)
		{
			vitri = i;
			printf("%d co vi tri la %d\n", x, i);
		}
	}
	if (vitri == 0) printf("-1");
}
void lietKe(int* a, int n)
{
	for (int i = 1; i < n; i++)
	{
		if (a[i - 1] <= a[i])
		{
			printf("%d <= %d\n", a[i - 1], a[i]);
		}
		if (a[i - 1] >= a[i])
		{
			printf("%d <= %d\n", a[i], a[i - 1]);
		}
	}
	
}
void timDoanChuaMang(double* a, int n)
{
	int max = a[0];
	int min = a[0];
	for (int i = 1; i < n-1; i++)
	{
		if (max < a[i]) max = a[i];
		if (min > a[i]) min = a[i];
	}
	if (abs(min) >= abs(max))
	{
		printf("mang thuoc trong doan tu [%d,%d]\n", min, (-min));
	}
	else
	{
		printf("mang thuoc trong doan tu [%d,%d]\n", (-max), max);
	}
}
void timSNTlonHonMang(int* a, int N)
{
	int max = a[0];
	for (int i = 1; i < N; i++)
	{
		if (max < a[i]) max = a[i];
	}
	while (max!=0)
	{
		max++;
		if (ktraSoNguyenTo(max) == 1)
		{
			printf("so nguyen to nho nhat ma lon hon gia tri lon nhat cua mang la: %d \n", max);
				break;
		}
	}
}
//int xetViTriDau(int* a, int n)
//{
//	if (pow())
//		return 1;
//	return 0;
//}
int timUCLN(int a, int b)
{
	if (a == 0 || b == 0) return (a + b);
	for (int i = (a + b) / 2; i>=1; i--)
	{
		if (a % i == 0 && b % i == 0)
		{
			return i;
			break;
		}
	}
}
void timUCLNMang(int* a, int n)
{
	int x = timUCLN(a[0], a[1]);
	for (int i = 2; i < n; i++)
	{
		x = timUCLN(x, a[i]);
	}
	printf("%d la UCLN cua mang\n\n", x);
}
int vietFiboDQ(int n)
{
	if (n == 1) return 0;
	if (n == 2) return 1;
	return (vietFiboDQ(n - 1) + vietFiboDQ(n - 2));
}
int tinhGiaiThuaDQ(int n)
{
	if (n == 1) return 1;
	return n*tinhGiaiThuaDQ(n-1);
}
int tinhGiaiThuaKDQ(int n)
{
	int so = 1;
	for (int i =1; i <= n; i++)
	{
		so *= i;
	}
	return so;
}
void timGiaTriGanNhau(double* a, int n)
{
	int hieu = a[0] - a[1];
	double x = a[0], y = a[1];
	for (int i = 1; i < n-1; i++)
	{
		int hieu1 = a[i] - a[i + 1];
		if (abs(hieu) > abs(hieu1))
		{
			x = a[i];
			y = a[i + 1];
			hieu = hieu1;
		}
	}
	printf("%0.2lf\t%0.2lf", x, y);
}
void timChancanhChan(int* a, int n)
{
	int x = 0;
	for (int i = 0; i < n-1; i++)
	{
		if (a[i] % 2 == 0 && a[i + 1] % 2 == 0)
		{
			x = 1;
			printf("%d\t", a[i]);
		}
		else 
		{
			x = 0;
		}
	}
	if (x == 0)
		printf("not found!");
}
void xuatMang(int a[][100], int n, int m)
{
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			printf("%d\t", a[i][j]);
		}
		printf("\n");
	}
}
void xoadong(int a[][100], int n, int m)
{
	int x;
	printf("nhap dong can xoa:  ");
	scanf_s("%d", &x);
	for (int i = x; i < n - 1; i++)
	{
		for (int j = 0; j < m; j++)
		{
			a[i][j] = a[i + 1][j];
		}
		printf("\n");
	}
	n--;
	xuatMang(a, n, m);
}
void xoacot(int a[][100], int n, int m)
{
	int x;
	printf("nhap cot can xoa:  ");
	scanf_s("%d", &x);
	for (int i = 0; i < n; i++)
	{
		for (int j = x; j < m-1; j++)
		{
			a[i][j] = a[i][j+1];
		}
		printf("\n");
	}
	m--;
	xuatMang(a, n, m);
}
void Xuat(int* a, int n)
{
	for (int i = 0; i < n; i++)
		printf("%d\t", a[i]);
}
void xoaPhanTuTrung(int* a, int n)
{
	for (int i = 0; i < n-1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (a[i] == a[j])
			{
				a[j] = 0;
			}
		}
	}
	Xuat(a, n);
}
void tinhtongchusotrongchuoi(char* s, int n)
{
	/*for (int i = 0; i < n; i++;)
	{
		if( )
	}*/
}
//kiem tra xem co phai la so hay k?
int laSo(char c) { return (c >= '0' && c <= '9'); }
//dem  ky tu trong chuoi
int demChuoi(char* s) {
	int n = 0,dem=0;
	while (s[n] != '\0')
	{
		dem++;
		n++;
	}
	return dem;
}
// gan kt so sang so
int ghepKT(int socu, char KT) { return (socu*10 + KT - '0'); }
int tinhTongChuoi(char* s)
{
	int tong = 0, so = 0;
	int n = demChuoi(s);
	for (int i = 0; i < n; i++)
	{
		if (laSo(s[i]))
		{
			so = ghepKT(so, s[i]);
		}
		else
		{
			if (so != 0) printf("%d + ", so);
			tong += so;
			so = 0;
		}
	}
	return tong;
}
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
	int i=0;
	int so1 = 1;
	int so2 = 1, so3=0;
	while ( i < a)
	{
		so3 = so1 + so2;
		
		if (so3==a)
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
	/*int x = timMin3So(18, 8, 15);
	printf("so nho nhat la: %d\n", x);
	if(kTraFibo(x)!=0) printf("%d thuoc trong day fibonacci ", x);
	if(kTraFibo(x)==0)
	{
		printf("%d khong thuoc trong day so fibonacci", x);
	}*/
	/*int a[] = { 1,2,2,4,5,78,7,9,10,4 };
	int n = 10;
	timChancanhChan(a, n);*/
	double a[] = { 10, 8, 1.3, 6, 4.6, 7, 9.4, 6.7 };
	int n = 8;
	timGiaTriGanNhau(a, n);

	/*char a[] = "abc123hd45ad71kabfv12lkaj36";
	int x = tinhTongChuoi(a);
	printf(" = %d", x);*/
	/*double a[] = { 2,2,2,3,4,3,3,7,5,6 };
	int c = timDieuKienMang(a,10);
	printf("%d\n", c);
	if (c == 1) printf("mang thoa man dieu kien");
	else printf("mang k thoa man dieu kien");*/
	/*int a[] = { 9,2,3,4,5,7,6,81,13,14,11,53,45,77,89 };
	int n = 15;*/
	/*int a[] = {1,2,3,4,5,2,3,4,5,6,3,4,8,9,10 };
	int n = 15; int m = 5;
	Xuat(a, n);
	printf("\n");
	xoaPhanTuTrung(a, n);*/
	/*int a[] = { 51,27,9,54,45,72,63,18,3,24,141,54,45,87,90 };
	int n = 15;
	timUCLNMang(a, n);*/
	//int x = vietFiboDQ(35);
	//printf("%d", x);
	/*int x = xetViTriDau(a, n);
	if (x == 1)
		printf("phan tu dau tien cua mang co dang 2^k la %d \n\n", a[0]);
	else
		printf("%d", x);*/	
	/*double y = tinhGiaiThuaKDQ(3);
	printf("%d\n", y);
	double x = tinhGiaiThuaDQ(3);
	printf("%d ", x);*/
	//timSNTlonHonMang(a, n);
}