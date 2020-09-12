#include<iostream>
#include <list>

//sử dung struct kiểm tra tam giác

struct Diem{
	double hoanhDo;
	double tungDo;
};
struct TamGiac
{
	Diem diem[3];
};

TamGiac nhap()
{
	TamGiac a;
	std::cout << "Nhap toa do diem 1" << std::endl;
	std::cin >> a.diem[0].hoanhDo >> a.diem[0].tungDo;
	std::cout << "Nhap toa do diem 2"<<std::endl;
	std::cin >> a.diem[1].hoanhDo >> a.diem[1].tungDo;
	std::cout << "Nhap toa do diem 3\n";
	std::cin >> a.diem[2].hoanhDo >> a.diem[2].tungDo;
	return a;
}
double TinhDoDai(Diem a, Diem b)
{
	double x = (a.hoanhDo-b.hoanhDo)*(a.hoanhDo-b.hoanhDo) + (a.tungDo -b.tungDo)*(a.tungDo - b.tungDo);
	return x;
}

bool KtraTamGiac(TamGiac x)
{
	double a = TinhDoDai(x.diem[0], x.diem[1]);
	double b = TinhDoDai(x.diem[0], x.diem[2]);
	double c = TinhDoDai(x.diem[1], x.diem[2]);

	if (a + b > c && a + c > b && b + c > a) return true;
	else return false;

}
bool laTamGiacVuong(double a, double b, double c)
{
	if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a) return true;
	else return false;
}
bool laTamGiacCan(double a, double b, double c)
{
	if (a == b || a == c || b == c) return true;
	else return false;
}
bool laTamGiacVuongCan(double a, double b, double c)
{
	if (laTamGiacCan(a, b, c) == true && laTamGiacVuong(a, b, c) == true) return true;
	else return false;
}
bool laTamGiacDeu(double a, double b, double c)
{
	if (a == b == c) return true;
	else return false;
}
std::string KtraLoaiTamGiac(TamGiac x)
{
	double a = TinhDoDai(x.diem[0], x.diem[1]);
	double b = TinhDoDai(x.diem[0], x.diem[2]);
	double c = TinhDoDai(x.diem[1], x.diem[2]);
	std::string str;
	if (laTamGiacVuong(a, b, c) == true) return "la tam giac vuong";
	else return "k p? la tam giac vuong";
}


void main()
{
	TamGiac x; x = nhap();
	std::string str = KtraLoaiTamGiac(x);
	std::cout << str << "\n";
	/*if (KtraTamGiac(x) == true) std::cout << "la tam gia";
	else std::cout << "khong phai la tam giac";*/
}