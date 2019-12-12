&IF DEFINED (ttGetEntityOut_i) = 0 &THEN
   &GLOBAL-DEFINE ttGetEntityOut_i

   define temp-table ttGetEntityOut
      field CompanyCode     as character
      field Company_ID      as integer
      .
&ENDIF