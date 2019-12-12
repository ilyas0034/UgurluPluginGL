&IF DEFINED (dsGetPeriodIn_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetPeriodIn_i
  
   {us/tt/ttGetPeriodIn.i}
   {us/tt/ttuserinfotr.i}

   define dataset dsGetPeriodIn for ttuserinfotr,ttGetPeriodIn.

&ENDIF