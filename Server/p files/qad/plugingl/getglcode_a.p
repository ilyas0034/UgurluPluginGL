/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{com/qad/shell/interface/dsSessionContext.i} 
{com/qad/shell/interface/dsExceptions.i} 
{com/qad/shell/messaging/dsMessageQuery.i} 
{com/qad/shell/messaging/dsMessage.i} 

{us/ds/dsGetGlCodeIn.i}
{us/ds/dsGetGlCodeOut.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsSessionContext.
define input  parameter dataset for dsGetGlCodeIn.       
define output parameter dataset for dsMessage.
define output parameter dataset for dsGetGlCodeOut.

{com/qad/shell/interface/DispatchServiceRequest.i}

procedure AppEntryPoint:

   run com/qad/plugingl/getglcode.p (input dataset dsGetGlCodeIn,output dataset dsGetGlCodeOut).

end procedure.
