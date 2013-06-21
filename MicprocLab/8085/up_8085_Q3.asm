; Q 3>
;	a>	Exchange the content of two memory locations
	SU		4300h
			[4300h]		=	01h			; A = 1
			[4301h]		=	02h			; B = 2
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		inx		h
		mov		c, M
		mov		M, b
		dcx		h
		mov		M, c
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4300h
	[4300h]		->	02h			; A = 2
	[4301h]		->	01h			; B = 1
	.


	

;	b>	Add a set of 8bit numbers stored in an array
	SU		4300h
			[4300h]		=	03h			; A.length = 3
			[4301h]		=	01h			; A[0] = 0
			[4302h]		=	02h			; A[1] = 1
			[4303h]		=	03h			; A[2] = 2
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		b, M
		mvi		a, 0
		inx		h
		sum_loop:
		add		M
		inx		h
		dcr		b
		jnz		sum_loop
		mov		M, a
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4304h
	[4304h]		->	03h			; Sum = 3
	.


	

;	c>	Given an integer, determine if the number is +ve or -ve
	SU		4300h
			[4300h]		=	0FDh		; A = -3
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		a, M
		ori		0
		jz		is_zero
		jp		is_pos
		mvi		a, 0FFh
		jmp		finish
		is_zero:
		mvi		a, 00h
		jmp		finish
		is_pos:
		mvi		a, 01h
		finish:
		inx		h
		mov		M, a
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4301h
	[4301h]		->	0FFh		; sgn(A) = -1
	.

