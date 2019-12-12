&IF DEFINED (dsGetEntityIn_i) = 0 &THEN
   &GLOBAL-DEFINE dsGetEntityIn_i
  
   {us/tt/ttGetEntityIn.i}
   {us/tt/ttuserinfotr.i}

   define dataset dsGetEntityIn for ttuserinfotr,ttGetEntityIn.

&ENDIF