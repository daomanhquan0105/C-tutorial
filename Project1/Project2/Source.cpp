#include<iostream>

using namespace std;

class Employee {
private:
	int idNum;
	double salary;
public:
	Employee(int idNum, double salary);
	double operator+(Employee emp);
	friend double operator+(double raise, Employee emp);
};
Employee::Employee(int idNum, double salary) {
	this->idNum = idNum;
	this->salary = salary;
}
double Employee::operator+(Employee emp) {
	double total;
	total = this->salary + emp.salary;
	return total;
}
double operator+(double raise, Employee emp) {
	double newSalary = raise + emp.salary;
	return newSalary;
}
void main() {
	Employee e1(123, 400);
	Employee e2(234, 600);
	double sum = e1 + e2;
	cout << "sum=" << sum << "\n";
	double sum1 = e1.operator+(e2);
	cout << "sum1=" << sum1 << "\n";
	double newSalary = 100 + e1;
	cout << "newSalary=" << newSalary << "\n";
}
