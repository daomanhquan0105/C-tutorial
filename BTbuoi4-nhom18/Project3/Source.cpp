#include<stdio.h>
#include<string.h>

struct sinhvien
{
	char hoten[50];
};
struct HoTen
{
	char ten[10];
	char tendem[20];
	char ho[10];
};
void nhap(sinhvien sv[],int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("nhap ten sv thu %d: ",(i+1));
		gets_s(sv[i].hoten);
	}
	
}

void hien(sinhvien sv[],int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("ho va ten sinh  thu %d : %s\n",(i+1) ,sv[i].hoten);
	}
}

void doicho(sinhvien x, sinhvien y)
{
	sinhvien c = x;
	x = y; y = c;
}
void catTen(sinhvien x, HoTen y)
{
	
	for (int i = strlen(x.hoten)-1;i>=0; i--)
	{
		if (x.hoten[i]==' ')
		{
			strcpy_s(y.ten, x.hoten +1+i);
			break;
		}
	}
	printf("%s\n", y.ten);
}
void catHo(sinhvien x, HoTen y)
{
	for (int i = 0; i < strlen(x.hoten); i++)
	{
		strcpy_s(y.ho, x.hoten+i);
		if (x.hoten[i] == ' ')
		{
			break;
		}
	}
	printf("\n%s", y.ho);
}
//void hienTen(HoTen ht[],int n)
//{
//	for (int i = 0; i < n; i++)
//	{
//		printf("ho va ten sinh  thu %d : %s\n", (i + 1), ht[].ten);
//	}
//}
//void sapXepTen(sinhvien x, sinhvien y)
//{
//	char s1[10];
//	char s2[10];
//	int i ,j;
//	for(i=0;i<strlen())
//}
void main()
{
	sinhvien sv1[10];
	HoTen y[10];
	nhap(sv1, 3);
	hien(sv1, 3);
	for (int i = 0;  i < 3;  i++)
	{
		catTen(sv1[i], y[i]);
		catHo(sv1[i], y[i]);
	}
	
}