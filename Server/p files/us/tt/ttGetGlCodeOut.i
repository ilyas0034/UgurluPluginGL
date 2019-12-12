&IF DEFINED (ttGetGlCodeOut_i) = 0 &THEN
   &GLOBAL-DEFINE ttGetGlCodeOut_i

   define temp-table ttGetGlCodeOut
      field GL_ID           as integer
      field GLCode          as character
      .
&ENDIF