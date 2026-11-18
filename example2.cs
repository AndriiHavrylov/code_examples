using PX.Data;

protected void _(Events.RowSelected<Account> e)
{
    if (e.Row == null)
        return;

    PXUIFieldAttribute.SetRequired<Account.groupID>(e.Cache, true);
}
