&IF DEFINED (ttGetPeriodIn_i) = 0 &THEN
   &GLOBAL-DEFINE ttGetPeriodIn_i

      define temp-table ttGetPeriodIn
      field Year                as integer
      field Company_ID          as integer
      .
&ENDIF