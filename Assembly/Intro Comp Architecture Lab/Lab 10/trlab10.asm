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
		
		PUSH		cx			;pushes register BX to store the value in RD
		Call		RD
		Pop			cx			;Holds input
		
		mov			bx,cx		;copys the input to bx for alteration
		shr			bx,10		;deletes 10 rightmost bit, leaving only one letter
								;and the useless bit
								
		and			bl,31		;makes the useless bit a 0
								
		or			bl,64		;adds 010 before the 5 bits we have
		
		mov			dl,bl		;Print commands here
		mov			ah,2
		int			21h
		
		mov			bx,cx		;copys the input to bx for alteration
		shr			bx,5		;deletes 5 rightmost bit, leaving 5 bits
								;and 6 useless bits to its left
								
		and			bl,31		;makes all the useless bits 0
								
		or			bl,64		;adds 010 before the 5 bits we have
		
		mov			dl,bl		;Print commands here
		mov			ah,2
		int			21h
		
		mov			bx,cx		;copys the input to bx for alteration
								;leaves 5 bits that I need
								;and 11 useless bits to its left
								
		and			bl,31		;makes all the useless bits 0
								
		or			bl,64		;adds 010 before the 5 bits we have
		
		mov			dl,bl		;Print commands here
		mov			ah,2
		int			21h
		
		mov			ah,4ch
		int			21h
		END			Main