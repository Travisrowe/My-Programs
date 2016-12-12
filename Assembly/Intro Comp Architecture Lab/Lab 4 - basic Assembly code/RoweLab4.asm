					;DOS Commands:
					;TASM filename.asm
					;TLINK filename
					;filename
					;You must type all three in DOSbox.
		
		
		.MODEL 		small
		.STACK		100h
		.DATA
Var		DB			'This is Travis Rowe adding two numbers: 29 + 17 = $'
					; instruction above declares a string of characters
Eoli	DB			13, 10, '$'
		.CODE
Main:	mov			ax,@data		;these two instructions will be always
		mov			ds,ax			;in the beginning of the program
		
		mov			ah,9			;these 3 instructions print
		lea			dx, Var			;the string Var to the
		int			21h				;screen
		
		mov			ch,29			;these two instructions show
		mov			bl,17			;how to initialize registers
		add			ch,bl			;and this one, how to add
		
		mov			dl,ch
		mov			ah,2			;these two instructions
		int			21h				;print whatever is in DL
		
		mov			ah,9			;these 3 instruction print
		lea			dx,Eoli			;the string Eoli (end of line)
		int			21h				;to the screen
		
		mov			ah,4ch			;these three instructions, always at the end,
		int			21h				;stop the program execution
		END			Main