#include<stdio.h>
struct hocvien
{
	char tenHV[50];
	int tuoi;
	char diaChi[1000];
};
hocvien nhap()
{
	char a[2];
	hocvien hv;
	printf("\nnhap ten hoc vien: ");
	gets_s(hv.tenHV);
	printf("\nnhap tuoi cua hoc vien: ");
	scanf_s("%d", &hv.tuoi);
	gets_s(a);
	printf("\nnhap dia chi cua hoc vien: ");
	gets_s(hv.diaChi);
	return hv;
}
void hien(hocvien hv)
{
	printf("\n ten cua hoc vien: %s", hv.tenHV);
	printf("\n tuoi cua hoc vien: %d ", hv.tuoi);
	printf("\n dia chi cua hoc vien: %s", hv.diaChi);
}
void main()
{
	hocvien hv1;
	hv1 = nhap();
	hien(hv1);
}