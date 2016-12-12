		.MODEL 	small		;Travis Rowe
		.STACK	100H		;Lab 12
		.DATA
		.CODE
		
Main:	mov			ax,@data
		mov			ds,ax
		
		mov			ax,0600h	;specifies full screen
		mov			bh,7		;white characters on black background
		mov			cx,0		;clears from row and col number 0 to
		mov			dx,184Fh	;the end of screen
		int			10h
		
		mov			bh,0		;begin positioning the cursor
		mov			ah,2
		mov			dh,12		;position is established by dx value
		mov			dl,12		;DH = row, DL = col
		int			10h			;cursor now positioned at (12,12)
								;Note: Top left corner of screen is (0,0)
		
Inpt:	mov			ah,7	;Reads input without "echoing" it back to the
		int			21h		;screen
		
		cmp			al,13	;ENTER (End program)
		JE			Exit
		cmp			al,'w'	;No drawing - up
		JE			Up
		cmp			al,'z'	; - down
		JE			Dn
		cmp			al,'a'	; - left
		JE			Lft
		cmp			al,'s'	; - right
		JE			Rt
		cmp			al,'u'	;Drawing - up
		JE			Up
		cmp			al,'n'	; - down
		JE			Dn
		cmp			al,'h'	; - left
		JE			Lft
		cmp			al,'j'	; - right
		JE			Rt

Up:		mov			ah,2
		sub			dh,1	;moves cursor up one row
		int			10h
		cmp			al,'u'	;checks whether to write
		JE			Wrt
		JMP			Inpt

Dn:		mov			ah,2
		add			dh,1	;moves cursor down one row
		int			10h
		cmp			al,'n'	;checks whether to write
		JE			Wrt
		JMP			Inpt
		
Lft:	mov			ah,2
		sub			dl,1	;moves cursor left one col
		int			10h
		cmp			al,'h'	;checks whether to write
		JE			Wrt
		JMP			Inpt
		
Rt:		mov			ah,2
		add			dl,1	;moves cursor right one col
		int			10h
		cmp			al,'j'	;checks whether to write
		JE			Wrt
		JMP			Inpt
		
Wrt:	Push		dx		;protects cursor position
		mov			ah,2
		mov			dl,219	;prepares to print a black box to cursor
		int			21h
		Pop			dx		;moves cursor position back to dx
		JMP			Inpt
		
Exit:	mov			ah,4ch
		int			21h
		END			Main