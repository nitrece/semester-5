; Q 2>
;	a>	Subtraction of 2 32bit BCD numbers
	SW		2000h
			[2000h]		=	614Eh		; A = 12345678
			[2002h]		=	00BCh		; 
			[2004h]		=	162Eh		; B = 5678
			[2006h]		=	0000h		; 
			[2008h]		=	(ans)		; C = (A - B)
			[200Ah]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		sub		ax, [2004h]
		sbb		bx, [2006h]
		mov		[2008h], ax
		mov		[200Ah], bx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2008h						; ans = 4B20h
	SW		200Ah						; ans = 00BCh
	.									; => 12340000

	
	
;	b>	Multiplication of 2 16bit numbers
	SW		2000h
			[2000h]		=	03E8h		; A = 1000
			[2002h]		=	000Ah		; B = 10
			[2004h]		=	(ans)		; C = (A * B)
			[2006h]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		mul		bx
		mov		[2004h], ax
		mov		[2006h], dx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2004h						; ans = 2710h
	SW		2006h						; ans = 0000h
	.									; => 10000

	
	
;	c>	Addition of 8bit signed and unsigned numbers using a loop
;		with the array starting at some specified memory location
	SB		2002h					; Unsigned Array A[]
			[2002h]		=	05h		; A.length = 5
			[2003h]		=	00h		; 
			[2004h]		=	0Ah		; A[0] = 10
			[2005h]		=	0Ah		; A[1] = 10
			[2006h]		=	0Ah		; A[2] = 10
			[2007h]		=	0Ah		; A[3] = 10
			[2008h]		=	0Ch		; A[4] = 12
			[2009h]		=	(ans)	; C = sum(A)
			.
	SB		200Ah					; Signed Array B[]
			[200Ah]		=	004h	; B.length = 4
			[200Bh]		=	000h	; 
			[200Ch]		=	00Ah	; A[0] = 10
			[200Dh]		=	0F7h	; A[1] = -9
			[200Eh]		=	00Ah	; A[2] = 10
			[200Fh]		=	0F7h	; A[3] = -9
			[2010h]		=	(ans)	; C = sum(A)
			.
	
	A
	1000h
		mov		al, 00h
		mov		si, [2000h]
		mov		cx, [si]
		add		si, 0002h
		loop_label:					; Note the address here
		add		al, [si]
		inc		si
		dec		cx
		jnz		loop_label			; Use that address here
		mov		[si], al
		hlt
		.
	
	; Case-1 Unsigned Numbers
	SW		2000h
			[2000h]		=	2002h	; Pointer to Unsigned Array A[]
	.
	GO		1000h
	INT						;(try '.' here)
	
	SB		2009h						; ans = 34h
	.									; => 52
	
	; Case-2 Signed Numbers
	SW		2000h
			[2000h]		=	200Ah	; Pointer to Signed Array B[]
	.
	GO		1000h
	INT						;(try '.' here)
	
	SB		2010h						; ans = 02h
	.									; => 2
		
	