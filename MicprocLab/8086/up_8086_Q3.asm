; Q 3>
;	a>	Multiplication of 2 32bit numbers
	SW		2000h
			[2000h]		=	0A120h		; A = 500000
			[2002h]		=	00007h		; 
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
		mov		[2008h], ax
		mov		[200Ah], ax
		mov		[200Ch], ax
		mov		[200Eh], ax
		mov		ax, [2000h]
		mov		bx, [2004h]
		mul		bx
		mov		[2008h], ax
		mov		[200Ah], dx
		mov		ax, [2000h]
		mov		bx, [2006h]
		mul		bx
		add		[200Ah], ax
		adc		[200Ch], dx
		adc		w.[200Eh], 0000h
		mov		ax, [2002h]
		mov		bx, [2004h]
		mul		bx
		add		[200Ah], ax
		adc		[200Ch], dx
		adc		w.[200Eh], 0000h
		mov		ax, [2002h]
		mov		bx, [2006h]
		mul		bx
		add		[200Ch], ax
		adc		[200Eh], dx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2008h						; ans = 8800h
	SW		200Ah						; ans = 6A52h
	SW		200Ch						; ans = 0074h
	SW		200Eh						; ans = 0000h
	.									; => 500000000000

	
	
;	b>	Multiplication of 2 signed 16bit numbers
	SW		2000h
			[2000h]		=	003E8h		; A = 1000
			[2002h]		=	0FFF6h		; B = -10
			[2004h]		=	(ans)		; C = (A * B)
			[2006h]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		imul	bx
		mov		[2004h], ax
		mov		[2006h], dx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2004h						; ans = 0D8F0h
	SW		2006h						; ans = 0FFFFh
	.									; => -10000
		
	