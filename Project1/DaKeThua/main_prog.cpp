class A {
public:
	int a;
};
class B :public A {
public:
	int b;
};
class C :public A {
public:
	int c;
};
class D :public B, public C {
public:
	int d;
};
void main() {
	D h;
	h.d = 1;
	h.b = 2;
	h.c = 3;
	h.a = 4;
}
