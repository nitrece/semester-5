; Q 4>
;	a>	To store the elements of a given array in 2 separate arrays
;		comprising of even and odd elements
	SW		2000h
			[2000h]		=	2006h		; Address of source array A[]
			[2002h]		=	2014h		; Address to even array E[]
			[2004h]		=	2024h		; Address to odd array O[]
			[2006h]		=	0006h		; A.length = 6
			[2008h]		=	0001h		; A[0] = 1
			[200Ah]		=	0002h		; A[1] = 2
			[200Ch]		=	0003h		; A[2] = 3
			[200Eh]		=	0004h		; A[3] = 4
			[2010h]		=	0005h		; A[4] = 5
			[2012h]		=	0006h		; A[5] = 6
			.
	
	A
	1000h
		mov		bx, [2000h]
		mov		si, [2002h]
		mov		di, [2004h]
		mov		ax, [bx]
		push	ax
		mov		bp, sp
		add		bx, 0002h
		add		si, 0002h
		add		di, 0002h
		mov		cx, 0000h
		mov		dx, 0000h
		loop_label:
		mov		ax, [bx]
		test	ax, 0001h
		jnz		odd_num
		mov		[si], ax
		add		si, 0002h
		inc		cx
		jmp		loop_comm
		odd_num:
		mov		[di], ax
		add		di, 0002h
		inc		dx
		loop_comm:
		add		bx, 0002h
		dec		[bp]
		jnz		loop_label
		pop		ax
		mov		[2014h], cx
		mov		[2024h], dx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2014h						; ans = 0003h => E.length = 3
	SW		2016h						; ans = 0002h => E[0] = 2
	SW		2018h						; ans = 0004h => E[1] = 4
	SW		201Ah						; ans = 0006h => E[2] = 6
	SW		2024h						; ans = 0003h => O.length = 3
	SW		2026h						; ans = 0001h => O[0] = 1
	SW		2028h						; ans = 0003h => O[1] = 3
	SW		202Ah						; ans = 0005h => O[2] = 5
	.

	
	
;	b>	To move the contents from a block in a memory location to a
;		different memory location using stack
	SW		2000h
			[2000h]		=	2006h		; Source Block Address SRC
			[2002h]		=	2010h		; Destination Block Address DST
			[2004h]		=	000Ah		; Transfer Size SZ = 10
			[2006h]		=	0001h		; 00h, 01h
			[2008h]		=	0002h		; 00h, 02h
			[200Ah]		=	0003h		; 00h, 03h
			[200Ch]		=	0004h		; 00h, 04h
			[200Eh]		=	0005h		; 00h, 05h
			.
	
	A
	1000h
		mov		si, [2000h]
		mov		di, [2002h]
		mov		cx, [2004h]
		add		di, cx
		dec		di
		mov		ax, 0000h
		loop_label1:
		mov		al, [si]
		push	ax
		inc		si
		dec		cx
		jnz		loop_label1
		mov		cx, [2004h]
		loop_label2:
		pop		ax
		mov		[di], al
		dec		di
		dec		cx
		jnz		loop_label2
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2010h						; ans = 0001h
	SW		2012h						; ans = 0002h
	SW		2014h						; ans = 0003h
	SW		2016h						; ans = 0004h
	SW		2018h						; ans = 0005h
		
	