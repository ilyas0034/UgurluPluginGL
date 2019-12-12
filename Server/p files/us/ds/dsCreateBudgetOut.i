&IF DEFINED (dsCreateBudgetOut_i) = 0 &THEN
   &GLOBAL-DEFINE dsCreateBudgetOut_i

   {us/tt/ttcstmessages.i}  
   {us/tt/ttCreateBudgetOut.i}

   define dataset dsCreateBudgetOut for ttCstMessages,ttCreateBudgetOut.

&ENDIF