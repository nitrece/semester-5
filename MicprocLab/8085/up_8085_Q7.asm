; Q 7>	Divide a 16bit number by an 8bit number

	SU		4300h
			[4300h]		=	10h			; A = 16
			[4301h]		=	00h			;
			[4302h]		=	03h			; B = 3
			.
	
	A
	ORG	4200h
		// [4300h]	=	a0
		// [4301h]	=	a1
		// [4302h]	=	b
		// [4303h]	=	q0
		// [4304h]	=	q1
		// [4304h]	=	r
		// [4305h]	=	qk0
		// [4306h]	=	qk1
		de = ak;
	
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
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4303h
	[4303h]		->	05h			; Quotient = 5
	[4304h]		->	00h			;
	[4305h]		->	01h			; Remainder = 1
	.


