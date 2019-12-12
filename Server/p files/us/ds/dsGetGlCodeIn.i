&IF DEFINED (dsGetGlCodeIn_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetGlCodeIn_i
  
   {us/tt/ttGetGlCodeIn.i}
   {us/tt/ttuserinfotr.i}

   define dataset dsGetGlCodeIn for ttuserinfotr,ttGetGlCodeIn.

&ENDIF