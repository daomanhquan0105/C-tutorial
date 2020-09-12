#include<stdio.h>
struct sach
{
	char tieuDe[100];
	char tacGia[50];
	int giaBan;
	char noiDung[1000];
};
sach nhap()
{
	char a[2];
	sach s;
	printf("\n nhap tieu de cua sach: ");
	gets_s(s.tieuDe);
	printf("\n ten tac gia cua sach la: ");
	gets_s(s.tacGia);
	printf("\n gia ban cua sach do: ");
	scanf_s("%d", &s.giaBan);
	gets_s(a);
	printf("\n noi dung chinh cua sach: ");
	gets_s(s.noiDung);
	printf("====================================");
	return s;
}
void hien(sach s)
{
	printf("\n tieu de cua sach: %s", s.tieuDe);
	printf("\n tac gia cua sach: %s", s.tacGia);
	printf("\n gia ban cua sach: %d", s.giaBan);
	printf("\n noi dung cua sach: %s", s.noiDung);
	printf("------------------------------------------");
}
void main()
{
	sach a[3];
	for (int i = 0; i < 3; i++)
	{
		a[i] = nhap();
	}
	printf("\nsach co gia ban lon hon la: ");
	int x;
	scanf_s("%d", &x);
	for (int i = 0; i < 3; i++)
	{
		if (a[i].giaBan >= x)
		{
			hien(a[i]);
		}
	}
}