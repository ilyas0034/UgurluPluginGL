&IF DEFINED (ttCreateBudgetOut_i) = 0 &THEN
   &GLOBAL-DEFINE ttCreateBudgetOut_i

   define temp-table ttCreateBudgetOut
      field ID                    as character
	  field Period                as integer
	  field GLCode                as character
	  field Amount                as decimal
	  field CompanyCode           as character
	  field Year                  as integer
      .
&ENDIF