#include<stdio.h>
#include<string.h>
#include<stdlib.h>
int NhapMang(int a[][100], int n, int m);
int TinhTong(int N);
int KiemtraChanle(int N);
double Doicho(int a, int b);
int KiemTraSoChinhPhuong(int a);
double TinhDienTich(int a, int b);
int TinhTongSoLe(int a, int b);
int TimMinMax(int* a, int n);
int TimMin(int a, int b,int c);
int XuatMang(int* a, int n);
int NhapVaKtraChanLe();
char TimChuoiMin(char* a,int N);
char XuatChuoi(char *a);
int TimMin(int dem = 0);
int KiemTraAmDuong();
int TinhGiaiThua(int N);
int NhapMang();//loi
int xuatMang(int* a,int n);
char doiChuThuongThanhHoadauchuoi(char a[]);
int randomChan(int N);
int demSoAmChuoi(char* a);
int demSoAmMang(int* a);
int KtraChuoiSo(char a[]);
void giaiPTBac2(int a, int b, int c);
double nhapMang(double a[50][60], int n, int m);
double sum(int* a,int N);
int ktraSoNguyenTo(int N);
int swap(int a, int b);
int timMu3(int n);
int ktraTamGiacDeu(int a, int b, int c);
int xuatHienMax(int* a, int n);
//B32;
int timUoc(int a, int b, int c);
int timMin(int* a, int N);
int KtraChanLe(int N);
float xuat(int N);
int timMax(int a, int b, int c);
int xuatMang(int* a, int N);
int ktraSNT(int N);
char timChuoiMax(char s[], int N);
int ktraSoTonTai(int* a, int N);
int tronVaSapXepMang(int* a, int N, int* b, int m);
int nhapMang(int a[100][100], int n, int m);
double tinhTong(int N);
int KtraSoCP(int N);
int tinhDientichHCN(int a, int b);
int tinhTongSole(int a, int b);
int timMinMax(int* a, int n);
int timMax(int so, int n);
int ktraChan(int N);
int catKyTuTrangDauChuoi(char* a, int N);
int kiemTraFibo(int a);
int tinhTrungBinhCong(int a[][100],int n,int m);
int chuyenNhiPhan(int n);
double tinhTong(int *a,int n);
double timMinMax(double so, int n);
double xuat(double so,int N);
double tinhLai(int tiengui, int sothanggui, int i);
int soSanhDodai(int* a, int n, int* b, int m);
int tronVaoMang1(int* a, int n, int* b, int m);
int chuyenchuoisangso(char* a);
int timUCLN(int a, int b);
double inViTriMin(double* a, int n);
int demKyTuXuatHien(char* a);
int tinhTrungBinhCong(int N);
int doiSangHeThapLuc(int n);
char inchuoi(char s[]);
//char timChuoiMin(char s[], int N);
int demMax(int *so, int n);
int ktraSoTonTaiTrongKhoang(int N);
double tinhTienDien(double kw);
int tachMang(int* a, int n, int* chan, int* le);
int tinhTongGiaiThua(int* a, int N);
double ngichDao(double N);
int NhapvaInMang(int a[][100], int n);
int demKyTuHoa(char* s);
int tinhKichThuocByte(int N);
int timUCLN(int a, int b)
{
	if (a == 0 || b == 0) return (a + b);
	for (int i = (a + b) / 2; i > 1; i--)
	{
		if (a % i == 0 && b % i == 0)
		{
			return i;
			break;
		}
	}
}
//void timUCLNMang(int* a, int n)
//{
//	int x = timUCLN(a[0], a[1]);
//	for (int i = 2; i < n; i++)
//	{
//		x = timUCLN(x, a[i]);
//	}
//	printf("%d ", x);
//}
//void main()
//{
//	int a[] = { 5,2,3,4,5,7,6,89,13,14,11,53,45,77,89 };
//	int n = 15;
//	timDieuKienMang(a, n);
//}
void Xuat(int* a, int n)
{
	for (int i = 0; i < n; i++)
		printf("%d\t", a[i]);
}
void xoaPhanTuTrung(int* a, int n)
{
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (a[i] == a[j])
				a[j] = 0;
		}
	}
	
	Xuat(a, n);
	printf("\n\n\n");
}

void main()
{
	/*double a[] = { 2,2,2,3,4,3,3,7,5,6 };
	int c = timDieuKienMang(a,10);
	printf("%d\n", c);
	if (c == 1) printf("mang thoa man dieu kien");
	else printf("mang k thoa man dieu kien");*/
	/*int a[] = { 9,2,3,4,5,7,6,81,13,14,11,53,45,77,89 };
	int n = 15;*/
	int a[] = { 1,2,3,4,5,2,3,4,5,6,3,4,8,9,10 };
	int n = 15; int m = 5;
	Xuat(a, n);
	printf("\n");
	xoaPhanTuTrung(a, n);
}