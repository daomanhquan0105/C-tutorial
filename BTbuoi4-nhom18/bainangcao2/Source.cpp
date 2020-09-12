#include<stdio.h>
#include<stdlib.h>
#include<math.h>
struct diem
{
	int x;
	int y;
};
struct tamgiac
{
	diem A;
	diem B;
	diem C;
};
tamgiac nhap()
{
	tamgiac TG;
	char c[2];
	printf("\n nhap vao toa do cua diem A: ");
	scanf_s("%d", &TG.A.x);
	scanf_s("%d", &TG.A.y);
	printf("\n nhap vao toa do cua diem b: ");
	scanf_s("%d", &TG.B.x);
	scanf_s("%d", &TG.B.y);
	printf("\n nhap vao toa do cua diem c: ");
	scanf_s("%d", &TG.C.x);
	scanf_s("%d", &TG.C.y);
	return TG;
}
void hien(tamgiac TG)
{
	printf("\nA(%d,%d)", TG.A.x, TG.A.y);
	printf("\nB(%d,%d)", TG.B.x, TG.B.y);
	printf("\nC(%d,%d)", TG.C.x, TG.C.y);
}
double tinhChieuDai(diem A, diem B) { return sqrt(pow((A.x - B.x), 2)+pow((A.y-B.y),2)); }
double kTraTamGia(diem A, diem B, diem C) 
{
	if (A.x == B.x && A.y==B.y || A.x==C.x && A.y== C.y || B.x==C.x && B.y==C.y) return 0;
	else 
	{
		double a = tinhChieuDai(A, B);
		double b = tinhChieuDai(B, C);
		double c = tinhChieuDai(C, A);
		if (a + b > c || a + c > b || b + c > a) return 1;
		else
		{
			return 0;
		}
	}
}
 void tinhChuVi(tamgiac tg)
{
	if (kTraTamGia(tg.A,tg.B,tg.C) == 1)
	{
		double a = tinhChieuDai(tg.A, tg.B);
		double b = tinhChieuDai(tg.B, tg.C);
		double c = tinhChieuDai(tg.C, tg.A);
		hien(tg);
		printf("\n chu vi tam gia: %lf",((a + b + c)/2));
	}
	else
	{
		tg = nhap();
		tinhChuVi(tg);
	}
}
 int GanChuVi(tamgiac tg)
 {
	 if (kTraTamGia(tg.A, tg.B, tg.C) == 1)
	 {
		 double a = tinhChieuDai(tg.A, tg.B);
		 double b = tinhChieuDai(tg.B, tg.C);
		 double c = tinhChieuDai(tg.C, tg.A);
		 hien(tg);
		 return ((a + b + c) / 2);
	 }
	 else
	 {
		 tg = nhap();
		 tinhChuVi(tg);
	 }
}
void tinhdientich(tamgiac tg)
{
	if (kTraTamGia(tg.A,tg.B,tg.C) == 1)
	{
		double a = tinhChieuDai(tg.A, tg.B);
		double b = tinhChieuDai(tg.B, tg.C);
		double c = tinhChieuDai(tg.C, tg.A);
		double p = (a + b + c)/2;
		double s = sqrt(p * (p - a) * (p - b) * (p - c));
		printf("\n dien tich tam giac la: %lf", s);
	}
	else
	{
		tg = nhap();
		tinhdientich(tg);
	}
}
void swap(tamgiac a, tamgiac b)
{
	tamgiac c = a;
	a = b; b = c;
}
void tinhChuViMang(tamgiac tg[], int n)
{
	tamgiac a[1000];
	for (int i = 0; i < n; i++)
	{
		printf("chu vi cua tam giac thu %d trong mang: ", (i + 1));
	    tinhChuVi(tg[i]);
	}
	for (int i = 0; i < n - 1; i++)
	{
		double a = tinhChieuDai(tg[i].A, tg[i].B);
		double b = tinhChieuDai(tg[i].B, tg[i].C);
		double c = tinhChieuDai(tg[i].C, tg[i].A);
		double p = (a + b + c) / 2;
		for (int j = i + 1; j < n; j++)
		{
			double a1 = tinhChieuDai(tg[j].A, tg[j].B);
			double b1 = tinhChieuDai(tg[j].B, tg[j].C);
			double c1 = tinhChieuDai(tg[j].C, tg[j].A);
			double p1 = (a1 + b1 + c1) / 2;
			if (p < p1)
			{
				swap(tg[i], tg[j]);
			}
		}
	}
}

void main()
{
	tamgiac tg1;
	tg1 = nhap();
	system("cls");
	tinhChuVi(tg1);
	tinhdientich(tg1);
}