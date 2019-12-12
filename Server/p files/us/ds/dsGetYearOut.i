&IF DEFINED (dsGetYearOut_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetYearOut_i

   {us/tt/ttcstmessages.i}  
   {us/tt/ttGetYearOut.i}

   define dataset dsGetYearOut for ttCstMessages,ttGetYearOut.

&ENDIF