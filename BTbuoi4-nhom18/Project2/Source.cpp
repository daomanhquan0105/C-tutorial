#include<stdio.h>

struct sanPham
{
	char tenSP[100];
	char loaiSP[100];
	int giaSP;
	char ghiChu[1000];
};
sanPham nhap()
{
	char c[2];
	sanPham s;
	printf("\n nhap ten san pham: ");
	gets_s(s.tenSP);
	printf("\n loai san pham: ");
	gets_s(s.loaiSP);
	printf("\n gia cua san pham: ");
	scanf_s("%d", &s.giaSP);
	gets_s(c);
	printf("\n ghi chu ve san pham: ");
	gets_s(s.ghiChu);
	printf("==================================");
	return s;
}
void hien(sanPham s)
{
	printf("\n ten san pham: %s", s.tenSP);
	printf("\n loai san pham: %s", s.loaiSP);
	printf("\n gia san pham: %d", s.giaSP);
	printf("\n ghi chu ve san pham: %s", s.ghiChu);
	printf("\n-----------------------------------------");
}

void main()
{
	sanPham sp1[3];
	for (int i = 0; i < 3; i++)
	{
		sp1[i] = nhap();
	}
	printf("\nsan pham da duoc sap xep la: ");
	for (int i = 0; i < 2; i++)
	{
		for (int j = i + 1; j < 3;j++)
		{
			if (sp1[i].giaSP > sp1[j].giaSP)
			{
				sanPham x = sp1[i];
				sp1[i] = sp1[j];
				sp1[j] = x;
			}
		}
	}
	for (int i = 0; i < 3; i++)
	{
		hien(sp1[i]);
	}
}