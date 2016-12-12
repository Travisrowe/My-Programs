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
		
Main:	mov			ax,@data
		mov			ds,ax
		
		mov			ah,1
		int			21h
		
		mov			bh,al		;Holds number of people
		sub			bh,30h
		mov			ah,1
		int			21h
		sub			al,30h
		
		mov			bl,al		;Holds price
		mul			bh			;multiplies price by numPeople
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