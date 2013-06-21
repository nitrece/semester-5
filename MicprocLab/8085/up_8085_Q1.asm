; Q 1>	Addition of two BCD numbers of 16 bit width
	SU		4300h
			[4300h]		=	99h			; A = 999 in BCD
			[4301h]		=	09h			;
			[4302h]		=	01h			; B = 1 in BCD
			[4303h]		=	00h			;
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		inx		h
		mov		c, M
		inx		h
		mov		a, b
		add		M
		mov		b, a
		mov		a, c
		aci		0
		inx		h
		add		M
		mov		c, a
		mov		a, b
		daa
		mov		b, a
		mov		a, c
		aci		0
		daa
		mov		c, a
		inx		h
		mov		M, b
		inx		h
		mov		M, c
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4304h
	[4304h]		->	00h			; ans = 1000h (1000 in BCD)
	[4305h]		->	10h			;
	.
	
	
	

		