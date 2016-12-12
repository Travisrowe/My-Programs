					;DOS Commands:
					;TASM filename.asm
					;TLINK filename
					;filename
					;You must type all three in DOSbox.
					
					;Travis Rowe
		
		
		.MODEL 		small
		.STACK		100h
		.DATA
Win		DB			'We have a winner', 10, 13, '$'
					; instruction above declares a string of characters
Tie		DB			'We need another debate', 10, 13, '$'
		.CODE
Main:	mov			ax,@data		;these two instructions will be always
		mov			ds,ax			;in the beginning of the program
		
		mov			ah,1			;reads one byte from the keyboard and places
		int 		21h				;it in AL as an ASCII value
		
		mov			bh,al			;moves input to register dh
		sub			bh,30H			;converts this input to a decimal number
		
		mov			ah,1
		int 		21h	
		sub			al,30H
		
		sub			bh,al
		cmp			bh,5			;compares the difference of dh and dl to the number 5
		JGE			Clear			
		JL			Deb				;Jumps to Deb if the difference is less than 5
		
	
Deb:	mov			ah,9			;Prints the String Tie
		lea			dx,Tie			;if the difference was
		int			21h				;less than 5
		JMP			Endng
		
Clear:	mov			ah,9			;Prints the string Win otherwise
		lea			dx,Win
		int			21h
		JMP			Endng
Endng:		
		mov			ah,4ch			;these three instructions, always at the end,
		int			21h				;stop the program execution
		END			Main