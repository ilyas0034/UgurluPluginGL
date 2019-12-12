/*============================================================================
   Purpose: Retrieves a Profile from the database.
==============================================================================*/

/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{us/ds/dsCreateBudgetIn.i}
{us/ds/dsCreateBudgetOut.i}

{us/mf/mfdtitle.i} 
{us/zz/zzebshared.i} 

define buffer buffGL for GL.

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsCreateBudgetIn.
define output parameter dataset for dsCreateBudgetOut.
empty temp-table ttCreateBudgetOut.


/*============================================================================*/
/* **************************  GLOBAL VARIABLES  **************************** */
/*============================================================================*/
run logappend("begin").  	

for each ttCreateBudgetIn:
   
   find first xxBudget_mstr where xxBudget_mstr.GLCode=ttCreateBudgetIn.GLCode and xxBudget_mstr.PeriodYearPeriod=ttCreateBudgetIn.Period
   and xxBudget_mstr.CompanyCode=ttCreateBudgetIn.CompanyCode exclusive-lock no-error.
   if available xxBudget_mstr then do:
      update xxBudget_mstr.Amount=ttCreateBudgetIn.Amount
             xxBudget_mstr.GLCode=ttCreateBudgetIn.GLCode
             xxBudget_mstr.Id=ttCreateBudgetIn.ID
             xxBudget_mstr.PeriodYearPeriod=ttCreateBudgetIn.Period
			 xxBudget_mstr.CompanyCode=ttCreateBudgetIn.CompanyCode
			 xxBudget_mstr.PeriodYear=ttCreateBudgetIn.Year.
      create ttCreateBudgetOut.
	     assign ttCreateBudgetOut.ID=xxBudget_mstr.Id
		        ttCreateBudgetOut.GLCode=xxBudget_mstr.GLCode
			    ttCreateBudgetOut.Amount=xxBudget_mstr.Amount
			    ttCreateBudgetOut.Period=xxBudget_mstr.PeriodYearPeriod
                ttCreateBudgetOut.CompanyCode=xxBudget_mstr.CompanyCode
                ttCreateBudgetOut.Year=xxBudget_mstr.PeriodYear. 				
run logappend(" xxBudget_mstr.GLCode: " + string(xxBudget_mstr.GLCode)).
run logappend(" ttCreateBudgetIn.Amount: " + string(ttCreateBudgetIn.Amount)).				
run logappend(" xxBudget_mstr.Amount: " + string(xxBudget_mstr.Amount)).				
   end.
   else do:
      create xxBudget_mstr.
         assign xxBudget_mstr.Amount=ttCreateBudgetIn.Amount
                xxBudget_mstr.GLCode=ttCreateBudgetIn.GLCode
                xxBudget_mstr.Id=ttCreateBudgetIn.ID
                xxBudget_mstr.PeriodYearPeriod=ttCreateBudgetIn.Period
				xxBudget_mstr.CompanyCode=ttCreateBudgetIn.CompanyCode
				xxBudget_mstr.PeriodYear=ttCreateBudgetIn.Year.
	  create ttCreateBudgetOut.
	     assign ttCreateBudgetOut.ID=ttCreateBudgetIn.ID
		        ttCreateBudgetOut.GLCode=ttCreateBudgetIn.GLCode
				ttCreateBudgetOut.Amount=ttCreateBudgetIn.Amount
				ttCreateBudgetOut.Period=ttCreateBudgetIn.Period
                ttCreateBudgetOut.CompanyCode=ttCreateBudgetIn.CompanyCode
                ttCreateBudgetOut.Year=ttCreateBudgetIn.Year.				
run logappend(" xxBudget_mstr.GLCode: " + string(xxBudget_mstr.GLCode)).				
run logappend(" xxBudget_mstr.Amount: " + string(xxBudget_mstr.Amount)).				
   end.
end.
 			 
create ttCstMessages.
   assign ttCstMessages.ttMessageNumber = "100"
	       ttCstMessages.ttMessage = "Success".   
run logappend("end").
procedure logappend:
   define input parameter textstr as character.
    
   define variable dt as datetime no-undo.
   dt = now.
   output to /apl/tmp/createBudgetIls.log append.
    
   put unformatted string(dt) + " : " + textstr skip.

   output close.
end procedure.