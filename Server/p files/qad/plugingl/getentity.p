/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{us/ds/dsGetEntityIn.i}
{us/ds/dsGetEntityOut.i}

{us/mf/mfdtitle.i} 
{us/zz/zzebshared.i} 

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/

&SCOPED-DEFINE MESSAGENUMBER "100"
&SCOPED-DEFINE xxMESSAGE     "xxxxxx"


define input  parameter dataset for dsGetEntityIn.
define output parameter dataset for dsGetEntityOut.
empty temp-table ttGetEntityOut.

run logappend("begin").

for each ttGetEntityIn :
   
   for each Company no-lock:
      create ttGetEntityOut.
         assign ttGetEntityOut.CompanyCode=Company.CompanyCode
                ttGetEntityOut.Company_ID=Company.Company_ID.		 
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
   output to /apl/tmp/getentity.log append.
   put unformatted string(dt) + " : " + textstr skip.
   output close.
end procedure.

