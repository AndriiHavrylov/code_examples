using PX.Data;
using PX.Objects.FS;

// Заказ ссылается на сохранённый контакт по умолчанию.
// contactCache — кэш FSContact этого graph. Стандартный обработчик OverrideContact подключён.
// Какую запись изменит ApplyEmail? Что изменится при использовании прямого setter?
private void UpdateOrderContact(PXCache contactCache, string newEmail)
{
    FSContact contact = GetOrderContact();

    contactCache.SetValueExt<FSContact.overrideContact>(contact, true);
    ApplyEmail(contact, newEmail);
}
