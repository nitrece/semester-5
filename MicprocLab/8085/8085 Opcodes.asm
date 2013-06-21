;-----------------------
;     8085 Opcodes
;-----------------------

*I		-	Immediate
*X		-	16 bit Register pair

;Movement
;--------
MOV		r/M, r/M	; mov		r/M, r/M
MVI		r/M, i		; mov		r/M, i
LDA		addr		; mov		a, [addr]
LDAX	B/D			; mov		a, [BC/DE]
STA		addr		; mov		[addr], a
STAX	B/D			; mov		[BC/DE], a
LHLD	addr		; mov		HL, [addr]
LXI		rp, i		; mov		rp, i
PUSH	rp			; push		rp
POP		rp			; pop		rp


;Arithmetic
;----------
ADD		r/M			; add		a, r/M
ADI		i			; add		a, i
ADC		r/M			; adc		a, r/M
ACI		i			; adc		a, i
DAD		rp			; add		HL, rp
DAA					; daa
INR		r/M			; inc		r/M
INX		rp			; inc		rp
DCR		r/M			; dec		r/M
DCX		rp			; inc		rp


;Bitwise
;-------
ANA		r/M			; and		a, r/M
ANI		i			; and		a, i
ORA		r/M			; or		a, r/M
ORI		i			; or		a, i
CMA					; not		a
RAL					; rcl		a, 1
RAR					; rcr		a, 1
RLC					; rol		a, 1
RRC					; ror		a, 1


;Flag Control
;------------
CMC					; not		CF
DI					; cli
EI					; sti
NOP					; nop
HLT					; hlt
RIM					; mov		a, IF


;Branching
;---------
CMP		r/M			; cmp 		a, r/M
JMP		addr		; jmp 		addr	
JZ		addr		; jz		addr
JNZ		addr		; jnz		addr
JC		addr		; jc		addr
JNC		addr		; jnc		addr
JP		addr		; jns		addr
JM		addr		; js		addr
PCHL				; jmp		[HL]
JPE		addr		; jnp		addr
JPO		addr		; jp		addr
CALL	addr		; call		addr
CZ		addr		; callz		addr
CNZ		addr		; callnz	addr
CC		addr		; callc		addr
CNC		addr		; callnc	addr
CP		addr		; callns	addr
CM		addr		; calls		addr
CPE		addr		; callnp	addr
CPO		addr		; callp		addr
RET					; ret
RZ					; retz
RNZ					; retnz
RC					; retc
RNC					; retnc
RP					; retns
RM					; rets
RPE					; retnp
RPO					; retp
PUSH	PSW			; push		psw
POP		PSW			; pop		psw


;I/O
;---
IN		addr		; in		a, addr
OUT		addr		; out		addr, a

