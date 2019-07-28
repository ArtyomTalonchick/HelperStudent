//---------------------------------------------------------------------------

#include <windows.h>
#include <iostream>
#include <math.h>
#include <algorithm>
#include <vector.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>
#include <string>
using namespace std;

//---------------------------------------------------------------------------
//   Important note about DLL memory management when your DLL uses the
//   static version of the RunTime Library:
//
//   If your DLL exports any functions that pass String objects (or structs/
//   classes containing nested Strings) as parameter or function results,
//   you will need to add the library MEMMGR.LIB to both the DLL project and
//   any other projects that use the DLL.  You will also need to use MEMMGR.LIB
//   if any other projects which use the DLL will be performing new or delete
//   operations on any non-TObject-derived classes which are exported from the
//   DLL. Adding MEMMGR.LIB to your project will change the DLL and its calling
//   EXE's to use the BORLNDMM.DLL as their memory manager.  In these cases,
//   the file BORLNDMM.DLL should be deployed along with your DLL.
//
//   To avoid using BORLNDMM.DLL, pass string information using "char *" or
//   ShortString parameters.
//
//   If your DLL uses the dynamic version of the RTL, you do not need to
//   explicitly add MEMMGR.LIB as this will be done implicitly for you
//---------------------------------------------------------------------------

#pragma argsused
int WINAPI DllEntryPoint(HINSTANCE hinst, unsigned long reason, void* lpReserved)
{
	return 1;
}

extern "C" __declspec(dllexport) char* TableKeliForSum(int m)
{
	if(m <= 0) return "������� ������ ������ ���� ��������������";
	string str;
	int **a = new int*[m];
	for(int i = 0; i < m; i++)
		a[i] = new int[m];
	for(int i = 0; i < m; i++)
		for(int j = 0; j < m; j++)
			a[i][j] = (i+j)%m;
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < m; j++)
		{
			char temp[100];
			itoa(a[i][j], temp, 10);
			str += temp;
			str += '\t';
		}
		str += '\n';
	}
	str += '\n';
	char *p = new char[str.length()+1];
	for(int i = 0; i < str.length(); i++)
		p[i] = str[i];
	p[str.length()] = '\0';
	return p;
}

extern "C" __declspec(dllexport) char* TableKeliForMultiplication(int m)
{
	if(m <= 0) return "������� ������ ������ ���� ��������������";
	string str;
	int **a = new int*[m];
	for(int i = 0; i < m; i++)
		a[i] = new int[m];
	for(int i = 0; i < m; i++)
		for(int j = 0; j < m; j++)
			a[i][j] = (i*j)%m;
	for(int i = 0; i < m; i++)
	{
		for(int j = 0; j < m; j++)
		{
			char temp[100];
			itoa(a[i][j], temp, 10);
			str += temp;
			str += '\t';
		}
		str += '\n';
	}
	str += '\n';
	for(int i = 0; i < m; i++)
	for(int j = 0; j < m; j++)
	{
		if(a[i][j] == 1)
		{
			char temp[100];
			itoa(i, temp,10);
			str +=  temp;
			str += "(-1)=";
			itoa(j, temp, 10);
			str +=  temp;
			str += ' ';
		}
	}
	char *p = new char[str.length()+1];
	for(int i = 0; i < str.length(); i++)
		p[i] = str[i];
	p[str.length()] = '\0';
	return p;
}

typedef long long ll;
typedef pair<ll,ll> lll;
typedef pair<ll,int> lli;
typedef pair<int,int> ii;

#define EL printf("\n")
#define OK printf("OK")
#define pb push_back
#define mp make_pair
#define ep emplace_back
#define X  first
#define Y  second
#define fillchar(a,x) memset(a, x, sizeof(a))
#define FOR(i,l,r) for (int i=l;i<=r;i++)
#define FORD(i,r,l) for (int i=r;i>=l;i--)

const int base = 1e9;
typedef vector<int> BigInt;

void Set(BigInt &a) {
    while (a.size() > 1 && a.back() == 0) a.pop_back();
}

void Print(BigInt a) {
    Set(a);
    printf("%d", (a.size() == 0) ? 0 : a.back());
	FORD(i,a.size()-2,0) printf("%09d", a[i]); EL;
}



BigInt Integer(string s) {
    BigInt ans;
    if (s[0] == '-') return ans;
    if (s.size() == 0) {ans.pb(0); return ans;}
	while (s.size()%9 != 0) s += '0';
    for (int i=0;i<s.size();i+=9) {
		int v = 0;
		for (int j=i;j<i+9;j++) v = v*10+(s[j]-'0');
        ans.insert(ans.begin(),v);
    }
    Set(ans);
    return ans;
}

BigInt Integer(char c[]) {
    string s = "";
	FOR(i,0,strlen(c)-1) s += c[i];
    return Integer(s);
}

BigInt Integer(ll x) {
    string s = "";
	while (x > 0) s += char(x%10+'0') , x /= 10;
	return Integer(s);
}

BigInt Integer(int x) {
    return Integer((ll) x);
}




void operator >> (istream &in, BigInt &a) {
    string s;
	getline(cin, s);
    a = Integer(s);
}

void operator << (ostream &out, BigInt a) {
	Print(a);
}




bool operator < (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    if (a.size() != b.size()) return (a.size() < b.size());
    FORD(i,a.size()-1,0)
        if (a[i] != b[i]) return (a[i] < b[i]);
    return false;
}

bool operator > (BigInt a, BigInt b) {
    return (b < a);
}

bool operator == (BigInt a, BigInt b) {
    return (!(a < b) && !(b < a));
}

bool operator <= (BigInt a, BigInt b) {
    return (a < b || a == b);
}

bool operator >= (BigInt a, BigInt b) {
    return (b < a || b == a);
}

bool operator < (BigInt a, int b) {
    return (a < Integer(b));
}

bool operator > (BigInt a, int b) {
    return (a > Integer(b));
}

bool operator == (BigInt a, int b) {
    return (a == Integer(b));
}

bool operator >= (BigInt a, int b) {
    return (a >= Integer(b));
}

bool operator <= (BigInt a, int b) {
    return (a <= Integer(b));
}



BigInt max(BigInt a, BigInt b) {
    if (a > b) return a;
    return b;
}

BigInt min(BigInt a, BigInt b) {
    if (a < b) return a;
    return b;
}




BigInt operator + (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    BigInt ans;
    int carry = 0;
    FOR(i,0,max(a.size(), b.size())-1) {
        if (i < a.size()) carry += a[i];
        if (i < b.size()) carry += b[i];
        ans.pb(carry%base);
        carry /= base;
    }
    if (carry) ans.pb(carry);
    Set(ans);
    return ans;
}

BigInt operator + (BigInt a, int b) {
    return a + Integer(b);
}

BigInt operator ++ (BigInt &a) { // ++a
    a = a + 1;
    return a;
}

void operator += (BigInt &a, BigInt b) {
    a = a + b;
}

void operator += (BigInt &a, int b) {
    a = a + b;
}




BigInt operator - (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    BigInt ans;
    int carry = 0;
    FOR(i,0,a.size()-1) {
        carry += a[i] - (i < b.size() ? b[i] : 0);
        if (carry < 0) ans.pb(carry+base), carry = -1;
        else ans.pb(carry), carry = 0;
    }
    Set(ans);
    return ans;
}

BigInt operator - (BigInt a, int b) {
    return a - Integer(b);
}

void operator -- (BigInt &a) { // --a
    a = a - 1;
}

void operator -= (BigInt &a, BigInt b) {
    a = a + b;
}

void operator -= (BigInt &a, int b) {
    a = a - b;
}




BigInt operator * (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    BigInt ans;
    ans.assign(a.size()+b.size(), 0);
    FOR(i,0,a.size()-1) {
        ll carry = 0ll;
        for (int j=0;j<b.size() || carry > 0;j++) {
            ll s = ans[i+j] + carry + (ll)a[i]*(j<b.size()?(ll)b[j]:0ll);
            ans[i+j] = s%base;
            carry = s/base;
        }
    }
    Set(ans);
    return ans;
}

BigInt operator * (BigInt a, int b) {
    return a * Integer(b);
}

void operator *= (BigInt &a, BigInt b) {
    a = a * b;
}

void operator *= (BigInt &a, int b) {
    a = a * b;
}



BigInt operator / (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    if (b == Integer(0)) return Integer("-1");
    BigInt ans, cur;
    FORD(i,a.size()-1,0) {
        cur.insert(cur.begin(), a[i]);
        int x = 0, L = 0, R = base;
        while (L <= R) {
            int mid = (L+R)>>1;
            if (b*Integer(mid) > cur) {
                x = mid;
                R = mid-1;
            }
            else
                L = mid+1;
        }
        cur = cur - Integer(x-1)*b;
        ans.insert(ans.begin(),x-1);
    }
    Set(ans);
    return ans;
}

BigInt operator / (BigInt a, int b) {
    Set(a);
    BigInt ans;
    ll cur = 0ll;
    FORD(i,a.size()-1,0) {
        cur = (cur*(ll)base + (ll)a[i]);
        ans.insert(ans.begin(),cur/b);
        cur %= b;
    }
    Set(ans);
    return ans;
}

void operator /= (BigInt &a, BigInt b) {
    a = a / b;
}

void operator /= (BigInt &a, int b) {
    a = a / b;
}



BigInt operator % (BigInt a, BigInt b) {
    Set(a);
    Set(b);
    if (b == Integer(0)) return Integer("-1");
    BigInt ans;
    FORD(i,a.size()-1,0) {
        ans.insert(ans.begin(), a[i]);
        int x = 0, L = 0, R = base;
        while (L <= R) {
            int mid = (L+R)>>1;
            if (b*Integer(mid) > ans) {
                x = mid;
                R = mid-1;
            }
            else
                L = mid+1;
        }
        ans = ans - Integer(x-1)*b;
    }
    Set(ans);
    return ans;
}

int operator % (BigInt a, int b) {
    Set(a);
    if (b == 0) return -1;
    int ans = 0;
    FORD(i,a.size()-1,0)
        ans = (ans*(base%b) + a[i]%b)%b;
    return ans;
}

void operator %= (BigInt &a, BigInt b) {
    a = a % b;
}

void operator %= (BigInt &a, int b) {
    a = a % Integer(b);
}

extern "C" __declspec(dllexport) char* gcd(string s1,  string s2) {
		BigInt a = Integer(s1);
	BigInt b = Integer(s2);
	Set(a);
	Set(b);
	while (b > Integer(0)) {
		BigInt r = a%b;
		a = b;
		b = r;
	}
	Set(a);
	string str;
	str += a.back() + '0';
	FORD(i,a.size()-2,0) str += a[i] + '0';
	char *p = new char[str.length()+1];
	for(int i = 0; i < str.length(); i++)
		p[i] = str[i];
	p[str.length()] = '\0';
	return p;
}

BigInt gcd1(BigInt a, BigInt b) {

	Set(a);
	Set(b);
	while (b > Integer(0)) {
		BigInt r = a%b;
		a = b;
		b = r;
	}
	Set(a);
	return a;
}

BigInt lcm(BigInt a, BigInt b) {
	return (a*b/gcd1(a,b));
}


BigInt sqrt(BigInt a) {
    BigInt x0 = a, x1 = (a+1)/2;
    while (x1 < x0) {
        x0 = x1;
        x1 = (x1+a/x1)/2;
    }
    return x0;
}


BigInt pow(BigInt a, BigInt b) {
    if (b == Integer(0)) return Integer(1);
    BigInt tmp = pow(a, b/2);
    if (b%2 == 0) return tmp * tmp;
    return tmp * tmp * a;
}


BigInt pow(BigInt a, int b) {
    return pow(a,(Integer(b)));
}


int log(int n, BigInt a) {
	Set(a);
    int ans = 0;
    while (a > Integer(1)) {
        ans++;
        a /= n;
    }
    return ans;
}

//---------------------------------------------------------------------------

