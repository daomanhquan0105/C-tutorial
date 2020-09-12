#include <fstream>
#include<iostream>

using namespace std;

void docFile() {
	ifstream inFile("C:\\Data\\data.txt", ios::ate);//ios::ate

	char aChar;
	inFile.get(aChar);
	while (!inFile.eof())
	{
		cout << aChar;
		inFile.get(aChar);
	}
	inFile.close();
}
void docBanPhimGhiFile() {
	int stuId;
	string name;
	double gpa;
	ofstream outFile;
	outFile.open("C:\\Data\\Students.txt");
	if (!outFile.good())
		cout << "File could not be opened" << endl;
	else
	{
		cout << "Enter ID, name, and grade point average" <<
			endl;
		cout << "Enter Ctrl + Z to end" << endl;
		cin >> stuId >> name >> gpa;
		while (!cin.fail())
		{
			outFile << stuId << " " << name << " " << gpa << endl;
			cout << "Enter ID, name, and grade point average" << endl;
			cout << "Enter Ctrl + Z to end " << endl;
			cin >> stuId >> name >> gpa;
		}
	}
	outFile.close();
}
