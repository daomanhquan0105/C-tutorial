#include<stdio.h>

struct SanPham
{
	char tenSP[100];
	int idSP;
	int SoLuongSP;
	int DonGia;
};
struct loaiSP
{
	int idLoaiSP;
	char TenLoai[50];
	int soLuongLoaiSP;
	SanPham DSSanPham[1000];
};
loaiSP nhapLoaiSP(loaiSP loai)
{
	char c[1];
	printf("nhap ten san pham: ");
	gets_s(loai.TenLoai);
	printf("nhap id cua loai san pham: ");
	scanf_s("%d", &loai.idLoaiSP);
	gets_s(c);
	printf("nhap so luong loai san pham: ");
	scanf_s("%d", &loai.soLuongLoaiSP);
	gets_s(c);
	for (int i = 0; i < loai.soLuongLoaiSP; i++)
	{
		printf("nhap ten san pham thu %d: ", (i + 1));
		gets_s(loai.DSSanPham[i].tenSP);
		printf("nhap ma id cua san pham thu %d: ", (i + 1));
		scanf_s("%d", &loai.DSSanPham[i].idSP);
		gets_s(c);
		printf("nhap so luong san pham thu: %d", (i + 1));
		scanf_s("%d", &loai.DSSanPham[i].SoLuongSP);
		gets_s(c);
		printf("nhap don gia san pham thu: %d", (i + 1));
		scanf_s("%d", &loai.DSSanPham[i].DonGia);
		gets_s(c);
		printf("----------------------------------------------");
	}
	return loai;
}
void hienLoaiSP(loaiSP loai)
{
	printf("\n ten san pham: %s",loai.TenLoai);
	printf("\n id cua loai san pham: %d", loai.idLoaiSP);
	printf("\n so luong loai san pham: %d", loai.soLuongLoaiSP);
	for (int i = 0; i < loai.soLuongLoaiSP; i++)
	{
		printf("\n ten san pham thu %d: ", (i + 1),loai.DSSanPham[i].tenSP);
		printf("\n ma id san pham thu %d: %d", (i + 1), loai.DSSanPham[i].idSP);
		printf("\n so luong san pham thu %d: %d", (i + 1),loai.DSSanPham[i].SoLuongSP);
		printf("\n don gia san pham thu %d: %d", (i + 1),loai.DSSanPham[i].DonGia);
		printf("-----------------------------------------------------------------------------");
	}
}
loaiSP nhapDSLoaiSP(loaiSP loai[], int soloai)
{
	for (int i = 0; i < soloai; i++)
	{
		printf("\n=================================================");
		printf("\n nhap thong tin loai san pham thu %d: ", (i + 1));
		nhapLoaiSP(loai[i]);
	}
}
void hienDSLoaiSP(loaiSP loai[], int soloai)
{
	for (int i = 0; i < soloai; i++)
	{
		printf("\n=================================================");
		printf("\nthong tin loai san pham thu %d: ", (i + 1));
		hienLoaiSP(loai[i]);
	}
}
void tinhTienTungLoai(loaiSP loai[], int soloai)
{
	int sum = 0;
	for (int i = 0; i < soloai; i++)
	{
		for (int j = 0; j < loai[i].soLuongLoaiSP; j++)
		{
			sum += loai[i].DSSanPham[j].DonGia;
		}
		printf("\n tong tien loai san pham thu %d: %d", (i + 1), sum);
		sum = 0;
	}
}

void main()
{
	loaiSP loai1[10];
	int n = 3;
	nhapDSLoaiSP(loai1, n);
	hienDSLoaiSP(loai1, n);
	tinhTienTungLoai(loai1, n);
}