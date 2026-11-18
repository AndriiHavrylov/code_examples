using PX.Data;

// Пользователь вводит Qty = -1. Отладчик дошёл до throw.
// Ожидание: отклонить ввод и показать сообщение возле Qty.
// Что изменить? Как обеспечить ту же проверку при сохранении после прямого присваивания?
protected void _(Events.FieldVerifying<OrderLine, OrderLine.qty> e)
{
    if (e.NewValue is decimal qty && qty < 0m)
    {
        throw new PXRowPersistingException(
            nameof(OrderLine.Qty), qty, "Quantity cannot be negative.");
    }
}
