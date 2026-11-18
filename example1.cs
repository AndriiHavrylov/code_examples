using PX.Data;

protected void _(Events.FieldVerifying<OrderLine, OrderLine.qty> e)
{
    if (e.NewValue is decimal qty && qty < 0m)
    {
        throw new PXRowPersistingException(
            nameof(OrderLine.Qty), qty, "Quantity cannot be negative.");
    }
}
