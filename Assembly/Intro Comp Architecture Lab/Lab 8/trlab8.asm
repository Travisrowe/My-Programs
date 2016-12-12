		.MODEL	small			;Travis Rowe
		.STACK 	100h
		.DATA
		.CODE
		
RD		PROC	near
		
		push		ax
		push		bx
		push		cx
		push		dx
		
		mov			ah,1
		int			21h
		
		sub			al,30h
		mov			ah,0			;ax is the same as al
		
		
		mov			bp, sp
		mov			[bp+10],ax
		
		pop			dx
		pop			cx
		pop			bx
		pop			ax
		ret
RD		ENDP

Prt		PROC	near
		
		mov			ax,cx		;transfers product to ax for alteration
		mov			bl,10
		div			bl			;separates the product into two digits
		mov			dx,ax		;stores quotient in dl, remainder in dh
		
		add			dl,30h
		mov			ah,2		;prints the first (tens) digit
		int			21h
		
		mov			dl,dh
		add			dl,30h
		mov			ah,2		;prints the second (ones) digit
		int			21h
		
		ret
Prt		ENDP
		
Main:	mov			ax,@data
		mov			ds,ax
		
		PUSH		bx
		Call		RD
		Pop			bx			;Holds number of people
		
		push		dx
		call		RD
		pop			dx			;Holds price
		
		mov			al, dl
		mul			bl			;multiplies price by numPeople
		mov			cx,ax		;stores product in cx
		
		mov			ah,1
		int			21h
		mov			bh,al		;Holds VIP status (no longer numPeople)
		
		cmp			bh,'v'
		JNE			Detour
		
		sub			cl,dl
		jmp			Output
		
Detour:	cmp			bh,'V'
		JNE			Output
		
		sub			cl,dl
		
Output:	Call		Prt
		
		mov			ah,4ch
		int			21h
		END			Main