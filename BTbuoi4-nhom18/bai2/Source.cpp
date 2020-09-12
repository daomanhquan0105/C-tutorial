#include<stdio.h>

struct sach
{
	char tieude[50];
	char tacgia[50];
	int giaban;
	char noidung[1000];
};

sach nhap()
{
	char c[2];
	sach s;
	printf("Nhap tieu de: ");
	gets_s(s.tieude);
	printf("\nNhap ten tac gia:");
	gets_s(s.tacgia);
	printf("\nNhap gia ban: ");
	scanf_s("%d", &s.giaban);//sau khi dung scanf thi ham gets ben duoi se bij an mat;
	gets_s(c);
	printf("\nNhap noi dung chinh: ");
	gets_s(s.noidung);
	return s;
}
void hien(sach z)
{
	printf("tieu de la: %s \n tac gia: %s \n gia ban: %d \n noi dung chinh: %s\n",
		z.tieude, z.tacgia, z.giaban, z.noidung);
}
void main()
{
	sach s1;
	s1 = nhap();
	hien(s1);
}