/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{com/qad/shell/interface/dsSessionContext.i}
{com/qad/shell/interface/dsExceptions.i}
{com/qad/shell/messaging/dsMessageQuery.i}
{com/qad/shell/messaging/dsMessage.i} 

{us/ds/dsGetYearIn.i}
{us/ds/dsGetYearOut.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsSessionContext.
define input  parameter dataset for dsGetYearIn.       
define output parameter dataset for dsMessage.
define output parameter dataset for dsGetYearOut.

{com/qad/shell/interface/DispatchServiceRequest.i}

procedure AppEntryPoint:

   run com/qad/plugingl/getyear.p (input dataset dsGetYearIn,output dataset dsGetYearOut).

end procedure.
