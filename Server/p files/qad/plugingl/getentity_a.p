/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{com/qad/shell/interface/dsSessionContext.i} 
{com/qad/shell/interface/dsExceptions.i} 
{com/qad/shell/messaging/dsMessageQuery.i} 
{com/qad/shell/messaging/dsMessage.i} 

{us/ds/dsGetEntityIn.i}
{us/ds/dsGetEntityOut.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsSessionContext.
define input  parameter dataset for dsGetEntityIn.       
define output parameter dataset for dsMessage.
define output parameter dataset for dsGetEntityOut.

{com/qad/shell/interface/DispatchServiceRequest.i}

procedure AppEntryPoint:

   run com/qad/plugingl/getentity.p (input dataset dsGetEntityIn,output dataset dsGetEntityOut).

end procedure.
