using PX.Data;

protected void _(Events.FieldDefaulting<InquiryFilter, InquiryFilter.branchID> e)
{
    e.NewValue = GetPreferredBranchID();
    e.Cancel = true;
}
