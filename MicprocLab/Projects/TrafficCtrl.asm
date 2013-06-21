; Traffic Controller
;-------------------
;
; PortA = Left Traffic Light
; PortB = Top Traffic Light
; PortC = Bottom Traffic Light
;	b0 = Red Light
;	b1 = Yellow Light
;	b2 = Green Light

; Data
SW		2000h
RedClr		=	001b
YellowClr	=	010b
GreenClr	=	100b

; Initialization
A
1000h
	mov		al, 80h
	out		26h, al
	case1:
	mov		al, 
display_light:
	push	ax
	mov		cl, ah
	and		cl, 11b
	mov		al, 1
	shl		al, cl
	out		20h, al
	shr		ah, 1
	shr		ah, 1
	mov		cl, ah
	and		cl, 11b
	mov		al, 1
	shl		al, cl
	out		22h, al
	shr		ah, 1
	shr		ah, 1
	mov		cl, ah
	and		cl, 
	
get_colour:
	push	cl
	mov		cl, al
	and		cl, 11b
	mov		ah, 1
	shl		ah, cl
	pop		cl
	ret


