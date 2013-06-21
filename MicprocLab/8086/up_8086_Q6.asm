; Q 6>	Given a 16bit number determine all its factors from
;		0 to 9
	SW		2000h
			[2000h]		=	00D2h		; A = 210
			[2002h]		=	2004h		; Address to Factors Array F[]
			.
	
	A
	1000h
		mov		cx, 0000h
		mov		bx, 0001h
		mov		di, [2002h]
		add		di, 0002h
		loop_label:
		mov		dx, 0000h
		mov		ax, [2000h]
		div		bx
		or		dx, dx
		jnz		not_factor
		inc		cx
		mov		[di], bx
		add		di, 0002h
		not_factor:
		inc		bx
		cmp		bx, 0009h
		jbe		loop_label
		mov		di, [2002h]
		mov		[di], cx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2004h						; ans = 0006h => F.length = 6
	SW		2006h						; ans = 0001h => 1
	SW		2008h						; ans = 0002h => 2
	SW		200Ah						; ans = 0003h => 3
	SW		200Ch						; ans = 0005h => 5
	SW		200Eh						; ans = 0006h => 6
	SW		2010h						; ans = 0007h => 7
	.

	
