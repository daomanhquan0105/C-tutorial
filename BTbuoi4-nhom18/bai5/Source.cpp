#include<stdio.h>

struct sophuc
{
	int phanthuc;
	int phanao;
};
sophuc nhap()
{
	sophuc sp;
	printf("\nnhap phan thuc: ");
	scanf_s("%d", &sp.phanthuc);
	printf("\nnhap phan ao: ");
	scanf_s("%d", &sp.phanao);
	return sp;
}
void hien(sophuc sp)
{
	printf("%d+%d*i\t", sp.phanthuc, sp.phanao);
}
void main()
{
	sophuc a[3];
	for (int i = 0; i < 3; i++)
	{
		a[i] = nhap();
	}
	printf("cac so phuc co phan ao >100: \n");
	for (int i = 0; i < 3; i++)
	{
		if (a[i].phanao >= 100)
		{
			hien(a[i]);
		}
	}
}