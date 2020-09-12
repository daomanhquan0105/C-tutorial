#include<stdio.h>
struct SanPham
{
	char tenSP[50];
	char loaiSP[100];
	int giaSP;
	char GhiChu[1000];
};
SanPham nhap()
{
	char a[2];
	SanPham sp;
	printf("\nnhap ten san pham: ");
	gets_s(sp.tenSP);
	printf("\nloai san pham: ");
	gets_s(sp.loaiSP);
	printf("\n gia san pham la: ");
	scanf_s("%d", &sp.giaSP);
	gets_s(a);
	printf("\n ghi chu cho san pham: ");
	gets_s(sp.GhiChu);
	return sp;
}
void hien(SanPham sp)
{
	printf("\nten san pham: %s", sp.tenSP);
	printf("\nten san pham: %s", sp.loaiSP);
	printf("\nten san pham: %d", sp.giaSP);
	printf("\nten san pham: %s", sp.GhiChu);
}
void main()
{
	SanPham sp1;
	sp1 = nhap();
	hien(sp1);
}