#include<stdio.h>
#include<stdlib.h>
struct HocSinh
{
	int MaHS;
	char tenHS[100];
	char diaChi[200];
	char ngaySinh[50];
	float diemTB;
};
struct Lop
{
	int maLop;
	char tenLop[20];
	int siSo;
	HocSinh hs[100];
};
Lop nhap()
{
	char c[2];
	Lop lop;
	printf("\nma lop: ");
	scanf_s("%d", &lop.maLop);
	gets_s(c);
	printf("ten lop: ");
	gets_s(lop.tenLop);
	printf("nhap si so lop: ");
	scanf_s("%d", &lop.siSo);
	gets_s(c);
	printf("====================================");
	HocSinh hs[100];
	for (int i = 0; i < lop.siSo; i++)
	{
		printf("\n nhap thong tin cua hoc sinh %d: ", (i + 1));
		printf("\n ten hoc sinh: ");
		gets_s(lop.hs[i].tenHS);
		printf("ma hoc sinh: ");
		scanf_s("%d", &lop.hs[i].MaHS);
		gets_s(c);
		printf("dia chi: ");
		gets_s(lop.hs[i].diaChi);
		printf("ngay sinh: ");
		gets_s(lop.hs[i].ngaySinh);
		printf("diem trung binh: ");
		scanf_s("%f", &lop.hs[i].diemTB);
		gets_s(c);
		printf("---------------------------------------------------");
	}
	return lop;
}
void nhapDS(Lop lop[], int n)
{
	for (int i = 0; i < n; i++)
	{
		lop[i] = nhap();
	}
}
Lop sapXepMaHS(Lop lop)
{
	Lop x;
	for (int i = 0; i < lop.siSo - 1; i++)
	{
		for (int j = i + 1; j < lop.siSo; j++)
		{
			if (lop.hs[i].MaHS > lop.hs[j].MaHS)
			{
				x.hs[1] = lop.hs[i];
				lop.hs[i] = lop.hs[j];
				lop.hs[j] = x.hs[1];
			}
		}
	}
	return lop;
}
void hien(Lop lop)
{
	for (int i = 0; i < lop.siSo; i++)
	{
		printf("\n ten lop : %s", lop.tenLop);
		printf("\n ma lop cua hoc sinh: %d", lop.maLop);
		printf("\n si so cua lop do la: %d", lop.siSo);
		printf("\n ten hoc sinh: %s", lop.hs[i].tenHS);
		printf("\n ma hoc sinh: %d", lop.hs[i].MaHS);
		printf("\n dia chi hoc sinh: %s", lop.hs[i].diaChi);
		printf("\n ngay sinh cua hoc sinh: %s", lop.hs[i].ngaySinh);
		printf("\n diem trung binh hoc sinh: %f", lop.hs[i].diemTB);
		printf("\n-----------------------------------------------------------------");
	}
	printf("\n==================================================================");
}
void hienDS(Lop lop[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("thong tin lop %d: ", (i + 1));
		hien(lop[i]);
	}
}
void xepHanhKiem(Lop lop)
{
	printf("\ndanh sach sinh vien co hanh kiem yeu la: \n");
	for (int i = 0; i < lop.siSo; i++)
	{
		if (0 <= lop.hs[i].diemTB <= 4)
		{
			hien(lop);
		}
	}
	printf("\ndanh sach sinh vien co hanh kiem trung binh la: \n");
	for (int i = 0; i < lop.siSo; i++)
	{
		if (4< lop.hs[i].diemTB <= 6)
		{
			hien(lop);
		}
	}
	printf("\ndanh sach sinh vien co hanh kiem kha la: \n");
	for (int i = 0; i < lop.siSo; i++)
	{
		if (6 < lop.hs[i].diemTB <= 8)
		{
			hien(lop);
		}
	}
	printf("\ndanh sach sinh vien co hanh kiem gioi la: \n");
	for (int i = 0; i < lop.siSo; i++)
	{
		if (8 < lop.hs[i].diemTB <= 9)
		{
			hien(lop);
		}
	}
	printf("\ndanh sach sinh vien co hanh kiem xuat sac la: \n");
	for (int i = 0; i < lop.siSo; i++)
	{
		if (9 < lop.hs[i].diemTB <= 10)
		{
			hien(lop);
		}
	}
}
void xepHanhKiemTheoLop(Lop lop[], int n)
{
	for (int i = 0; i < n; i++)
	{
		xepHanhKiem(lop[i]);
	}
}
void main()
{
	Lop lop1[10];
	int n = 2;
	nhapDS(lop1, n);
	system("cls");
	hienDS(lop1, n);
	xepHanhKiemTheoLop(lop1, n);
}