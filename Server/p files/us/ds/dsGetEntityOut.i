&IF DEFINED (dsGetEntityOut_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetEntityOut_i

   {us/tt/ttcstmessages.i}  
   {us/tt/ttGetEntityOut.i}

   define dataset dsGetEntityOut for ttCstMessages,ttGetEntityOut.

&ENDIF