/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{us/ds/dsGetYearIn.i}
{us/ds/dsGetYearOut.i}

{us/mf/mfdtitle.i} 
{us/zz/zzebshared.i} 

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/

&SCOPED-DEFINE MESSAGENUMBER "100"
&SCOPED-DEFINE xxMESSAGE      "xxxxxx"


define input  parameter dataset for dsGetYearIn.
define output parameter dataset for dsGetYearOut.
empty temp-table ttGetYearOut.

run logappend("begin").

for each ttGetYearIn :
   
   for each Period where Period.Company_ID=ttGetYearIn.Company_ID no-lock                                                               
   ,each PeriodMark of Period no-lock break
   by PeriodYear:
      IF FIRST-OF(PeriodYear) THEN   
      create ttGetYearOut.
         assign ttGetYearOut.Year=PeriodYear.                                                          
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
   output to /apl/tmp/getyear.log append.
   put unformatted string(dt) + " : " + textstr skip.
   output close.
end procedure.

