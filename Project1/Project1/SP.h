#include <iostream>
using namespace std;
class SP {
private:
	double pt;
	double pa;
public:
	SP Cong(SP sp2) {
		SP sp;
		sp.pt = this->pt + sp2.pt;
		sp.pa = this->pa + sp2.pa;
	}
	void in() {
		cout << pt << "+ i*" << pa << "\n";
	}
};

