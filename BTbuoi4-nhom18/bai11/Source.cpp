#include<stdio.h>
#include<string.h>
struct quequan
{
	char thanhpho[30];
};
struct hocsinh
{
	char hoten[30];
	quequan que;
};
hocsinh nhap()
{
	hocsinh hs;
	printf("nhap ten hoc sinh: ");
	gets_s(hs.hoten);
	printf("nhap thanh pho cua hoc sinh: ");
	gets_s(hs.que.thanhpho);
	return hs;
}
void hien(hocsinh hs)
{
	printf("\n ten hoc sinh la: %s", hs.hoten);
	printf("\n thanh pho cua hs la: %s", hs.que.thanhpho);
}
void timChuoiHaNoi(hocsinh hs[],int n)
{
	char x[] = "ha noi";
	for (int i = 0; i < n; i++)
	{
		if (strstr(hs[i].que.thanhpho, x) != NULL)
		{
			hien(hs[i]);
		}
	}
}
void main()
{
	hocsinh hs1[3];
	for (int i = 0; i < 3; i++)
	{
		hs1[i]=nhap();
	}
	for (int i = 0; i < 3; i++)
	{
		hien(hs1[i]);
	}
	timChuoiHaNoi(hs1, 3);
}