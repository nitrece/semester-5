; Q 6>	Arrange a set of given numbers in ascending order
;		using bubble sort algorithm

	SU		4300h
			[4300h]		=	05h			; A.length = 5
			[4301h]		=	01h			; A[0] = 5
			[4302h]		=	02h			; A[1] = 3
			[4303h]		=	03h			; A[2] = 1
			[4304h]		=	04h			; A[3] = 4
			[4305h]		=	05h			; A[4] = 2
			.
	
	A
	ORG	4200h
		lxi		h, 4300h
		mov		c, M
		inx		h
		dcr		c
		mvi		d, 0
		loop_pri:
		mov		a, d
		cmp		c
		jp		loop_pri_end
		jz		loop_pri_end
		mov		e, c
		loop_sec:
		mov		a, e
		cmp		d
		jm		loop_sec_end
		jz		loop_sec_end
		push	h
		mov		a, l
		add		e
		mov		l, a
		mov		a, h
		aci		0
		mov		h, a
		mov		a, M
		dcx		h
		mov		b, M
		cmp		b
		jp		dont_swap
		jz		dont_swap
		mov		M, a
		inx		h
		mov		M, b
		dont_swap:
		pop		h
		dcr		e
		jmp		loop_sec
		loop_sec_end:
		inr		d
		jmp		loop_pri
		loop_pri_end:
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4300h
	[4300h]		->	05h			; A.length = 5
	[4301h]		->	01h			; A[0] = 1
	[4302h]		->	03h			; A[1] = 2
	[4303h]		->	05h			; A[2] = 3
	[4304h]		->	02h			; A[3] = 4
	[4305h]		->	04h			; A[4] = 5
	.


