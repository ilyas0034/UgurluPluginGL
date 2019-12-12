/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{us/ds/dsGetGlCodeIn.i}
{us/ds/dsGetGlCodeOut.i}

{us/mf/mfdtitle.i} 
{us/zz/zzebshared.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/

&SCOPED-DEFINE MESSAGENUMBER "100"
&SCOPED-DEFINE xxMESSAGE      "xxxxxx"


define input  parameter dataset for dsGetGlCodeIn.
define output parameter dataset for dsGetGlCodeOut.
empty temp-table ttGetGlCodeOut.

run logappend("begin").

for each ttGetGlCodeIn :
   
   for each Domains no-lock where Domains.Domaincode=string(global_domain)                
    ,each DomainSharedSet of Domains no-lock                                           
    ,each SharedSet where SharedSet.SharedSet_ID=DomainSharedSet.SharedSet_ID no-lock   
    ,each GL no-lock where GL.SharedSet_ID=SharedSet.SharedSet_ID and (INTEGER(SUBSTR(GLCode,1,1))>=6) :                                              
       create ttGetGlCodeOut.
          assign ttGetGlCodeOut.GL_ID=GL.GL_ID
                 ttGetGlCodeOut.GLCode=GL.GLCode.                                                          
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
   output to /apl/tmp/getglcode.log append.
   put unformatted string(dt) + " : " + textstr skip.
   output close.
end procedure.

