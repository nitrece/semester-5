; Q 7>	Multiplication of 2 32bit signed numbers
	SW		2000h
			[2000h]		=	05EE0h		; A = -500000
			[2002h]		=	0FFF8h		; 
			[2004h]		=	04240h		; B = 1000000
			[2006h]		=	0000Fh		; 
			[2008h]		=	(ans)		; C = (A * B)
			[200Ah]		=	(ans)		;
			[200Ch]		=	(ans)		;
			[200Eh]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, 0000h
		mov		ax, [2000h]
		mov		bx, [2004h]
		imul	bx
		mov		[2008h], ax
		mov		[200Ah], dx
		mov		cl, 08h
		sar		dx, cl
		mov		dl, dh
		mov		[200Ch], dx
		mov		[200Eh], dx
		mov		ax, [2000h]
		mov		bx, [2006h]
		imul	bx
		add		[200Ah], ax
		adc		[200Ch], dx
		sar		dx, cl
		mov		dl, dh
		adc		[200Eh], dx
		mov		ax, [2002h]
		mov		bx, [2004h]
		imul	bx
		add		[200Ah], ax
		adc		[200Ch], dx
		sar		dx, cl
		mov		dl, dh
		adc		[200Eh], dx
		mov		ax, [2002h]
		mov		bx, [2006h]
		imul	bx
		add		[200Ch], ax
		adc		[200Eh], dx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2008h						; ans = 07800h
	SW		200Ah						; ans = 095ADh
	SW		200Ch						; ans = 0FF8Bh
	SW		200Eh						; ans = 0FFFFh
	.									; => -500000000000

	
