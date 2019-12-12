&IF DEFINED (dsCreateBudgetIn_i) = 0 &THEN
   &GLOBAL-DEFINE dsCreateBudgetIn_i
  
   {us/tt/ttCreateBudgetIn.i}
   {us/tt/ttuserinfotr.i}

   define dataset dsCreateBudgetIn for ttuserinfotr,ttCreateBudgetIn.

&ENDIF