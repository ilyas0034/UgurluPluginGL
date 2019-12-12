&IF DEFINED (dsGetYearIn_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetYearIn_i
  
   {us/tt/ttGetYearIn.i}
   {us/tt/ttuserinfotr.i}

   define dataset dsGetYearIn for ttuserinfotr,ttGetYearIn.

&ENDIF