using PX.Data;

// В 26.100.0175 после смены локации селектор не находит подставленный маршрут.
// В отладчике routeID — число. В сообщении селектора отображается [object Object].
// Что проверишь в данных и кэше? Откуда мог взяться объект?
protected void _(Events.FieldUpdated<Order, Order.locationID> e)
{
    if (e.Row == null)
        return;

    int? routeID = FindLocationRoute(e.Row.LocationID);
    e.Cache.SetValueExt<Order.routeID>(e.Row, routeID);
}
