; Q 4>
;	a>	Multiply two 8bit numbers using repetitive addition
	SU		4300h
			[4300h]		=	02h			; A = 2
			[4301h]		=	04h			; B = 4
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		inx		h
		mov		c, M
		inx		h
		mvi		a, 0
		add_loop:
		add		c
		dcr		b
		jnz		add_loop
		mov		M, a
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4302h
	[4302h]		->	08h			; A * B = 8
	.


	

;	b>	Multiply two 8bit numbers using shift and add
	SU		4300h
			[4300h]		=	02h			; A = 2
			[4301h]		=	04h			; B = 4
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		inx		h
		mov		c, M
		inx		h
		mvi		d, 0
		add_loop:
		mov		a, c
		ani		1
		jz		dont_add
		mov		a, d
		add		b
		mov		d, a
		dont_add:
		mov		a, b
		adi		0
		ral
		mov		b, a
		mov		a, c
		rar
		ori		0
		mov		c, a
		jnz		add_loop
		mov		M, d
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4302h
	[4302h]		->	08h			; A * B = 8
	.

