#include<stdio.h>
struct QueQuan
{
	char XaPhuong[100];
	char QuanHuyen[100];
	char ThanhPho[100];
};
struct Nguoi
{
	char HoTen[100];
	int tuoi;
	int GioiTinh;
	QueQuan quequan;
};
Nguoi nhap()
{
	char c[2];
	Nguoi human;
	printf("nhap thong tin: ");
	printf("\n nhap tinh : ");
	gets_s(human.quequan.ThanhPho);
	printf("\n nhap quan huyen: ");
	gets_s(human.quequan.QuanHuyen);
	printf("\n nhap xa phuong: ");
	gets_s(human.quequan.XaPhuong);
	printf("\n nhap ho ten: ");
	gets_s(human.HoTen);
	printf("\n nhap tuoi: ");
	scanf_s("%d", &human.tuoi);
	gets_s(c);
	printf("\n gioi tinh: ");
	scanf_s("%d", &human.GioiTinh);
	gets_s(c);
	printf("======================================");
	return human;
}
void hien(Nguoi human)
{
	printf("\n ten tinh: %s", human.quequan.ThanhPho);
	printf("\n quan/ huyen: %s", human.quequan.QuanHuyen);
	printf("\n xa/phuong: %s", human.quequan.XaPhuong);
	printf("\n ho va ten: %s", human.HoTen);
	printf("\n tuoi: %d", human.tuoi);
	printf("\n gioi tinh: ");
	if (human.GioiTinh == 1)
		printf(" nam ");
	else printf(" nu ");
}
void main()
{
	Nguoi human1;
	human1 = nhap();
	hien(human1);
}