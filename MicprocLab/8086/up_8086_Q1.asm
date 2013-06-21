; Q 1>
;	a>	Addition of 2 16bit BCD numbers with carry
	SW		2000h
			[2000h]		=	0999h		; A = 999 in BCD
			[2002h]		=	0001h		; B = 1 in BCD
			[2004h]		=	(ans)		; C = (A + B) in BCD
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		add		bx, ax
		mov		al, bl
		daa
		adc		bh, 00h
		mov		bl, al
		mov		al, bh
		daa
		mov		bh, al
		mov		[2004h], bx
		hlt
		.
	
	GO		1000h
	INT									; (try '.' here)
	
	SW		2004h						; ans = 1000h
	.									; => 1000 in BCD
	
	
	
;	b>	Addition of 2 32bit numbers
	SW		2000h
			[2000h]		=	4B20h		; A = 12340000
			[2002h]		=	00BCh		; 
			[2004h]		=	162Eh		; B = 5678
			[2006h]		=	0000h		; 
			[2008h]		=	(ans)		; C = (A + B)
			[200Ah]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		add		ax, [2004h]
		adc		bx, [2006h]
		mov		[2008h], ax
		mov		[200Ah], bx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2008h						; ans = 614Eh
	SW		200Ah						; ans = 00BCh
	.									; => 12345678
	
	
	
;	c>	Addition of 2 signed 32bit numbers
	SW		2000h
			[2000h]		=	614Eh		; A = 12345678
			[2002h]		=	00BCh		; 
			[2004h]		=	0E9D2h		; B = -5678
			[2006h]		=	0FFFFh		; 
			[2008h]		=	(ans)		; C = (A + B)
			[200Ah]		=	(ans)		;
			.
	
	A
	1000h
		mov		ax, [2000h]
		mov		bx, [2002h]
		add		ax, [2004h]
		adc		bx, [2006h]
		mov		[2008h], ax
		mov		[200Ah], bx
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2008h						; ans = 4B20h
	SW		200Ah						; ans = 00BCh
	.									; => 12340000
