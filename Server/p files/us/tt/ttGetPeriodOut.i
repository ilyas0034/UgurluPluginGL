&IF DEFINED (ttGetPeriodOut_i) = 0 &THEN
   &GLOBAL-DEFINE ttGetPeriodOut_i

   define temp-table ttGetPeriodOut
      field Period      as integer
      field Period_ID   as integer                                                        
      field PeriodYear  as integer                                                            
      .
&ENDIF