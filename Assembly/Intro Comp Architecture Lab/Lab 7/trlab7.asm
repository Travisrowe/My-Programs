		.MODEL	small			;Travis Rowe
		.STACK 	100h
		.DATA
		.CODE
		
Prt		PROC	near
		
		mov			ax,cx		;transfers product to ax for alteration
		mov			bl,10
		div			bl			;separates the product into two digits
		mov			dx,ax		;stores quotion in dl, remainder in dh
		
		add			dl,30h
		mov			ah,2		;prints the first (tens) digit
		int			21h
		
		mov			dl,dh
		add			dl,30h
		mov			ah,2		;prints the second (ones) digit
		int			21h
		
		ret
Prt		ENDP

RD		PROC	near
		
		push		ax
		push		bx
		push		cx
		push		dx
		
		mov			ah,1
		int			21h
		
		mov			bh,al		
		sub			bh,30h
		
		pop			ax
		pop			bx
		pop			cx
		pop			dx
		ret
RD		ENDP
		
Main:	mov			ax,@data
		mov			ds,ax
		
		PUSH		bx
		Call		RD
		Pop			bx
		
		mov			dh,bh		;Holds number of people
		
		push		bx
		call		RD
		pop			bx
		
		mov			al,bh		;Holds price
		
		mul			dh			;multiplies price by numPeople
		mov			cx,ax		;stores product in cx
		
		mov			ah,1
		int			21h
		mov			bh,al		;Holds VIP status (no longer numPeople)
		
		cmp			bh,'v'
		JNE			Detour
		
		sub			cl,bl
		jmp			Output
		
Detour:	cmp			bh,'V'
		JNE			Output
		
		sub			cl,bl
		
Output:	Call		Prt
		
		mov			ah,4ch
		int			21h
		END			Main