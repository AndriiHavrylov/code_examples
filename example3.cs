using PX.Data;

// На странице задано PageLoadBehavior="PopulateSavedValues".
// Пользователь выбрал другую ветку. После закрытия и повторного открытия видит её же.
// Почему новое начальное значение не видно? Как проверить оба сценария?
protected void _(Events.FieldDefaulting<InquiryFilter, InquiryFilter.branchID> e)
{
    e.NewValue = GetPreferredBranchID();
    e.Cancel = true;
}
