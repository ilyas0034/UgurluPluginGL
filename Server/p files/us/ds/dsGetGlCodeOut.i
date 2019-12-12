&IF DEFINED (dsGetGlCodeOut_i) = 0 &THEN
   &GLOBAL-DEFINE dsGlCodeOut_i

   {us/tt/ttcstmessages.i}  
   {us/tt/ttGetGlCodeOut.i}

   define dataset dsGetGlCodeOut for ttCstMessages,ttGetGlCodeOut.

&ENDIF