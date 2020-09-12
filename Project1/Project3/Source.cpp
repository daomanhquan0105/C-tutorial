#include<iostream>

using namespace std;

class Sale
{
public:
	Sale(int,double);
	friend ostream& operator<<(ostream&, Sale s);

private:
	int idNum;
	double saleAmount;
};

Sale::Sale(int idNum,double saleAmount)
{
	this->idNum = idNum;
	this->saleAmount = saleAmount;
}
ostream& operator<<(ostream& out, Sale s)
{
	out << "idNum=" << s.idNum << "  sale Amount=" << s.saleAmount<<"\n";
	return out;
}
void main()
{
	Sale s(13, 19.9);
	cout<<s;
}