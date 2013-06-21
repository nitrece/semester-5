; Q 2>	Add two 32 bit signed numbers
	SU		4300h
			[4300h]		=	4Eh			; A = 12345678
			[4301h]		=	61h			;
			[4302h]		=	0BCh		;
			[4303h]		=	00h			;
			[4304h]		=	0D2h		; B = -5678
			[4305h]		=	0E9h		;
			[4306h]		=	0FFh		;
			[4307h]		=	0FFh		;
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		inx		h
		mov		c, M
		inx		h
		mov		d, M
		inx		h
		mov		e, M
		inx		h
		mov		a, b
		add		M
		mov		b, a
		mov		a, c
		aci		0
		mov		c, a
		mov		a, d
		aci		0
		mov		d, a
		mov		a, e
		aci		0
		mov		e, a
		inx		h
		mov		a, c
		add		M
		mov		c, a
		mov		a, d
		aci		0
		mov		d, a
		mov		a, e
		aci		0
		mov		e, a
		inx		h
		mov		a, d
		add		M
		mov		d, a
		mov		a, e
		aci		0
		inx		h
		add		M
		mov		e, a
		inx		h
		mov		M, b
		inx		h
		mov		M, c
		inx		h
		mov		M, d
		inx		h
		mov		M, e
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4308h
	[4308h]		->	20h			; ans = 12340000
	[4309h]		->	4Bh			;
	[430Ah]		->	0BCh		;
	[430Bh]		->	00h			;
	.

