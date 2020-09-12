#include<stdio.h>
#include <conio.h>
#include<string.h>
void main()
{
	char a[] = "abcdefadkfajf";
	int n = 13;
	int gio[256] = { 0 };
	//Sap xep gio
	for (int i = 0; i < n; i++)
	{
		gio[a[i]]++;
	}
	//Do cam ra de kiem tra
	for (int i = 0; i < 256; i++)
	{
		if (gio[i] > 0)
		{
			for (int j = 0; j < gio[i]; j++)
			{
				printf("%c ", i);
			}
		}
	}
	_getch();
}