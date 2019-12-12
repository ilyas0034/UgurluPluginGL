/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{com/qad/shell/interface/dsSessionContext.i}
{com/qad/shell/interface/dsExceptions.i}
{com/qad/shell/messaging/dsMessageQuery.i}
{com/qad/shell/messaging/dsMessage.i} 

{us/ds/dsGetPeriodIn.i}
{us/ds/dsGetPeriodOut.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsSessionContext.
define input  parameter dataset for dsGetPeriodIn.       
define output parameter dataset for dsMessage.
define output parameter dataset for dsGetPeriodOut.

{com/qad/shell/interface/DispatchServiceRequest.i}

procedure AppEntryPoint:

   run com/qad/plugingl/getperiod.p (input dataset dsGetPeriodIn,output dataset dsGetPeriodOut).

end procedure.
