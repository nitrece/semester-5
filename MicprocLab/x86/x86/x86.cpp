// x86.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


void add_16bit_BCD()
{
	short	a, b, sum;

	printf("Enter A: ");
	scanf_s("%x", &a);
	printf("Enter B: ");
	scanf_s("%x", &b);

	__asm
	{
		pusha;
		mov		ax, a;
		mov		bx, b;
		add		ax, bx;
		aaa;
		mov		sum, ax;
		popa;
	}

	printf("Sum = %x\n", sum);
}

void add_32bit_DEC()
{
	unsigned short	a, b, sum;

	printf("Enter A: ");
	scanf_s("%x", &a);
	printf("Enter B: ");
	scanf_s("%x", &b);

	__asm
	{
		pusha;
		mov		ax, a;
		mov		bx, b;
		add		ax, bx;
		aaa;
		mov		sum, ax;
		popa;
	}

	printf("Sum = %x\n", sum);
}

void Bubble_Sort_Ascending()
{
	short	i, j, k, t;
	short	n = 5;
	short	a[] = {5, 4, 3, 2, 1};
	
	k = n - 1;
	for(i=0; i<k; i++)
	{
		for(j=k; j>i; j--)
		{
			if(a[j] < a[j-1])
			{
				t = a[j-1];
				a[j-1] = a[j];
				a[j] = t;
			}
		}
	}

	for(i=0; i<n; i++)
		printf("%d\n", a[i]);
}

void Divide_16_8()
{
	short	a = 13, b = 4;
	short	c, ak, q, qk, r;

	c = b; qk = 1;
	while(c <= a)
	{
		c <<= 1;
		qk <<= 1;
	}

	ak = a; q = 0;
	do
	{
		c >>= 1;
		qk >>= 1;
		if(c <= ak)
		{
			ak -= c;
			q |= qk;
		}
	}while(qk > 1);
	r = ak;

	printf("%d / %d = %d rem %d\n", a, b, q, r);
}

int _tmain(int argc, _TCHAR* argv[])
{
	char	c;

	Divide_16_8();
	scanf_s("%c", &c, &c);
	return(0);
}
