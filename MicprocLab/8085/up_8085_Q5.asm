; Q 5>
;	a>	Split a given array of 8bit numbers into two different
;		arrays containing odd and even numbers
	SU		4300h
			[4300h]		=	10h			; addr. of Odd Array
			[4301h]		=	43h			;
			[4302h]		=	20h			; addr. of Even Array
			[4303h]		=	43h			;
			[4304h]		=	05h			; A.length = 5
			[4305h]		=	01h			; A[0] = 1
			[4306h]		=	02h			; A[1] = 2
			[4307h]		=	03h			; A[2] = 3
			[4308h]		=	04h			; A[3] = 4
			[4309h]		=	05h			; A[4] = 5
			.
	
	A
	ORG	4200h
		lda		4304h
		mov		b, a
		push	b
		lhld	4300h
		push	h
		pop		b
		lhld	4302h
		push	h
		pop		d
		lxi		h, 4305h
		main_loop:
		mov		a, M
		ani		1
		jz		is_even
		mov		a, M
		stax	b
		inx		b
		jmp		is_common
		is_even:
		mov		a, M
		stax	d
		inx		d
		is_common:
		inx		h
		lda		4304h
		dcr		a
		sta		4304h
		jnz		main_loop
		pop		b
		mov		a, b
		sta		4304h
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4310h
	[4310h]		->	01h			; Odd[0] = 1
	[4311h]		->	03h			; Odd[1] = 3
	[4312h]		->	05h			; Odd[2] = 5
	SU		4320h
	[4320h]		->	02h			; Even[0] = 2
	[4321h]		->	04h			; Even[1] = 4
	.


	

;	b>	Split a given array of 8bit numbers into two different
;		arrays containing odd and even elements
	SU		4300h
			[4300h]		=	10h			; addr. of Odd Array
			[4301h]		=	43h			;
			[4302h]		=	20h			; addr. of Even Array
			[4303h]		=	43h			;
			[4304h]		=	05h			; A.length = 5
			[4305h]		=	02h			; A[0] = 2
			[4306h]		=	04h			; A[1] = 4
			[4307h]		=	06h			; A[2] = 6
			[4308h]		=	08h			; A[3] = 8
			[4309h]		=	0Ah			; A[4] = 10
			.
	
	A
	ORG	4200h
		lda		4304h
		mov		b, a
		push	b
		lhld	4300h
		push	h
		pop		b
		lhld	4302h
		push	h
		pop		d
		lxi		h, 4305h
		main_loop:
		mov		a, M
		stax	b
		inx		b
		inx		h
		lda		4304h
		dcr		a
		sta		4304h
		jz		main_end
		mov		a, M
		stax	d
		inx		d
		inx		h
		lda		4304h
		dcr		a
		sta		4304h
		jnz		main_loop
		main_end:
		pop		b
		mov		a, b
		sta		4304h
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4310h
	[4310h]		->	02h			; Odd[0] = 2
	[4311h]		->	06h			; Odd[1] = 6
	[4312h]		->	0Ah			; Odd[2] = 10
	SU		4320h
	[4320h]		->	04h			; Even[0] = 4
	[4321h]		->	08h			; Even[1] = 8
	.


	

;	c>	Move the content of a block of memory to another
;		memory location using stack pointer
	SU		4300h
			[4300h]		=	10h			; addr. of Dest Block
			[4301h]		=	43h			;
			[4302h]		=	05h			; Src.length = 5
			[4303h]		=	02h			; Src[0] = 1
			[4304h]		=	04h			; Src[1] = 2
			[4305h]		=	06h			; Src[2] = 3
			[4306h]		=	08h			; Src[3] = 4
			[4307h]		=	0Ah			; Src[4] = 5
			.
	
	A
	ORG	4200h
		lhld	4300h
		lda		4302h
		add		l
		mov		l, a
		mov		a, h
		aci		0
		mov		h, a
		sphl
		lxi		h, 4302h
		mov		c, M
		mov		a, c
		add		l
		mov		l, a
		mov		a, h
		aci		0
		mov		h, a
		move_loop:
		mov		b, M
		dcx		h
		push	b
		inx		sp
		dcr		c
		jnz		move_loop
		hlt
		.
			
	G		4200h
	INT									; (try '.' here)
	
	SU		4310h
	[4310h]		->	01h			; Dest[0] = 1
	[4311h]		->	02h			; Dest[1] = 2
	[4312h]		->	03h			; Dest[2] = 3
	[4313h]		->	04h			; Dest[0] = 4
	[4314h]		->	05h			; Dest[1] = 5
	.

