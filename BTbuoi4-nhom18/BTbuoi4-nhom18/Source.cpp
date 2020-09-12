#include<stdio.h>
#include<math.h>

struct sophuc
{
	int phanthuc;
	int phanao;
};
sophuc gan(int a,int b)
{
	sophuc z;
	z.phanthuc = a;
	z.phanao = b;
	return z;
}
void hien(sophuc z)
{
	printf("%d + %d*i", z.phanthuc, z.phanao);
	
}
void main()
{
	
}