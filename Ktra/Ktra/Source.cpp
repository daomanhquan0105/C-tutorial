#include "DienThoai.h"

void main()
{
	DienThoai dienthoai1;
	dienthoai1.NhapGT();
	int thanhtien=dienthoai1.TinhTien(10);
	cout << "Gia tien cua 10 chiec ";
	dienthoai1.XuatTTDt();
	cout << " la: " << thanhtien;
}
