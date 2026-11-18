using PX.Data;

// Поле отмечено звёздочкой, но запись сохраняется без выбранной группы.
// В этом экране null и 0 означают отсутствие выбора.
// Что делает SetRequired? Как показать ошибку у поля и остановить сохранение?
protected void _(Events.RowSelected<Account> e)
{
    if (e.Row == null)
        return;

    PXUIFieldAttribute.SetRequired<Account.groupID>(e.Cache, true);
}
