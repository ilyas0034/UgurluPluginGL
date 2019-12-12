&IF DEFINED (dsGetPeriodOut_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetPeriodOut_i

   {us/tt/ttcstmessages.i}  
   {us/tt/ttGetPeriodOut.i}

   define dataset dsGetPeriodOut for ttCstMessages,ttGetPeriodOut.

&ENDIF