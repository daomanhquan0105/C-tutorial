#include<iostream>

using namespace std;

class DienThoai {
private:
	string maDienThoai;
	string loaiDienThoai;
	int donGia;
	
public :
	DienThoai();
	DienThoai(string MaDT, string LoaiDT, int DonGia);
	void LayVaDatGT(string MaDT, string LoaiDT, int DonGia)
	{
		this->maDienThoai = MaDT;
		this->loaiDienThoai = LoaiDT;
		this->donGia = DonGia;
	}
	void NhapGT()
	{
		cout << "Nhap ma dien thoai:";
		cin >> this->maDienThoai;
		cout << "Nhap loai dien thoai:";
		cin >> this->loaiDienThoai;
		cout << "Nhap gia tien dien thoai:";
		cin >> this->donGia;
	}
	void XuatTTDt()
	{
		cout << maDienThoai << " thuoc loai " << loaiDienThoai << " co don gia la:" << donGia << endl;

	}
	int TinhTien(int SoDienThoai)
	{
		return this->donGia * SoDienThoai;
	}
};
