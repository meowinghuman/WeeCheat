SendMode, Input

tog:=1    ;set to 1 if you want tapfire on when script starts.




F8::tog:=!tog    ;F8 hotkey to toggle tapfire on/off.


#If (tog)

*~$XButton2::

    While GetKeyState("XButton2", "P"){

        Click

        Sleep 200  ;  milliseconds

    }

return

#If