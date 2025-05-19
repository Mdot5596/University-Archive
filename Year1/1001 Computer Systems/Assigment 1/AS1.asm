; AS1
.386  ; Specify instruction set
.model flat, stdcall  ; Flat memory model, std. calling convention
.stack 4096 ; Reserve stack space
ExitProcess PROTO, dwExitCode: DWORD  ; Exit process prototype




.data ; data segment
	arrayA DWORD 3,2,3,1,7,5,7,8,9,2
	

.code ; code segment
main PROC ; main procedure
 

	mov ebx, 0    ; this makes ebx 0 wich is the start of the c loop, ebx is now i


	loop1:
	mov ecx, 2 ;ecx = 2
	mov esi, 3 ;esi = 3
    mov eax, ebx ;if i times ebx by 2 it will no longer be a counter so i have made a copy of it
	
    MUL ecx ;times i by 2
	add eax, 1 ;  add 1 to i
	div esi
	add eax, ebx
	MUL esi ; times i by 3
	
	mov esi, OFFSET arrayA

    mov ecx, [ esi + TYPE arrayA * ebx ] ;move A[i] into ecx

    add ecx, eax ;A[i] += VAL 

    mov [ esi + TYPE arrayA * ebx ], ecx ;move back into array


    inc ebx  ; add i
    cmp ebx, 10 ; compare i to 10              ;CMP PUTS INFO INTO REGISTERS THAT I DONT WORRY ABOUT
    jne loop1 ;jump if i lower to 10          ; JNE LOOKS AT THE REGISTER AFTER, this is the end of the loop





	INVOKE ExitProcess, 0 ; call exit function
  
main ENDP ; exit main procedure
END main  ; stop assembling

