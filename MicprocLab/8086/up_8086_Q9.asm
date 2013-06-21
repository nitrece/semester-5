; Q 9>
;	a>	Determine the range of signed numbers the uP can handle
	SW		2000h
			[2000h]		=	(ans)		; Minimum signed number
			[2002h]		=	(ans)		; Maximum signed number
			.
	
	A
	1000h
		mov		cl, 04h
		mov		ax, 0008h
		loop_min:
		or		ax, ax
		js		num_min
		shl		ax, cl
		jmp		loop_min
		num_min:
		mov		[2000h], ax
		not		ax
		mov		[2002h], ax
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2000h						; ans = 8000h => -32768
	SW		2002h						; ans = 7FFFh => 32767
	.

	
	
;	b>	Determine the range of unsigned numbers the uP can handle
	SW		2000h
			[2000h]		=	(ans)		; Minimum unsigned number
			[2002h]		=	(ans)		; Maximum unsigned number
			.
	
	A
	1000h
		mov		ax, 0000h
		mov		[2000h], ax
		not		ax
		mov		[2002h], ax
		hlt
		.
	
	GO		1000h
	INT						;(try '.' here)
	
	SW		2000h						; ans = 00000h => 0
	SW		2002h						; ans = 0FFFFh => 65535
	.	