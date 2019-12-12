/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{us/ds/dsGetPeriodIn.i}
{us/ds/dsGetPeriodOut.i}

{us/mf/mfdtitle.i} 
{us/zz/zzebshared.i} 

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/

&SCOPED-DEFINE MESSAGENUMBER "100"
&SCOPED-DEFINE xxMESSAGE      "xxxxxx"


define input  parameter dataset for dsGetPeriodIn.
define output parameter dataset for dsGetPeriodOut.
empty temp-table ttGetPeriodOut.

run logappend("begin").

for each ttGetPeriodIn :
   
   for each Period no-lock where Period.Company_ID=ttGetPeriodIn.Company_ID                             
      ,each PeriodMark no-lock of Period where PeriodYear=ttGetPeriodIn.Year:                           
         create ttGetPeriodOut.
         assign ttGetPeriodOut.Period_ID=Period_ID                                                          
                ttGetPeriodOut.PeriodYear=PeriodYear                                                         
                ttGetPeriodOut.Period=PeriodYearPeriod. 
   end.  
end.

create ttCstMessages.
   assign ttCstMessages.ttMessageNumber = {&MESSAGENUMBER}
	       ttCstMessages.ttMessage = {&xxMESSAGE}
   . 
	
/*	
run ThrowMessage(input table ttUserInfoTr
                ,input "R"
                ,input "91000" /* Success */
                ,input "").
*/

run logappend("end").
					 
procedure logappend:
   define input parameter textstr as character.
   define variable dt as datetime no-undo.
   dt = now.
   output to /apl/tmp/getperiod.log append.
   put unformatted string(dt) + " : " + textstr skip.
   output close.
end procedure.

