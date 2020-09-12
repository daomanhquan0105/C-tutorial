#include<iostream>
#include<math.h>

using namespace std;

void vidu1() 
{
	int a;
	cout << "nhap a"; cin >> a;
	double b;
	cout << "nhap b: "; cin >> b;
	char c;
	cout << "nhap chuoi c: "; cin >> c;
}
void vidu2()
{
	int a;
	cout << "nhap a: "; cin >> a;
	int b;
	cout << "nhap b: "; cin >> b;
	cout << a << " + " << b << " = " << (a + b) << endl;
	cout << a << " - " << b << " = " << (a - b) << endl;
	cout << a << " * " << b << " = " << (a * b) << endl;
	cout << a << " / " << b << " = " << (a / b) << endl;
	cout << a << " % " << b << " = " << (a % b) << endl;
}
void vidu3()
{
	double a, b, c;
	cout << "nhap a,b,c: "; cin >> a >> b >> c;
	cout << sin( abs(pow(a, (b - c))) );
}

void vidu4()
{
	/*int a=10, b=15;
	printf("nhap gia tri cua a,b: %d   %d ", a, b);*/
	char x = 65;
	printf("%c", x);
	printf("%c", (x + 32));
}
void vidu6()
{
	int a = 10, b = 20, c = 30;
	int temp = a;
	a = b;
	b = c;
	c = temp;
	printf("gia tri moi cua a,b,c la:%d %d %d", a, b, c);
}
void vidu7()
{
	int a = 10,b=15;
	--a;
	++b;
	a -= b;
	b += a;
	//printf("%d", a);
	//printf("%d", b);
}

void vidu21(int a,int b,int c)
{
	if (a == 0)
	{
		printf("nghiem cua phuong trinh la: %f", (-c / b));
	}
	else
	{
		if (a != 0) 
		{
			double denta = pow(b, 2) - 4 * a * c;
			if (denta == 0)
				printf("phuong tring co 1 nghiem : %f", (-b / (2 * a) ) );
			else
			{
				double x1 = (-b - sqrt(denta)) / 2 * a;
				double x2 = (-b + sqrt(denta)) / 2 * a;
				printf("gia tri nghiem cua phuong trinh la: %f  %f", x1, x2);
			}
		}
	}
}

void vidu22(int a,int b,int c) 
{
	if(a>b)
	{
		if (a > c)
			printf("max=%d", a);
		else
		{
			printf("max=%d", c);
		}
		if (b < c)
			printf("min=%d", b);
		else
		{
			printf("min=%c", c);
		}
	}
	else
	{
		if (b > c)
			printf("max=%d", b);
		else
		{
			printf("max=%d", c);
		}
		if (a < c)
			printf(" min=%d", a);
		else
		{
			printf("min=%c", c);
		}
	}
}
void vidu23()
{
	int x=1;
	printf(" ");
	scanf_s("%d", &x);
	//int x=1;
	//scanf_s("%d", &x);
	switch (x)
	{
	case 1:
		printf("hnay la thu 2"); 
		break;
	case 2: 
		printf("hnay la thu 3");
		break;
	case 3: 
		printf("hnay la thu 4");
		break;
	case 4:
		printf("hnay la thu 5 ");
		break;
	default:
		printf("khong phai ngay trogn tuan");
		break;
	}
}
void vidu25()
{
	int a;
	scanf_s("%d", &a);
	if (0 < a < 100)
	{
		if (a % 3 == 0)
			printf("a chia het cho 3");
		if (a % 5 == 0)
			printf("\na chia het cho 5");
	}
	else
		printf("khong thao man dau ve");
}
void vidu35()
{
	int n;
	scanf_s("%d", &n);
	for (int i = 0; i < (n+4)/2; i++)
	{
		for(int j=0;j<2*n;j++)
		{
			if (i == 0 || j == 0||i==((n + 4)/2)-1||j==(2*n)-1)
			{
				printf("*");
			}
			else {
				printf(" ");
			}
		}
		printf("\n");
	}
}
void vidu36()
{
	int n,k=0;
	scanf_s("%d", &n);
	/*for (int i = 0; i < n; i++) {
		for (int j = 0; j < i; j++) {
			printf("* ");
		}
		printf("\n");
	}*/
	while(n>0)
	{
		for (int i = 0; i < n; i++)
		{
			printf(" ");
		}
		for(int j=1;j<k;j++)
		{
			printf("*");
		}
		n--;
		k+=2; 
		printf("\n");
	}
}
void vidu316()
{
	int n, k = 0;
	scanf_s("%d", &n);
	while (n > 0)
	{
		for (int i = 0; i < n; i++)
		{
			printf(" ");
		}
		for (int j = 1; j <= k; j++)
		{
			printf("%d", j);
		}
		for (int x = k+1; x>0 ; x--) 
		{
			printf("%d", x);
		}
		n--;
		k ++;
		printf("\n");
	}
}

void vidu3738()
{
	int a,cout=0;
	int sum = 0;
	scanf_s("%d", &a);
	while(a>0)
	{
		int x = a % 10;
		sum += x;
		printf("%d\n", x);
		cout++;
		a /= 10;
	}
	printf("tong cac chu so la: %d", sum);
	printf("\nso ban dau co %d chu so", cout);
}
void vidu39()
{
	int a, b;
	scanf_s("%d\%d", &a, &b);
	int n = a + b;
		for (int i = n; i > 0; i--) 
		{
			if (a % i == 0 && b % i == 0) 
			{
				printf("uoc chung lon nhat la: %d", i);
				break;
			}
		}
}
void vidu310()
{
	int a, b;
	scanf_s("%d\n%d", &a, &b);
	int n = a * b;
	for (int i = a; i <= n; i++)
	{
		if (i % a == 0 && i % b == 0 && i%10==0) {
			printf("boi chung nho nhat la: %d", i);
			break;
		}
	}
}
void vidu312()
{
	int a=13131,b=0;
	for (int i = a; i != 0;i= i / 10)
	{
		b =b*10+ i % 10;
	}
	if (b == a) 
	{
		printf("%d la so doi xung", a);
	}
}
void vidu313()
{
	int a = 6,sum=0;
	for (int i = 1; i < a; i++)
	{
		if (a % i == 0) 
		{
			sum += i;
		}
	}
	if (sum == a) {
		printf("%d la so hanh phuc", a);
	}
}

void main()
{
	vidu316();
}