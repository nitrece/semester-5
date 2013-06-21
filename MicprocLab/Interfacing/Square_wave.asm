mvi		a, 80h
out		0Fh
mvi		a, 0FFh
loop:
out		0Ch
out		0Dh
out		0Eh
cma
jmp		loop
