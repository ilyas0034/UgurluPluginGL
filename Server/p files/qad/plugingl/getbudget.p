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
   
   for each xxBudget_mstr where xxBudget_mstr.CompanyCode=ttCreateBudgetIn.CompanyCode and xxBudget_mstr.PeriodYear=ttCreateBudgetIn.Year no-lock:
      create ttCreateBudgetOut.
	     assign ttCreateBudgetOut.ID=xxBudget_mstr.Id
		        ttCreateBudgetOut.GLCode=xxBudget_mstr.GLCode
			    ttCreateBudgetOut.Amount=xxBudget_mstr.Amount
			    ttCreateBudgetOut.Period=xxBudget_mstr.PeriodYearPeriod
                ttCreateBudgetOut.CompanyCode=xxBudget_mstr.CompanyCode.				
   end.
end.
 			 
create ttCstMessages.
   assign ttCstMessages.ttMessageNumber = "100"
	       ttCstMessages.ttMessage = "Success".
run logappend(" ttCreateBudgetIn.Year: " + string(ttCreateBudgetIn.Year)).
run logappend(" ttCreateBudgetIn.Amount: " + string(ttCreateBudgetIn.Amount)).				
run logappend(" xxBudget_mstr.Amount: " + string(xxBudget_mstr.Amount)).			   
run logappend("end").
procedure logappend:
   define input parameter textstr as character.
    
   define variable dt as datetime no-undo.
   dt = now.
   output to /apl/tmp/getBudgetIls.log append.
    
   put unformatted string(dt) + " : " + textstr skip.

   output close.
end procedure.