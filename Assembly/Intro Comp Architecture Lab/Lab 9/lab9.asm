		.MODEL	small				;Travis Rowe
		.STACK 	100h
		.DATA
		.CODE
	
	
RD		PROC	near
		
		push		ax
		push		bx
		push		cx
		push		dx
		mov			ax,0			;clears all registers for
		mov			dx,0			;accuracy before reading
		mov			bx,0
		mov			cx,0
		
Again:	mov			ah,1
		int			21h
		
		cmp			al,13 			;compares the input to the ASCII
		JE			Exit			;representation of a carriage return
		
		sub			al,30h
		mov			cl,al			;stores input in cl, temporarily
		mov			bx,10
		
		mov			ax,dx			;stores most recent Val in ax for alteration
		mul			bx				;multiplies Val by 10
		add			al,cl			;adds the most recent input to the ones digit
		mov			dx,ax			;stores the new Val in dx for safe-keeping
		
		JMP			Again			;Loops the procedure
		
Exit:	mov			bp, sp			;Moves the value of the cursor for alteration
		mov			[bp+10],dx		;stores the final result in the pushed register
		
		pop			dx
		pop			cx
		pop			bx
		pop			ax
		ret
RD		ENDP


Prt		PROC	near
		
		mov			ax,dx		;stores remainder in ax for alteration
		mov			cx,10
		
		mov			dx,0
		div			cx			;because ax is at most 2 digits long
								;this separates ax into 2 digits
								;tens digit in ax, ones digit in dx
								
		push		dx
		mov			dl, al		;prepares to print the tens digit
		add			dl,30h
		mov			ah,2
		int			21h
		
		pop			dx			;moves the ones digit back into dx (or dl)
		add			dl,30h
		mov			ah,2
		int			21h
		ret
Prt		ENDP
		
		
Main:	mov			ax,@data
		mov			ds,ax
		
		PUSH		bx			;pushes register BX to store the value in RD
		Call		RD
		Pop			bx			;Holds total amount paid (range 1 to 30,000)
		
		push		cx			;pushes register DX to store value of RD
		call		RD
		pop			cx			;Holds single ticket price (range 1 to 75)
		
		mov			dx,0
		mov			ax, bx		;moves Tot Amt Paid to ax for alteration
		div			cx			;divides TotAmt by Single ticket price			
								;stores remainder in dx, quotient in ax
		
		Call		Prt
		
		mov			ah,4ch
		int			21h
		END			Main