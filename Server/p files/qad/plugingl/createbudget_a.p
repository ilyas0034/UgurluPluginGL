/*============================================================================*/
/* ****************************  TEMP TABLES  ******************************* */
/*============================================================================*/
{com/qad/shell/interface/dsSessionContext.i}
{com/qad/shell/interface/dsExceptions.i}
{com/qad/shell/messaging/dsMessageQuery.i}
{com/qad/shell/messaging/dsMessage.i} 

{us/ds/dsCreateBudgetIn.i}
{us/ds/dsCreateBudgetOut.i}

/*============================================================================*/
/* ****************************  PARAMETERS  ******************************** */
/*============================================================================*/
define input  parameter dataset for dsSessionContext.
define input  parameter dataset for dsCreateBudgetIn.       
define output parameter dataset for dsMessage.
define output parameter dataset for dsCreateBudgetOut.

{com/qad/shell/interface/DispatchServiceRequest.i}

procedure AppEntryPoint:

   run com/qad/plugingl/createbudget.p (input dataset dsCreateBudgetIn,output dataset dsCreateBudgetOut).

end procedure.
