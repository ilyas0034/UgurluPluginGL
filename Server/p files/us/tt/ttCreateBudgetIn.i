&IF DEFINED (ttCreateBudgetIn_i) = 0 &THEN
   &GLOBAL-DEFINE ttCreateBudgetIn_i

      define temp-table ttCreateBudgetIn
      field ID                    as character
	  field Period                as integer
	  field GLCode                as character
	  field Amount                as decimal
	  field CompanyCode           as character
	  field Year                  as integer
      .
&ENDIF